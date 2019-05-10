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
        Pen penRed = new Pen(Brushes.OrangeRed);
        Pen penGreen = new Pen(Brushes.Green);
        Pen penYellow = new Pen(Brushes.Yellow);
        Pen penBlue = new Pen(Brushes.Blue);
        Pen penBrown = new Pen(Brushes.Brown);

        public void desenhar(Graphics g, string playerCor,int xPirata) 
        {

            switch (playerCor){
                case "Vermelho":
                    penRed.Width = 8.0F;
                    g.DrawRectangle(penRed, new Rectangle(xPirata, 5, 6, 6));
                    break;
                case "Verde":
                    penGreen.Width = 8.0F;
                    g.DrawRectangle(penGreen, new Rectangle(xPirata, 15, 6, 6));
                    break;
                case "Amarelo":
                    penYellow.Width = 8.0F;
                    g.DrawRectangle(penYellow, new Rectangle(xPirata, 25, 6, 6));
                    break;
                case "Azul":
                    penBlue.Width = 8.0F;
                    g.DrawRectangle(penBlue, new Rectangle(xPirata, 35, 6, 6));
                    break;
                case "Marrom":
                    penBrown.Width = 8.0F;
                    g.DrawRectangle(penBrown, new Rectangle(xPirata, 45, 6, 6));
                    break;
            }
        }

        public void desenharPiratas(Tabuleiro tabuleiro, PictureBox[] casaTabuleiro)
        {
            PictureBox[] posicaoTabuleiro = casaTabuleiro;

            foreach (Posicao posicao in tabuleiro.Posicoes)
            {
                int xPirata = 5;
                foreach (Pirata pirata in posicao.piratas)
                {
                    string playerCor = pirata.cor;
                    Graphics g = posicaoTabuleiro[pirata.local].CreateGraphics();
                    this.desenhar(g,playerCor, xPirata);
                    xPirata += 7;
                    // draw pixel
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

        public void jogar(Jogada jogada, Tabuleiro tabuleiro)
        {
            Pirata pirata = piratas[jogada.indexPirata];
            string carta = jogada.carta;
            
            int localNovo, localAntigo = pirata.local;
            cartas.Remove(carta);

            // Joga o pirata
            Jogo.Jogar(id, senha, localAntigo, carta);

            // Acha o novo local do pirata
            for (localNovo = localAntigo; localNovo < tabuleiro.Posicoes.Length - 1; localNovo++)
            {
                if (carta == tabuleiro.Posicoes[localNovo].tipo &&
                    tabuleiro.Posicoes[localNovo].piratas.Count == 0) break;
            }

            // Remove o pirata do lugar antigo e coloca no novo.
            tabuleiro.Posicoes[localAntigo].piratas.Remove(pirata);
            pirata.local = localNovo;
            tabuleiro.Posicoes[localNovo].piratas.Add(pirata);

        }

        public void voltarPirata(Jogada jogada, Tabuleiro tabuleiro)
        {
            Pirata pirata = piratas[jogada.indexPirata];
            int localAntigo = pirata.local, localNovo;


            for (int i = localAntigo - 1; i > 0; i--)
            {
                if (tabuleiro.Posicoes[i].numeroPiratas() > 0 &&
                    tabuleiro.Posicoes[i].numeroPiratas() < 3)
                {
                    localNovo = i;
                    Jogo.Jogar(id, senha, pirata.local);

                    tabuleiro.Posicoes[localAntigo].piratas.Remove(pirata);
                    pirata.local = localNovo;
                    tabuleiro.Posicoes[localNovo].piratas.Add(pirata);
                    break;
                }
            }

        }

        public void pularJogada()
        {
            Jogo.Jogar(id, senha);
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
                        Console.WriteLine(prioridades.ToString());
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
            foreach (Pirata pirata in piratas)
            {
                // 1
                Jogada jogada;

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
    
        private void avaliarJogada(List<Jogada> jogadasPossiveis){
            Random r = new Random();
            foreach (Jogada jogada in jogadasPossiveis)
            {
                jogada.pontuacao = r.Next(0, 10);
            }
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
    }
}
