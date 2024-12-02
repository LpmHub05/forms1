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

namespace forms1
{
    public partial class frmManutencao : Form
    {
        int valor = 0;

        private DataTable dataTable;
        string sqli = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Desktop\Documents\banco_admin.mdf;Integrated Security=True;Connect Timeout=30";
        public frmManutencao()
        {
            InitializeComponent();
        }
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente OutroForm = new frmCliente();
            OutroForm.Show();
            Hide();
        }
        private void aluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAluguel OutroForm = new frmAluguel();
            OutroForm.Show();
            Hide();
        }
        private void HistóricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorico OutroForm = new frmHistorico();
            OutroForm.Show();
            Hide();
        }
        private void ProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto OutroForm = new frmProduto();
            OutroForm.Show();
            Hide();
        }
        private void TipoDoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoProduto OutroForm = new frmTipoProduto();
            OutroForm.Show();
            Hide();
        }

        private void btnSairManutencao_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrarManutencao_Click_1(object sender, EventArgs e)
        {
            btnSalvarManutencao.Enabled = true;
            txtNomeFuncionarioManutencao.Enabled = true;
            txtNomeProdutoManutencao.Enabled = true;
            txtDataManutencao.Enabled = true;
            btnCadastrarManutencao.Enabled = false;
            btnBuscarManutencao.Enabled = false;
            btnLimparManutencao.Enabled = false;
            btnRemoverManutencao.Enabled = false;
            btnAlterarManutencao.Enabled = false;
            btnImprimirManutencao.Enabled = false;
            btnAnteriorManutencao.Enabled = false;
            btnPosteriorManutencao.Enabled = false;
            btnPrimeiroManutencao.Enabled = false;
            btnUltimoManutencao.Enabled = false;
            cadastrarToolStripMenuItem.Enabled = false;
            removerToolStripMenuItem.Enabled = false;
            buscarToolStripMenuItem.Enabled = false;
            alterarToolStripMenuItem.Enabled = false;
            RelatorioManutencaoToolStripMenuItem.Enabled = false;
            salvarToolStripMenuItem.Enabled = false;
            limparToolStripMenuItem.Enabled = false;



            string id = "SELECT ISNULL(MAX(id_Manutencao), 0) + 1 FROM Manutencao";

            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                SqlCommand pesq = new SqlCommand(id, conexao);
                try
                {
                    conexao.Open();
                    object result = pesq.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int proximoID = Convert.ToInt32(result);
                        txtCodigoManutencao.Text = proximoID.ToString();
                        MessageBox.Show("ID encontrado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado ou valor nulo.");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir registro: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void btnSalvarManutencao_Click_1(object sender, EventArgs e)
        {
            btnSalvarManutencao.Enabled = false;
            txtNomeFuncionarioManutencao.Enabled = false;
            txtNomeProdutoManutencao.Enabled = false;
            txtDataManutencao.Enabled = false;
            btnCadastrarManutencao.Enabled = true;
            btnBuscarManutencao.Enabled = true;
            btnLimparManutencao.Enabled = true;
            btnRemoverManutencao.Enabled = true;
            btnAlterarManutencao.Enabled = true;
            btnImprimirManutencao.Enabled = true;
            btnAnteriorManutencao.Enabled = false;
            btnPosteriorManutencao.Enabled = false;
            btnPrimeiroManutencao.Enabled = false;
            btnUltimoManutencao.Enabled = false;
            cadastrarToolStripMenuItem.Enabled = true;
            removerToolStripMenuItem.Enabled = true;
            buscarToolStripMenuItem.Enabled = true;
            alterarToolStripMenuItem.Enabled = true;
            RelatorioManutencaoToolStripMenuItem.Enabled = true;
            salvarToolStripMenuItem.Enabled = true;
            limparToolStripMenuItem.Enabled = true;


            string funcionario = txtNomeFuncionarioManutencao.Text;
            string produto = txtNomeProdutoManutencao.Text;
            string data = txtDataManutencao.Text;


            string sql = "INSERT INTO Manutencao(nm_Funcionario_Manutencao, nm_Produto, dt_Manutencao) VALUES(@funcionario, @produto, @data)";

            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                SqlCommand cmd = new SqlCommand(sql, conexao);


                cmd.Parameters.AddWithValue("@funcionario", funcionario);
                cmd.Parameters.AddWithValue("@produto", produto);
                cmd.Parameters.AddWithValue("@data", data);


                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro inserido com sucesso!");
                    txtNomeFuncionarioManutencao.Text = "";
                    txtNomeProdutoManutencao.Text = "";
                    txtDataManutencao.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir registro: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void btnAnteriorManutencao_Click_1(object sender, EventArgs e)
        {
            valor++;

            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string idmin = " SELECT CASE WHEN ISNULL(MAX(id_Manutencao), 0) - @valor < 0 THEN 0 ELSE ISNULL(MAX(id_Manutencao), 0) - @valor END AS idmin FROM Manutencao;";
                SqlCommand pesq = new SqlCommand(idmin, conexao);
                pesq.Parameters.AddWithValue("@valor", valor);

                try
                {
                    conexao.Open();
                    object result = pesq.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {


                        int proximoID = Convert.ToInt32(result);
                        txtCodigoManutencao.Text = proximoID.ToString();

                        string sql = "SELECT nm_Funcionario_Manutencao, nm_Produto, dt_Manutencao FROM Manutencao WHERE id_Manutencao = @id";
                        SqlCommand cmd = new SqlCommand(sql, conexao);
                        cmd.Parameters.AddWithValue("@id", proximoID);


                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtNomeFuncionarioManutencao.Text = reader["nm_Funcionario_Manutencao"].ToString();
                            txtNomeProdutoManutencao.Text = reader["nm_Produto"].ToString();
                            txtDataManutencao.Text = reader["dt_Manutencao"].ToString();
                        }
                        else
                        {
                            proximoID = 1;
                            cmd.Parameters.AddWithValue("@id", proximoID);

                            txtCodigoManutencao.Text = proximoID.ToString();
                            txtNomeFuncionarioManutencao.Text = "";
                            txtNomeProdutoManutencao.Text = "";
                            txtDataManutencao.Text = "";
                        }
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado ou valor nulo.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar registro: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void btnPosteriorManutencao_Click_1(object sender, EventArgs e)
        {
            valor--;

            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string idmin = " SELECT CASE WHEN ISNULL(MAX(id_Manutencao), 0) - @valor < 0 THEN 0 ELSE ISNULL(MAX(id_Manutencao), 0) - @valor END AS idmin FROM Manutencao;";
                SqlCommand pesq = new SqlCommand(idmin, conexao);
                pesq.Parameters.AddWithValue("@valor", valor);

                try
                {
                    conexao.Open();
                    object result = pesq.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int proximoID = Convert.ToInt32(result);
                        txtCodigoManutencao.Text = proximoID.ToString();

                        string sql = "SELECT nm_Funcionario_Manutencao, nm_Produto, dt_Manutencao FROM Manutencao WHERE id_Manutencao = @id";
                        SqlCommand cmd = new SqlCommand(sql, conexao);
                        cmd.Parameters.AddWithValue("@id", proximoID);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtNomeFuncionarioManutencao.Text = reader["nm_Funcionario_Manutencao"].ToString();
                            txtNomeProdutoManutencao.Text = reader["nm_Produto"].ToString();
                            txtDataManutencao.Text = reader["dt_Manutencao"].ToString();
                        }
                        else

                        {
                            proximoID = 1;
                            MessageBox.Show("Nenhum registro encontrado ou valor nulo.");
                            txtNomeFuncionarioManutencao.Text = "";
                            txtNomeProdutoManutencao.Text = "";
                            txtDataManutencao.Text = "";
                        }
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado ou valor nulo.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar registro: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void btnPrimeiroManutencao_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string sql = "SELECT TOP 1 id_Manutencao, nm_Funcionario_Manutencao, nm_Produto, dt_Manutencao FROM Manutencao ORDER BY id_Manutencao ASC";
                SqlCommand cmd = new SqlCommand(sql, conexao);

                try
                {
                    conexao.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtCodigoManutencao.Text = reader["id_Manutencao"].ToString();
                        txtNomeFuncionarioManutencao.Text = reader["nm_Funcionario_Manutencao"].ToString();
                        txtNomeProdutoManutencao.Text = reader["nm_Produto"].ToString();
                        txtDataManutencao.Text = reader["dt_Manutencao"].ToString();

                        MessageBox.Show("Registro encontrado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar registro: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void btnUltimoManutencao_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string sql = "SELECT TOP 1 id_Manutencao, nm_Funcionario_Manutencao, nm_Produto, dt_Manutencao FROM Manutencao ORDER BY id_Manutencao DESC";
                SqlCommand cmd = new SqlCommand(sql, conexao);

                try
                {
                    conexao.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtCodigoManutencao.Text = reader["id_Manutencao"].ToString();
                        txtNomeFuncionarioManutencao.Text = reader["nm_Funcionario_Manutencao"].ToString();
                        txtNomeProdutoManutencao.Text = reader["nm_Produto"].ToString();
                        txtDataManutencao.Text = reader["dt_Manutencao"].ToString();

                        MessageBox.Show("Registro encontrado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar registro: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void btnBuscarManutencao_Click_1(object sender, EventArgs e)
        {
            btnAnteriorManutencao.Enabled = true;
            btnPosteriorManutencao.Enabled = true;
            btnPrimeiroManutencao.Enabled = true;
            btnUltimoManutencao.Enabled = true;
            btnBuscarManutencao.Enabled = false;
        }
    }
}
