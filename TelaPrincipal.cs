using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA
{
    public partial class TelaPrincipal : Form
    {

        Principal principal = new Principal();
        Servico servico = new Servico();
        Relatorio relatorio = new Relatorio();
        Ajuda ajuda = new Ajuda();

        

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult op = MessageBox.Show("Tem certeza que deseja sair?", "Sair", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (op == DialogResult.OK)
            {
                var th = new Thread(() => Application.Run(new TelaLogin())); //instancia a tela login
                th.SetApartmentState(ApartmentState.STA);
                th.Start(); //abre a tela login
                this.Close(); //fecha o form principal
            }
            
        }


        private void btnInicio_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "INÍCIO";

            relatorio.Visible = false;
            servico.Visible = false;
            pictureBox.Visible = false;
            labelData.Visible = false;
            labelHora.Visible = false;
            ajuda.Visible = false;

            principal.TopLevel = false;
            principal.Visible = true;
            principal.Size = new Size(panelForms.Width, panelForms.Height);
            principal.Location = new Point(0, 0);
            principal.Dock = DockStyle.Fill;
            panelForms.Controls.Add(principal);

            btnRelatorio.BackColor = Color.FromArgb(40, 42, 54);
            btnServico.BackColor = Color.FromArgb(40, 42, 54);
            btnInicio.BackColor = Color.FromArgb(52, 55, 70);
            btnAjuda.BackColor = Color.FromArgb(40, 42, 54);
        }

        private void btnServico_Click(object sender, EventArgs e)
        {

            lblTitle.Text = "NOVO SERVIÇO";

            principal.Visible = false;
            relatorio.Visible = false;
            pictureBox.Visible = false;
            labelData.Visible = false;
            labelHora.Visible = false;
            ajuda.Visible = false;

            servico.TopLevel = false;
            servico.Visible = true;
            servico.Size = new Size(panelForms.Width, panelForms.Height);
            servico.Location = new Point(0, 0);
            servico.Dock = DockStyle.Fill;
            panelForms.Controls.Add(servico);

            btnInicio.BackColor = Color.FromArgb(40, 42, 54);
            btnRelatorio.BackColor = Color.FromArgb(40, 42, 54);
            btnServico.BackColor = Color.FromArgb(52, 55, 70);
            btnAjuda.BackColor = Color.FromArgb(40, 42, 54);
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "RELATÓRIO";

            principal.Visible = false;
            servico.Visible = false;
            pictureBox.Visible = false;
            labelData.Visible = false;
            labelHora.Visible = false;
            ajuda.Visible = false;

            relatorio.TopLevel = false;
            relatorio.Visible = true;
            relatorio.Size = new Size(panelForms.Width, panelForms.Height);
            relatorio.Location = new Point(0, 0);
            relatorio.Dock = DockStyle.Fill;
            panelForms.Controls.Add(relatorio);

            btnInicio.BackColor = Color.FromArgb(40, 42, 54);
            btnServico.BackColor = Color.FromArgb(40, 42, 54);
            btnRelatorio.BackColor = Color.FromArgb(52, 55, 70);
            btnAjuda.BackColor = Color.FromArgb(40, 42, 54);
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            servico.Visible = false;
            relatorio.Visible = false;
            pictureBox.Visible = true;
            labelData.Visible = true;
            labelHora.Visible = true;
            ajuda.Visible = false;

            lblTitle.Text = "SEJA BEM - VINDO";
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            labelData.Text = DateTime.Now.ToString("M") + " de " + DateTime.Now.ToString("yyyy");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void labelHora_Click(object sender, EventArgs e)
        {

        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "AJUDA";

            relatorio.Visible = false;
            principal.Visible = false;
            servico.Visible = false;
            pictureBox.Visible = false;
            labelData.Visible = false;
            labelHora.Visible = false;

            ajuda.TopLevel = false;
            ajuda.Visible = true;
            ajuda.Size = new Size(panelForms.Width, panelForms.Height);
            ajuda.Location = new Point(0, 0);
            ajuda.Dock = DockStyle.Fill;
            panelForms.Controls.Add(ajuda);

            btnRelatorio.BackColor = Color.FromArgb(40, 42, 54);
            btnServico.BackColor = Color.FromArgb(40, 42, 54);
            btnAjuda.BackColor = Color.FromArgb(52, 55, 70);
        }
    }
}
