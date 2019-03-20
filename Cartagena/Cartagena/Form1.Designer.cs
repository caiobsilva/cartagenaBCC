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
            this.txtPartidaId = new System.Windows.Forms.TextBox();
            this.txtPartidaSenha = new System.Windows.Forms.TextBox();
            this.lblPartidaID = new System.Windows.Forms.Label();
            this.lblPartidaSenha = new System.Windows.Forms.Label();
            this.btnPartidaEntrar = new System.Windows.Forms.Button();
            this.txtJogadorNome = new System.Windows.Forms.TextBox();
            this.lblJogadorNome = new System.Windows.Forms.Label();
            this.lblPartidaNome = new System.Windows.Forms.Label();
            this.txtPartidaNome = new System.Windows.Forms.TextBox();
            this.btnPartidaCriar = new System.Windows.Forms.Button();
            this.btnPartidaListar = new System.Windows.Forms.Button();
            this.lsbPartidas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtJogadorID
            // 
            this.txtJogadorID.Location = new System.Drawing.Point(12, 294);
            this.txtJogadorID.Name = "txtJogadorID";
            this.txtJogadorID.Size = new System.Drawing.Size(114, 20);
            this.txtJogadorID.TabIndex = 0;
            // 
            // txtJogadorSenha
            // 
            this.txtJogadorSenha.Location = new System.Drawing.Point(12, 346);
            this.txtJogadorSenha.Name = "txtJogadorSenha";
            this.txtJogadorSenha.Size = new System.Drawing.Size(114, 20);
            this.txtJogadorSenha.TabIndex = 1;
            // 
            // lblIDJogador
            // 
            this.lblIDJogador.AutoSize = true;
            this.lblIDJogador.Location = new System.Drawing.Point(9, 278);
            this.lblIDJogador.Name = "lblIDJogador";
            this.lblIDJogador.Size = new System.Drawing.Size(71, 13);
            this.lblIDJogador.TabIndex = 2;
            this.lblIDJogador.Text = "ID do jogador";
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Location = new System.Drawing.Point(12, 330);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(91, 13);
            this.lblSenhaJogador.TabIndex = 3;
            this.lblSenhaJogador.Text = "Senha do jogador";
            // 
            // btnPartidaIniciar
            // 
            this.btnPartidaIniciar.Location = new System.Drawing.Point(17, 372);
            this.btnPartidaIniciar.Name = "btnPartidaIniciar";
            this.btnPartidaIniciar.Size = new System.Drawing.Size(86, 32);
            this.btnPartidaIniciar.TabIndex = 4;
            this.btnPartidaIniciar.Text = "Iniciar Partida";
            this.btnPartidaIniciar.UseVisualStyleBackColor = true;
            this.btnPartidaIniciar.Click += new System.EventHandler(this.btnPartidaIniciar_Click);
            // 
            // txtPartidaId
            // 
            this.txtPartidaId.Location = new System.Drawing.Point(311, 294);
            this.txtPartidaId.Name = "txtPartidaId";
            this.txtPartidaId.Size = new System.Drawing.Size(114, 20);
            this.txtPartidaId.TabIndex = 5;
            // 
            // txtPartidaSenha
            // 
            this.txtPartidaSenha.Location = new System.Drawing.Point(311, 346);
            this.txtPartidaSenha.Name = "txtPartidaSenha";
            this.txtPartidaSenha.Size = new System.Drawing.Size(114, 20);
            this.txtPartidaSenha.TabIndex = 6;
            // 
            // lblPartidaID
            // 
            this.lblPartidaID.AutoSize = true;
            this.lblPartidaID.Location = new System.Drawing.Point(308, 278);
            this.lblPartidaID.Name = "lblPartidaID";
            this.lblPartidaID.Size = new System.Drawing.Size(68, 13);
            this.lblPartidaID.TabIndex = 7;
            this.lblPartidaID.Text = "ID da partida";
            // 
            // lblPartidaSenha
            // 
            this.lblPartidaSenha.AutoSize = true;
            this.lblPartidaSenha.Location = new System.Drawing.Point(308, 330);
            this.lblPartidaSenha.Name = "lblPartidaSenha";
            this.lblPartidaSenha.Size = new System.Drawing.Size(88, 13);
            this.lblPartidaSenha.TabIndex = 8;
            this.lblPartidaSenha.Text = "Senha da partida";
            // 
            // btnPartidaEntrar
            // 
            this.btnPartidaEntrar.Location = new System.Drawing.Point(320, 372);
            this.btnPartidaEntrar.Name = "btnPartidaEntrar";
            this.btnPartidaEntrar.Size = new System.Drawing.Size(86, 32);
            this.btnPartidaEntrar.TabIndex = 9;
            this.btnPartidaEntrar.Text = "Entrar Partida";
            this.btnPartidaEntrar.UseVisualStyleBackColor = true;
            this.btnPartidaEntrar.Click += new System.EventHandler(this.btnPartidaEntrar_Click);
            // 
            // txtJogadorNome
            // 
            this.txtJogadorNome.Location = new System.Drawing.Point(12, 242);
            this.txtJogadorNome.Name = "txtJogadorNome";
            this.txtJogadorNome.Size = new System.Drawing.Size(114, 20);
            this.txtJogadorNome.TabIndex = 10;
            // 
            // lblJogadorNome
            // 
            this.lblJogadorNome.AutoSize = true;
            this.lblJogadorNome.Location = new System.Drawing.Point(9, 226);
            this.lblJogadorNome.Name = "lblJogadorNome";
            this.lblJogadorNome.Size = new System.Drawing.Size(91, 13);
            this.lblJogadorNome.TabIndex = 11;
            this.lblJogadorNome.Text = "Nome do Jogador";
            // 
            // lblPartidaNome
            // 
            this.lblPartidaNome.AutoSize = true;
            this.lblPartidaNome.Location = new System.Drawing.Point(308, 226);
            this.lblPartidaNome.Name = "lblPartidaNome";
            this.lblPartidaNome.Size = new System.Drawing.Size(85, 13);
            this.lblPartidaNome.TabIndex = 13;
            this.lblPartidaNome.Text = "Nome da partida";
            // 
            // txtPartidaNome
            // 
            this.txtPartidaNome.Location = new System.Drawing.Point(311, 242);
            this.txtPartidaNome.Name = "txtPartidaNome";
            this.txtPartidaNome.Size = new System.Drawing.Size(114, 20);
            this.txtPartidaNome.TabIndex = 12;
            // 
            // btnPartidaCriar
            // 
            this.btnPartidaCriar.Location = new System.Drawing.Point(431, 235);
            this.btnPartidaCriar.Name = "btnPartidaCriar";
            this.btnPartidaCriar.Size = new System.Drawing.Size(86, 32);
            this.btnPartidaCriar.TabIndex = 14;
            this.btnPartidaCriar.Text = "Criar Partida";
            this.btnPartidaCriar.UseVisualStyleBackColor = true;
            this.btnPartidaCriar.Click += new System.EventHandler(this.btnPartidaCriar_Click);
            // 
            // btnPartidaListar
            // 
            this.btnPartidaListar.Location = new System.Drawing.Point(170, 294);
            this.btnPartidaListar.Name = "btnPartidaListar";
            this.btnPartidaListar.Size = new System.Drawing.Size(86, 32);
            this.btnPartidaListar.TabIndex = 15;
            this.btnPartidaListar.Text = "Listar Partidas";
            this.btnPartidaListar.UseVisualStyleBackColor = true;
            this.btnPartidaListar.Click += new System.EventHandler(this.btnPartidaListar_Click);
            // 
            // lsbPartidas
            // 
            this.lsbPartidas.FormattingEnabled = true;
            this.lsbPartidas.Location = new System.Drawing.Point(12, 12);
            this.lsbPartidas.Name = "lsbPartidas";
            this.lsbPartidas.Size = new System.Drawing.Size(505, 199);
            this.lsbPartidas.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbPartidas);
            this.Controls.Add(this.btnPartidaListar);
            this.Controls.Add(this.btnPartidaCriar);
            this.Controls.Add(this.lblPartidaNome);
            this.Controls.Add(this.txtPartidaNome);
            this.Controls.Add(this.lblJogadorNome);
            this.Controls.Add(this.txtJogadorNome);
            this.Controls.Add(this.btnPartidaEntrar);
            this.Controls.Add(this.lblPartidaSenha);
            this.Controls.Add(this.lblPartidaID);
            this.Controls.Add(this.txtPartidaSenha);
            this.Controls.Add(this.txtPartidaId);
            this.Controls.Add(this.btnPartidaIniciar);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.lblIDJogador);
            this.Controls.Add(this.txtJogadorSenha);
            this.Controls.Add(this.txtJogadorID);
            this.MaximumSize = new System.Drawing.Size(543, 465);
            this.MinimumSize = new System.Drawing.Size(543, 465);
            this.Name = "Form1";
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
        private System.Windows.Forms.TextBox txtPartidaId;
        private System.Windows.Forms.TextBox txtPartidaSenha;
        private System.Windows.Forms.Label lblPartidaID;
        private System.Windows.Forms.Label lblPartidaSenha;
        private System.Windows.Forms.Button btnPartidaEntrar;
        private System.Windows.Forms.TextBox txtJogadorNome;
        private System.Windows.Forms.Label lblJogadorNome;
        private System.Windows.Forms.Label lblPartidaNome;
        private System.Windows.Forms.TextBox txtPartidaNome;
        private System.Windows.Forms.Button btnPartidaCriar;
        private System.Windows.Forms.Button btnPartidaListar;
        private System.Windows.Forms.ListBox lsbPartidas;
        private System.Windows.Forms.Label label1;
    }
}

