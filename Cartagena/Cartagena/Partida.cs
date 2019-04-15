using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartagenaServer;

namespace Cartagena
{
    class Partida
    {
        string _nome { get; set; }
        int _id { get; set; }
        string _senha { get; set; }
        Tabuleiro _tabuleiro { get; set; }
        Jogador _Kuriso { get; set; }

        public string nome { get { return _nome; } }
        public int id { get { return _id; } }
        public string senha { get { return _senha; } }
        public Tabuleiro tabuleiro { get { return _tabuleiro; } }
        public Jogador Kuriso{ get { return _Kuriso; } }

        public Partida(int id, string nome, string senha, int idJogador, string nomeJogador, string senhaJogador, string corJogador)
        {
            _id = id;
            _nome = nome;
            _senha = senha;
            _Kuriso = new Jogador(idJogador,nomeJogador,corJogador,senhaJogador);
            _tabuleiro = new Tabuleiro(_id,_Kuriso.piratas);
        }

        /*
            Retorna uma lista com todos os piratas em uma determinada posição
        */
        public List<Pirata> piratasEm(int posicao)
        {
            List<Pirata> piratasNaPosicao = new List<Pirata>();

            foreach ( Pirata pirata in _Kuriso.piratas)
            {
                if(pirata.local == posicao)
                {
                    piratasNaPosicao.Add(pirata);
                }
            }

            return piratasNaPosicao;
        }

    }
}
