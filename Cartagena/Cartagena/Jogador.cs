using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;
namespace Cartagena
{
    public class Jogador
    {
        protected int _id { get; set; }
        protected string _nome { get; set; }
        protected string _cor { get; set; }

        Pen penRed = new Pen(Brushes.OrangeRed);
        Pen penGreen = new Pen(Brushes.Green);
        Pen penYellow = new Pen(Brushes.Yellow);
        Pen penBlue = new Pen(Brushes.Blue);
        Pen penBrown = new Pen(Brushes.Brown);

        public Pirata[] piratas;

        public int id
        {
            get { return _id; }
        }

        public string nome
        {
            get { return _nome; }
        }

        public string cor
        {
            get { return _cor; }
        }

        public List<Pirata> piratasEm(int posicao)
        {
            List<Pirata> piratasNaPosicao = new List<Pirata>();

            foreach (Pirata pirata in piratas)
            {
                if (pirata.local == posicao)
                {
                    piratasNaPosicao.Add(pirata);
                }
            }

            return piratasNaPosicao;
        }
        
        public void desenhar(Graphics g, string playerCor,int xPirata, int yPirata) 
        {
            switch (playerCor){
                case "Vermelho":
                    penRed.Width = 8.0F;
                    g.DrawRectangle(penRed, new Rectangle(xPirata, yPirata, 5, 5));
                    break;
                case "Verde":
                    penGreen.Width = 8.0F;
                    g.DrawRectangle(penGreen, new Rectangle(xPirata, yPirata, 5, 5));
                    break;
                case "Amarelo":
                    penYellow.Width = 8.0F;
                    g.DrawRectangle(penYellow, new Rectangle(xPirata, yPirata, 5, 5));
                    break;
                case "Azul":
                    penBlue.Width = 8.0F;
                    g.DrawRectangle(penBlue, new Rectangle(xPirata, yPirata, 5, 5));
                    break;
                case "Marrom":
                    penBrown.Width = 8.0F;
                    g.DrawRectangle(penBrown, new Rectangle(xPirata, yPirata, 5, 5));
                    break;
            }
        }

        public void desenharPiratas(Tabuleiro tabuleiro, PictureBox[] casaTabuleiro)
        {
            PictureBox[] posicaoTabuleiro = casaTabuleiro;

            foreach (Posicao posicao in tabuleiro.Posicoes)
            {
                int xPirata = 5, yPirata = 5;
                foreach (Pirata pirata in posicao.piratas)
                {
                    if (pirata.local == 0 || pirata.local == 37) { }
                    else
                    {
                        string playerCor = pirata.cor;
                        Graphics g = posicaoTabuleiro[pirata.local].CreateGraphics();
                        this.desenhar(g,playerCor, xPirata,yPirata);
                        xPirata += 15;
                        yPirata +=15;
                    }
                }

            }

        }

        public override string ToString()
        {
            string toString;
            toString = _nome + " (" + _cor + ")" + ": ";
            foreach (Pirata pirata in piratas)
            {
                toString += pirata.local.ToString() + " ";
            }

            return toString;
        }
    }

