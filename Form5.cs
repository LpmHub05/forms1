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
    public partial class frmProduto : Form
    {
        int valor = 0;

        private DataTable dataTable;
        string sqli = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Desktop\Documents\banco_admin.mdf;Integrated Security=True;Connect Timeout=30";
        public frmProduto()
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
        private void TipoDoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoProduto OutroForm = new frmTipoProduto();
            OutroForm.Show();
            Hide();
        }

        private void btnSairProduto_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrarProduto_Click_1(object sender, EventArgs e)
        {
            btnSalvarProduto.Enabled = true;
            txtNomeProduto.Enabled = true;
            txtQuantidadeProduto.Enabled = true;
            cboTipoProduto.Enabled = true;
            btnCadastrarProduto.Enabled = false;
            btnBuscarProduto.Enabled = false;
            btnLimparProduto.Enabled = false;
            btnRemoverProduto.Enabled = false;
            btnAlterarProduto.Enabled = false;
            btnImprimirProduto.Enabled = false;
            btnAnteriorProduto.Enabled = false;
            btnPosteriorProduto.Enabled = false;
            btnPrimeiroProduto.Enabled = false;
            btnUltimoProduto.Enabled = false;
            cadastrarToolStripMenuItem.Enabled = false;
            removerToolStripMenuItem.Enabled = false;
            buscarToolStripMenuItem.Enabled = false;
            alterarToolStripMenuItem.Enabled = false;
            RelatorioProdutoToolStripMenuItem.Enabled = false;
            salvarToolStripMenuItem.Enabled = false;
            limparToolStripMenuItem.Enabled = false;



            string id = "SELECT ISNULL(MAX(id_Produto), 0) + 1 FROM Produto";

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
                        txtCodigoProduto.Text = proximoID.ToString();
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

        private void btnSalvarProduto_Click_1(object sender, EventArgs e)
        {
            btnSalvarProduto.Enabled = false;
            txtNomeProduto.Enabled = false;
            txtQuantidadeProduto.Enabled = false;
            cboTipoProduto.Enabled = false;
            btnCadastrarProduto.Enabled = true;
            btnBuscarProduto.Enabled = true;
            btnLimparProduto.Enabled = true;
            btnRemoverProduto.Enabled = true;
            btnAlterarProduto.Enabled = true;
            btnImprimirProduto.Enabled = true;
            btnAnteriorProduto.Enabled = false;
            btnPosteriorProduto.Enabled = false;
            btnPrimeiroProduto.Enabled = false;
            btnUltimoProduto.Enabled = false;
            cadastrarToolStripMenuItem.Enabled = true;
            removerToolStripMenuItem.Enabled = true;
            buscarToolStripMenuItem.Enabled = true;
            alterarToolStripMenuItem.Enabled = true;
            RelatorioProdutoToolStripMenuItem.Enabled = true;
            salvarToolStripMenuItem.Enabled = true;
            limparToolStripMenuItem.Enabled = true;


            string nome = txtNomeProduto.Text;
            string quantidade = txtQuantidadeProduto.Text;
            string tipo = cboTipoProduto.Text;
            string descricao = txtDescricaoProduto.Text;


            string sql = "INSERT INTO Produto(nm_Produto, qt_Produto, tp_Produto, ds_Produto) VALUES(@nome, @quantidade, @tipo, @descricao)";

            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                SqlCommand cmd = new SqlCommand(sql, conexao);


                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@quantidade", quantidade);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@descricao", descricao);


                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro inserido com sucesso!");
                    txtNomeProduto.Text = "";
                    txtQuantidadeProduto.Text = "";
                    cboTipoProduto.Text = "";
                    txtDescricaoProduto.Text = "";
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

        private void btnAnteriorProduto_Click_1(object sender, EventArgs e)
        {
            valor++;

            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string idmin = " SELECT CASE WHEN ISNULL(MAX(id_Produto), 0) - @valor < 0 THEN 0 ELSE ISNULL(MAX(id_Produto), 0) - @valor END AS idmin FROM Produto;";
                SqlCommand pesq = new SqlCommand(idmin, conexao);
                pesq.Parameters.AddWithValue("@valor", valor);

                try
                {
                    conexao.Open();
                    object result = pesq.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {


                        int proximoID = Convert.ToInt32(result);
                        txtCodigoProduto.Text = proximoID.ToString();

                        string sql = "SELECT nm_Produto, qt_Produto, tp_Produto, ds_Produto FROM Produto WHERE id_Produto = @id";
                        SqlCommand cmd = new SqlCommand(sql, conexao);
                        cmd.Parameters.AddWithValue("@id", proximoID);


                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtNomeProduto.Text = reader["nm_Produto"].ToString();
                            txtQuantidadeProduto.Text = reader["qt_Produto"].ToString();
                            cboTipoProduto.Text = reader["tp_Produto"].ToString();
                            txtDescricaoProduto.Text = reader["ds_Produto"].ToString();
                        }
                        else
                        {
                            proximoID = 1;
                            cmd.Parameters.AddWithValue("@id", proximoID);

                            txtCodigoProduto.Text = proximoID.ToString();
                            txtNomeProduto.Text = "";
                            txtQuantidadeProduto.Text = "";
                            cboTipoProduto.Text = "";
                            txtDescricaoProduto.Text = "";
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

        private void btnPosteriorProduto_Click_1(object sender, EventArgs e)
        {
            valor--;

            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string idmin = " SELECT CASE WHEN ISNULL(MAX(id_Produto), 0) - @valor < 0 THEN 0 ELSE ISNULL(MAX(id_Produto), 0) - @valor END AS idmin FROM Produto;";
                SqlCommand pesq = new SqlCommand(idmin, conexao);
                pesq.Parameters.AddWithValue("@valor", valor);

                try
                {
                    conexao.Open();
                    object result = pesq.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int proximoID = Convert.ToInt32(result);
                        txtCodigoProduto.Text = proximoID.ToString();

                        string sql = "SELECT nm_Produto, qt_Produto, tp_Produto, ds_Produto FROM Produto WHERE id_Produto = @id";
                        SqlCommand cmd = new SqlCommand(sql, conexao);
                        cmd.Parameters.AddWithValue("@id", proximoID);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtNomeProduto.Text = reader["nm_Produto"].ToString();
                            txtQuantidadeProduto.Text = reader["qt_Produto"].ToString();
                            cboTipoProduto.Text = reader["tp_Produto"].ToString();
                            txtDescricaoProduto.Text = reader["ds_Produto"].ToString();
                        }
                        else

                        {
                            proximoID = 1;
                            MessageBox.Show("Nenhum registro encontrado ou valor nulo.");
                            txtNomeProduto.Text = "";
                            txtQuantidadeProduto.Text = "";
                            cboTipoProduto.Text = "";
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

        private void btnPrimeiroProduto_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string sql = "SELECT TOP 1 id_Produto, nm_Produto, qt_Produto, tp_Produto, ds_Produto FROM Produto ORDER BY id_Produto ASC";
                SqlCommand cmd = new SqlCommand(sql, conexao);

                try
                {
                    conexao.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtCodigoProduto.Text = reader["id_Produto"].ToString();
                        txtNomeProduto.Text = reader["nm_Produto"].ToString();
                        txtQuantidadeProduto.Text = reader["qt_Produto"].ToString();
                        cboTipoProduto.Text = reader["tp_Produto"].ToString();
                        txtDescricaoProduto.Text = reader["ds_Produto"].ToString();

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

        private void btnUltimoProduto_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string sql = "SELECT TOP 1 id_Produto, nm_Produto, qt_Produto, tp_Produto, ds_Produto FROM Produto ORDER BY id_Produto DESC";
                SqlCommand cmd = new SqlCommand(sql, conexao);

                try
                {
                    conexao.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtCodigoProduto.Text = reader["id_Produto"].ToString();
                        txtNomeProduto.Text = reader["nm_Produto"].ToString();
                        txtQuantidadeProduto.Text = reader["qt_Produto"].ToString();
                        cboTipoProduto.Text = reader["tp_Produto"].ToString();
                        txtDescricaoProduto.Text = reader["ds_Produto"].ToString();

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

        private void btnBuscarProduto_Click_1(object sender, EventArgs e)
        {
            btnAnteriorProduto.Enabled = true;
            btnPosteriorProduto.Enabled = true;
            btnPrimeiroProduto.Enabled = true;
            btnUltimoProduto.Enabled = true;
            btnBuscarProduto.Enabled = false;
        }
    }
}
