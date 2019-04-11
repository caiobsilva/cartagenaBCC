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
        public static string[] tabuleiroCartasPosicoes;
        public Form1(){
            InitializeComponent();
        }

        //Método de quebra de linha e caracteres do posicionamento dos piratas no mapa.
        public void quebraLinhaPosicoes(){
            //Armazena o id do jogador e quantidade de piratas num determinado indice-posição.
            string[] tabuleiro = new string[38];
            string posicao, id, quantidadePiratas;
            string temp;

            temp = Jogo.VerificarVez(Convert.ToInt32(txtPartidaID.Text));
            string[] posicoesPiratas = temp.Split('\n');

            temp = Jogo.ExibirTabuleiro(Convert.ToInt32(txtPartidaID.Text));
            string[] linhasTabuleiro = temp.Split('\n');

            for (int i = 0 ; i < linhasTabuleiro.Length-1; i++){
                linhasTabuleiro[i] = linhasTabuleiro[i].Replace("\n","");
                tabuleiro[i] = linhasTabuleiro[i];
            }

            for (int i = 1; i < posicoesPiratas.Length-1; i++){
                int index1 = posicoesPiratas[i].IndexOf(',');
                int index2 = posicoesPiratas[i].IndexOf(',', index1 + 1);
                posicao = posicoesPiratas[i].Substring(0,index1);
                id = posicoesPiratas[i].Substring(index1+1, index2-2);
                quantidadePiratas = posicoesPiratas[i].Substring(index2+1);

                tabuleiro[Convert.ToInt32(posicao)] += " | " + " O jogador " + id + " tem " + quantidadePiratas + " aqui.";

            }
            lsbLog.Items.Clear();

            for (int k = 0; k < tabuleiro.Length - 1; k++){
                lsbLog.Items.Add(tabuleiro[k]);
            }
        }
        public string[] mostrarCartasTabuleiro(){
            string statusTabuleiro = Jogo.ExibirTabuleiro(Convert.ToInt32(txtPartidaID.Text));
            string[] linhaTabuleiro = statusTabuleiro.Split('\n');
            tabuleiroCartasPosicoes = new string[38];
            for (int k = 0; k < linhaTabuleiro.Length - 1; k++){
                linhaTabuleiro[k] = linhaTabuleiro[k].Replace("\n", "");
            }
            //percorrer somente da 1 ate a 36
            for (int i = 1; i < linhaTabuleiro.Length - 2; i++){
                int index = linhaTabuleiro[i].IndexOf(',');
                string temp = linhaTabuleiro[i].Substring(index, index+1);
                temp = temp.Replace(",", "");
                temp = temp.Replace("\r", "");
                tabuleiroCartasPosicoes[i] = temp;
            }

            return tabuleiroCartasPosicoes;
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
            string entradaRetorno = Jogo.EntrarPartida(Convert.ToInt32(txtPartidaID.Text), txtJogadorNome.Text, txtPartidaSenha.Text);
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
            txtPartidaID.Text = partidaID.ToString();
        }

        //Método de listagem de Partidas.
        private void btnPartidaListar_Click(object sender, EventArgs e){
            string lista = Jogo.ListarPartidas("T");
            string[] linha;
            linha = lista.Split('\n');

            lsbLog.Items.Clear();
            for (int i = 0; i < linha.Length; i++){
                linha[i].Replace("\r", "");
                lsbLog.Items.Add(linha[i]);
            }
        }

        //Método de listagem de cartas
        private void btnCartasListar_Click(object sender, EventArgs e){
            int jogadorID = Convert.ToInt32(txtJogadorID.Text);
            string jogadorSenha = txtJogadorSenha.Text;

            string cartas = Jogo.ConsultarMao(jogadorID, jogadorSenha);
            string[] jogadorCartas = cartas.Split('\n');

            lsbLog.Items.Clear();
            for (int i = 0; i < jogadorCartas.Length; i++){
                jogadorCartas[i].Replace("\r", "");
                lsbLog.Items.Add(jogadorCartas[i]);
            }
        }

        //Método de listagem de jogadores
        private void btnJogadoresListar_Click(object sender, EventArgs e){
            int partidaID = Convert.ToInt32(txtPartidaID.Text);
            string[] jogadores = Jogo.ListarJogadores(partidaID).ToString().Split('\r');

            lsbLog.Items.Clear();
            for(int i = 0; i < jogadores.Length; i++){
                jogadores[i].Replace("\r","");
                lsbLog.Items.Add(jogadores[i]);
            }
        }

        //Método de jogada. Jogar pra frente.
        private void btnAndar_Click(object sender, EventArgs e){
            //Posição do pirata. Carta a ser jogada. Senha do jogador. id do jogador.
            int jogadorID = Convert.ToInt32(txtJogadorID.Text);
            string jogadorSenha = txtJogadorSenha.Text;
            int pirata = Convert.ToInt32(txtPirataPosicao.Text);
            string carta = cboCartas.SelectedItem.ToString();

            string[] jogadas;

            //Pega apenas o primeiro caractere do item selecionado.
            carta = carta.Substring(0, 1);

            lsbLog.Items.Clear();
            jogadas = Jogo.Jogar(jogadorID, jogadorSenha, pirata, carta).Split('\n');

            for (int i = 0; i < jogadas.Length; i++){
                jogadas[i].Replace("\r", "");
                lsbLog.Items.Add(jogadas[i]);
            }
        }

        //Método de jogada. Jogar pra trás.
        private void btnVoltar_Click(object sender, EventArgs e){
            int jogadorID = Convert.ToInt32(txtJogadorID.Text);
            string jogadorSenha = txtJogadorSenha.Text;
            int posicao = Convert.ToInt32(txtPirataPosicao.Text);
            string[] jogadas;

            jogadas = Jogo.Jogar(jogadorID, jogadorSenha, posicao).Split('\n');

            for (int i = 0; i < jogadas.Length; i++){
                jogadas[i].Replace("\r", "");
                lsbLog.Items.Add(jogadas[i]);
            }
        }

        //Método jogada. Pular vez. 
        private void btnPular_Click(object sender, EventArgs e){
            int jogadorID = Convert.ToInt32(txtJogadorID.Text);
            string jogadorSenha = txtJogadorSenha.Text;

            Jogo.Jogar(jogadorID, jogadorSenha);

            lsbLog.Items.Add("Jogada pulada!");
        }

        //Método de exibição de tabuleiro.
        //Quando o tabuleiro for implementado, deve ser removido e trocado por um timer que executa o método automaticamente.
        private void btnMostrarTabuleiro_Click(object sender, EventArgs e){
            /*string tabuleiro = Jogo.ExibirTabuleiro(Convert.ToInt32(txtPartidaID.Text));
            string[] linha;
            linha = tabuleiro.Split('\r');

            lsbLog.Items.Clear();
            for (int i = 0; i < linha.Length; i++){
                linha[i] = linha[i].Replace("\n","");
                lsbLog.Items.Add(linha[i]);
            }*/
            /*lsbLog.Items.Clear();
            mostrarCartasTabuleiro();
            Form2 formDois = new Form2();
            formDois.Tabuleiro();
            formDois.Show();
            */
            quebraLinhaPosicoes();
        }

        //Método de verificar vez.
        private void btnVerificarVez_Click(object sender, EventArgs e){
           string vez = Jogo.VerificarVez(Convert.ToInt32(txtPartidaID.Text));
           string[] jogadas = vez.Split('\r');
            lsbLog.Items.Clear();
            for (int i = 0; i < jogadas.Length; i++){
                jogadas[i].Replace("\n", "");
                lsbLog.Items.Add(jogadas[i]);
            }
        }
    }
}
