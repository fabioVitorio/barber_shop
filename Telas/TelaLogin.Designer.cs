namespace SA
{
    partial class TelaLogin
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
            this.button1 = new System.Windows.Forms.Button();
            this.inputUsuario = new System.Windows.Forms.TextBox();
            this.inputSenha = new System.Windows.Forms.TextBox();
            this.mostrarSenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(368, 423);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "ENTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputUsuario
            // 
            this.inputUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.inputUsuario.Location = new System.Drawing.Point(332, 206);
            this.inputUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputUsuario.Name = "inputUsuario";
            this.inputUsuario.Size = new System.Drawing.Size(252, 38);
            this.inputUsuario.TabIndex = 1;
            this.inputUsuario.TextChanged += new System.EventHandler(this.inputUsuario_TextChanged);
            // 
            // inputSenha
            // 
            this.inputSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.inputSenha.Location = new System.Drawing.Point(332, 284);
            this.inputSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.PasswordChar = '●';
            this.inputSenha.Size = new System.Drawing.Size(252, 38);
            this.inputSenha.TabIndex = 2;
            // 
            // mostrarSenha
            // 
            this.mostrarSenha.AutoSize = true;
            this.mostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.mostrarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mostrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mostrarSenha.ForeColor = System.Drawing.Color.White;
            this.mostrarSenha.Location = new System.Drawing.Point(332, 327);
            this.mostrarSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mostrarSenha.Name = "mostrarSenha";
            this.mostrarSenha.Size = new System.Drawing.Size(126, 22);
            this.mostrarSenha.TabIndex = 6;
            this.mostrarSenha.Text = "Mostrar senha";
            this.mostrarSenha.UseVisualStyleBackColor = false;
            this.mostrarSenha.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TelaLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::SA.Properties.Resources.bg_login4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 530);
            this.Controls.Add(this.mostrarSenha);
            this.Controls.Add(this.inputSenha);
            this.Controls.Add(this.inputUsuario);
            this.Controls.Add(this.button1);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputUsuario;
        private System.Windows.Forms.TextBox inputSenha;
        private System.Windows.Forms.CheckBox mostrarSenha;
    }
}

