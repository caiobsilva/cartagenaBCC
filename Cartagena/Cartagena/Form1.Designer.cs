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
            this.txtIDJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.lblIDJogador = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.txtPartidaId = new System.Windows.Forms.TextBox();
            this.txtPartidaSenha = new System.Windows.Forms.TextBox();
            this.lblIDPartida = new System.Windows.Forms.Label();
            this.lblSenhaPartida = new System.Windows.Forms.Label();
            this.btnPartidaEntrar = new System.Windows.Forms.Button();
            this.txtJogadorNome = new System.Windows.Forms.TextBox();
            this.lblJogadorNome = new System.Windows.Forms.Label();
            this.lblSalaNome = new System.Windows.Forms.Label();
            this.txtSalaNome = new System.Windows.Forms.TextBox();
            this.btnSalaCriar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.lsbPartidas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtIDJogador
            // 
            this.txtIDJogador.Location = new System.Drawing.Point(12, 294);
            this.txtIDJogador.Name = "txtIDJogador";
            this.txtIDJogador.Size = new System.Drawing.Size(114, 20);
            this.txtIDJogador.TabIndex = 0;
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(12, 346);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(114, 20);
            this.txtSenhaJogador.TabIndex = 1;
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
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(17, 372);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(86, 32);
            this.btnIniciarPartida.TabIndex = 4;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
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
            // lblIDPartida
            // 
            this.lblIDPartida.AutoSize = true;
            this.lblIDPartida.Location = new System.Drawing.Point(308, 278);
            this.lblIDPartida.Name = "lblIDPartida";
            this.lblIDPartida.Size = new System.Drawing.Size(68, 13);
            this.lblIDPartida.TabIndex = 7;
            this.lblIDPartida.Text = "ID da partida";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.Location = new System.Drawing.Point(308, 330);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(88, 13);
            this.lblSenhaPartida.TabIndex = 8;
            this.lblSenhaPartida.Text = "Senha da partida";
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
            // lblSalaNome
            // 
            this.lblSalaNome.AutoSize = true;
            this.lblSalaNome.Location = new System.Drawing.Point(308, 226);
            this.lblSalaNome.Name = "lblSalaNome";
            this.lblSalaNome.Size = new System.Drawing.Size(74, 13);
            this.lblSalaNome.TabIndex = 13;
            this.lblSalaNome.Text = "Nome da Sala";
            // 
            // txtSalaNome
            // 
            this.txtSalaNome.Location = new System.Drawing.Point(311, 242);
            this.txtSalaNome.Name = "txtSalaNome";
            this.txtSalaNome.Size = new System.Drawing.Size(114, 20);
            this.txtSalaNome.TabIndex = 12;
            // 
            // btnSalaCriar
            // 
            this.btnSalaCriar.Location = new System.Drawing.Point(431, 235);
            this.btnSalaCriar.Name = "btnSalaCriar";
            this.btnSalaCriar.Size = new System.Drawing.Size(86, 32);
            this.btnSalaCriar.TabIndex = 14;
            this.btnSalaCriar.Text = "Criar Sala";
            this.btnSalaCriar.UseVisualStyleBackColor = true;
            this.btnSalaCriar.Click += new System.EventHandler(this.btnSalaCriar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(169, 294);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(86, 32);
            this.btnListar.TabIndex = 15;
            this.btnListar.Text = "Listar Partidas";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lsbPartidas
            // 
            this.lsbPartidas.FormattingEnabled = true;
            this.lsbPartidas.Location = new System.Drawing.Point(12, 12);
            this.lsbPartidas.Name = "lsbPartidas";
            this.lsbPartidas.Size = new System.Drawing.Size(503, 199);
            this.lsbPartidas.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 426);
            this.Controls.Add(this.lsbPartidas);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnSalaCriar);
            this.Controls.Add(this.lblSalaNome);
            this.Controls.Add(this.txtSalaNome);
            this.Controls.Add(this.lblJogadorNome);
            this.Controls.Add(this.txtJogadorNome);
            this.Controls.Add(this.btnPartidaEntrar);
            this.Controls.Add(this.lblSenhaPartida);
            this.Controls.Add(this.lblIDPartida);
            this.Controls.Add(this.txtPartidaSenha);
            this.Controls.Add(this.txtPartidaId);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.lblIDJogador);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.txtIDJogador);
            this.Name = "Form1";
            this.Text = "Cartagena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Label lblIDJogador;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.TextBox txtPartidaId;
        private System.Windows.Forms.TextBox txtPartidaSenha;
        private System.Windows.Forms.Label lblIDPartida;
        private System.Windows.Forms.Label lblSenhaPartida;
        private System.Windows.Forms.Button btnPartidaEntrar;
        private System.Windows.Forms.TextBox txtJogadorNome;
        private System.Windows.Forms.Label lblJogadorNome;
        private System.Windows.Forms.Label lblSalaNome;
        private System.Windows.Forms.TextBox txtSalaNome;
        private System.Windows.Forms.Button btnSalaCriar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ListBox lsbPartidas;
    }
}

