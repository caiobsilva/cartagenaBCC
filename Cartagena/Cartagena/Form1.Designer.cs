namespace Cartagena
{
    partial class Cartagena
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cartagena));
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
            this.lsbLog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJogadoresListar = new System.Windows.Forms.Button();
            this.btnAndar = new System.Windows.Forms.Button();
            this.cboCartas = new System.Windows.Forms.ComboBox();
            this.lblCartas = new System.Windows.Forms.Label();
            this.lblPosicao = new System.Windows.Forms.Label();
            this.txtPirataPosicao = new System.Windows.Forms.TextBox();
            this.btnPular = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnIniciarKuriso = new System.Windows.Forms.Button();
            this.lblVersao = new System.Windows.Forms.Label();
            this.timerVerificarVez = new System.Windows.Forms.Timer(this.components);
            this.timerAtulizaInterface = new System.Windows.Forms.Timer(this.components);
            this.pcbPrisao = new System.Windows.Forms.PictureBox();
            this.pcbBarco = new System.Windows.Forms.PictureBox();
            this.pcbTabuleiro = new System.Windows.Forms.PictureBox();
            this.pcbChave = new System.Windows.Forms.PictureBox();
            this.pcbEsq = new System.Windows.Forms.PictureBox();
            this.pcbFaca = new System.Windows.Forms.PictureBox();
            this.pcbGar = new System.Windows.Forms.PictureBox();
            this.pcbPist = new System.Windows.Forms.PictureBox();
            this.pcbTric = new System.Windows.Forms.PictureBox();
            this.lblChave = new System.Windows.Forms.Label();
            this.lblEsq = new System.Windows.Forms.Label();
            this.lblFaca = new System.Windows.Forms.Label();
            this.lblGar = new System.Windows.Forms.Label();
            this.lblPist = new System.Windows.Forms.Label();
            this.lblTric = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPrisao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBarco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTabuleiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbChave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEsq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTric)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJogadorID
            // 
            this.txtJogadorID.Location = new System.Drawing.Point(14, 308);
            this.txtJogadorID.Name = "txtJogadorID";
            this.txtJogadorID.Size = new System.Drawing.Size(134, 20);
            this.txtJogadorID.TabIndex = 0;
            // 
            // txtJogadorSenha
            // 
            this.txtJogadorSenha.Location = new System.Drawing.Point(14, 356);
            this.txtJogadorSenha.Name = "txtJogadorSenha";
            this.txtJogadorSenha.Size = new System.Drawing.Size(134, 20);
            this.txtJogadorSenha.TabIndex = 1;
            // 
            // lblIDJogador
            // 
            this.lblIDJogador.AutoSize = true;
            this.lblIDJogador.Location = new System.Drawing.Point(11, 292);
            this.lblIDJogador.Name = "lblIDJogador";
            this.lblIDJogador.Size = new System.Drawing.Size(71, 13);
            this.lblIDJogador.TabIndex = 2;
            this.lblIDJogador.Text = "ID do jogador";
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Location = new System.Drawing.Point(14, 340);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(91, 13);
            this.lblSenhaJogador.TabIndex = 3;
            this.lblSenhaJogador.Text = "Senha do jogador";
            // 
            // btnPartidaIniciar
            // 
            this.btnPartidaIniciar.Location = new System.Drawing.Point(227, 382);
            this.btnPartidaIniciar.Name = "btnPartidaIniciar";
            this.btnPartidaIniciar.Size = new System.Drawing.Size(79, 32);
            this.btnPartidaIniciar.TabIndex = 4;
            this.btnPartidaIniciar.Text = "Iniciar Partida";
            this.btnPartidaIniciar.UseVisualStyleBackColor = true;
            this.btnPartidaIniciar.Click += new System.EventHandler(this.btnPartidaIniciar_Click);
            // 
            // txtPartidaID
            // 
            this.txtPartidaID.Location = new System.Drawing.Point(172, 308);
            this.txtPartidaID.Name = "txtPartidaID";
            this.txtPartidaID.Size = new System.Drawing.Size(134, 20);
            this.txtPartidaID.TabIndex = 5;
            // 
            // txtPartidaSenha
            // 
            this.txtPartidaSenha.Location = new System.Drawing.Point(172, 356);
            this.txtPartidaSenha.Name = "txtPartidaSenha";
            this.txtPartidaSenha.Size = new System.Drawing.Size(134, 20);
            this.txtPartidaSenha.TabIndex = 6;
            // 
            // lblPartidaID
            // 
            this.lblPartidaID.AutoSize = true;
            this.lblPartidaID.Location = new System.Drawing.Point(169, 292);
            this.lblPartidaID.Name = "lblPartidaID";
            this.lblPartidaID.Size = new System.Drawing.Size(68, 13);
            this.lblPartidaID.TabIndex = 7;
            this.lblPartidaID.Text = "ID da partida";
            // 
            // lblPartidaSenha
            // 
            this.lblPartidaSenha.AutoSize = true;
            this.lblPartidaSenha.Location = new System.Drawing.Point(169, 340);
            this.lblPartidaSenha.Name = "lblPartidaSenha";
            this.lblPartidaSenha.Size = new System.Drawing.Size(88, 13);
            this.lblPartidaSenha.TabIndex = 8;
            this.lblPartidaSenha.Text = "Senha da partida";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(99, 382);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(122, 32);
            this.btnEntrarPartida.TabIndex = 9;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnPartidaEntrar_Click);
            // 
            // txtJogadorNome
            // 
            this.txtJogadorNome.Location = new System.Drawing.Point(14, 265);
            this.txtJogadorNome.Name = "txtJogadorNome";
            this.txtJogadorNome.Size = new System.Drawing.Size(134, 20);
            this.txtJogadorNome.TabIndex = 10;
            // 
            // lblJogadorNome
            // 
            this.lblJogadorNome.AutoSize = true;
            this.lblJogadorNome.Location = new System.Drawing.Point(11, 249);
            this.lblJogadorNome.Name = "lblJogadorNome";
            this.lblJogadorNome.Size = new System.Drawing.Size(91, 13);
            this.lblJogadorNome.TabIndex = 11;
            this.lblJogadorNome.Text = "Nome do Jogador";
            // 
            // lblPartidaNome
            // 
            this.lblPartidaNome.AutoSize = true;
            this.lblPartidaNome.Location = new System.Drawing.Point(169, 249);
            this.lblPartidaNome.Name = "lblPartidaNome";
            this.lblPartidaNome.Size = new System.Drawing.Size(85, 13);
            this.lblPartidaNome.TabIndex = 13;
            this.lblPartidaNome.Text = "Nome da partida";
            // 
            // txtPartidaNome
            // 
            this.txtPartidaNome.Location = new System.Drawing.Point(172, 265);
            this.txtPartidaNome.Name = "txtPartidaNome";
            this.txtPartidaNome.Size = new System.Drawing.Size(134, 20);
            this.txtPartidaNome.TabIndex = 12;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(14, 382);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(79, 32);
            this.btnCriarPartida.TabIndex = 14;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnPartidaCriar_Click);
            // 
            // btnPartidaListar
            // 
            this.btnPartidaListar.Location = new System.Drawing.Point(12, 204);
            this.btnPartidaListar.Name = "btnPartidaListar";
            this.btnPartidaListar.Size = new System.Drawing.Size(181, 32);
            this.btnPartidaListar.TabIndex = 15;
            this.btnPartidaListar.Text = "Listar Partidas";
            this.btnPartidaListar.UseVisualStyleBackColor = true;
            this.btnPartidaListar.Click += new System.EventHandler(this.btnPartidaListar_Click);
            // 
            // lsbLog
            // 
            this.lsbLog.FormattingEnabled = true;
            this.lsbLog.Location = new System.Drawing.Point(12, 12);
            this.lsbLog.Name = "lsbLog";
            this.lsbLog.Size = new System.Drawing.Size(294, 186);
            this.lsbLog.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(775, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // btnJogadoresListar
            // 
            this.btnJogadoresListar.Location = new System.Drawing.Point(199, 204);
            this.btnJogadoresListar.Name = "btnJogadoresListar";
            this.btnJogadoresListar.Size = new System.Drawing.Size(107, 32);
            this.btnJogadoresListar.TabIndex = 19;
            this.btnJogadoresListar.Text = "Listar Jogadores";
            this.btnJogadoresListar.UseVisualStyleBackColor = true;
            this.btnJogadoresListar.Click += new System.EventHandler(this.btnJogadoresListar_Click);
            // 
            // btnAndar
            // 
            this.btnAndar.Location = new System.Drawing.Point(172, 463);
            this.btnAndar.Name = "btnAndar";
            this.btnAndar.Size = new System.Drawing.Size(54, 39);
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
            this.cboCartas.Location = new System.Drawing.Point(14, 518);
            this.cboCartas.Name = "cboCartas";
            this.cboCartas.Size = new System.Drawing.Size(134, 21);
            this.cboCartas.TabIndex = 21;
            // 
            // lblCartas
            // 
            this.lblCartas.AutoSize = true;
            this.lblCartas.Location = new System.Drawing.Point(11, 502);
            this.lblCartas.Name = "lblCartas";
            this.lblCartas.Size = new System.Drawing.Size(32, 13);
            this.lblCartas.TabIndex = 22;
            this.lblCartas.Text = "Carta";
            // 
            // lblPosicao
            // 
            this.lblPosicao.AutoSize = true;
            this.lblPosicao.Location = new System.Drawing.Point(11, 463);
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(45, 13);
            this.lblPosicao.TabIndex = 23;
            this.lblPosicao.Text = "Posição";
            // 
            // txtPirataPosicao
            // 
            this.txtPirataPosicao.Location = new System.Drawing.Point(14, 479);
            this.txtPirataPosicao.Name = "txtPirataPosicao";
            this.txtPirataPosicao.Size = new System.Drawing.Size(134, 20);
            this.txtPirataPosicao.TabIndex = 24;
            // 
            // btnPular
            // 
            this.btnPular.Location = new System.Drawing.Point(172, 508);
            this.btnPular.Name = "btnPular";
            this.btnPular.Size = new System.Drawing.Size(134, 31);
            this.btnPular.TabIndex = 32;
            this.btnPular.Text = "Pular Jogada";
            this.btnPular.UseVisualStyleBackColor = true;
            this.btnPular.Click += new System.EventHandler(this.btnPular_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(232, 463);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(74, 39);
            this.btnVoltar.TabIndex = 33;
            this.btnVoltar.Text = "Mover para trás";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnIniciarKuriso
            // 
            this.btnIniciarKuriso.Location = new System.Drawing.Point(14, 420);
            this.btnIniciarKuriso.Name = "btnIniciarKuriso";
            this.btnIniciarKuriso.Size = new System.Drawing.Size(292, 30);
            this.btnIniciarKuriso.TabIndex = 36;
            this.btnIniciarKuriso.Text = "Iniciar Kurisu";
            this.btnIniciarKuriso.UseVisualStyleBackColor = true;
            this.btnIniciarKuriso.Click += new System.EventHandler(this.btnIniciarKuriso_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(790, 526);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(46, 13);
            this.lblVersao.TabIndex = 37;
            this.lblVersao.Text = "Versão: ";
            // 
            // timerVerificarVez
            // 
            this.timerVerificarVez.Interval = 1500;
            this.timerVerificarVez.Tick += new System.EventHandler(this.timerVerificarVez_Tick);
            // 
            // timerAtulizaInterface
            // 
            this.timerAtulizaInterface.Interval = 2000;
            this.timerAtulizaInterface.Tick += new System.EventHandler(this.timerAtulizaInterface_Tick);
            // 
            // pcbPrisao
            // 
            this.pcbPrisao.Image = ((System.Drawing.Image)(resources.GetObject("pcbPrisao.Image")));
            this.pcbPrisao.Location = new System.Drawing.Point(340, 12);
            this.pcbPrisao.Name = "pcbPrisao";
            this.pcbPrisao.Size = new System.Drawing.Size(370, 80);
            this.pcbPrisao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPrisao.TabIndex = 38;
            this.pcbPrisao.TabStop = false;
            // 
            // pcbBarco
            // 
            this.pcbBarco.Image = ((System.Drawing.Image)(resources.GetObject("pcbBarco.Image")));
            this.pcbBarco.Location = new System.Drawing.Point(340, 442);
            this.pcbBarco.Name = "pcbBarco";
            this.pcbBarco.Size = new System.Drawing.Size(370, 97);
            this.pcbBarco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBarco.TabIndex = 39;
            this.pcbBarco.TabStop = false;
            // 
            // pcbTabuleiro
            // 
            this.pcbTabuleiro.BackColor = System.Drawing.Color.Transparent;
            this.pcbTabuleiro.Image = ((System.Drawing.Image)(resources.GetObject("pcbTabuleiro.Image")));
            this.pcbTabuleiro.Location = new System.Drawing.Point(340, 92);
            this.pcbTabuleiro.Name = "pcbTabuleiro";
            this.pcbTabuleiro.Size = new System.Drawing.Size(370, 350);
            this.pcbTabuleiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbTabuleiro.TabIndex = 40;
            this.pcbTabuleiro.TabStop = false;
            // 
            // pcbChave
            // 
            this.pcbChave.Image = ((System.Drawing.Image)(resources.GetObject("pcbChave.Image")));
            this.pcbChave.Location = new System.Drawing.Point(739, 92);
            this.pcbChave.Name = "pcbChave";
            this.pcbChave.Size = new System.Drawing.Size(50, 50);
            this.pcbChave.TabIndex = 41;
            this.pcbChave.TabStop = false;
            // 
            // pcbEsq
            // 
            this.pcbEsq.Image = ((System.Drawing.Image)(resources.GetObject("pcbEsq.Image")));
            this.pcbEsq.Location = new System.Drawing.Point(739, 152);
            this.pcbEsq.Name = "pcbEsq";
            this.pcbEsq.Size = new System.Drawing.Size(50, 50);
            this.pcbEsq.TabIndex = 42;
            this.pcbEsq.TabStop = false;
            // 
            // pcbFaca
            // 
            this.pcbFaca.Image = ((System.Drawing.Image)(resources.GetObject("pcbFaca.Image")));
            this.pcbFaca.Location = new System.Drawing.Point(739, 212);
            this.pcbFaca.Name = "pcbFaca";
            this.pcbFaca.Size = new System.Drawing.Size(50, 50);
            this.pcbFaca.TabIndex = 43;
            this.pcbFaca.TabStop = false;
            // 
            // pcbGar
            // 
            this.pcbGar.Image = ((System.Drawing.Image)(resources.GetObject("pcbGar.Image")));
            this.pcbGar.Location = new System.Drawing.Point(739, 272);
            this.pcbGar.Name = "pcbGar";
            this.pcbGar.Size = new System.Drawing.Size(50, 50);
            this.pcbGar.TabIndex = 44;
            this.pcbGar.TabStop = false;
            // 
            // pcbPist
            // 
            this.pcbPist.Image = ((System.Drawing.Image)(resources.GetObject("pcbPist.Image")));
            this.pcbPist.Location = new System.Drawing.Point(739, 332);
            this.pcbPist.Name = "pcbPist";
            this.pcbPist.Size = new System.Drawing.Size(50, 50);
            this.pcbPist.TabIndex = 45;
            this.pcbPist.TabStop = false;
            // 
            // pcbTric
            // 
            this.pcbTric.Image = ((System.Drawing.Image)(resources.GetObject("pcbTric.Image")));
            this.pcbTric.Location = new System.Drawing.Point(739, 392);
            this.pcbTric.Name = "pcbTric";
            this.pcbTric.Size = new System.Drawing.Size(50, 50);
            this.pcbTric.TabIndex = 46;
            this.pcbTric.TabStop = false;
            // 
            // lblChave
            // 
            this.lblChave.AutoSize = true;
            this.lblChave.Location = new System.Drawing.Point(795, 111);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(48, 13);
            this.lblChave.TabIndex = 47;
            this.lblChave.Text = "lblChave";
            // 
            // lblEsq
            // 
            this.lblEsq.AutoSize = true;
            this.lblEsq.Location = new System.Drawing.Point(795, 170);
            this.lblEsq.Name = "lblEsq";
            this.lblEsq.Size = new System.Drawing.Size(35, 13);
            this.lblEsq.TabIndex = 48;
            this.lblEsq.Text = "lblEsq";
            // 
            // lblFaca
            // 
            this.lblFaca.AutoSize = true;
            this.lblFaca.Location = new System.Drawing.Point(795, 230);
            this.lblFaca.Name = "lblFaca";
            this.lblFaca.Size = new System.Drawing.Size(41, 13);
            this.lblFaca.TabIndex = 49;
            this.lblFaca.Text = "lblFaca";
            // 
            // lblGar
            // 
            this.lblGar.AutoSize = true;
            this.lblGar.Location = new System.Drawing.Point(795, 292);
            this.lblGar.Name = "lblGar";
            this.lblGar.Size = new System.Drawing.Size(34, 13);
            this.lblGar.TabIndex = 50;
            this.lblGar.Text = "lblGar";
            // 
            // lblPist
            // 
            this.lblPist.AutoSize = true;
            this.lblPist.Location = new System.Drawing.Point(795, 349);
            this.lblPist.Name = "lblPist";
            this.lblPist.Size = new System.Drawing.Size(34, 13);
            this.lblPist.TabIndex = 51;
            this.lblPist.Text = "lblPist";
            // 
            // lblTric
            // 
            this.lblTric.AutoSize = true;
            this.lblTric.Location = new System.Drawing.Point(795, 411);
            this.lblTric.Name = "lblTric";
            this.lblTric.Size = new System.Drawing.Size(35, 13);
            this.lblTric.TabIndex = 52;
            this.lblTric.Text = "lblTric";
            // 
            // Cartagena
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(874, 551);
            this.Controls.Add(this.lblTric);
            this.Controls.Add(this.lblPist);
            this.Controls.Add(this.lblGar);
            this.Controls.Add(this.lblFaca);
            this.Controls.Add(this.lblEsq);
            this.Controls.Add(this.lblChave);
            this.Controls.Add(this.pcbTric);
            this.Controls.Add(this.pcbPist);
            this.Controls.Add(this.pcbGar);
            this.Controls.Add(this.pcbFaca);
            this.Controls.Add(this.pcbEsq);
            this.Controls.Add(this.pcbChave);
            this.Controls.Add(this.pcbTabuleiro);
            this.Controls.Add(this.pcbBarco);
            this.Controls.Add(this.pcbPrisao);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnIniciarKuriso);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPular);
            this.Controls.Add(this.txtPirataPosicao);
            this.Controls.Add(this.lblPosicao);
            this.Controls.Add(this.lblCartas);
            this.Controls.Add(this.cboCartas);
            this.Controls.Add(this.btnAndar);
            this.Controls.Add(this.btnJogadoresListar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbLog);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(10000, 8000);
            this.MinimumSize = new System.Drawing.Size(1, 1);
            this.Name = "Cartagena";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Kurisu-Varsóvia";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            ((System.ComponentModel.ISupportInitialize)(this.pcbPrisao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBarco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTabuleiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbChave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEsq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTric)).EndInit();
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
        private System.Windows.Forms.ListBox lsbLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJogadoresListar;
        private System.Windows.Forms.Button btnAndar;
        private System.Windows.Forms.ComboBox cboCartas;
        private System.Windows.Forms.Label lblCartas;
        private System.Windows.Forms.Label lblPosicao;
        private System.Windows.Forms.TextBox txtPirataPosicao;
        private System.Windows.Forms.Button btnPular;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnIniciarKuriso;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Timer timerVerificarVez;
        private System.Windows.Forms.Timer timerAtulizaInterface;
        private System.Windows.Forms.PictureBox pcbPrisao;
        private System.Windows.Forms.PictureBox pcbBarco;
        private System.Windows.Forms.PictureBox pcbTabuleiro;
        private System.Windows.Forms.PictureBox pcbChave;
        private System.Windows.Forms.PictureBox pcbEsq;
        private System.Windows.Forms.PictureBox pcbFaca;
        private System.Windows.Forms.PictureBox pcbGar;
        private System.Windows.Forms.PictureBox pcbPist;
        private System.Windows.Forms.PictureBox pcbTric;
        private System.Windows.Forms.Label lblChave;
        private System.Windows.Forms.Label lblEsq;
        private System.Windows.Forms.Label lblFaca;
        private System.Windows.Forms.Label lblGar;
        private System.Windows.Forms.Label lblPist;
        private System.Windows.Forms.Label lblTric;
    }
}

