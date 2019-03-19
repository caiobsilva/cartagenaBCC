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

namespace CartagenaServidores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e){

            string lista = Jogo.ListarPartidas("T");
            string[] linha;
            linha = lista.Split('\n');

            lsbPartidas.Items.Clear();
            for (int i = 0; i < linha.Length; i++){
                linha[i].Replace("\r", "");
                lsbPartidas.Items.Add(linha[i]);
            }

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {

        }
    }
}
