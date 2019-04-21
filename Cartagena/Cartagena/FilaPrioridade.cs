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
        List<Entrada> jogadasPrioridade = new List<Entrada>();

        public void adicionar(Jogada jogada, int prioridade)
        {
            Entrada entrada = new Entrada(jogada, prioridade);
            //Caso a fila esteja vazia, adiciona à fila.
            if (jogadasPrioridade.Count == 0)
            {
                jogadasPrioridade.Add(entrada);
            }
            //Caso a chave seja maior que o último, adiciona à fila.
            else if (entrada.chave > jogadasPrioridade[jogadasPrioridade.Count - 1].chave)
                jogadasPrioridade.Add(entrada);

            else
            {
                int atual = jogadasPrioridade[0].chave;
                int index = 0;
                //Encontra posição que a entrada deverá ser inserida.
                for (int i = 1; i < jogadasPrioridade.Count; i++)
                {
                    while (atual < entrada.chave)
                        atual = jogadasPrioridade[i].chave;
                        index = i;
                }
                //Insere na posição específica.
                jogadasPrioridade.Insert(index, entrada);
            }
        }

        //Remove a jogada de maior prioridade.
        public Jogada remover()
        {
            //Recebe a jogada de maior prioridade.
            Jogada temp = jogadasPrioridade[jogadasPrioridade.Count - 1].jogada;
            //Remove o elemento de maior prioridade da fila.
            jogadasPrioridade.RemoveAt(jogadasPrioridade.Count - 1);
            return temp;
        }
    }
}
