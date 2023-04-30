namespace SA
{
    partial class Relatorio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAtualizar = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelClienteMes = new System.Windows.Forms.Label();
            this.labelClienteDia = new System.Windows.Forms.Label();
            this.labelGanho2 = new System.Windows.Forms.Label();
            this.labelGanho1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkDiario = new System.Windows.Forms.CheckBox();
            this.chkMensal = new System.Windows.Forms.CheckBox();
            this.btnBaixar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.chkDiario);
            this.panel1.Controls.Add(this.chkMensal);
            this.panel1.Controls.Add(this.btnBaixar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(67, 0, 0, 86);
            this.panel1.Size = new System.Drawing.Size(1076, 796);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.btnAtualizar);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.labelClienteMes);
            this.panel2.Controls.Add(this.labelClienteDia);
            this.panel2.Controls.Add(this.labelGanho2);
            this.panel2.Controls.Add(this.labelGanho1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(51, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 543);
            this.panel2.TabIndex = 5;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAtualizar.AutoSize = true;
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.btnAtualizar.IconColor = System.Drawing.Color.White;
            this.btnAtualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAtualizar.IconSize = 25;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(442, 493);
            this.btnAtualizar.MaximumSize = new System.Drawing.Size(143, 38);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAtualizar.Size = new System.Drawing.Size(143, 38);
            this.btnAtualizar.TabIndex = 20;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SA.Properties.Resources.icon_dinheiro2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.InitialImage = global::SA.Properties.Resources.icon_dinheiro1;
            this.pictureBox2.Location = new System.Drawing.Point(679, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SA.Properties.Resources.icon_dinheiro1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = global::SA.Properties.Resources.icon_dinheiro1;
            this.pictureBox1.Location = new System.Drawing.Point(169, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelClienteMes
            // 
            this.labelClienteMes.Font = new System.Drawing.Font("Bahnschrift Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClienteMes.ForeColor = System.Drawing.Color.White;
            this.labelClienteMes.Location = new System.Drawing.Point(605, 401);
            this.labelClienteMes.Name = "labelClienteMes";
            this.labelClienteMes.Size = new System.Drawing.Size(254, 40);
            this.labelClienteMes.TabIndex = 5;
            this.labelClienteMes.Text = "37 clientes";
            this.labelClienteMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelClienteDia
            // 
            this.labelClienteDia.Font = new System.Drawing.Font("Bahnschrift Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClienteDia.ForeColor = System.Drawing.Color.White;
            this.labelClienteDia.Location = new System.Drawing.Point(110, 401);
            this.labelClienteDia.Name = "labelClienteDia";
            this.labelClienteDia.Size = new System.Drawing.Size(245, 40);
            this.labelClienteDia.TabIndex = 4;
            this.labelClienteDia.Text = "7 clientes";
            this.labelClienteDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGanho2
            // 
            this.labelGanho2.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F);
            this.labelGanho2.ForeColor = System.Drawing.Color.White;
            this.labelGanho2.Location = new System.Drawing.Point(595, 264);
            this.labelGanho2.Name = "labelGanho2";
            this.labelGanho2.Size = new System.Drawing.Size(264, 60);
            this.labelGanho2.TabIndex = 3;
            this.labelGanho2.Text = "R$ 000,00";
            this.labelGanho2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGanho1
            // 
            this.labelGanho1.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F);
            this.labelGanho1.ForeColor = System.Drawing.Color.White;
            this.labelGanho1.Location = new System.Drawing.Point(110, 264);
            this.labelGanho1.Name = "labelGanho1";
            this.labelGanho1.Size = new System.Drawing.Size(245, 60);
            this.labelGanho1.TabIndex = 2;
            this.labelGanho1.Text = "R$ 000,00";
            this.labelGanho1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(622, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ganhos do mês";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ganhos do dia";
            // 
            // chkDiario
            // 
            this.chkDiario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDiario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkDiario.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F);
            this.chkDiario.Location = new System.Drawing.Point(67, 589);
            this.chkDiario.Margin = new System.Windows.Forms.Padding(4);
            this.chkDiario.MaximumSize = new System.Drawing.Size(200, 34);
            this.chkDiario.Name = "chkDiario";
            this.chkDiario.Size = new System.Drawing.Size(200, 34);
            this.chkDiario.TabIndex = 3;
            this.chkDiario.Text = "Relatório diário";
            this.chkDiario.UseVisualStyleBackColor = true;
            this.chkDiario.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkMensal
            // 
            this.chkMensal.AutoSize = true;
            this.chkMensal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkMensal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkMensal.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F);
            this.chkMensal.Location = new System.Drawing.Point(67, 623);
            this.chkMensal.Margin = new System.Windows.Forms.Padding(4);
            this.chkMensal.MaximumSize = new System.Drawing.Size(200, 47);
            this.chkMensal.Name = "chkMensal";
            this.chkMensal.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.chkMensal.Size = new System.Drawing.Size(200, 40);
            this.chkMensal.TabIndex = 2;
            this.chkMensal.Text = "Relatório mensal";
            this.chkMensal.UseVisualStyleBackColor = true;
            this.chkMensal.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnBaixar
            // 
            this.btnBaixar.AutoSize = true;
            this.btnBaixar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btnBaixar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaixar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBaixar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaixar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBaixar.ForeColor = System.Drawing.Color.White;
            this.btnBaixar.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnBaixar.IconColor = System.Drawing.Color.White;
            this.btnBaixar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBaixar.IconSize = 25;
            this.btnBaixar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaixar.Location = new System.Drawing.Point(67, 663);
            this.btnBaixar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaixar.MaximumSize = new System.Drawing.Size(180, 47);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnBaixar.Size = new System.Drawing.Size(180, 47);
            this.btnBaixar.TabIndex = 4;
            this.btnBaixar.Text = "Baixar";
            this.btnBaixar.UseVisualStyleBackColor = false;
            this.btnBaixar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Relatorio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1076, 796);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Relatorio";
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.Relatorio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkDiario;
        private System.Windows.Forms.CheckBox chkMensal;
        private FontAwesome.Sharp.IconButton btnBaixar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelClienteMes;
        private System.Windows.Forms.Label labelClienteDia;
        private System.Windows.Forms.Label labelGanho2;
        private System.Windows.Forms.Label labelGanho1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnAtualizar;
    }
}