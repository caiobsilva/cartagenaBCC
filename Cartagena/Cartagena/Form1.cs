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
        public const int pcbEixoX = 340; //Define a posição inicial desenho das pictureboxes no eixo X
        public const int pcbEixoY = 92; //Define a posição inicial desenho das pictureboxes no eixo Y

        Partida partidaAtiva;

        public Cartagena()
        {
            InitializeComponent();
            lblVersao.Text += Jogo.Versao;
        }

        //Método de inicialização de partida.
        private void btnPartidaIniciar_Click(object sender, EventArgs e)
        {
            //O método IniciarPartida do Jogo retorna o id do jogador que iniciou a partida. 
            if (txtJogadorID.Text == "" || txtJogadorSenha.Text == "")
            {
                MessageBox.Show("Campo invalido!");
                return;
            }
            
            LidarErros(Jogo.IniciarPartida(Convert.ToInt32(txtJogadorID.Text), txtJogadorSenha.Text));
            
            MessageBox.Show("Partida iniciada!");

        }

        //Método de criação de jogador. O jogador é criado quando entra em uma sala. Em cada sala o seu ID, Nome e Senha (de jogador) serão diferentes.
        private void btnPartidaEntrar_Click(object sender, EventArgs e)
        {
            if (txtPartidaID.Text == "" || txtJogadorNome.Text == "" || txtPartidaSenha.Text == "")
            {
                MessageBox.Show("Campo invalido!");
                return;
            }
            
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
            if (txtPartidaNome.Text == "")
            {
                MessageBox.Show("Campo invalido!");
                return;
            }
            
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
            if (txtPartidaID.Text == "")
            {
                MessageBox.Show("Campo invalido!");
                return;
            }
            
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
                timerVerificarVez.Enabled = false;
                lsbLog.Items.Clear();
                
                string nomeVencedor = verificarVencedor(dados);
        
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
                        lsbLog.Items.Add("Vez de:" + inimigo.nome + "(" + inimigo.cor + ")\n");
                    }
                }
                return;
            }
            
            // Printando o tabuleiro
            Console.WriteLine(partidaAtiva.tabuleiro.ToString());
            // Printando todos os piratas da Kuriso
            Console.WriteLine(partidaAtiva.Kurisu.ToString());
            // Printando todos os piratas dos inimigos
            if (partidaAtiva.inimigos.Count > 0)
            {
                foreach (Inimigo inimigo in partidaAtiva.inimigos)
                {
                    Console.WriteLine(inimigo.ToString());
                }
            }
            
            Jogar();
            
        }

        void Jogar()
        {
            
            // avisa que estamos jogando
            lsbLog.Items.Clear();
            lsbLog.Items.Add("Nossa vez! (" + partidaAtiva.Kurisu.cor + ")\n" );

            lblChave.Text = "x0";
            lblEsq.Text = "x0";
            lblFaca.Text = "x0";
            lblGar.Text = "x0";
            lblPist.Text = "x0";
            lblTric.Text = "x0";

            int chave = 0, esqueleto = 0, faca = 0, garrafa = 0, pistola = 0, tricornio = 0;

            foreach (string carta in partidaAtiva.Kurisu.cartas)
            {

                switch (carta)
                {
                    case "C":
                        chave++;
                        lblChave.Text = "x" + chave.ToString();
                        break;
                    case "E":
                        esqueleto++;
                        lblEsq.Text = "x" + esqueleto.ToString();
                        break;
                    case "F":
                        faca++;
                        lblFaca.Text = "x" + faca.ToString();
                        break;
                    case "G":
                        garrafa++;
                        lblGar.Text = "x" + garrafa.ToString();
                        break;
                    case "P":
                        pistola++;
                        lblPist.Text = "x" + pistola.ToString();
                        break;
                    case "T":
                        tricornio++;
                        lblTric.Text = "x" + tricornio.ToString();
                        break;
                }
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
            
        public string verificarVencedor(string vez)
        {
            string vencedor = "";
            string[] posicoes, jogadas;
            jogadas = vez.Split('\n');
            
            for (int i = 1; i < (jogadas.Length - 1); i++)
            {
                
                jogadas[i] = jogadas[i].Replace("\r", "");
                posicoes = jogadas[i].Split(',');
                
                int posicao  = Convert.ToInt16(posicoes[0]),
                    idJogador = Convert.ToInt16(posicoes[1]),
                    numeroPiratas = Convert.ToInt16(posicoes[2]);
                
                if (posicao == 37 && numeroPiratas == 6)
                {
                    if (idJogador == partidaAtiva.Kurisu.id)
                    {
                        vencedor = partidaAtiva.Kurisu.nome;
                        break;
                    }
                    foreach (Inimigo inimigo in partidaAtiva.inimigos)
                    {
                        
                        if (idJogador == inimigo.id)
                        {
                            vencedor = inimigo.nome;
                            break;
                        }   
                        
                    }
                }

            }

            return vencedor;

        }

        // Parte interface abaixo

        //Cria o vetor de pictureBoxes, de acordo com o tabuleiro.
        //Funciona somente quando há um partida instanciada!
        public void criarInterfaceTabuleiro()
        {
            int positionX = pcbEixoX;
            int positionY = pcbEixoY;
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
                    if (inverteRow==false) { inverteRow = true; positionX = pcbEixoX+300; }
                    else if (inverteRow==true) { inverteRow = false; positionX = pcbEixoX; }
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
