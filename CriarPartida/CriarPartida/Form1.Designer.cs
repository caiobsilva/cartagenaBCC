namespace CriarPartida
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
            this.txtSalaNome = new System.Windows.Forms.TextBox();
            this.txtSalaSenha = new System.Windows.Forms.TextBox();
            this.btnSalaCriar = new System.Windows.Forms.Button();
            this.lblSalaNome = new System.Windows.Forms.Label();
            this.lblSalaSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSalaNome
            // 
            this.txtSalaNome.Location = new System.Drawing.Point(12, 27);
            this.txtSalaNome.Name = "txtSalaNome";
            this.txtSalaNome.Size = new System.Drawing.Size(110, 20);
            this.txtSalaNome.TabIndex = 0;
            // 
            // txtSalaSenha
            // 
            this.txtSalaSenha.Location = new System.Drawing.Point(12, 78);
            this.txtSalaSenha.Name = "txtSalaSenha";
            this.txtSalaSenha.Size = new System.Drawing.Size(110, 20);
            this.txtSalaSenha.TabIndex = 1;
            // 
            // btnSalaCriar
            // 
            this.btnSalaCriar.Location = new System.Drawing.Point(173, 34);
            this.btnSalaCriar.Name = "btnSalaCriar";
            this.btnSalaCriar.Size = new System.Drawing.Size(90, 36);
            this.btnSalaCriar.TabIndex = 2;
            this.btnSalaCriar.Text = "Criar sala";
            this.btnSalaCriar.UseVisualStyleBackColor = true;
            this.btnSalaCriar.Click += new System.EventHandler(this.btnSalaCriar_Click);
            // 
            // lblSalaNome
            // 
            this.lblSalaNome.AutoSize = true;
            this.lblSalaNome.Location = new System.Drawing.Point(12, 9);
            this.lblSalaNome.Name = "lblSalaNome";
            this.lblSalaNome.Size = new System.Drawing.Size(72, 13);
            this.lblSalaNome.TabIndex = 3;
            this.lblSalaNome.Text = "Nome da sala";
            // 
            // lblSalaSenha
            // 
            this.lblSalaSenha.AutoSize = true;
            this.lblSalaSenha.Location = new System.Drawing.Point(12, 57);
            this.lblSalaSenha.Name = "lblSalaSenha";
            this.lblSalaSenha.Size = new System.Drawing.Size(75, 13);
            this.lblSalaSenha.TabIndex = 4;
            this.lblSalaSenha.Text = "Senha da sala";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 110);
            this.Controls.Add(this.lblSalaSenha);
            this.Controls.Add(this.lblSalaNome);
            this.Controls.Add(this.btnSalaCriar);
            this.Controls.Add(this.txtSalaSenha);
            this.Controls.Add(this.txtSalaNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalaNome;
        private System.Windows.Forms.TextBox txtSalaSenha;
        private System.Windows.Forms.Button btnSalaCriar;
        private System.Windows.Forms.Label lblSalaNome;
        private System.Windows.Forms.Label lblSalaSenha;
    }
}

