using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SA
{
    public partial class Servico : Form
    {
        public Servico()
        {
            InitializeComponent();
        }

        // string de conexão com o banco
        string strConn = "server=localhost; port=3306; UID=root; database=banco_sa; pwd=";

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            string nome = inputNome.Text;
            string telefone = inputTel.Text;
            string servico = inputServico.Text;
            string valor = inputValor.Text;
            valor = valor.Replace(',', '.');
            string data = inputDate.Text;
            string hora = inputTime.Text;

            


            // verifica os campos
            if (inputNome.Text == "" || inputServico.Text == "" || inputDate.Text == "" || inputTime.Text == "" || inputValor.Text == "" || inputTel.Text == "")
            {
                MessageBox.Show("Favor verificar os dados inseridos!", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else if (inputTel.Text.Length < 14)
            {
                MessageBox.Show("Telefone inválido \nFavor conferir o campo e digitar novamente ", "Erro com o Telefone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputTel.Focus();
            }
            else if (inputValor.Text.Length < 1)
            {
                MessageBox.Show("Vlor inválido \nFavor conferir o campo e digitar novamente ", "Erro com o Valor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputValor.Focus();
            }
            else
            {
                

                try
                {
                    MySqlConnection conn = new MySqlConnection(strConn);
                    conn.Open();

                    MySqlCommand sql = new MySqlCommand("insert into agenda(nome, telefone, tipo_servico, valor_servico, data, hora, status) values " +
                                                        "('" + nome + "', '" + telefone +"', '" + servico +"', '"+ valor +"', '"+ data +"', '"+ hora +"', 'Pendente');", conn);
                    sql.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Agendamento realizado com sucesso! ", "Agendado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message, "Erro com o banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
            }

            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
