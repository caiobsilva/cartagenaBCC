namespace Cartagena
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtJogadorID = new System.Windows.Forms.TextBox();
            this.txtJogadorSenha = new System.Windows.Forms.TextBox();
            this.lblIDJogador = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.btnPartidaIniciar = new System.Windows.Forms.Button();
            this.txtPartidaID = new System.Windows.Forms.TextBox();
            this.txtPartidaSenha = new System.Windows.Forms.TextBox();
            this.lblPartidaID = new System.Windows.Forms.Label();
            this.lblPartidaSenha = new System.Windows.Forms.Label();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.txtJogadorNome = new System.Windows.Forms.TextBox();
            this.lblJogadorNome = new System.Windows.Forms.Label();
            this.lblPartidaNome = new System.Windows.Forms.Label();
            this.txtPartidaNome = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.btnPartidaListar = new System.Windows.Forms.Button();
            this.lsbPartidas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCartasListar = new System.Windows.Forms.Button();
            this.btnJogadoresListar = new System.Windows.Forms.Button();
            this.btnAndar = new System.Windows.Forms.Button();
            this.cboCartas = new System.Windows.Forms.ComboBox();
            this.lblCartas = new System.Windows.Forms.Label();
            this.lblPosicao = new System.Windows.Forms.Label();
            this.txtPirataPosicao = new System.Windows.Forms.TextBox();
            this.lsbJogadores = new System.Windows.Forms.ListBox();
            this.lsbCartas = new System.Windows.Forms.ListBox();
            this.lsbJogadas = new System.Windows.Forms.ListBox();
            this.btnMostrarTabuleiro = new System.Windows.Forms.Button();
            this.lsbTabuleiro = new System.Windows.Forms.ListBox();
            this.btnPular = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnVerificarVez = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtJogadorID
            // 
            this.txtJogadorID.Location = new System.Drawing.Point(12, 316);
            this.txtJogadorID.Name = "txtJogadorID";
            this.txtJogadorID.Size = new System.Drawing.Size(114, 20);
            this.txtJogadorID.TabIndex = 0;
            // 
            // txtJogadorSenha
            // 
            this.txtJogadorSenha.Location = new System.Drawing.Point(12, 368);
            this.txtJogadorSenha.Name = "txtJogadorSenha";
            this.txtJogadorSenha.Size = new System.Drawing.Size(114, 20);
            this.txtJogadorSenha.TabIndex = 1;
            // 
            // lblIDJogador
            // 
            this.lblIDJogador.AutoSize = true;
            this.lblIDJogador.Location = new System.Drawing.Point(9, 300);
            this.lblIDJogador.Name = "lblIDJogador";
            this.lblIDJogador.Size = new System.Drawing.Size(71, 13);
            this.lblIDJogador.TabIndex = 2;
            this.lblIDJogador.Text = "ID do jogador";
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Location = new System.Drawing.Point(12, 352);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(91, 13);
            this.lblSenhaJogador.TabIndex = 3;
            this.lblSenhaJogador.Text = "Senha do jogador";
            // 
            // btnPartidaIniciar
            // 
            this.btnPartidaIniciar.Location = new System.Drawing.Point(271, 356);
            this.btnPartidaIniciar.Name = "btnPartidaIniciar";
            this.btnPartidaIniciar.Size = new System.Drawing.Size(120, 32);
            this.btnPartidaIniciar.TabIndex = 4;
            this.btnPartidaIniciar.Text = "Iniciar Partida";
            this.btnPartidaIniciar.UseVisualStyleBackColor = true;
            this.btnPartidaIniciar.Click += new System.EventHandler(this.btnPartidaIniciar_Click);
            // 
            // txtPartidaID
            // 
            this.txtPartidaID.Location = new System.Drawing.Point(141, 316);
            this.txtPartidaID.Name = "txtPartidaID";
            this.txtPartidaID.Size = new System.Drawing.Size(114, 20);
            this.txtPartidaID.TabIndex = 5;
            // 
            // txtPartidaSenha
            // 
            this.txtPartidaSenha.Location = new System.Drawing.Point(141, 368);
            this.txtPartidaSenha.Name = "txtPartidaSenha";
            this.txtPartidaSenha.Size = new System.Drawing.Size(114, 20);
            this.txtPartidaSenha.TabIndex = 6;
            // 
            // lblPartidaID
            // 
            this.lblPartidaID.AutoSize = true;
            this.lblPartidaID.Location = new System.Drawing.Point(138, 300);
            this.lblPartidaID.Name = "lblPartidaID";
            this.lblPartidaID.Size = new System.Drawing.Size(68, 13);
            this.lblPartidaID.TabIndex = 7;
            this.lblPartidaID.Text = "ID da partida";
            // 
            // lblPartidaSenha
            // 
            this.lblPartidaSenha.AutoSize = true;
            this.lblPartidaSenha.Location = new System.Drawing.Point(138, 352);
            this.lblPartidaSenha.Name = "lblPartidaSenha";
            this.lblPartidaSenha.Size = new System.Drawing.Size(88, 13);
            this.lblPartidaSenha.TabIndex = 8;
            this.lblPartidaSenha.Text = "Senha da partida";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(271, 252);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(120, 32);
            this.btnEntrarPartida.TabIndex = 9;
            this.btnEntrarPartida.Text = "Entrar Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnPartidaEntrar_Click);
            // 
            // txtJogadorNome
            // 
            this.txtJogadorNome.Location = new System.Drawing.Point(12, 264);
            this.txtJogadorNome.Name = "txtJogadorNome";
            this.txtJogadorNome.Size = new System.Drawing.Size(114, 20);
            this.txtJogadorNome.TabIndex = 10;
            // 
            // lblJogadorNome
            // 
            this.lblJogadorNome.AutoSize = true;
            this.lblJogadorNome.Location = new System.Drawing.Point(9, 248);
            this.lblJogadorNome.Name = "lblJogadorNome";
            this.lblJogadorNome.Size = new System.Drawing.Size(91, 13);
            this.lblJogadorNome.TabIndex = 11;
            this.lblJogadorNome.Text = "Nome do Jogador";
            // 
            // lblPartidaNome
            // 
            this.lblPartidaNome.AutoSize = true;
            this.lblPartidaNome.Location = new System.Drawing.Point(138, 248);
            this.lblPartidaNome.Name = "lblPartidaNome";
            this.lblPartidaNome.Size = new System.Drawing.Size(85, 13);
            this.lblPartidaNome.TabIndex = 13;
            this.lblPartidaNome.Text = "Nome da partida";
            // 
            // txtPartidaNome
            // 
            this.txtPartidaNome.Location = new System.Drawing.Point(141, 264);
            this.txtPartidaNome.Name = "txtPartidaNome";
            this.txtPartidaNome.Size = new System.Drawing.Size(114, 20);
            this.txtPartidaNome.TabIndex = 12;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(271, 304);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(120, 32);
            this.btnCriarPartida.TabIndex = 14;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnPartidaCriar_Click);
            // 
            // btnPartidaListar
            // 
            this.btnPartidaListar.Location = new System.Drawing.Point(12, 5);
            this.btnPartidaListar.Name = "btnPartidaListar";
            this.btnPartidaListar.Size = new System.Drawing.Size(243, 32);
            this.btnPartidaListar.TabIndex = 15;
            this.btnPartidaListar.Text = "Listar Partidas";
            this.btnPartidaListar.UseVisualStyleBackColor = true;
            this.btnPartidaListar.Click += new System.EventHandler(this.btnPartidaListar_Click);
            // 
            // lsbPartidas
            // 
            this.lsbPartidas.FormattingEnabled = true;
            this.lsbPartidas.Location = new System.Drawing.Point(12, 43);
            this.lsbPartidas.Name = "lsbPartidas";
            this.lsbPartidas.Size = new System.Drawing.Size(243, 186);
            this.lsbPartidas.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // btnCartasListar
            // 
            this.btnCartasListar.Location = new System.Drawing.Point(730, 21);
            this.btnCartasListar.Name = "btnCartasListar";
            this.btnCartasListar.Size = new System.Drawing.Size(98, 32);
            this.btnCartasListar.TabIndex = 18;
            this.btnCartasListar.Text = "Listar Cartas";
            this.btnCartasListar.UseVisualStyleBackColor = true;
            this.btnCartasListar.Click += new System.EventHandler(this.btnCartasListar_Click);
            // 
            // btnJogadoresListar
            // 
            this.btnJogadoresListar.Location = new System.Drawing.Point(271, 5);
            this.btnJogadoresListar.Name = "btnJogadoresListar";
            this.btnJogadoresListar.Size = new System.Drawing.Size(174, 32);
            this.btnJogadoresListar.TabIndex = 19;
            this.btnJogadoresListar.Text = "Listar Jogadores";
            this.btnJogadoresListar.UseVisualStyleBackColor = true;
            this.btnJogadoresListar.Click += new System.EventHandler(this.btnJogadoresListar_Click);
            // 
            // btnAndar
            // 
            this.btnAndar.Location = new System.Drawing.Point(465, 49);
            this.btnAndar.Name = "btnAndar";
            this.btnAndar.Size = new System.Drawing.Size(42, 32);
            this.btnAndar.TabIndex = 20;
            this.btnAndar.Text = "Jogar";
            this.btnAndar.UseVisualStyleBackColor = true;
            this.btnAndar.Click += new System.EventHandler(this.btnAndar_Click);
            // 
            // cboCartas
            // 
            this.cboCartas.FormattingEnabled = true;
            this.cboCartas.Items.AddRange(new object[] {
            "",
            "Chave",
            "Esqueleto",
            "Faca",
            "Garrafa",
            "Pistola",
            "Tricórnio"});
            this.cboCartas.Location = new System.Drawing.Point(583, 21);
            this.cboCartas.Name = "cboCartas";
            this.cboCartas.Size = new System.Drawing.Size(121, 21);
            this.cboCartas.TabIndex = 21;
            // 
            // lblCartas
            // 
            this.lblCartas.AutoSize = true;
            this.lblCartas.Location = new System.Drawing.Point(580, 5);
            this.lblCartas.Name = "lblCartas";
            this.lblCartas.Size = new System.Drawing.Size(32, 13);
            this.lblCartas.TabIndex = 22;
            this.lblCartas.Text = "Carta";
            // 
            // lblPosicao
            // 
            this.lblPosicao.AutoSize = true;
            this.lblPosicao.Location = new System.Drawing.Point(462, 6);
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(45, 13);
            this.lblPosicao.TabIndex = 23;
            this.lblPosicao.Text = "Posição";
            // 
            // txtPirataPosicao
            // 
            this.txtPirataPosicao.Location = new System.Drawing.Point(465, 22);
            this.txtPirataPosicao.Name = "txtPirataPosicao";
            this.txtPirataPosicao.Size = new System.Drawing.Size(100, 20);
            this.txtPirataPosicao.TabIndex = 24;
            // 
            // lsbJogadores
            // 
            this.lsbJogadores.FormattingEnabled = true;
            this.lsbJogadores.Location = new System.Drawing.Point(271, 43);
            this.lsbJogadores.Name = "lsbJogadores";
            this.lsbJogadores.Size = new System.Drawing.Size(177, 186);
            this.lsbJogadores.TabIndex = 25;
            // 
            // lsbCartas
            // 
            this.lsbCartas.FormattingEnabled = true;
            this.lsbCartas.Location = new System.Drawing.Point(730, 59);
            this.lsbCartas.Name = "lsbCartas";
            this.lsbCartas.Size = new System.Drawing.Size(98, 121);
            this.lsbCartas.TabIndex = 26;
            // 
            // lsbJogadas
            // 
            this.lsbJogadas.FormattingEnabled = true;
            this.lsbJogadas.Location = new System.Drawing.Point(465, 87);
            this.lsbJogadas.Name = "lsbJogadas";
            this.lsbJogadas.Size = new System.Drawing.Size(239, 121);
            this.lsbJogadas.TabIndex = 27;
            // 
            // btnMostrarTabuleiro
            // 
            this.btnMostrarTabuleiro.AllowDrop = true;
            this.btnMostrarTabuleiro.Location = new System.Drawing.Point(862, 22);
            this.btnMostrarTabuleiro.Name = "btnMostrarTabuleiro";
            this.btnMostrarTabuleiro.Size = new System.Drawing.Size(98, 32);
            this.btnMostrarTabuleiro.TabIndex = 28;
            this.btnMostrarTabuleiro.Text = "Mostrar Tabuleiro";
            this.btnMostrarTabuleiro.UseVisualStyleBackColor = true;
            this.btnMostrarTabuleiro.Click += new System.EventHandler(this.btnMostrarTabuleiro_Click);
            // 
            // lsbTabuleiro
            // 
            this.lsbTabuleiro.FormattingEnabled = true;
            this.lsbTabuleiro.Location = new System.Drawing.Point(980, 21);
            this.lsbTabuleiro.Name = "lsbTabuleiro";
            this.lsbTabuleiro.Size = new System.Drawing.Size(209, 368);
            this.lsbTabuleiro.TabIndex = 29;
            // 
            // btnPular
            // 
            this.btnPular.Location = new System.Drawing.Point(513, 48);
            this.btnPular.Name = "btnPular";
            this.btnPular.Size = new System.Drawing.Size(92, 32);
            this.btnPular.TabIndex = 32;
            this.btnPular.Text = "Pular Jogada";
            this.btnPular.UseVisualStyleBackColor = true;
            this.btnPular.Click += new System.EventHandler(this.btnPular_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(611, 48);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(93, 32);
            this.btnVoltar.TabIndex = 33;
            this.btnVoltar.Text = "Mover para trás";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnVerificarVez
            // 
            this.btnVerificarVez.Location = new System.Drawing.Point(513, 214);
            this.btnVerificarVez.Name = "btnVerificarVez";
            this.btnVerificarVez.Size = new System.Drawing.Size(92, 32);
            this.btnVerificarVez.TabIndex = 34;
            this.btnVerificarVez.Text = "Verificar Vez";
            this.btnVerificarVez.UseVisualStyleBackColor = true;
            this.btnVerificarVez.Click += new System.EventHandler(this.btnVerificarVez_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 426);
            this.Controls.Add(this.btnVerificarVez);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPular);
            this.Controls.Add(this.lsbTabuleiro);
            this.Controls.Add(this.btnMostrarTabuleiro);
            this.Controls.Add(this.lsbJogadas);
            this.Controls.Add(this.lsbCartas);
            this.Controls.Add(this.lsbJogadores);
            this.Controls.Add(this.txtPirataPosicao);
            this.Controls.Add(this.lblPosicao);
            this.Controls.Add(this.lblCartas);
            this.Controls.Add(this.cboCartas);
            this.Controls.Add(this.btnAndar);
            this.Controls.Add(this.btnJogadoresListar);
            this.Controls.Add(this.btnCartasListar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbPartidas);
            this.Controls.Add(this.btnPartidaListar);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.lblPartidaNome);
            this.Controls.Add(this.txtPartidaNome);
            this.Controls.Add(this.lblJogadorNome);
            this.Controls.Add(this.txtJogadorNome);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.lblPartidaSenha);
            this.Controls.Add(this.lblPartidaID);
            this.Controls.Add(this.txtPartidaSenha);
            this.Controls.Add(this.txtPartidaID);
            this.Controls.Add(this.btnPartidaIniciar);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.lblIDJogador);
            this.Controls.Add(this.txtJogadorSenha);
            this.Controls.Add(this.txtJogadorID);
            this.MinimumSize = new System.Drawing.Size(543, 465);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Cartagena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJogadorID;
        private System.Windows.Forms.TextBox txtJogadorSenha;
        private System.Windows.Forms.Label lblIDJogador;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.Button btnPartidaIniciar;
        private System.Windows.Forms.TextBox txtPartidaID;
        private System.Windows.Forms.TextBox txtPartidaSenha;
        private System.Windows.Forms.Label lblPartidaID;
        private System.Windows.Forms.Label lblPartidaSenha;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.TextBox txtJogadorNome;
        private System.Windows.Forms.Label lblJogadorNome;
        private System.Windows.Forms.Label lblPartidaNome;
        private System.Windows.Forms.TextBox txtPartidaNome;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Button btnPartidaListar;
        private System.Windows.Forms.ListBox lsbPartidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCartasListar;
        private System.Windows.Forms.Button btnJogadoresListar;
        private System.Windows.Forms.Button btnAndar;
        private System.Windows.Forms.ComboBox cboCartas;
        private System.Windows.Forms.Label lblCartas;
        private System.Windows.Forms.Label lblPosicao;
        private System.Windows.Forms.TextBox txtPirataPosicao;
        private System.Windows.Forms.ListBox lsbJogadores;
        private System.Windows.Forms.ListBox lsbCartas;
        private System.Windows.Forms.ListBox lsbJogadas;
        private System.Windows.Forms.Button btnMostrarTabuleiro;
        private System.Windows.Forms.ListBox lsbTabuleiro;
        private System.Windows.Forms.Button btnPular;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnVerificarVez;
    }
}

