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
        Kurisu _Kurisu { get; set; }
        List<Inimigo> _inimigos { get; set; }

        public string nome { get { return _nome; } }
        public int id { get { return _id; } }
        public string senha { get { return _senha; } }
        public Tabuleiro tabuleiro { get { return _tabuleiro; } }
        public Kurisu Kurisu{ get { return _Kurisu; } }
        public List<Inimigo> inimigos{ get { return _inimigos; } }

        
        public Partida(int id, string nome, string senha, int idJogador, string nomeJogador, string senhaJogador)
        {
            _id = id;
            _nome = nome;
            _senha = senha;
            _inimigos = new List<Inimigo>();
            
            string[] listaJogadores = Jogo.ListarJogadores(id).Split('\n');
            // Criando todos os jogadores
            for (int i = 0 ; i < listaJogadores.Length - 1 ; i++)
            {
                // ID, NOME, COR
                string[] atributosJogador = listaJogadores[i].Replace("\r", "").Split(',');
                
                int idInimigo = Convert.ToInt16(atributosJogador[0]);
                string nomeInimigo = atributosJogador[1];
                string cor = atributosJogador[2];
                
                if (idInimigo != idJogador)
                {
                    Inimigo inimigo = new Inimigo(idInimigo, nomeInimigo, cor);
                    _inimigos.Add(inimigo);                    
                }
                else
                {
                    _Kurisu = new Kurisu(idJogador,nomeJogador,cor,senhaJogador);
                }
            }
            
            _tabuleiro = new Tabuleiro(_id,_Kurisu.piratas,_inimigos);
        }

        /*
            Atualiza os dados do tabuleiro
        */

        public void atualizarDados(string vez)
        {
            // Limpando os piratas das posições
            foreach (Posicao posicao in tabuleiro.Posicoes)
            {
                posicao.piratas = new List<Pirata>();
            }
            
            // Atualizando os piratas da Kurisu
            Kurisu.piratas = new Pirata[6];
            int index = 0;
            string[] posicoes, jogadas;
            jogadas = vez.Split('\n');
            
            for (int i = 1; i < jogadas.Length - 1; i++)
            {
                
                jogadas[i] = jogadas[i].Replace("\r", "");
                
                posicoes = jogadas[i].Split(',');
                
                int posicao  = Convert.ToInt16(posicoes[0]),
                    idJogador = Convert.ToInt16(posicoes[1]),
                    numeroPiratas = Convert.ToInt16(posicoes[2]);

                if (idJogador == Kurisu.id)
                {
                    for (int j = 0; j <  numeroPiratas ; j++)
                    {
                        Pirata pirata = new Pirata(Kurisu.cor, posicao);
                        Kurisu.piratas[index] = pirata;
                        index++;
                        tabuleiro.Posicoes[posicao].piratas.Add(pirata);
                    }
                }
            }
            
            // Atualizando os piratas
            foreach (Inimigo inimigo in _inimigos)
            {
                index = 0;
                inimigo.piratas = new Pirata[6];
                
                for (int i = 1; i < jogadas.Length - 1; i++)
                {
                    posicoes = jogadas[i].Split(',');
                    
                    int posicao  = Convert.ToInt16(posicoes[0]),
                        idJogador = Convert.ToInt16(posicoes[1]),
                        numeroPiratas = Convert.ToInt16(posicoes[2]);

                    if (idJogador == inimigo.id)
                    {
                        for (int j = 0; j <  numeroPiratas ; j++)
                        {
                            Pirata pirata = new Pirata(inimigo.cor, posicao);
                            inimigo.piratas[index] = pirata;
                            index++;
                            tabuleiro.Posicoes[posicao].piratas.Add(pirata);
                        }
                    }
                }
            }
        }
    }
}
