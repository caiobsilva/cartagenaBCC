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
        string[] jogador;
        int partidaID;
        public Form1()
        {
            InitializeComponent();
        }

        //Método de 
        private void btnPartidaIniciar_Click(object sender, EventArgs e)
        {
            String jogadorIniciador;
            //O método IniciarPartida (padrão da biblioteca) retorna o id do jogador que iniciou a partida. 
            jogadorIniciador = Jogo.IniciarPartida(Convert.ToInt32(txtJogadorID.Text), txtJogadorSenha.Text);
            MessageBox.Show("O jogador de ID: " + jogadorIniciador + " iniciou a partida.");
        }

        //Método de criação de jogador. O jogador é criado quando entra em uma sala. Em cada sala o seu ID, Nome e Senha (de jogador) serão diferentes.
        private void btnPartidaEntrar_Click(object sender, EventArgs e)
        {
            string entradaRetorno = Jogo.EntrarPartida(Convert.ToInt32(txtPartidaId.Text), txtJogadorNome.Text, txtPartidaSenha.Text);

            jogador = entradaRetorno.Split(',');
            MessageBox.Show(entradaRetorno);

            txtJogadorID.Text = jogador[0].ToString();
            txtJogadorSenha.Text = jogador[1].ToString();
            //jogador[2] é a cor do jogador na partida.
        }

        //Método de criação de Partida.
        private void btnPartidaCriar_Click(object sender, EventArgs e)
        {   
            partidaID = Convert.ToInt32(Jogo.CriarPartida(txtPartidaNome.Text, txtPartidaSenha.Text));
            MessageBox.Show(partidaID.ToString());
        }

        //Método de listagem de Partidas.
        private void btnPartidaListar_Click(object sender, EventArgs e)
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

        //Método de listagem de cartas
        private void btnCartasListar_Click(object sender, EventArgs e)
        {
            int idJogador = Convert.ToInt32(txtJogadorID.Text);
            string senhaJogador = txtJogadorSenha.Text;

            string cartas = Jogo.ConsultarMao(idJogador, senhaJogador);
            lsbPartidas.Items.Add(cartas);
        }

        //Método de listagem de jogadores
        private void btnJogadoresListar_Click(object sender, EventArgs e)
        {
            partidaID = Convert.ToInt32(txtPartidaId.Text);
            string jogadores = Jogo.ListarJogadores(partidaID);

            lsbPartidas.Items.Add(jogadores);
        }
    }
}
