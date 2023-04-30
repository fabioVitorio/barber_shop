namespace SA
{
    partial class TelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAjuda = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new FontAwesome.Sharp.IconButton();
            this.btnRelatorio = new FontAwesome.Sharp.IconButton();
            this.btnServico = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelForms = new System.Windows.Forms.Panel();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnAjuda);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnRelatorio);
            this.panel1.Controls.Add(this.btnServico);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 989);
            this.panel1.TabIndex = 0;
            // 
            // btnAjuda
            // 
            this.btnAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjuda.FlatAppearance.BorderSize = 0;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAjuda.ForeColor = System.Drawing.Color.White;
            this.btnAjuda.IconChar = FontAwesome.Sharp.IconChar.Comment;
            this.btnAjuda.IconColor = System.Drawing.Color.White;
            this.btnAjuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAjuda.IconSize = 30;
            this.btnAjuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjuda.Location = new System.Drawing.Point(0, 383);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(5, 4, 4, 4);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAjuda.Size = new System.Drawing.Size(297, 86);
            this.btnAjuda.TabIndex = 6;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 900);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "© reserved by meu salão";
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSair.IconColor = System.Drawing.Color.White;
            this.btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSair.IconSize = 30;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 473);
            this.btnSair.Margin = new System.Windows.Forms.Padding(5, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(297, 86);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.IconChar = FontAwesome.Sharp.IconChar.SquarePollVertical;
            this.btnRelatorio.IconColor = System.Drawing.Color.White;
            this.btnRelatorio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRelatorio.IconSize = 30;
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.Location = new System.Drawing.Point(0, 293);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(5, 4, 4, 4);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRelatorio.Size = new System.Drawing.Size(297, 86);
            this.btnRelatorio.TabIndex = 3;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnServico
            // 
            this.btnServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServico.FlatAppearance.BorderSize = 0;
            this.btnServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnServico.ForeColor = System.Drawing.Color.White;
            this.btnServico.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnServico.IconColor = System.Drawing.Color.White;
            this.btnServico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnServico.IconSize = 30;
            this.btnServico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServico.Location = new System.Drawing.Point(0, 202);
            this.btnServico.Margin = new System.Windows.Forms.Padding(5, 4, 4, 4);
            this.btnServico.Name = "btnServico";
            this.btnServico.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnServico.Size = new System.Drawing.Size(297, 86);
            this.btnServico.TabIndex = 2;
            this.btnServico.Text = "Novo serviço";
            this.btnServico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServico.UseVisualStyleBackColor = true;
            this.btnServico.Click += new System.EventHandler(this.btnServico_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnInicio.IconColor = System.Drawing.Color.White;
            this.btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInicio.IconSize = 30;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 111);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(5, 4, 4, 4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(297, 86);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Início";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.panelLogo.BackgroundImage = global::SA.Properties.Resources.logo_menu1;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Controls.Add(this.iconPictureBox1);
            this.panelLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(297, 111);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 111;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(297, 111);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(297, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1605, 111);
            this.panel2.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(649, 26);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(322, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SEJA BEM - VINDO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelForms
            // 
            this.panelForms.BackColor = System.Drawing.Color.White;
            this.panelForms.Controls.Add(this.labelHora);
            this.panelForms.Controls.Add(this.labelData);
            this.panelForms.Controls.Add(this.pictureBox);
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(297, 111);
            this.panelForms.Margin = new System.Windows.Forms.Padding(4);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(1605, 878);
            this.panelForms.TabIndex = 2;
            // 
            // labelHora
            // 
            this.labelHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHora.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F);
            this.labelHora.Location = new System.Drawing.Point(419, 637);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(765, 38);
            this.labelHora.TabIndex = 2;
            this.labelHora.Text = "00:00:00";
            this.labelHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHora.Click += new System.EventHandler(this.labelHora_Click);
            // 
            // labelData
            // 
            this.labelData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelData.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.labelData.Location = new System.Drawing.Point(417, 569);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(767, 48);
            this.labelData.TabIndex = 1;
            this.labelData.Text = "00/00/0000";
            this.labelData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = global::SA.Properties.Resources.bg_inicio;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1605, 878);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1902, 989);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnInicio;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private FontAwesome.Sharp.IconButton btnSair;
        private FontAwesome.Sharp.IconButton btnRelatorio;
        private FontAwesome.Sharp.IconButton btnServico;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnAjuda;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Timer timer1;
    }
}