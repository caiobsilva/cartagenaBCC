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

        public void Tabuleiro() {
            Form1 form1 = new Form1();

            PictureBox[] posicoesTabuleiro = new PictureBox[38];

            string[] cartasTabuleiro = new string[38];
            cartasTabuleiro = Form1.tabuleiroCartasPosicoes;

            string[] piratasTabuleiro = new string[38];


            for (int i = 0; i < posicoesTabuleiro.Length; i++) {
                posicoesTabuleiro[i] = new PictureBox();
                posicoesTabuleiro[i].Height = 50;
                posicoesTabuleiro[i].Width = 50;

                switch (cartasTabuleiro[i]) {
                    case "C":
                        posicoesTabuleiro[i].Image = Image.FromFile(@"../../res/chave.png");
                        break;
                    case "E":
                        posicoesTabuleiro[i].Image = Image.FromFile(@"../../res/esqueleto.png");
                        break;
                    case "F":
                        posicoesTabuleiro[i].Image = Image.FromFile(@"../../res/faca.png");
                        break;
                    case "G":
                        posicoesTabuleiro[i].Image = Image.FromFile(@"../../res/garrafa.png");
                        break;
                    case "P":
                        posicoesTabuleiro[i].Image = Image.FromFile(@"../../res/pistola.png");
                        break;
                    case "T":
                        posicoesTabuleiro[i].Image = Image.FromFile(@"../../res/tricornio.png");
                        break;
                    default:
                        posicoesTabuleiro[i].BackColor = Color.Black;
                        break;
                }

                flpTabuleiro.Controls.Add(posicoesTabuleiro[i]);
            }
        }

    }
}
