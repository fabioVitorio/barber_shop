using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace SA
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        string strConn = "server=localhost; port=3306; UID=root; database=banco_sa; pwd=";
        MySqlDataAdapter da;
        MySqlCommand command;
        DataTable dt;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void principal_Load(object sender, EventArgs e) {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }


        private void Principal_Load_1(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(strConn);
                conn.Open();

                command = new MySqlCommand("select * from agenda where status = 'Pendente'", conn);
                command.ExecuteNonQuery();

                dt = new DataTable();
                da = new MySqlDataAdapter(command);
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message, "Erro com o banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                MySqlConnection conn = new MySqlConnection(strConn);
                conn.Open();
               
                if (sender is DataGridView dgv)
                {
                    DataGridViewCell cell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    string valor = "Pendente";
                    string indice = dgv[0,e.RowIndex].Value.ToString();
                    int indice2 = int.Parse(indice);

                    if (cell.Value is string value && value == "Pendente" )
                    {
                        
                        command = new MySqlCommand("update agenda set status = 'Concluido' where status = 'Pendente' and id_cliente= '"+indice2 +"'", conn);
                        command.ExecuteNonQuery();
                        cell.Value = "Concluido";
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message, "Erro com o banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(strConn);
                conn.Open();

                command = new MySqlCommand("select * from agenda where status = 'Pendente'", conn);
                command.ExecuteNonQuery();

                dt = new DataTable();
                da = new MySqlDataAdapter(command);
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message, "Erro com o banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
