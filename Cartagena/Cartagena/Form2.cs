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

            }
            pictureTabuleiro[0].Paint += new PaintEventHandler((sender, e) =>
            {
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                e.Graphics.DrawString("1", Font, Brushes.Red, 0, 0);
                e.Graphics.DrawString("\n2", Font, Brushes.Red, 0, 0);
            });
        }
    }
}
