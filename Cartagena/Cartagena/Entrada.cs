using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartagena
{
    class Entrada
    {
        public Jogada jogada { get; set; }
        public int chave { get; set; }

        public Entrada(Jogada jogada, int chave)
        {
            this.jogada = jogada;
            this.chave = chave;
        }
    }
}
