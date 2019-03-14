namespace PiInterface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtJogadorNome = new System.Windows.Forms.TextBox();
            this.txtPartidaId = new System.Windows.Forms.TextBox();
            this.txtJogadorSenha = new System.Windows.Forms.TextBox();
            this.txtPartidaSenha = new System.Windows.Forms.TextBox();
            this.txtJogadorId = new System.Windows.Forms.TextBox();
            this.btnPartidaEntrar = new System.Windows.Forms.Button();
            this.lblJogadorID = new System.Windows.Forms.Label();
            this.lblJogadorSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtJogadorNome
            // 
            this.txtJogadorNome.Location = new System.Drawing.Point(62, 12);
            this.txtJogadorNome.Name = "txtJogadorNome";
            this.txtJogadorNome.Size = new System.Drawing.Size(100, 20);
            this.txtJogadorNome.TabIndex = 0;
            this.txtJogadorNome.Text = "nome";
            // 
            // txtPartidaId
            // 
            this.txtPartidaId.Location = new System.Drawing.Point(62, 57);
            this.txtPartidaId.Name = "txtPartidaId";
            this.txtPartidaId.Size = new System.Drawing.Size(100, 20);
            this.txtPartidaId.TabIndex = 1;
            this.txtPartidaId.Text = "id partida";
            // 
            // txtJogadorSenha
            // 
            this.txtJogadorSenha.Location = new System.Drawing.Point(349, 57);
            this.txtJogadorSenha.Name = "txtJogadorSenha";
            this.txtJogadorSenha.Size = new System.Drawing.Size(100, 20);
            this.txtJogadorSenha.TabIndex = 2;
            // 
            // txtPartidaSenha
            // 
            this.txtPartidaSenha.Location = new System.Drawing.Point(62, 103);
            this.txtPartidaSenha.Name = "txtPartidaSenha";
            this.txtPartidaSenha.Size = new System.Drawing.Size(100, 20);
            this.txtPartidaSenha.TabIndex = 3;
            this.txtPartidaSenha.Text = "senha partida";
            // 
            // txtJogadorId
            // 
            this.txtJogadorId.Location = new System.Drawing.Point(349, 12);
            this.txtJogadorId.Name = "txtJogadorId";
            this.txtJogadorId.Size = new System.Drawing.Size(100, 20);
            this.txtJogadorId.TabIndex = 4;
            // 
            // btnPartidaEntrar
            // 
            this.btnPartidaEntrar.Location = new System.Drawing.Point(328, 103);
            this.btnPartidaEntrar.Name = "btnPartidaEntrar";
            this.btnPartidaEntrar.Size = new System.Drawing.Size(121, 46);
            this.btnPartidaEntrar.TabIndex = 5;
            this.btnPartidaEntrar.Text = "Entrar partida";
            this.btnPartidaEntrar.UseVisualStyleBackColor = true;
            this.btnPartidaEntrar.Click += new System.EventHandler(this.btnPartidaEntrar_Click);
            // 
            // lblJogadorID
            // 
            this.lblJogadorID.AutoSize = true;
            this.lblJogadorID.Location = new System.Drawing.Point(279, 15);
            this.lblJogadorID.Name = "lblJogadorID";
            this.lblJogadorID.Size = new System.Drawing.Size(59, 13);
            this.lblJogadorID.TabIndex = 6;
            this.lblJogadorID.Text = "Jogador ID";
            this.lblJogadorID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJogadorSenha
            // 
            this.lblJogadorSenha.AutoSize = true;
            this.lblJogadorSenha.Location = new System.Drawing.Point(264, 57);
            this.lblJogadorSenha.Name = "lblJogadorSenha";
            this.lblJogadorSenha.Size = new System.Drawing.Size(79, 13);
            this.lblJogadorSenha.TabIndex = 7;
            this.lblJogadorSenha.Text = "Jogador Senha";
            this.lblJogadorSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 157);
            this.Controls.Add(this.lblJogadorSenha);
            this.Controls.Add(this.lblJogadorID);
            this.Controls.Add(this.btnPartidaEntrar);
            this.Controls.Add(this.txtJogadorId);
            this.Controls.Add(this.txtPartidaSenha);
            this.Controls.Add(this.txtJogadorSenha);
            this.Controls.Add(this.txtPartidaId);
            this.Controls.Add(this.txtJogadorNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJogadorNome;
        private System.Windows.Forms.TextBox txtPartidaId;
        private System.Windows.Forms.TextBox txtJogadorSenha;
        private System.Windows.Forms.TextBox txtPartidaSenha;
        private System.Windows.Forms.TextBox txtJogadorId;
        private System.Windows.Forms.Button btnPartidaEntrar;
        private System.Windows.Forms.Label lblJogadorID;
        private System.Windows.Forms.Label lblJogadorSenha;
    }
}

