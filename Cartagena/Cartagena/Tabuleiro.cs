using System;
using System.Collections.Generic;
using CartagenaServer;

namespace Cartagena
{
    public class Tabuleiro
    {

        public Posicao[] Posicoes;

        public Tabuleiro(int id, Pirata[] piratasKuriso)
        {
            Posicoes = new Posicao[38];
            string output = Jogo.ExibirTabuleiro(Convert.ToInt32(id));

            string[] linha = output.Split('\r');

            Posicoes[0] = new Posicao("Prisão", piratasKuriso);
            for (int i = 1; i < 37; i++)
            {
                linha[i] = linha[i].Replace("\n", "");
                string[] tipo = linha[i].Split(',');
                Posicoes[i] = new Posicao(tipo[1]);
            }
            Posicoes[37] = new Posicao("Barco");
        
        }

    }

    public class Posicao
    {
        public List<Pirata> piratas;
        string _tipo { get; set; }
        public string tipo { get { return _tipo; } }

        public Posicao(string tipo, Pirata[] piratasKuriso)
        {
            _tipo = tipo;
            piratas = new List<Pirata>();
            foreach (Pirata p in piratasKuriso)
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
    }

}
