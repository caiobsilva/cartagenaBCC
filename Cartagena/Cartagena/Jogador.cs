using System;
using System.Collections.Generic;
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
            Cartagena.LidarErros(Jogo.Jogar(id, senha, pirata.local, carta));
            Console.WriteLine("Carta: "+ carta + " | Pirata foi para frente! | Pirata: " + pirata.ToString());
            
        }

        public void voltarPirata(Jogada jogada)
        {

            Pirata pirata = piratas[jogada.indexPirata];

            Console.WriteLine("Pirata voltou!");
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
            int diferenca = 0;
            
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
                
                if (piratas[jogada.indexPirata].local < 10 && jogada.carta != "voltar")
                {
                    jogada.pontuacao += 7;
                }

                if (pirata.local - piratas[jogada.indexPirata].local > diferenca)
                {
                    maiorPosicao = jogada;
                }

                if (tabuleiro.Posicoes[pirata.local].numeroPiratas() > 2 && cartas.Count < 3)
                {
                    jogada.pontuacao += 8;
                }

                if (tabuleiro.Posicoes[pirata.local].numeroPiratas() == 2)
                {
                    if (cartas.Count < 2)
                    {
                        jogada.pontuacao += 7;
                    }
                    else
                    {
                        jogada.pontuacao += 4;
                    }
                }

                if (pirata.local == 37)
                {
                    jogada.pontuacao += 10;
                }

                if (cartas.Count == 1 && jogada.carta == "voltar")
                {
                    jogada.pontuacao += 4;
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
