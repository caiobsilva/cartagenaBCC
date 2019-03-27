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

namespace Cartagena{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        //Método de início de partida.
        private void btnPartidaIniciar_Click(object sender, EventArgs e){
            String iniciadorID;
            //O método IniciarPartida do Jogo retorna o id do jogador que iniciou a partida. 
            iniciadorID = Jogo.IniciarPartida(Convert.ToInt32(txtJogadorID.Text), txtJogadorSenha.Text);
            MessageBox.Show("O jogador de ID " + iniciadorID + " iniciou a partida.");
        }

        //Método de criação de jogador. O jogador é criado quando entra em uma sala. Em cada sala o seu ID, Nome e Senha (de jogador) serão diferentes.
        private void btnPartidaEntrar_Click(object sender, EventArgs e){
            string entradaRetorno = Jogo.EntrarPartida(Convert.ToInt32(txtPartidaId.Text), txtJogadorNome.Text, txtPartidaSenha.Text);
            string[] jogador;

            jogador = entradaRetorno.Split(',');
            MessageBox.Show(entradaRetorno);

            txtJogadorID.Text = jogador[0].ToString();
            txtJogadorSenha.Text = jogador[1].ToString();
            //jogador[2] é a cor do jogador na partida.
        }

        //Método de criação de Partida.
        private void btnPartidaCriar_Click(object sender, EventArgs e){   
            int partidaID = Convert.ToInt32(Jogo.CriarPartida(txtPartidaNome.Text, txtPartidaSenha.Text));
            txtPartidaId.Text = partidaID.ToString();
        }

        //Método de listagem de Partidas.
        private void btnPartidaListar_Click(object sender, EventArgs e){
            string lista = Jogo.ListarPartidas("T");
            string[] linha;
            linha = lista.Split('\n');

            lsbPartidas.Items.Clear();
            for (int i = 0; i < linha.Length; i++){
                linha[i].Replace("\r", "");
                lsbPartidas.Items.Add(linha[i]);
            }
        }

        //Método de listagem de cartas
        private void btnCartasListar_Click(object sender, EventArgs e){
            int jogadorID = Convert.ToInt32(txtJogadorID.Text);
            string jogadorSenha = txtJogadorSenha.Text;

            string cartas = Jogo.ConsultarMao(jogadorID, jogadorSenha);
            string[] jogadorCartas = cartas.Split('\n');

            lsbCartas.Items.Clear();
            for (int i = 0; i < jogadorCartas.Length; i++) {
                jogadorCartas[i].Replace("\r", "");
                lsbCartas.Items.Add(jogadorCartas[i]);
            }
        }

        //Método de listagem de jogadores
        private void btnJogadoresListar_Click(object sender, EventArgs e){
            int partidaID = Convert.ToInt32(txtPartidaId.Text);
            string jogadores = Jogo.ListarJogadores(partidaID);

            lsbJogadores.Items.Clear();
            lsbJogadores.Items.Add(jogadores);
        }

        //Método de jogada. Jogar pra frente.
        private void btnAndar_Click(object sender, EventArgs e){
            //Posição do pirata. Carta a ser jogada. Senha do jogador. id do jogador.
            int pirata = Convert.ToInt32(txtPirataPosicao.Text);
            string carta = cboCartas.SelectedItem.ToString();
            string jogadorSenha = txtJogadorSenha.Text.ToString();
            int jogadorID = Convert.ToInt32(txtJogadorID.Text);

            string[] jogadas;

            switch (carta){
                case "Chave":
                    carta = "C";
                    break;
                case "Esqueleto":
                    carta = "E";
                    break;
                case "Faca":
                    carta = "F";
                    break;
                case "Garrafa":
                    carta = "G";
                    break;
                case "Pistola":
                    carta = "P";
                    break;
            }

            lsbJogadas.Items.Clear();
            jogadas = Jogo.Jogar(jogadorID, jogadorSenha, pirata, carta).Split('\n');

            for (int i = 0; i < jogadas.Length; i++) {
                jogadas[i].Replace("\r", "");
                lsbJogadas.Items.Add(jogadas[i]);
            }
        }
    }
}
