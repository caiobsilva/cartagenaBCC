using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartagena {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private string[] jogadorID(string[] tabuleiro)
        {
            int index1, index2,runTime = 0;
            int tempIndex2;
            string[] id = new string[5];
            if(tabuleiro[0] != "")
            {
                tabuleiro[0] = tabuleiro[0].Replace("\r", "");
                //Console.WriteLine(tabuleiro[0]); 
                index1 = tabuleiro[0].IndexOf(',');
                index2 = tabuleiro[0].IndexOf(';');
                id[runTime] = tabuleiro[0].Substring(0, index1);
                runTime+=1; //ate aqui ta OK
                //Console.WriteLine(id[runTime]);
                while (tabuleiro[0].IndexOf(';', index2+1) != -1 && runTime!=4)
                    {
                        tempIndex2 = index2 + 1;
                        index1 = tabuleiro[0].IndexOf(',',index1+1);
                        index2 = tabuleiro[0].IndexOf(';', index2 + 1);
                        id[runTime] = tabuleiro[0].Substring(tempIndex2, index1-1);
                        //Console.WriteLine(id[runTime]);
                        runTime+=1;
                    }
            }
            Console.WriteLine(id[0],id[1],id[2],id[3],id[4]);
            return id;
        }

        private Brush retornaCor(string id) {
            //Ordem das cores:
            //Vermelho, Verde, Amarelo, Azul, Marrom. Do primeiro ao último (menor id para o maior).
            if (id == Form1.idJogadores[0])
                return Brushes.Red;
            else if (id == Form1.idJogadores[1])
                return Brushes.Green;
            else if (id == Form1.idJogadores[2])
                return Brushes.Yellow;
            else if (id == Form1.idJogadores[3])
                return Brushes.Blue;
            else
                return Brushes.Brown;

        }

        public void Tabuleiro() {
            PictureBox[] pictureTabuleiro = new PictureBox[38];

            string[] cartas = Form1.cartasTabuleiro;

            string[] piratasTabuleiro = new string[38];
            
            for (int i = 0; i < pictureTabuleiro.Length; i++) {
                pictureTabuleiro[i] = new PictureBox();
                pictureTabuleiro[i].Height = 50;
                pictureTabuleiro[i].Width = 50;

                switch (cartas[i]) {
                    case "C":
                        pictureTabuleiro[i].Image = Image.FromFile(@"../../res/chave.png");
                        break;
                    case "E":
                        pictureTabuleiro[i].Image = Image.FromFile(@"../../res/esqueleto.png");
                        break;
                    case "F":
                        pictureTabuleiro[i].Image = Image.FromFile(@"../../res/faca.png");
                        break;
                    case "G":
                        pictureTabuleiro[i].Image = Image.FromFile(@"../../res/garrafa.png");
                        break;
                    case "P":
                        pictureTabuleiro[i].Image = Image.FromFile(@"../../res/pistola.png");
                        break;
                    case "T":
                        pictureTabuleiro[i].Image = Image.FromFile(@"../../res/tricornio.png");
                        break;
                    default:
                        pictureTabuleiro[i].BackColor = Color.Black;
                        break;
                }

                flpTabuleiro.Controls.Add(pictureTabuleiro[i]);
                //Tratar o Form1.tabuleiro
                //Primeiro, divida os ids e os passe (um a um) como parâmetro para a função "retornaCor".
                //Brush pincel = retornaCor("0");
                //Segundo, desenhar a quantidade de piratas na posição atual (com a cor do jogador) no pictureTabuleiro[i]. Um código exemplo abaixo (ele está funcionando):
                string temp = Form1.tabuleiro[i];
                Brush pincel;
                if (i == 0 || i == 37) {
                    pincel = Brushes.DarkRed;
                }
                else {
                    pincel = Brushes.White;
                }
                pictureTabuleiro[i].Paint += new PaintEventHandler((sender, e) =>
                {
                    //gr.Dispose()
                    //https://social.msdn.microsoft.com/Forums/en-US/4756ef0a-87bf-4d57-b5d3-a0651c4a41c9/drawstring-delete?forum=Vsexpressvb
                    e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                    e.Graphics.DrawString(temp, Font, pincel, 0, 0);
                });
            }
        }
    }
}
