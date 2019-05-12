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
    public partial class Cartagena : Form
    {
        public static string[] cartasTabuleiro = new string[38];
        public static string[] idJogadores = new string[5];
        public static string[] tabuleiro = new string[38];
        public PictureBox[] casaTabuleiro = new PictureBox[38];

        Partida partidaAtiva;

        public Cartagena()
        {
            InitializeComponent();
            lblVersao.Text += Jogo.Versao;
        }

        //Método de quebra das linhas de posicionamento dos piratas no mapa.
        public void quebraLinhaPosicoes()
        {
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

            for (int i = 1; i < posicoesPiratas.Length - 1; i++)
            {
                int index1 = posicoesPiratas[i].IndexOf(',');
                int index2 = posicoesPiratas[i].IndexOf(',', index1 + 1);
                posicao = posicoesPiratas[i].Substring(0, index1);
                id = posicoesPiratas[i].Substring(index1 + 1, index2 - 2);
                quantidadePiratas = posicoesPiratas[i].Substring(index2 + 1);

                tabuleiro[Convert.ToInt32(posicao)] += id + "," + quantidadePiratas + "\n";
            }

            for (int i = 0; i < tabuleiro.Length - 1; i++)
            {
                if (tabuleiro[i] != null)
                    lsbLog.Items.Add(tabuleiro[i]);
            }
        }

        public string[] mostrarCartasTabuleiro()
        {
            string statusTabuleiro = Jogo.ExibirTabuleiro(Convert.ToInt32(txtPartidaID.Text));
            string[] linhaTabuleiro = statusTabuleiro.Split('\n');
            for (int k = 0; k < linhaTabuleiro.Length - 1; k++)
            {
                linhaTabuleiro[k] = linhaTabuleiro[k].Replace("\n", "");
            }

            //Percorre o vetor de 1 até 36.
            for (int i = 1; i < linhaTabuleiro.Length - 2; i++)
            {
                int index = linhaTabuleiro[i].IndexOf(',');
                string temp = linhaTabuleiro[i].Substring(index, index + 1);
                temp = temp.Replace(",", "");
                temp = temp.Replace("\r", "");
                cartasTabuleiro[i] = temp;
            }

            return cartasTabuleiro;
        }

        //Método de recebimento dos identificadores dos jogadores.
        public void quebraCaracteresIdJogadores()
        {
            string[] tempJogadores = Jogo.ListarJogadores(78).Split('\n');
            for (int i = 0; i < tempJogadores.Length; i++)
            {
                tempJogadores[i] = tempJogadores[i].Replace("\r", "");
                tempJogadores[i] = tempJogadores[i].Replace("\n", "");
                int index1 = tempJogadores[i].IndexOf(',');
                //O conteúdo de tempJogadores[1] é vazio.
                if (index1 != -1)
                {
                    idJogadores[i] = tempJogadores[i].Substring(0, index1);
                }
            }
        }

        //Método de inicialização de partida.
        private void btnPartidaIniciar_Click(object sender, EventArgs e)
        {
            //O método IniciarPartida do Jogo retorna o id do jogador que iniciou a partida. 
            if (txtJogadorID.Text == "" || txtJogadorSenha.Text == "") { return; }
            
            LidarErros(Jogo.IniciarPartida(Convert.ToInt32(txtJogadorID.Text), txtJogadorSenha.Text));
            
            MessageBox.Show("Partida iniciada!");

        }

        //Método de criação de jogador. O jogador é criado quando entra em uma sala. Em cada sala o seu ID, Nome e Senha (de jogador) serão diferentes.
        private void btnPartidaEntrar_Click(object sender, EventArgs e)
        {
            if ( txtPartidaID.Text == "" || txtJogadorNome.Text == "" || txtPartidaSenha.Text == "") { return; }
            
            string entradaRetorno = Jogo.EntrarPartida(Convert.ToInt32(txtPartidaID.Text), txtJogadorNome.Text,
                txtPartidaSenha.Text);

            if (LidarErros(entradaRetorno))
            {
                string[] jogador;
    
                jogador = entradaRetorno.Split(',');
    
                txtJogadorID.Text = jogador[0].ToString();
                txtJogadorSenha.Text = jogador[1].ToString();
            }
        }

        //Método de criação de Partida.
        private void btnPartidaCriar_Click(object sender, EventArgs e)
        {
            if( txtPartidaNome.Text == "" ) {return;}
            
            int partidaID;
            string partida = Jogo.CriarPartida(txtPartidaNome.Text, txtPartidaSenha.Text);
            if (LidarErros(partida))
            {
                partidaID = Convert.ToInt32(partida);
                txtPartidaID.Text = partidaID.ToString();
            }
        }

        //Método de listagem de Partidas.
        private void btnPartidaListar_Click(object sender, EventArgs e)
        {
            string lista = Jogo.ListarPartidas("T");
            string[] linha;
            linha = lista.Split('\n');

            lsbLog.Items.Clear();
            for (int i = 0; i < linha.Length - 1; i++)
            {
                linha[i] = linha[i].Replace("\r", "");
                lsbLog.Items.Add(linha[i]);
            }
        }

        //Método de listagem de cartas
        private void btnCartasListar_Click(object sender, EventArgs e)
        {
            int jogadorID = Convert.ToInt32(txtJogadorID.Text);
            string jogadorSenha = txtJogadorSenha.Text;

            string cartas = Jogo.ConsultarMao(jogadorID, jogadorSenha);
            string[] jogadorCartas = cartas.Split('\n');

            lsbLog.Items.Clear();
            for (int i = 0; i < jogadorCartas.Length - 1; i++)
            {
                jogadorCartas[i].Replace("\r", "");
                lsbLog.Items.Add(jogadorCartas[i]);
            }
        }

        //Método de listagem de jogadores
        private void btnJogadoresListar_Click(object sender, EventArgs e)
        {
            if (txtPartidaID.Text == "") { return; }
            
            int partidaID = Convert.ToInt32(txtPartidaID.Text);
            string retorno = Jogo.ListarJogadores(partidaID);
            if (LidarErros(retorno))
            {
                string[] jogadores = retorno.Split('\r');
    
                lsbLog.Items.Clear();
                for (int i = 0; i < jogadores.Length - 1; i++)
                {
                    jogadores[i].Replace("\r", "");
                    lsbLog.Items.Add(jogadores[i]);
                }
            }
        }

        //Método de jogada. Jogar pra frente.
        private void btnAndar_Click(object sender, EventArgs e)
        {
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

            for (int i = 0; i < jogadas.Length - 1; i++)
            {
                jogadas[i].Replace("\r", "");
                lsbLog.Items.Add(jogadas[i]);
            }
        }

        //Método de jogada. Jogar pra trás.
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            int jogadorID = Convert.ToInt32(txtJogadorID.Text);
            string jogadorSenha = txtJogadorSenha.Text;
            int posicao = Convert.ToInt32(txtPirataPosicao.Text);
            string[] jogadas;

            jogadas = Jogo.Jogar(jogadorID, jogadorSenha, posicao).Split('\n');

            for (int i = 0; i < jogadas.Length - 1; i++)
            {
                jogadas[i] = jogadas[i].Replace("\r", "");
                lsbLog.Items.Add(jogadas[i]);
            }
        }

        //Método jogada. Pular vez. 
        private void btnPular_Click(object sender, EventArgs e)
        {
            int jogadorID = Convert.ToInt32(txtJogadorID.Text);
            string jogadorSenha = txtJogadorSenha.Text;

            string pular = Jogo.Jogar(jogadorID, jogadorSenha);
            LidarErros(pular);
            Console.WriteLine(pular);
            lsbLog.Items.Add("Jogada pulada!");
        }

        //Método de exibição de tabuleiro.
        //Quando o tabuleiro for implementado, deve ser removido e trocado por um timer que executa o método automaticamente.
        private void btnMostrarTabuleiro_Click(object sender, EventArgs e)
        {
            lsbLog.Items.Clear();
            mostrarCartasTabuleiro();
            quebraCaracteresIdJogadores();
            quebraLinhaPosicoes();
            /*Form2 formDois = new Form2();
            formDois.Tabuleiro();
            formDois.Show();*/

        }

        //Método de verificar vez.
        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            if (txtPartidaID.Text == "")
            {
                MessageBox.Show("Campo invalido!");
                return;
            }
            
            string retorno = Jogo.VerificarVez(Convert.ToInt32(txtPartidaID.Text));

            if (LidarErros(retorno))
            {
                string[] jogadas = retorno.Split('\r');
                lsbLog.Items.Clear();
                for (int i = 0; i < jogadas.Length - 1; i++)
                {
                    jogadas[i].Replace("\n", "");
                    Console.WriteLine(jogadas[i]);
                    lsbLog.Items.Add(jogadas[i]);
                }
            }
            
        }

        private void btnIniciarKuriso_Click(object sender, EventArgs e)
        {
            Console.WriteLine("\nKurisu iniciada.\n");

            // Iniciar todas as variaveis aqui
            partidaAtiva = new Partida(
                Convert.ToInt32(txtPartidaID.Text), // ID partida
                txtPartidaNome.Text, // Nome da partida
                txtPartidaSenha.Text, // Senha da partida
                Convert.ToInt32(txtJogadorID.Text), // ID jogador
                txtJogadorNome.Text, // Nome do jogador
                txtJogadorSenha.Text // Senha do jogador
            );
            criarInterfaceTabuleiro(); // Cria interface grafica do tabuleiro
            
            timerVerificarVez.Enabled = true; // Iniciando timer
            timerAtulizaInterface.Enabled = true; //Inicia o timer da interface grafica.
        }

        private void timerVerificarVez_Tick(object sender, EventArgs e)
        {
            string[] dadosVerificarVez;
            string vez, dados;
            int idJogador;

            dados = Jogo.VerificarVez(Convert.ToInt16(txtPartidaID.Text));
            dadosVerificarVez = dados.Split('\n');
            vez = dadosVerificarVez[0].Replace("\r", "");

            // Verifica se a partida começou 
            if (vez == "Erro:Partida não está em andamento") return;

            dadosVerificarVez = vez.Split(',');
            idJogador = Convert.ToInt16(dadosVerificarVez[1]);

            //Verifica se a partida acabou
            if (dadosVerificarVez[0] == "E")
            {

                string nomeVencedor = partidaAtiva.Kurisu.nome;

                timerVerificarVez.Enabled = false;
                lsbLog.Items.Clear();

                if (idJogador != partidaAtiva.Kurisu.id)
                {
                    foreach (Inimigo inimigo in partidaAtiva.inimigos)
                    {
                        if (idJogador == inimigo.id)
                        {
                            nomeVencedor = inimigo.nome;
                        }
                    }
                }

                lsbLog.Items.Add("Jogador Vencedor: " + nomeVencedor);
                return;
            }

            // Função para atualizar os dados em todas as jogadas
            partidaAtiva.atualizarDados(dados);
            // Desenha os piratas no tabuleiro
            partidaAtiva.Kurisu.desenharPiratas(partidaAtiva.tabuleiro, casaTabuleiro);

            // Verifica se é nossa vez
            if (idJogador != partidaAtiva.Kurisu.id)
            {
                lsbLog.Items.Clear();
                foreach (Inimigo inimigo in partidaAtiva.inimigos)
                {
                    if (idJogador == inimigo.id)
                    {
                        lsbLog.Items.Add("Vez de:" + inimigo.nome);
                    }
                }
                return;
            }

            Jogar();
            
        }

        void Jogar()
        {
            
            // avisa que estamos jogando
            lsbLog.Items.Clear();
            lsbLog.Items.Add("Nossa vez!\n");
            foreach (string carta in partidaAtiva.Kurisu.cartas)
            {
                lsbLog.Items.Add(carta);
            }
            

            // prioridades = partidaAtiva.gerarPrioridades();
            Jogada jogada = partidaAtiva.Kurisu.avaliarConsequências(partidaAtiva.tabuleiro);

            if (jogada.carta == "pular")
            {
                partidaAtiva.Kurisu.pularJogada();
            }
            else if (jogada.carta == "voltar")
            {
                partidaAtiva.Kurisu.voltarPirata(jogada);
            }
            else
            {
                partidaAtiva.Kurisu.jogar(jogada);
            }

            // função para atualizar as cartas
            partidaAtiva.Kurisu.atualizarCartas();
        }

        public static bool LidarErros(string erro)
        {
            if (!erro.Contains("ERRO:") && !erro.Contains("Erro:")) { return true; }

            MessageBox.Show(erro);
            return false;

        }

        // Parte interface abaixo

        // Cria o vetor de pictureBoxes, de acordo com o tabuleiro.
        //Funciona somente quando há um partida instanciada!
        public void criarInterfaceTabuleiro()
        {
            int positionX = 320;
            int positionY = 12;
            int row = 0;
            bool inverteRow = false;

            for (int i = 1; i < 37; i++)
            {
                //PictureBox picBox = new PictureBox();
                casaTabuleiro[i] = new PictureBox();
                switch (partidaAtiva.tabuleiro.Posicoes[i].tipo)
                {
                    case "C":
                        casaTabuleiro[i].BackgroundImage = Image.FromFile(@"../../res/chave.png");
                        break;
                    case "E":
                        casaTabuleiro[i].BackgroundImage = Image.FromFile(@"../../res/esqueleto.png");
                        break;
                    case "F":
                        casaTabuleiro[i].BackgroundImage = Image.FromFile(@"../../res/faca.png");
                        break;
                    case "G":
                        casaTabuleiro[i].BackgroundImage = Image.FromFile(@"../../res/garrafa.png");
                        break;
                    case "P":
                        casaTabuleiro[i].BackgroundImage = Image.FromFile(@"../../res/pistola.png");
                        break;
                    case "T":
                        casaTabuleiro[i].BackgroundImage = Image.FromFile(@"../../res/tricornio.png");
                        break;
                    case "Prisão":
                        casaTabuleiro[i].BackColor = Color.Black;
                        break;
                    case "Barco":
                        casaTabuleiro[i].BackColor = Color.Black;
                        break;
                }

                if (row == 6 )
                {
                    if (inverteRow==false) { inverteRow = true; positionX = 620; }
                    else if (inverteRow==true) { inverteRow = false; positionX = 320; }
                    positionY = positionY + 60;
                    row = 0;
                }
                if (row < 6 && !inverteRow)
                {
                    casaTabuleiro[i].Location = new Point(positionX, positionY);
                    if (row < 6) { positionX = positionX + 60; }
                    row++;
                }
                if(row < 6 && inverteRow)
                {
                    casaTabuleiro[i].Location = new Point(positionX, positionY);
                    if (row < 6) { positionX = positionX - 60; }
                    row++;
                }

                casaTabuleiro[i].Name = "casa"+i;
                casaTabuleiro[i].SizeMode = PictureBoxSizeMode.StretchImage;
                casaTabuleiro[i].Size = new Size(50, 50);
                //picBox.TabIndex = 98;
                casaTabuleiro[i].TabStop = false;

            }
                this.Controls.AddRange(casaTabuleiro);
        }

        private void timerAtulizaInterface_Tick(object sender, EventArgs e)
        {
            // LIMPAR INTERFACE
            for (int limpar = 1; limpar < 37; limpar++)
            {
                casaTabuleiro[limpar].Invalidate();
            }

            // Desenha os piratas no tabuleiro
            //partidaAtiva.Kurisu.desenharPiratas(partidaAtiva.tabuleiro, casaTabuleiro);
        }
    }
}
