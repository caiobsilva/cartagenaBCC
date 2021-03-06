using System;
using System.Collections.Generic;

namespace Cartagena
{
    public class Jogada
    {
        string _carta { get; set; }
        Tabuleiro _tabuleiro { get; set; }
        Pirata _pirata { get; set; }
        private int _indexPirata;
        
        public string carta { get { return _carta; } }
        public Tabuleiro tabuleiro { get { return _tabuleiro; } }
        public Pirata pirata { get { return _pirata; } }
        public int indexPirata { get { return _indexPirata; } }
        public int pontuacao { get; set; }
        public List<Jogada> jogadasFuturas;

        public Jogada(Tabuleiro tabuleiro, Pirata pirata, string carta, int l)
        {
            _tabuleiro = new Tabuleiro(tabuleiro);
            _pirata = pirata.copiar();
            _carta = carta;
            _indexPirata = l;
            pontuacao = 0;
        }

        public Jogada(Tabuleiro tabuleiro, Pirata pirata, int l)
        {
            _tabuleiro = new Tabuleiro(tabuleiro);
            _pirata = pirata.copiar();
            _carta = "voltar";
            _indexPirata = l;
            pontuacao = 0;
        }
        
        public Jogada(Tabuleiro tabuleiro)
        {
            _tabuleiro = new Tabuleiro(tabuleiro);
            _carta = "pular";
            pontuacao = 0;
        }
        
        public void simularJogada()
        {
            if (carta == "voltar")
            {
                int localAntigo = pirata.local, localNovo;

                for (localNovo = localAntigo - 1; localNovo > 0; localNovo--)
                {
                    if (tabuleiro.Posicoes[localNovo].numeroPiratas() > 0 &&
                        tabuleiro.Posicoes[localNovo].numeroPiratas() < 3)
                    {
                        tabuleiro.Posicoes[localAntigo].piratas.Remove(pirata);
                        pirata.local = localNovo;
                        tabuleiro.Posicoes[localNovo].piratas.Add(pirata);
                        break;
                    }
                }
                
            }
            else
            {
                int localNovo, localAntigo = pirata.local;
                
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
        }
        
    }
}
