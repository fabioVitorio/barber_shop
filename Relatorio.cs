using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;


namespace SA
{
    public partial class Relatorio : Form
    {

        public MySqlDataReader data;
        

        public Relatorio()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }


        //****************************************************
        //                  GERADOR DE PDF
        //****************************************************
        private void iconButton1_Click(object sender, EventArgs e)
        {
            string dataAtual = DateTime.Now.ToString("yyyy-MM-dd");
            string mesAtual = DateTime.Now.ToString("MM");

            // string de conexão com o banco
            string strConn = "server=localhost; port=3306; UID=root; database=banco_sa; pwd=";

            try
            {
                //PDF
                string nomeArquivo = @"relatorio.pdf";
                FileStream arquivoPdf = new FileStream(nomeArquivo, FileMode.Create);
                Document doc = new Document(PageSize.A4);
                PdfWriter escritorPdf = PdfWriter.GetInstance(doc, arquivoPdf);
                string dados = "";
                Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20));
                Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20));
                var tituloDiario = new Paragraph("Relatório diário\n", new iTextSharp.text.Font((iTextSharp.text.Font.FontFamily)iTextSharp.text.Font.BOLD, 25));
                var tituloMensal = new Paragraph("Relatório mensal\n", new iTextSharp.text.Font((iTextSharp.text.Font.FontFamily)iTextSharp.text.Font.BOLD, 25));
                Paragraph assinatura = new Paragraph("\n\n\n\n\n\n\n\n\n\n\n\n\n" +
                    "\n\n\n\n\n\n\n\n\n\n                               Assinatura: ___________________________________" +
                    "\n\n                                                                   " + DateTime.Now.ToString("dd/MM/yyyy"));

                //BANCO
                MySqlConnection conn = new MySqlConnection(strConn);
                conn.Open();

                if (chkDiario.Checked && chkMensal.Checked) //relatórios diários e mensais
                {
                    MySqlCommand command3 = new MySqlCommand("SELECT COUNT(status) as clienteDia FROM agenda WHERE status = 'Concluido' and data = '" + dataAtual + "';", conn);
                    data = command3.ExecuteReader();
                    data.Read();
                    paragrafo.Add("-> | Total de clientes no dia: " + data["clienteDia"].ToString());
                    data.Close();
                    MySqlCommand command1 = new MySqlCommand("SELECT SUM(valor_servico) as dinheiroDia FROM agenda WHERE data = '" + dataAtual + "' and status = 'Concluido';", conn);
                    data = command1.ExecuteReader();
                    data.Read();
                    paragrafo.Add("\n-> | Total Arrecadado no dia: R$ " + float.Parse(data["dinheiroDia"].ToString()) + "\n");
                    data.Close();

                    paragrafo.Add("\n-------------------------------------------\n\n");

                    MySqlCommand command4 = new MySqlCommand("SELECT COUNT(status) as clienteMes FROM agenda WHERE status = 'Concluido' and data LIKE '%" + mesAtual + "%';", conn);
                    data = command4.ExecuteReader();
                    data.Read();
                    paragrafo2.Add("-> | Total de clientes no mês: " + data["clienteMes"].ToString());
                    data.Close();
                    MySqlCommand command2 = new MySqlCommand("SELECT SUM(valor_servico) as dinheiroMes FROM agenda WHERE  data LIKE '%" + mesAtual + "%' and status = 'Concluido';", conn);
                    data = command2.ExecuteReader();
                    data.Read();
                    paragrafo2.Add("\n-> | Total de clientes no mês: " + float.Parse(data["dinheiroMes"].ToString()));
                    data.Close();


                    doc.Open();
                    doc.Add(tituloDiario);
                    doc.Add(paragrafo);
                    doc.Add(tituloMensal);
                    doc.Add(paragrafo2);
                    doc.Add(assinatura);
                    doc.Close();

                    MessageBox.Show("Relatório salvo com sucesso ", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
                else if (chkMensal.Checked) //relatório mensal
                {

                    MySqlCommand command4 = new MySqlCommand("SELECT COUNT(status) as clienteMes FROM agenda WHERE status = 'Concluido' and data LIKE '%" + mesAtual + "%';", conn);
                    data = command4.ExecuteReader();
                    data.Read();
                    paragrafo2.Add("-> | Total de clientes no mês: " + data["clienteMes"].ToString());
                    data.Close();

                    MySqlCommand command2 = new MySqlCommand("SELECT SUM(valor_servico) as dinheiroMes FROM agenda WHERE  data LIKE '%" + mesAtual + "%' and status = 'Concluido';", conn);
                    data = command2.ExecuteReader();
                    data.Read();
                    paragrafo2.Add("\n-> | Total Arrecadado no mês: R$ " + float.Parse(data["dinheiroMes"].ToString()));
                    data.Close();

                    doc.Open();
                    paragrafo.Add(tituloMensal);
                    doc.Add(paragrafo2);
                    doc.Add(assinatura);
                    doc.Close();

                    MessageBox.Show("Relatório salvo com sucesso ", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
                else if (chkDiario.Checked) //relatório diário
                {
                    MySqlCommand command3 = new MySqlCommand("SELECT COUNT(status) as clienteDia FROM agenda WHERE status = 'Concluido' and data = '" + dataAtual + "';", conn);
                    data = command3.ExecuteReader();
                    data.Read();
                    paragrafo.Add("-> | Total de clientes no dia: " + data["clienteDia"].ToString());
                    data.Close();

                    MySqlCommand command1 = new MySqlCommand("SELECT SUM(valor_servico) as dinheiroDia FROM agenda WHERE data = '" + dataAtual + "' and status = 'Concluido';", conn);
                    data = command1.ExecuteReader();
                    data.Read();
                    paragrafo.Add("\n-> | Total Arrecadado no mês: R$ " + float.Parse(data["dinheiroDia"].ToString()));
                    data.Close();

                    doc.Open();
                    doc.Add(tituloDiario);
                    doc.Add(paragrafo);
                    doc.Add(assinatura);
                    doc.Close();

                    MessageBox.Show("Relatório salvo com sucesso ", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Marque pelo menos uma opção para baixar ", "Opção inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message, "Erro com o banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
            
        }


        //****************************************************
        //              CONSULTAS COM O BANCO
        //****************************************************
        private void Relatorio_Load(object sender, EventArgs e)
        {   

            string dataAtual = DateTime.Now.ToString("yyyy-MM-dd");
            string mesAtual = DateTime.Now.ToString("MM");

            // string de conexão com o banco
            string strConn = "server=localhost; port=3306; UID=root; database=banco_sa; pwd=";

            try
            {
               
                MySqlConnection conn = new MySqlConnection(strConn);
                conn.Open();

                //total dinheiro diário
                MySqlCommand command1 = new MySqlCommand("SELECT SUM(valor_servico) as dinheiroDia FROM agenda WHERE data = '" + dataAtual + "' and status = 'Concluido';", conn);
                data = command1.ExecuteReader();
                data.Read();
                string dinheiroDia = data["dinheiroDia"].ToString();
                if (dinheiroDia.Equals("0"))
                {
                    labelGanho1.Text = "R$ 0,00";
                }
                else
                {
                    labelGanho1.Text = "R$ " + dinheiroDia;
                }
                
                data.Close();


                //total dinheiro mensal
                MySqlCommand command2 = new MySqlCommand("SELECT SUM(valor_servico) as dinheiroMes FROM agenda WHERE  data LIKE '%" + mesAtual + "%' and status = 'Concluido';", conn);
                data = command2.ExecuteReader();
                data.Read();
                string dinheiroMes = (data["dinheiroMes"].ToString());
                if (dinheiroMes.Equals("0"))
                {
                    labelGanho2.Text = "R$ 0,00";
                }else
                {
                    labelGanho2.Text = "R$ " + float.Parse(dinheiroMes);
                }
                
                data.Close();

                //total cliente diário
                MySqlCommand command3 = new MySqlCommand("SELECT COUNT(status) as clienteDia FROM agenda WHERE status = 'Concluido' and data = '" + dataAtual + "';", conn);
                data = command3.ExecuteReader();
                data.Read();
                labelClienteDia.Text = data["clienteDia"].ToString() + " clientes";
                data.Close();

                //total cliente mensal
                MySqlCommand command4 = new MySqlCommand("SELECT COUNT(status) as clienteMes FROM agenda WHERE status = 'Concluido' and data LIKE '%" + mesAtual + "%';", conn);
                data = command4.ExecuteReader();
                data.Read();
                labelClienteMes.Text = data["clienteMes"].ToString() + " clientes";
                data.Close();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message, "Erro com o banco", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string dataAtual = DateTime.Now.ToString("yyyy-MM-dd");
            string mesAtual = DateTime.Now.ToString("MM");

            // string de conexão com o banco
            string strConn = "server=localhost; port=3306; UID=root; database=banco_sa; pwd=";

            try
            {
                MySqlConnection conn = new MySqlConnection(strConn);
                conn.Open();

                //total dinheiro diário
                MySqlCommand command1 = new MySqlCommand("SELECT SUM(valor_servico) as dinheiroDia FROM agenda WHERE data = '" + dataAtual + "' and status = 'Concluido';", conn);
                data = command1.ExecuteReader();
                data.Read();
                string dinheiroDia = data["dinheiroDia"].ToString();
                if (dinheiroDia.Equals("0"))
                {
                    labelGanho1.Text = "R$ 0,00";
                }
                else
                {
                    labelGanho1.Text = "R$ " + dinheiroDia;
                }

                data.Close();


                //total dinheiro mensal
                MySqlCommand command2 = new MySqlCommand("SELECT SUM(valor_servico) as dinheiroMes FROM agenda WHERE  data LIKE '%" + mesAtual + "%' and status = 'Concluido';", conn);
                data = command2.ExecuteReader();
                data.Read();
                string dinheiroMes = (data["dinheiroMes"].ToString());
                if (dinheiroMes.Equals("0"))
                {
                    labelGanho2.Text = "R$ 0,00";
                }
                else
                {
                    labelGanho2.Text = "R$ " + float.Parse(dinheiroMes);
                }

                data.Close();

                //total cliente diário
                MySqlCommand command3 = new MySqlCommand("SELECT COUNT(status) as clienteDia FROM agenda WHERE status = 'Concluido' and data = '" + dataAtual + "';", conn);
                data = command3.ExecuteReader();
                data.Read();
                labelClienteDia.Text = data["clienteDia"].ToString() + " clientes";
                data.Close();

                //total cliente mensal
                MySqlCommand command4 = new MySqlCommand("SELECT COUNT(status) as clienteMes FROM agenda WHERE status = 'Concluido' and data LIKE '%" + mesAtual + "%';", conn);
                data = command4.ExecuteReader();
                data.Read();
                labelClienteMes.Text = data["clienteMes"].ToString() + " clientes";
                data.Close();

                conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message, "Erro com o banco", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
