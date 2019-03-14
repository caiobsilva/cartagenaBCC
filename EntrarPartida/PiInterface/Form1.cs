using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace PiInterface
{
    public partial class Form1 : Form
    {
        static string[] jogador;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPartidaEntrar_Click(object sender, EventArgs e)
        {
            string entradaRetorno = Jogo.EntrarPartida(Convert.ToInt32(txtPartidaId.Text), txtJogadorNome.Text, txtPartidaSenha.Text);

            jogador = entradaRetorno.Split(',');
            MessageBox.Show(entradaRetorno);

            foreach (string info in jogador){
                Console.WriteLine(info);
            }
        }
    }
}
