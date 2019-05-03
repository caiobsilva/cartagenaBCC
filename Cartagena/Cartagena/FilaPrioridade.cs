using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartagena
{
    class FilaPrioridade
    {
        //A fila. Uma fila de entradas (jogada, chave).
        List<Entrada> jogadas = new List<Entrada>();

        public void adicionar(Jogada jogada, int prioridade)
        {
            Entrada entrada = new Entrada(jogada, prioridade);
            //Caso a fila esteja vazia, adiciona à fila.
            if (jogadas.Count == 0)
                jogadas.Add(entrada);
            
            //Caso a chave seja maior que o último, adiciona à fila.
            else if (entrada.chave > jogadas[jogadas.Count - 1].chave)
                jogadas.Add(entrada);

            else
            {
                int atual = jogadas[0].chave;
                int index = 0;
                //Encontra posição que a entrada deverá ser inserida.
                while (atual < entrada.chave)
                {
                    index++;
                    atual = jogadas[index].chave;
                }
                //Insere na posição específica.
                jogadas.Insert(index, entrada);
            }
        }

        //Retorna a jogada de maior prioridade.
        public Jogada remover()
        {
            //Recebe a jogada de maior prioridade.
            Jogada temp = jogadas[jogadas.Count - 1].jogada;
            //Remove o elemento de maior prioridade da fila.
            jogadas.RemoveAt(jogadas.Count - 1);
            return temp;
        }

        public override string ToString()
        {
            string toString = "";

            foreach (Entrada jogada in jogadas)
            {
                toString += jogada.chave.ToString() + " ";
            }
            
            return toString;
        }
    }
}
