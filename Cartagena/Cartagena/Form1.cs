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
        public static PictureBox[] casaTabuleiro = new PictureBox[38];

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
            String iniciadorID;
            //O método IniciarPartida do Jogo retorna o id do jogador que iniciou a partida. 
            iniciadorID = Jogo.IniciarPartida(Convert.ToInt32(txtJogadorID.Text), txtJogadorSenha.Text);
            //MessageBox.Show("O jogador de ID " + iniciadorID + " iniciou a partida.");
        }

        //Método de criação de jogador. O jogador é criado quando entra em uma sala. Em cada sala o seu ID, Nome e Senha (de jogador) serão diferentes.
        private void btnPartidaEntrar_Click(object sender, EventArgs e)
        {
            string entradaRetorno = Jogo.EntrarPartida(Convert.ToInt32(txtPartidaID.Text), txtJogadorNome.Text,
                txtPartidaSenha.Text);
            string[] jogador;

            jogador = entradaRetorno.Split(',');
            //MessageBox.Show(entradaRetorno);

            txtJogadorID.Text = jogador[0].ToString();
            txtJogadorSenha.Text = jogador[1].ToString();
            //jogador[2] é a cor do jogador na partida.
        }

        //Método de criação de Partida.
        private void btnPartidaCriar_Click(object sender, EventArgs e)
        {
            int partidaID = Convert.ToInt32(Jogo.CriarPartida(txtPartidaNome.Text, txtPartidaSenha.Text));
            txtPartidaID.Text = partidaID.ToString();
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
            int partidaID = Convert.ToInt32(txtPartidaID.Text);
            string[] jogadores = Jogo.ListarJogadores(partidaID).Split('\r');

            lsbLog.Items.Clear();
            for (int i = 0; i < jogadores.Length - 1; i++)
            {
                jogadores[i].Replace("\r", "");
                lsbLog.Items.Add(jogadores[i]);
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

            Jogo.Jogar(jogadorID, jogadorSenha);

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
            criarInterfaceTabuleiro();

        }

        //Método de verificar vez.
        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            string vez = Jogo.VerificarVez(Convert.ToInt32(txtPartidaID.Text));
            string[] jogadas = vez.Split('\r');
            lsbLog.Items.Clear();
            for (int i = 0; i < jogadas.Length - 1; i++)
            {
                jogadas[i].Replace("\n", "");
                Console.WriteLine(jogadas[i]);
                lsbLog.Items.Add(jogadas[i]);
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
            // Iniciando timer
            timerVerificarVez.Enabled = true;
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
                            nomeVencedor = inimigo.nome;
                    }

                }

                lsbLog.Items.Add("Jogador Vencedor: " + nomeVencedor);
                return;
            }

            
            // Função para atualizar os dados em todas as jogadas
            partidaAtiva.atualizarDados(dados);
            
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

            timerVerificarVez.Enabled = false;
            
            Jogar();

        }

        void Jogar()
        {
            for (int i = 0; i < 3; i++)
            {

                // prioridades = partidaAtiva.gerarPrioridades();
                Jogada jogada = partidaAtiva.Kurisu.avaliarConsequências(partidaAtiva.tabuleiro);

                if (jogada.carta == "volta")
                {
                    partidaAtiva.Kurisu.voltarPirata(jogada, partidaAtiva.tabuleiro);
                }
                else
                {
                    partidaAtiva.Kurisu.jogar(jogada, partidaAtiva.tabuleiro);
                }

                // função temporaria de mover aleatoriamente
                //moverAleatoriamente();

                // função para atualizar as cartas
                partidaAtiva.Kurisu.atualizarCartas();

                // avisa que estamos jogando
                lsbLog.Items.Clear();
                lsbLog.Items.Add("Nossa vez!");
                foreach (string carta in partidaAtiva.Kurisu.cartas)
                {
                    lsbLog.Items.Add(carta);
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

            }

            timerVerificarVez.Enabled = true;
            
        }

        void moverAleatoriamente()
        {
            Random r = new Random();

            int x = r.Next(0, 6);
            while (partidaAtiva.Kurisu.piratas[x].local == 37)
            {
                x = r.Next(0, 6);
            }
            int y = r.Next(0, partidaAtiva.Kurisu.cartas.Count);

            // Se ele tem mais que duas cartas vai jogar para frente se não vai voltar
            if (partidaAtiva.Kurisu.cartas.Count > 0)
            {
                Pirata pirata = partidaAtiva.Kurisu.piratas[x];
                string carta = partidaAtiva.Kurisu.cartas[y];

                // função que recebe o pirata, carta e o tabuleiro e já cuida da jogada.
                //partidaAtiva.Kurisu.jogar(pirata, carta, partidaAtiva.tabuleiro);
            }
            else
            {
                // For loop para achar o pirata que temos mais avançado
                for (int i = 36; i > 0; i--)
                {
                    // Se achou o pirata vai colocar ele em uma variavel e usar voltar para tras.
                    if (partidaAtiva.Kurisu.piratasEm(i).Count > 0)
                    {
                        Pirata pirata = partidaAtiva.Kurisu.piratasEm(i)[0];
                        if (partidaAtiva.tabuleiro.existemPiratasAntesDe(pirata.local))
                        {
                            // função que recebe o pirata e o tabuleiro e já cuida de voltar para tras.
                            //partidaAtiva.Kurisu.voltarPirata(pirata, partidaAtiva.tabuleiro);
                            break;
                        }
                        partidaAtiva.Kurisu.pularJogada();
                        break;
                    }
                }
            }
        }

        // Parte interface abaixo

        public void criarInterfaceTabuleiro()
        {
            int positionX = 320;
            int positionY = 12;
            int row = 0;
            bool inverteRow = false;

            for (int i = 0; i < 38; i++)
            {
                var picBox = new PictureBox();

                if (i == 0 || i == 37) { picBox.BackColor = Color.Black; }
                if (i >= 1 && i <= 6) { picBox.BackgroundImage = Image.FromFile(@"../../res/chave.png"); }
                if (i >= 7 && i <= 12) { picBox.BackgroundImage = Image.FromFile(@"../../res/esqueleto.png"); }
                if (i >= 13 && i <= 18) { picBox.BackgroundImage = Image.FromFile(@"../../res/faca.png"); }
                if (i >= 19 && i <= 24) { picBox.BackgroundImage = Image.FromFile(@"../../res/garrafa.png"); }
                if (i >= 25 && i <= 30) { picBox.BackgroundImage = Image.FromFile(@"../../res/pistola.png"); }
                if (i >= 31 && i <= 36) { picBox.BackgroundImage = Image.FromFile(@"../../res/tricornio.png"); }

                if (row == 6 )
                {
                    if (inverteRow==false) { inverteRow = true; positionX = 620; }
                    else if (inverteRow==true) { inverteRow = false; positionX = 320; }
                    positionY = positionY + 60;
                    row = 0;
                }
                if (row < 6 && !inverteRow)
                {
                    picBox.Location = new Point(positionX, positionY);
                    if (row < 6) { positionX = positionX + 60; }
                    row++;
                }
                if(row < 6 && inverteRow)
                {
                    picBox.Location = new Point(positionX, positionY);
                    if (row < 6) { positionX = positionX - 60; }
                    row++;
                }

                picBox.Name = "casa"+i;
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                picBox.Size = new Size(50, 50);
                //picBox.TabIndex = 98;
                picBox.TabStop = false;

                casaTabuleiro[i] = picBox;
                this.Controls.Add(picBox);

            }
        }

    }
}
