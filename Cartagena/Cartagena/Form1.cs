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

namespace Cartagena
{
    public partial class Form1 : Form
    {
        static string[] jogador;
        int salaID;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            String jogadorIniciador;
            //O método IniciarPartida retorna o id do jogador que iniciou a partida. 
            jogadorIniciador = Jogo.IniciarPartida(Convert.ToInt32(txtIDJogador.Text), txtSenhaJogador.Text);
            MessageBox.Show("O jogador de ID: " + jogadorIniciador + "iniciou a partida.");
        }

        private void btnPartidaEntrar_Click(object sender, EventArgs e)
        {
            string entradaRetorno = Jogo.EntrarPartida(Convert.ToInt32(txtPartidaId.Text), txtJogadorNome.Text, txtPartidaSenha.Text);

            jogador = entradaRetorno.Split(',');
            MessageBox.Show(entradaRetorno);

            foreach (string info in jogador)
            {
                Console.WriteLine(info);
            }
        }

        private void btnSalaCriar_Click(object sender, EventArgs e)
        {
            salaID = Convert.ToInt32(Jogo.CriarPartida(txtSalaNome.Text, txtPartidaSenha.Text));
            MessageBox.Show(salaID.ToString());
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string lista = Jogo.ListarPartidas("T");
            string[] linha;
            linha = lista.Split('\n');

            lsbPartidas.Items.Clear();
            for (int i = 0; i < linha.Length; i++)
            {
                linha[i].Replace("\r", "");
                lsbPartidas.Items.Add(linha[i]);
            }
        }
    }
}
