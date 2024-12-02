using Google.Protobuf.WellKnownTypes;
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
    public partial class frmAluguel : Form
    {
        int valor = 0;

        private DataTable dataTable;
        string sqli = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Desktop\Documents\banco_admin.mdf;Integrated Security=True;Connect Timeout=30";
        public frmAluguel()
        {
            InitializeComponent();
        }
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente OutroForm = new frmCliente();
            OutroForm.Show();
            Hide();
        }
        private void ManutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManutencao OutroForm = new frmManutencao();
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
        private void btnSairAluguel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrarAluguel_Click_1(object sender, EventArgs e)
        {
            btnSalvarAluguel.Enabled = true;
            txtNomeAluguel.Enabled = true;
            txtDataAluguel.Enabled = true;
            txtDataDevoluçãoAluguel.Enabled = true;
            txtValorAluguel.Enabled = true;
            txtDescriçãoProdutoAluguel.Enabled = true;
            btnCadastrarAluguel.Enabled = false;
            btnBuscarAluguel.Enabled = false;
            btnLimparAluguel.Enabled = false;
            btnRemoverAluguel.Enabled = false;
            btnAlterarAluguel.Enabled = false;
            btnImprimirAluguel.Enabled = false;
            btnAnteriorAluguel.Enabled = false;
            btnPosteriorAluguel.Enabled = false;
            btnPrimeiroAluguel.Enabled = false;
            btnUltimoAluguel.Enabled = false;
            cadastrarToolStripMenuItem.Enabled = false;
            removerToolStripMenuItem.Enabled = false;
            buscarToolStripMenuItem.Enabled = false;
            alterarToolStripMenuItem.Enabled = false;
            RelatorioAluguelToolStripMenuItem.Enabled = false;
            salvarToolStripMenuItem.Enabled = false;
            limparToolStripMenuItem.Enabled = false;



            string id = "SELECT ISNULL(MAX(id_Aluguel), 0) + 1 FROM Aluguel";

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
                        txtCodigoAluguel.Text = proximoID.ToString();
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

        private void btnSalvarAluguel_Click_1(object sender, EventArgs e)
        {
            btnSalvarAluguel.Enabled = false;
            txtNomeAluguel.Enabled = false;
            txtDataAluguel.Enabled = false;
            txtDataDevoluçãoAluguel.Enabled = false;
            txtValorAluguel.Enabled = false;
            txtDescriçãoProdutoAluguel.Enabled = false;
            btnCadastrarAluguel.Enabled = true;
            btnBuscarAluguel.Enabled = true;
            btnLimparAluguel.Enabled = true;
            btnRemoverAluguel.Enabled = true;
            btnAlterarAluguel.Enabled = true;
            btnImprimirAluguel.Enabled = true;
            btnAnteriorAluguel.Enabled = false;
            btnPosteriorAluguel.Enabled = false;
            btnPrimeiroAluguel.Enabled = false;
            btnUltimoAluguel.Enabled = false;
            cadastrarToolStripMenuItem.Enabled = true;
            removerToolStripMenuItem.Enabled = true;
            buscarToolStripMenuItem.Enabled = true;
            alterarToolStripMenuItem.Enabled = true;
            RelatorioAluguelToolStripMenuItem.Enabled = true;
            salvarToolStripMenuItem.Enabled = true;
            limparToolStripMenuItem.Enabled = true;


            string nome = txtNomeAluguel.Text;
            string data = txtDataAluguel.Text;
            string devolucao = txtDataDevoluçãoAluguel.Text;
            string valor = txtValorAluguel.Text;
            string descricao = txtDescriçãoProdutoAluguel.Text;


            string sql = "INSERT INTO Aluguel(nm_Produto_Aluguel, dt_Aluguel, dt_Devolucao_Aluguel, vl_Aluguel, ds_Produto_Aluguel) VALUES(@nome, @data, @devolucao, @valor, @descricao)";

            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                SqlCommand cmd = new SqlCommand(sql, conexao);


                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@data", data);
                cmd.Parameters.AddWithValue("@devolucao", devolucao);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.Parameters.AddWithValue("@descricao", descricao);


                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro inserido com sucesso!");
                    txtNomeAluguel.Text = "";
                    txtDataAluguel.Text = "";
                    txtDataDevoluçãoAluguel.Text = "";
                    txtValorAluguel.Text = "";
                    txtDescriçãoProdutoAluguel.Text = "";
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

        private void btnAnteriorAluguel_Click_1(object sender, EventArgs e)
        {
            valor++;

            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string idmin = " SELECT CASE WHEN ISNULL(MAX(id_Aluguel), 0) - @valor < 0 THEN 0 ELSE ISNULL(MAX(id_Aluguel), 0) - @valor END AS idmin FROM Aluguel;";
                SqlCommand pesq = new SqlCommand(idmin, conexao);
                pesq.Parameters.AddWithValue("@valor", valor);

                try
                {
                    conexao.Open();
                    object result = pesq.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {


                        int proximoID = Convert.ToInt32(result);
                        txtCodigoAluguel.Text = proximoID.ToString();

                        string sql = "SELECT nm_Produto_Aluguel, dt_Aluguel, dt_Devolucao_Aluguel, vl_Aluguel, ds_Produto_Aluguel FROM Aluguel WHERE id_Aluguel = @id";
                        SqlCommand cmd = new SqlCommand(sql, conexao);
                        cmd.Parameters.AddWithValue("@id", proximoID);


                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtNomeAluguel.Text = reader["nm_Produto_Aluguel"].ToString();
                            txtDataAluguel.Text = reader["dt_Aluguel"].ToString();
                            txtDataDevoluçãoAluguel.Text = reader["dt_Devolucao_Aluguel"].ToString();
                            txtValorAluguel.Text = reader["vl_Aluguel"].ToString();
                            txtDescriçãoProdutoAluguel.Text = reader["ds_Produto_Aluguel"].ToString();
                        }
                        else
                        {
                            proximoID = 1;
                            cmd.Parameters.AddWithValue("@id", proximoID);

                            txtCodigoAluguel.Text = proximoID.ToString();
                            txtNomeAluguel.Text = "";
                            txtDataAluguel.Text = "";
                            txtDataDevoluçãoAluguel.Text = "";
                            txtValorAluguel.Text = "";
                            txtDescriçãoProdutoAluguel.Text = "";
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

        private void btnPosteriorAluguel_Click_1(object sender, EventArgs e)
        {
            valor--;

            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string idmin = " SELECT CASE WHEN ISNULL(MAX(id_Aluguel), 0) - @valor < 0 THEN 0 ELSE ISNULL(MAX(id_Aluguel), 0) - @valor END AS idmin FROM Aluguel;";
                SqlCommand pesq = new SqlCommand(idmin, conexao);
                pesq.Parameters.AddWithValue("@valor", valor);

                try
                {
                    conexao.Open();
                    object result = pesq.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int proximoID = Convert.ToInt32(result);
                        txtCodigoAluguel.Text = proximoID.ToString();

                        string sql = "SELECT nm_Produto_Aluguel, dt_Aluguel, dt_Devolucao_Aluguel, vl_Aluguel, ds_Produto_Aluguel FROM Aluguel WHERE id_Aluguel = @id";
                        SqlCommand cmd = new SqlCommand(sql, conexao);
                        cmd.Parameters.AddWithValue("@id", proximoID);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtNomeAluguel.Text = reader["nm_Produto_Aluguel"].ToString();
                            txtDataAluguel.Text = reader["dt_Aluguel"].ToString();
                            txtDataDevoluçãoAluguel.Text = reader["dt_Devolucao_Aluguel"].ToString();
                            txtValorAluguel.Text = reader["vl_Aluguel"].ToString();
                            txtDescriçãoProdutoAluguel.Text = reader["ds_Produto_Aluguel"].ToString();
                        }
                        else

                        {
                            proximoID = 1;
                            MessageBox.Show("Nenhum registro encontrado ou valor nulo.");
                            txtNomeAluguel.Text = "";
                            txtDataAluguel.Text = "";
                            txtDataDevoluçãoAluguel.Text = "";
                            txtValorAluguel.Text = "";
                            txtDescriçãoProdutoAluguel.Text = "";
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

        private void btnPrimeiroAluguel_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string sql = "SELECT TOP 1 id_Aluguel, nm_Produto_Aluguel, dt_Aluguel, dt_Devolucao_Aluguel, vl_Aluguel, ds_Produto_Aluguel FROM Aluguel ORDER BY id_Aluguel ASC";
                SqlCommand cmd = new SqlCommand(sql, conexao);

                try
                {
                    conexao.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtCodigoAluguel.Text = reader["id_Aluguel"].ToString();
                        txtNomeAluguel.Text = reader["nm_Produto_Aluguel"].ToString();
                        txtDataAluguel.Text = reader["dt_Aluguel"].ToString();
                        txtDataDevoluçãoAluguel.Text = reader["dt_Devolucao_Aluguel"].ToString();
                        txtValorAluguel.Text = reader["vl_Aluguel"].ToString();
                        txtDescriçãoProdutoAluguel.Text = reader["ds_Produto_Aluguel"].ToString();

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

        private void btnUltimoAluguel_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string sql = "SELECT TOP 1 id_Aluguel, nm_Produto_Aluguel, dt_Aluguel, dt_Devolucao_Aluguel, vl_Aluguel, ds_Produto_Aluguel FROM Aluguel ORDER BY id_Aluguel DESC";
                SqlCommand cmd = new SqlCommand(sql, conexao);

                try
                {
                    conexao.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtCodigoAluguel.Text = reader["id_Aluguel"].ToString();
                        txtNomeAluguel.Text = reader["nm_Produto_Aluguel"].ToString();
                        txtDataAluguel.Text = reader["dt_Aluguel"].ToString();
                        txtDataDevoluçãoAluguel.Text = reader["dt_Devolucao_Aluguel"].ToString();
                        txtValorAluguel.Text = reader["vl_Aluguel"].ToString();
                        txtDescriçãoProdutoAluguel.Text = reader["ds_Produto_Aluguel"].ToString();

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

        private void btnBuscarAluguel_Click_1(object sender, EventArgs e)
        {
            btnAnteriorAluguel.Enabled = true;
            btnPosteriorAluguel.Enabled = true;
            btnPrimeiroAluguel.Enabled = true;
            btnUltimoAluguel.Enabled = true;
            btnBuscarAluguel.Enabled = false;
        }
    }
}