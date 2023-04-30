namespace SA
{
    partial class Servico
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputValor = new System.Windows.Forms.MaskedTextBox();
            this.inputTime = new System.Windows.Forms.DateTimePicker();
            this.inputDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgendar = new FontAwesome.Sharp.IconButton();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputServico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel1.Size = new System.Drawing.Size(944, 646);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 100);
            this.panel3.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = global::SA.Properties.Resources.icon_salao;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(395, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.inputValor);
            this.groupBox1.Controls.Add(this.inputTime);
            this.groupBox1.Controls.Add(this.inputDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.inputNome);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputTel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.inputServico);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.groupBox1.Location = new System.Drawing.Point(155, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 500);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar novo serviço";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // inputValor
            // 
            this.inputValor.Font = new System.Drawing.Font("Calibri Light", 17F);
            this.inputValor.Location = new System.Drawing.Point(142, 306);
            this.inputValor.Mask = "000.00";
            this.inputValor.Name = "inputValor";
            this.inputValor.PromptChar = ' ';
            this.inputValor.Size = new System.Drawing.Size(126, 42);
            this.inputValor.TabIndex = 22;
            // 
            // inputTime
            // 
            this.inputTime.Font = new System.Drawing.Font("Calibri Light", 15.75F);
            this.inputTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.inputTime.Location = new System.Drawing.Point(450, 306);
            this.inputTime.Name = "inputTime";
            this.inputTime.ShowUpDown = true;
            this.inputTime.Size = new System.Drawing.Size(126, 40);
            this.inputTime.TabIndex = 21;
            this.inputTime.Value = new System.DateTime(2023, 3, 12, 0, 0, 0, 0);
            // 
            // inputDate
            // 
            this.inputDate.CalendarTitleBackColor = System.Drawing.SystemColors.Highlight;
            this.inputDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputDate.CustomFormat = "yyyy-MM-dd";
            this.inputDate.Font = new System.Drawing.Font("Calibri Light", 15.75F);
            this.inputDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputDate.Location = new System.Drawing.Point(279, 306);
            this.inputDate.MinDate = new System.DateTime(2023, 3, 12, 0, 0, 0, 0);
            this.inputDate.Name = "inputDate";
            this.inputDate.Size = new System.Drawing.Size(162, 40);
            this.inputDate.TabIndex = 20;
            this.inputDate.Value = new System.DateTime(2023, 3, 12, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(103, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 35);
            this.label7.TabIndex = 19;
            this.label7.Text = "R$";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.btnAgendar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 71);
            this.panel2.TabIndex = 18;
            // 
            // btnAgendar
            // 
            this.btnAgendar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgendar.AutoSize = true;
            this.btnAgendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btnAgendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgendar.ForeColor = System.Drawing.Color.White;
            this.btnAgendar.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnAgendar.IconColor = System.Drawing.Color.White;
            this.btnAgendar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgendar.IconSize = 25;
            this.btnAgendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendar.Location = new System.Drawing.Point(257, 16);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAgendar.Size = new System.Drawing.Size(161, 38);
            this.btnAgendar.TabIndex = 18;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // inputNome
            // 
            this.inputNome.Font = new System.Drawing.Font("Calibri Light", 17F);
            this.inputNome.Location = new System.Drawing.Point(98, 105);
            this.inputNome.Margin = new System.Windows.Forms.Padding(2);
            this.inputNome.MaxLength = 40;
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(478, 42);
            this.inputNome.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(456, 275);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hora: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(288, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(92, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone: ";
            // 
            // inputTel
            // 
            this.inputTel.Font = new System.Drawing.Font("Calibri Light", 17F);
            this.inputTel.Location = new System.Drawing.Point(99, 212);
            this.inputTel.Mask = "(00) 0000-0000";
            this.inputTel.Name = "inputTel";
            this.inputTel.PromptChar = ' ';
            this.inputTel.Size = new System.Drawing.Size(169, 42);
            this.inputTel.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(102, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor: ";
            // 
            // inputServico
            // 
            this.inputServico.Font = new System.Drawing.Font("Calibri Light", 17F);
            this.inputServico.Location = new System.Drawing.Point(279, 212);
            this.inputServico.Margin = new System.Windows.Forms.Padding(2);
            this.inputServico.MaxLength = 30;
            this.inputServico.Name = "inputServico";
            this.inputServico.Size = new System.Drawing.Size(297, 42);
            this.inputServico.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(273, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de serviço: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(93, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // Servico
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(944, 646);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Servico";
            this.Text = "Servico";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox inputTel;
        private FontAwesome.Sharp.IconButton btnAgendar;
        private System.Windows.Forms.TextBox inputServico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox inputData;
        private System.Windows.Forms.DateTimePicker inputDate;
        private System.Windows.Forms.DateTimePicker inputTime;
        private System.Windows.Forms.MaskedTextBox inputValor;
    }
}