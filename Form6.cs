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
    public partial class frmTipoProduto : Form
    {
        int valor = 0;

        private DataTable dataTable;
        string sqli = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Desktop\Documents\banco_admin.mdf;Integrated Security=True;Connect Timeout=30";
        public frmTipoProduto()
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
        private void manutencaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManutencao OutroForm = new frmManutencao();
            OutroForm.Show();
            Hide();
        }
        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorico OutroForm = new frmHistorico();
            OutroForm.Show();
            Hide();
        }
        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoProduto OutroForm = new frmTipoProduto();
            OutroForm.Show();
            Hide();
        }

        private void btnSairTipoProduto_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrarTipoProduto_Click_1(object sender, EventArgs e)
        {
            btnSalvarTipoProduto.Enabled = true;
            txtMarcaTipoProduto.Enabled = true;
            txtModeloTipoProduto.Enabled = true;
            btnCadastrarTipoProduto.Enabled = false;
            btnBuscarTipoProduto.Enabled = false;
            btnLimparTipoProduto.Enabled = false;
            btnRemoverTipoProduto.Enabled = false;
            btnAlterarTipoProduto.Enabled = false;
            btnImprimirTipoProduto.Enabled = false;
            btnAnteriorTipoProduto.Enabled = false;
            btnPosteriorTipoProduto.Enabled = false;
            btnPrimeiroTipoProduto.Enabled = false;
            btnUltimoTipoProduto.Enabled = false;
            cadastrarToolStripMenuItem.Enabled = false;
            removerToolStripMenuItem.Enabled = false;
            buscarToolStripMenuItem.Enabled = false;
            alterarToolStripMenuItem.Enabled = false;
            RelatorioTipoProdutoToolStripMenuItem.Enabled = false;
            salvarToolStripMenuItem.Enabled = false;
            limparToolStripMenuItem.Enabled = false;



            string id = "SELECT ISNULL(MAX(id_TipoProduto), 0) + 1 FROM TipoProduto";

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
                        txtCodigoTipoProduto.Text = proximoID.ToString();
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

        private void btnSalvarTipoProduto_Click_1(object sender, EventArgs e)
        {
            btnSalvarTipoProduto.Enabled = false;
            txtMarcaTipoProduto.Enabled = false;
            txtModeloTipoProduto.Enabled = false;
            btnCadastrarTipoProduto.Enabled = true;
            btnBuscarTipoProduto.Enabled = true;
            btnLimparTipoProduto.Enabled = true;
            btnRemoverTipoProduto.Enabled = true;
            btnAlterarTipoProduto.Enabled = true;
            btnImprimirTipoProduto.Enabled = true;
            btnAnteriorTipoProduto.Enabled = false;
            btnPosteriorTipoProduto.Enabled = false;
            btnPrimeiroTipoProduto.Enabled = false;
            btnUltimoTipoProduto.Enabled = false;
            cadastrarToolStripMenuItem.Enabled = true;
            removerToolStripMenuItem.Enabled = true;
            buscarToolStripMenuItem.Enabled = true;
            alterarToolStripMenuItem.Enabled = true;
            RelatorioTipoProdutoToolStripMenuItem.Enabled = true;
            salvarToolStripMenuItem.Enabled = true;
            limparToolStripMenuItem.Enabled = true;


            string marca = txtMarcaTipoProduto.Text;
            string modelo = txtModeloTipoProduto.Text;


            string sql = "INSERT INTO TipoProduto(marca_Produto, modelo_Produto) VALUES(@marca, @modelo)";

            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                SqlCommand cmd = new SqlCommand(sql, conexao);


                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@modelo", modelo);


                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro inserido com sucesso!");
                    txtMarcaTipoProduto.Text = "";
                    txtModeloTipoProduto.Text = "";
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

        private void btnAnteriorTipoProduto_Click_1(object sender, EventArgs e)
        {
            valor++;

            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string idmin = " SELECT CASE WHEN ISNULL(MAX(id_TipoProduto), 0) - @valor < 0 THEN 0 ELSE ISNULL(MAX(id_TipoProduto), 0) - @valor END AS idmin FROM TipoProduto;";
                SqlCommand pesq = new SqlCommand(idmin, conexao);
                pesq.Parameters.AddWithValue("@valor", valor);

                try
                {
                    conexao.Open();
                    object result = pesq.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {


                        int proximoID = Convert.ToInt32(result);
                        txtCodigoTipoProduto.Text = proximoID.ToString();

                        string sql = "SELECT marca_Produto, modelo_Produto FROM TipoProduto WHERE id_TipoProduto = @id";
                        SqlCommand cmd = new SqlCommand(sql, conexao);
                        cmd.Parameters.AddWithValue("@id", proximoID);


                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtMarcaTipoProduto.Text = reader["marca_Produto"].ToString();
                            txtModeloTipoProduto.Text = reader["modelo_Produto"].ToString();
                        }
                        else
                        {
                            proximoID = 1;
                            cmd.Parameters.AddWithValue("@id", proximoID);

                            txtCodigoTipoProduto.Text = proximoID.ToString();
                            txtMarcaTipoProduto.Text = "";
                            txtModeloTipoProduto.Text = "";
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

        private void btnPosteriorTipoProduto_Click_1(object sender, EventArgs e)
        {
            valor--;

            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string idmin = " SELECT CASE WHEN ISNULL(MAX(id_TipoProduto), 0) - @valor < 0 THEN 0 ELSE ISNULL(MAX(id_TipoProduto), 0) - @valor END AS idmin FROM TipoProduto;";
                SqlCommand pesq = new SqlCommand(idmin, conexao);
                pesq.Parameters.AddWithValue("@valor", valor);

                try
                {
                    conexao.Open();
                    object result = pesq.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int proximoID = Convert.ToInt32(result);
                        txtCodigoTipoProduto.Text = proximoID.ToString();

                        string sql = "SELECT marca_Produto, modelo_Produto FROM TipoProduto WHERE id_TipoProduto = @id";
                        SqlCommand cmd = new SqlCommand(sql, conexao);
                        cmd.Parameters.AddWithValue("@id", proximoID);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtMarcaTipoProduto.Text = reader["marca_Produto"].ToString();
                            txtModeloTipoProduto.Text = reader["modelo_Produto"].ToString();
                        }
                        else

                        {
                            proximoID = 1;
                            MessageBox.Show("Nenhum registro encontrado ou valor nulo.");
                            txtMarcaTipoProduto.Text = "";
                            txtModeloTipoProduto.Text = "";
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

        private void btnPrimeiroTipoProduto_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string sql = "SELECT TOP 1 id_TipoProduto, marca_Produto, modelo_Produto FROM TipoProduto ORDER BY id_TipoProduto ASC";
                SqlCommand cmd = new SqlCommand(sql, conexao);

                try
                {
                    conexao.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtCodigoTipoProduto.Text = reader["id_TipoProduto"].ToString();
                        txtMarcaTipoProduto.Text = reader["marca_Produto"].ToString();
                        txtModeloTipoProduto.Text = reader["modelo_Produto"].ToString();

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

        private void btnUltimoTipoProduto_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string sql = "SELECT TOP 1 id_TipoProduto, marca_Produto, modelo_Produto FROM TipoProduto ORDER BY id_TipoProduto DESC";
                SqlCommand cmd = new SqlCommand(sql, conexao);

                try
                {
                    conexao.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtCodigoTipoProduto.Text = reader["id_TipoProduto"].ToString();
                        txtMarcaTipoProduto.Text = reader["marca_Produto"].ToString();
                        txtModeloTipoProduto.Text = reader["modelo_Produto"].ToString();

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

        private void btnBuscarTipoProduto_Click_1(object sender, EventArgs e)
        {
            btnAnteriorTipoProduto.Enabled = true;
            btnPosteriorTipoProduto.Enabled = true;
            btnPrimeiroTipoProduto.Enabled = true;
            btnUltimoTipoProduto.Enabled = true;
            btnBuscarTipoProduto.Enabled = false;
        }
    }
}
