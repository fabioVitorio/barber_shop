using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputUsuario.Text == "@admin" && inputSenha.Text == "@salão")
            {

                var th = new Thread(() => Application.Run(new TelaPrincipal())); //instancia a tela principal
                th.SetApartmentState(ApartmentState.STA);
                th.Start(); //abre a tela principal
                this.Close(); //fecha o form login

               /* this.Hide();//fecha o form login
                TelaPrincipal telaPrincipal = new TelaPrincipal(); //instancia a tela principal
                telaPrincipal.Show(); //abre a tela principal */
            }
            else
                MessageBox.Show("Login ou senha estão inválidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrarSenha.Checked)
            {
                inputSenha.PasswordChar = '\0';
            }
            else
            {
                inputSenha.PasswordChar = '●';
            }
            
        }

        private void inputUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
