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
        public static string[] cartasTabuleiro = new string[38];
        public static string[] idJogadores = new string[5];
        public static string[] tabuleiro = new string[38];

        Partida partidaAtiva;

        public Form1(){
            InitializeComponent();
            lblVersao.Text += Jogo.Versao;
        }

        //Método de quebra das linhas de posicionamento dos piratas no mapa.
        public void quebraLinhaPosicoes(){
            //Armazena o id do jogador e quantidade de piratas num determinado indice-posição.
            string posicao, id, quantidadePiratas;
            string temp;

            string[] idJogadores = new string[5];

            //Recebe a vez e as jogadas.
            temp = Jogo.VerificarVez(Convert.ToInt32(txtPartidaID.Text));
            string[] posicoesPiratas = temp.Split('\n');

            //Recebe as distribuições de cartas no tabuleiro.
            temp = Jogo.ExibirTabuleiro(Convert.ToInt32(txtPartidaID.Text));
            string[] linha = temp.Split('\n');

            for (int i = 1; i < posicoesPiratas.Length-1; i++){
                int index1 = posicoesPiratas[i].IndexOf(',');
                int index2 = posicoesPiratas[i].IndexOf(',', index1 + 1);
                posicao = posicoesPiratas[i].Substring(0,index1);
                id = posicoesPiratas[i].Substring(index1+1, index2-2);
                quantidadePiratas = posicoesPiratas[i].Substring(index2+1);

                tabuleiro[Convert.ToInt32(posicao)] += id + "," + quantidadePiratas + "\n";
            }

            for (int i = 0; i < tabuleiro.Length - 1; i++){
                if(tabuleiro[i] != null)
                    lsbLog.Items.Add(tabuleiro[i]);
            }
        }

        public string[] mostrarCartasTabuleiro(){
            string statusTabuleiro = Jogo.ExibirTabuleiro(Convert.ToInt32(txtPartidaID.Text));
            string[] linhaTabuleiro = statusTabuleiro.Split('\n');
            for (int k = 0; k < linhaTabuleiro.Length - 1; k++){
                linhaTabuleiro[k] = linhaTabuleiro[k].Replace("\n", "");
            }
            //Percorre o vetor de 1 até 36.
            for (int i = 1; i < linhaTabuleiro.Length - 2; i++){
                int index = linhaTabuleiro[i].IndexOf(',');
                string temp = linhaTabuleiro[i].Substring(index, index+1);
                temp = temp.Replace(",", "");
                temp = temp.Replace("\r", "");
                cartasTabuleiro[i] = temp;
            }

            return cartasTabuleiro;
        }

        //Método de recebimento dos identificadores dos jogadores.
        public void quebraCaracteresIdJogadores() {
            string[] tempJogadores = Jogo.ListarJogadores(78).Split('\n');
            for (int i = 0; i < tempJogadores.Length; i++) {
                tempJogadores[i] = tempJogadores[i].Replace("\r", "");
                tempJogadores[i] = tempJogadores[i].Replace("\n", "");
                int index1 = tempJogadores[i].IndexOf(',');
                //O conteúdo de tempJogadores[1] é vazio.
                if (index1 != -1) {
                    idJogadores[i] = tempJogadores[i].Substring(0, index1);
                }
            }
        }

        //Método de inicialização de partida.
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
            for (int i = 0; i < linha.Length - 1; i++){
                linha[i] = linha[i].Replace("\r", "");
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
            for (int i = 0; i < jogadorCartas.Length - 1; i++){
                jogadorCartas[i].Replace("\r", "");
                lsbLog.Items.Add(jogadorCartas[i]);
            }
        }

        //Método de listagem de jogadores
        private void btnJogadoresListar_Click(object sender, EventArgs e){
            int partidaID = Convert.ToInt32(txtPartidaID.Text);
            string[] jogadores = Jogo.ListarJogadores(partidaID).Split('\r');

            lsbLog.Items.Clear();
            for(int i = 0; i < jogadores.Length - 1; i++){
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

            for (int i = 0; i < jogadas.Length - 1; i++){
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

            for (int i = 0; i < jogadas.Length - 1; i++){
                jogadas[i] = jogadas[i].Replace("\r", "");
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
            lsbLog.Items.Clear();
            mostrarCartasTabuleiro();
            quebraCaracteresIdJogadores();
            quebraLinhaPosicoes();
            Form2 formDois = new Form2();
            formDois.Tabuleiro();
            formDois.Show();
        }

        //Método de verificar vez.
        private void btnVerificarVez_Click(object sender, EventArgs e){
           string vez = Jogo.VerificarVez(Convert.ToInt32(txtPartidaID.Text));
           string[] jogadas = vez.Split('\r');
            lsbLog.Items.Clear();
            for (int i = 0; i < jogadas.Length-1; i++){
                jogadas[i].Replace("\n", "");
                lsbLog.Items.Add(jogadas[i]);
            }
        }

        private void btnIniciarKuriso_Click(object sender, EventArgs e)
        {
            // Iniciar todas as variaveis aqui
            partidaAtiva = new Partida(
               Convert.ToInt32(txtPartidaID.Text), // ID partida
               txtPartidaNome.Text, // Nome da partida
               txtPartidaSenha.Text, // Senha da partida
               Convert.ToInt32(txtJogadorID.Text), // ID jogador
               txtJogadorNome.Text, // Nome do jogador
               txtJogadorSenha.Text, // Senha do jogador
               "Vermelho" // Cor do jogador
            );
            // Iniciando timer
            timerVerificarVez.Enabled = true;
        }

        private void timerVerificarVez_Tick(object sender, EventArgs e)
        {
            string[] dadosVerificarVez;
            string status, vez;
            int numeroJogadas, idJogador;

            dadosVerificarVez = Jogo.VerificarVez(Convert.ToInt16(txtPartidaID.Text)).Split('\n');
            vez = dadosVerificarVez[0].Replace("\r","");

            // Verifica se a partida começou 
            if (vez == "Erro:Partida não está em andamento") return;

            dadosVerificarVez = vez.Split(',');

            status = dadosVerificarVez[0];
            idJogador = Convert.ToInt16(dadosVerificarVez[1]);
            numeroJogadas = Convert.ToInt16(dadosVerificarVez[2]);

            // Verifica se é nossa vez
            if (idJogador != partidaAtiva.Kuriso.id) return;


            foreach (Pirata p in partidaAtiva.Kuriso.piratas)
            {
                Console.Write(p.local.ToString() + " ");
            }
            Console.WriteLine();
            
            moverAleatoriamente();

        }

        void moverAleatoriamente()
        {

            Random r = new Random();

            int x = r.Next(0,6);
            int y = r.Next(0,partidaAtiva.Kuriso.cartas.Count);


            if (partidaAtiva.Kuriso.cartas.Count > 0)
            {
                int i;
                string carta = partidaAtiva.Kuriso.cartas[y];
                partidaAtiva.Kuriso.cartas.RemoveAt(y); 
                
                lsbLog.Items.Add(Jogo.Jogar(partidaAtiva.Kuriso.id, partidaAtiva.Kuriso.senha,
                partidaAtiva.Kuriso.piratas[x].local,carta));

                
                
                for (i = partidaAtiva.Kuriso.piratas[x].local; x < partidaAtiva.tabuleiro.Posicoes.Length-1; i++)
                {
                    if (carta == partidaAtiva.tabuleiro.Posicoes[i].tipo && partidaAtiva.tabuleiro.Posicoes[i].piratas.Count == 0) break;
                }
                
                partidaAtiva.tabuleiro.Posicoes[partidaAtiva.Kuriso.piratas[x].local].piratas.Remove(partidaAtiva.Kuriso.piratas[x]);
                
                partidaAtiva.Kuriso.piratas[x].local = i;
                
                partidaAtiva.tabuleiro.Posicoes[partidaAtiva.Kuriso.piratas[x].local].piratas.Add(partidaAtiva.Kuriso.piratas[x]);
                
            }
            
            else
            {
                int max = 0, secMax = 0;
                Pirata pirata;

                for ( int i = 36; i > 0; i--)
                {
                    if (partidaAtiva.tabuleiro.Posicoes[i].piratas.Count > 0)
                    {
                        max = i;
                        break;
                    }
                }
                
                for ( int i = max-1; i > 0; i--)
                {
                    if (partidaAtiva.tabuleiro.Posicoes[i].piratas.Count > 0 && partidaAtiva.tabuleiro.Posicoes[i].piratas.Count < 3)
                    {
                        secMax = i;
                        break;
                    }
                }
                
                lsbLog.Items.Add(Jogo.Jogar(partidaAtiva.Kuriso.id, partidaAtiva.Kuriso.senha, max));

                pirata = partidaAtiva.tabuleiro.Posicoes[max].piratas[0];
                
                partidaAtiva.tabuleiro.Posicoes[max].piratas.Remove(pirata);
                pirata.local = secMax;
                partidaAtiva.tabuleiro.Posicoes[secMax].piratas.Add(pirata);
                
            
            

                string[] jogadorCartas = Jogo.ConsultarMao(partidaAtiva.Kuriso.id, partidaAtiva.Kuriso.senha).Split('\n');
                for (int i = 0; i < jogadorCartas.Length - 1; i++){
                    string[] cartas = jogadorCartas[i].Replace("\r", "").Split(',');
                    for (int j = 0; j < Convert.ToInt32(cartas[1]); j++)
                    {
                        partidaAtiva.Kuriso.cartas.Add(cartas[0]);               
                    }                
                }
                
            }
        }
        
    }
}
