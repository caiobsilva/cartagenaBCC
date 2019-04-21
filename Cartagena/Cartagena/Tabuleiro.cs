using System;
using System.Collections.Generic;
using CartagenaServer;

namespace Cartagena
{
    public class Tabuleiro
    {

        public Posicao[] Posicoes;

        public Tabuleiro(int id, Pirata[] piratasKuriso, List<Inimigo> inimigos)
        {
            Posicoes = new Posicao[38];
            string output = Jogo.ExibirTabuleiro(Convert.ToInt32(id));

            string[] linha = output.Split('\r');

            Posicoes[0] = new Posicao("Prisão", piratasKuriso, inimigos);
            for (int i = 1; i < 37; i++)
            {
                linha[i] = linha[i].Replace("\n", "");
                string[] tipo = linha[i].Split(',');
                Posicoes[i] = new Posicao(tipo[1]);
            }
            Posicoes[37] = new Posicao("Barco");
        
        }

        public Tabuleiro(Tabuleiro tabuleiro)
        {
            int index = 0;
            foreach (Posicao posicao in tabuleiro.Posicoes)
            {
                Posicoes[index] = posicao.copiar();   
                index++;
            }
        }
        
        public bool existemPiratasAntesDe(int local)
        {
            bool existem = false;
            
            for (;local > 0; local--)
            {
                if (Posicoes[local].numeroPiratas() > 0)
                {
                    existem = true;
                    break;
                }
            }

            return existem;
        }

    }

    public class Posicao
    {
        public List<Pirata> piratas;
        string _tipo { get; set; }
        public string tipo { get { return _tipo; } }

        public Posicao(string tipo, Pirata[] piratasKuriso, List<Inimigo> inimigos)
        {
            
            _tipo = tipo;
            piratas = new List<Pirata>();
            foreach (Pirata p in piratasKuriso)
            {
                piratas.Add(p);
            }
            foreach (Inimigo inimigo in inimigos)
            {
                foreach (Pirata p in inimigo.piratas)
                {
                    piratas.Add(p);
                    
                }
            }
            
        }
        
        public Posicao(string tipo, List<Pirata> piratas)
        {
            
            _tipo = tipo;
            piratas = new List<Pirata>();
            foreach (Pirata p in piratas)
            {
                piratas.Add(p);
            }
            
        }

        public Posicao(string tipo)
        {
            _tipo = tipo;
            piratas = new List<Pirata>();
        }

        public int numeroPiratas()
        {
            return piratas.Count;
        }

        public Posicao copiar()
        {
            Posicao p = new Posicao(tipo,piratas);
            return p;
        }

        
        
        
    }

}
