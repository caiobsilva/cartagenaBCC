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

        
        public int id { get { return _id; } }
        public string nome { get { return _nome; } }
        public string cor { get { return _cor; } }
        
        public List<Pirata> piratasEm(int posicao) 
        {
            List<Pirata> piratasNaPosicao = new List<Pirata>();

            foreach ( Pirata pirata in piratas)
            {
                if(pirata.local == posicao)
                {
                    piratasNaPosicao.Add(pirata);
                }
            }
            
            return piratasNaPosicao;
        }

        public override string ToString()
        {
            string toString;
            toString = nome + ": ";
            foreach (Pirata pirata in piratas)
            {
                toString += (pirata.local.ToString() + " ");
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
            piratas = new Pirata[] { 
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

        public string senha { get { return _senha; } }
        
        public Kurisu(int id, string nome, string cor, string senha)
        {
            _id = id;
            _cor = cor;
            _nome = nome;
            _senha = senha;
            piratas = new Pirata[] { 
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor)
            };
            this.cartas = new List<string>();
            
            string[] jogadorCartas = Jogo.ConsultarMao(_id, _senha).Split('\n');

            for (int i = 0; i < jogadorCartas.Length - 1; i++){
                string[] cartas = jogadorCartas[i].Replace("\r", "").Split(',');
                for (int j = 0; j < Convert.ToInt32(cartas[1]); j++)
                {
                    this.cartas.Add(cartas[0]);
                }                
            }

        }

        public void jogar(Pirata pirata, string carta, Tabuleiro tabuleiro)
        {
            int localNovo, localAntigo = pirata.local;
            cartas.Remove(carta);

            // Joga o pirata
            Jogo.Jogar(id, senha,localAntigo, carta);


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

        public void voltarPirata(Pirata pirata, Tabuleiro tabuleiro )
        {
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
        
        public void atualizarCartas()
        {
            this.cartas = new List<string>();
            
            string[] jogadorCartas = Jogo.ConsultarMao(_id, _senha).Split('\n');

            for (int i = 0; i < jogadorCartas.Length - 1; i++){
                string[] cartas = jogadorCartas[i].Replace("\r", "").Split(',');
                for (int j = 0; j < Convert.ToInt32(cartas[1]); j++)
                {
                    this.cartas.Add(cartas[0]);
                }                
            }
        }

        public void avaliarConsequências()
        {
            int estagioAvaliacao = 0;
            bool avaliacao = false;

            while (avaliacao != true)
            {
                switch (estagioAvaliacao)
                {
                    case 0: //Inicia estágio de avaliação de movimentos;
                        //avaliarMovimento(tabuleiro);
                        estagioAvaliacao += 1;
                        break;
                    case 1: //Inicia estágio de adicionar jogadas à Fila de Prioridades.
                        //adicionarPrioridades();
                        estagioAvaliacao += 1;
                        break;
                    case 2: //Inicia estágio de ordenação da Fila de Prioridades.
                        //ordenarPrioridades();
                        estagioAvaliacao += 1;
                        break;
                    case 3: //Inicia o estágio de movimentação com a jogada prioritária.
                        //mover();
                        avaliacao = true;
                        break;
                }
            }
        }
    }
}


/* Máquina de Estados que vai alterar as etapas da avaliação de consequências. Estágios:

Um método de condicionais que determinam as pontuações de todas as jogadas possíveis no tabuleiro;
Um método de adição à Fila de Prioridades;
Um método de ordenação da Fila de Prioridades;
Um método que joga a jogada prioritária;
 */