    public class Inimigo : Jogador
    {
        public Inimigo(int id, string nome, string cor)
        {
            _id = id;
            _cor = cor;
            _nome = nome;
            piratas = new Pirata[]
            {
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor)
            };
        }
    }

    public class Kurisu : Jogador
    {

        string _senha { get; set; }
        public List<string> cartas;

        public string senha
        {
            get { return _senha; }
        }

        public Kurisu(int id, string nome, string cor, string senha)
        {
            _id = id;
            _cor = cor;
            _nome = nome;
            _senha = senha;
            piratas = new Pirata[]
            {
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor)
            };
            this.cartas = new List<string>();

            string[] jogadorCartas = Jogo.ConsultarMao(_id, _senha).Split('\n');

            for (int i = 0; i < jogadorCartas.Length - 1; i++)
            {
                string[] cartas = jogadorCartas[i].Replace("\r", "").Split(',');
                for (int j = 0; j < Convert.ToInt32(cartas[1]); j++)
                {
                    this.cartas.Add(cartas[0]);
                }
            }

        }

        public void jogar(Jogada jogada)
        {
            Pirata pirata = piratas[jogada.indexPirata];
            string carta = jogada.carta;
            
            cartas.Remove(carta);

            
            // Joga o pirata
            //Console.WriteLine("Carta: "+ carta + " | Pirata foi para frente! | Pirata: " + pirata.ToString());
            Cartagena.LidarErros(Jogo.Jogar(id, senha, pirata.local, carta));
            
            
        }

        public void voltarPirata(Jogada jogada)
        {

            Pirata pirata = piratas[jogada.indexPirata];

            //Console.WriteLine("Pirata voltou!");
            Cartagena.LidarErros(Jogo.Jogar(id, senha, pirata.local));

        }

        public void pularJogada()
        {
            Console.WriteLine("Jogada pulada!");
            Cartagena.LidarErros(Jogo.Jogar(id, senha));
        }

        public void atualizarCartas()
        {
            this.cartas = new List<string>();

            string[] jogadorCartas = Jogo.ConsultarMao(_id, _senha).Split('\n');

            for (int i = 0; i < jogadorCartas.Length - 1; i++)
            {
                string[] cartas = jogadorCartas[i].Replace("\r", "").Split(',');
                for (int j = 0; j < Convert.ToInt32(cartas[1]); j++)
                {
                    this.cartas.Add(cartas[0]);
                }
            }
        }

        public Jogada avaliarConsequências(Tabuleiro tabuleiro)
        {
            int estagioAvaliacao = 0;
            bool avaliacao = false;
            Jogada jogada;
            FilaPrioridade prioridades = new FilaPrioridade();
            List<Jogada> jogadasPossiveis = gerarJogadas(tabuleiro);

            while (avaliacao != true)
            {
                switch (estagioAvaliacao)
                {
                    case 0: //Inicia estágio de avaliação de jogada;
                        avaliarJogada(jogadasPossiveis);
                        estagioAvaliacao += 1;
                        break;
                    case 1: //Inicia estágio de adicionar jogadas à Fila de Prioridades.
                        prioridades = adicionarNaListaPrioridade(jogadasPossiveis);
                        estagioAvaliacao += 1;
                        break;
                    case 2: //Inicia o estágio de movimentação com a jogada prioritária.
                        avaliacao = true;
                        break;
                }
            }

            jogada = prioridades.remover();
            return jogada;

        }

        private List<Jogada> gerarJogadas(Tabuleiro tabuleiro)
        {
            List<Jogada> jogadas = new List<Jogada>();
            int index = 0;
            
            // Adiciona a jogada de pular
            jogadas.Add(new Jogada(tabuleiro));
            
            foreach (Pirata pirata in piratas)
            {
                Jogada jogada;
                // 1
                
                if (pirata.local == 37)
                {
                    continue;
                }

                if (pirata.local == 0 || !tabuleiro.existemPiratasAntesDe(pirata.local))
                {
                    foreach (string carta in cartas)
                    {
                        jogada = new Jogada(tabuleiro, pirata, carta, index);
                        jogada.simularJogada();
                        jogadas.Add(jogada);
                    }
                }
                else
                {
                    jogada = new Jogada(tabuleiro, pirata, index);
                    jogada.simularJogada();
                    jogadas.Add(jogada);
                    foreach (string carta in cartas)
                    {
                        jogada = new Jogada(tabuleiro, pirata, carta, index);
                        jogada.simularJogada();
                        jogadas.Add(jogada);
                    }
                }
                index++;
            }
            return jogadas;
        }
    
        private void avaliarJogada(List<Jogada> jogadasPossiveis)
        {

            Jogada maiorPosicao = jogadasPossiveis[0];
            int diferenca = 0, menor = 0, media = 0, index = 0, diferencaMenor = 38;
            int indexMenor = piratas.Length-1;
            Tabuleiro tab = jogadasPossiveis[0].tabuleiro;
            foreach (var p in piratas)
            {
                
                media += p.local;
                if(p.local < piratas[menor].local)
                {
                    menor = index;
                }

                index++;
                
            }

            for (int i = piratas.Length-1; i > 0 ; i--)
            {
                if (piratas[i].local != 37 && 
                    piratas[i].local - tab.posicaoPirataAnterior(piratas[i].local) <= diferencaMenor )
                {
                    diferencaMenor = piratas[i].local - tab.posicaoPirataAnterior(piratas[i].local);
                    indexMenor = i;
                }
            }
            
            media /= 6;
            
            foreach (Jogada jogada in jogadasPossiveis)
            {
                if(jogada.carta == "pular") { continue; }
                if (cartas.Count > 5 && jogada.carta == "voltar") { continue; }

                Pirata pirata = jogada.pirata;
                Tabuleiro tabuleiro = jogada.tabuleiro;
                
                if (piratas[jogada.indexPirata].local == 0)
                {
                    jogada.pontuacao += 7;
                }

                if (pirata.local - piratas[jogada.indexPirata].local > diferenca)
                {
                    maiorPosicao = jogada;
                    diferenca = pirata.local - piratas[jogada.indexPirata].local;
                }

                if (cartas.Count < 3 && jogada.carta == "voltar")
                {
                    // Ganhando duas cartas                    
                    if (tabuleiro.Posicoes[pirata.local].numeroPiratas() > 2)
                    {
                        jogada.pontuacao += 2;
                    }

                    if (piratas[jogada.indexPirata].local > media)
                    {
                        jogada.pontuacao += 2;
                    }
                    
                    // Sem cartas                    
                    if (cartas.Count == 0)
                    {
                        jogada.pontuacao += 3;
                    }

                    if (piratas[jogada.indexPirata].local == indexMenor)
                    {
                        jogada.pontuacao += 4;
                    }
                    
                    jogada.pontuacao += 4;
                    
                }

                if (jogada.carta != "voltar")
                {
                    if (jogada.indexPirata == menor)
                    {
                        jogada.pontuacao += 6;
                    }
                    
                    if (piratas[jogada.indexPirata].local < media)
                    {
                        jogada.pontuacao += 6;
                    }
    
                    if (piratas[jogada.indexPirata].local < 17)
                    {
                        jogada.pontuacao += 5;
                    }
                    
                    if (pirata.local == 37)
                    {
                        jogada.pontuacao += 10;
                    }
                }
                
            }

            maiorPosicao.pontuacao += 6;

        }

        //Adiciona e ordena as jogadas na Fila de Prioridade.
        private FilaPrioridade adicionarNaListaPrioridade(List<Jogada> jogadasPossiveis)
        {
            FilaPrioridade filaPrioridades = new FilaPrioridade();
            foreach (Jogada jogadaPossivel in jogadasPossiveis)
            {
                filaPrioridades.adicionar(jogadaPossivel, jogadaPossivel.pontuacao);
            }

            return filaPrioridades;

        }
        
        public override string ToString()
        {
            string toString;
            toString = _nome + " (" + _cor + ")" + ": ";
            foreach (Pirata pirata in piratas)
            {
                toString += pirata.local.ToString() + " ";
            }
            toString += " | Cartas: ";
            foreach (string carta in cartas)
            {
                toString += carta + " ";
            }

            return toString;
        }
        
    }
}
