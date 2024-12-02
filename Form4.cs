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
    public partial class frmHistorico : Form
    {
        int valor = 0;

        private DataTable dataTable;
        string sqli = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Desktop\Documents\banco_admin.mdf;Integrated Security=True;Connect Timeout=30";
        public frmHistorico()
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

        private void btnSairHistorico_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrarHistorico_Click_1(object sender, EventArgs e)
        {
            btnSalvarHistorico.Enabled = true;
            txtNomeClienteHistorico.Enabled = true;
            txtDataEntradaHistorico.Enabled = true;
            txtDataSaidaHistorico.Enabled = true;
            txtTipoDispositivoHistorico.Enabled = true;
            btnCadastrarHistorico.Enabled = false;
            btnBuscarHistorico.Enabled = false;
            btnLimparHistorico.Enabled = false;
            btnRemoverHistorico.Enabled = false;
            btnAlterarHistorico.Enabled = false;
            btnImprimirHistorico.Enabled = false;
            btnAnteriorHistorico.Enabled = false;
            btnPosteriorHistorico.Enabled = false;
            btnPrimeiroHistorico.Enabled = false;
            btnUltimoHistorico.Enabled = false;
            cadastrarToolStripMenuItem.Enabled = false;
            removerToolStripMenuItem.Enabled = false;
            buscarToolStripMenuItem.Enabled = false;
            alterarToolStripMenuItem.Enabled = false;
            RelatorioHistoricoToolStripMenuItem.Enabled = false;
            salvarToolStripMenuItem.Enabled = false;
            limparToolStripMenuItem.Enabled = false;



            string id = "SELECT ISNULL(MAX(id_Historico), 0) + 1 FROM Historico";

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
                        txtCodigoHistorico.Text = proximoID.ToString();
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

        private void btnSalvarHistorico_Click_1(object sender, EventArgs e)
        {
            btnSalvarHistorico.Enabled = false;
            txtNomeClienteHistorico.Enabled = false;
            txtDataEntradaHistorico.Enabled = false;
            txtDataSaidaHistorico.Enabled = false;
            txtTipoDispositivoHistorico.Enabled = false;
            btnCadastrarHistorico.Enabled = true;
            btnBuscarHistorico.Enabled = true;
            btnLimparHistorico.Enabled = true;
            btnRemoverHistorico.Enabled = true;
            btnAlterarHistorico.Enabled = true;
            btnImprimirHistorico.Enabled = true;
            btnAnteriorHistorico.Enabled = false;
            btnPosteriorHistorico.Enabled = false;
            btnPrimeiroHistorico.Enabled = false;
            btnUltimoHistorico.Enabled = false;
            cadastrarToolStripMenuItem.Enabled = true;
            removerToolStripMenuItem.Enabled = true;
            buscarToolStripMenuItem.Enabled = true;
            alterarToolStripMenuItem.Enabled = true;
            RelatorioHistoricoToolStripMenuItem.Enabled = true;
            salvarToolStripMenuItem.Enabled = true;
            limparToolStripMenuItem.Enabled = true;


            string cliente = txtNomeClienteHistorico.Text;
            string entrada = txtDataEntradaHistorico.Text;
            string saida = txtDataSaidaHistorico.Text;
            string dispositivo = txtTipoDispositivoHistorico.Text;


            string sql = "INSERT INTO Historico(nm_Cliente, dt_Entrada_Historico, dt_Saida_Historico, tp_Dispositivo) VALUES(@cliente, @entrada, @saida, @dispositivo)";

            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                SqlCommand cmd = new SqlCommand(sql, conexao);


                cmd.Parameters.AddWithValue("@cliente", cliente);
                cmd.Parameters.AddWithValue("@entrada", entrada);
                cmd.Parameters.AddWithValue("@saida", saida);
                cmd.Parameters.AddWithValue("@dispositivo", dispositivo);


                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro inserido com sucesso!");
                    txtNomeClienteHistorico.Text = "";
                    txtDataEntradaHistorico.Text = "";
                    txtDataSaidaHistorico.Text = "";
                    txtTipoDispositivoHistorico.Text = "";
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

        private void btnAnteriorHistorico_Click_1(object sender, EventArgs e)
        {
            valor++;

            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string idmin = " SELECT CASE WHEN ISNULL(MAX(id_Historico), 0) - @valor < 0 THEN 0 ELSE ISNULL(MAX(id_Historico), 0) - @valor END AS idmin FROM Historico;";
                SqlCommand pesq = new SqlCommand(idmin, conexao);
                pesq.Parameters.AddWithValue("@valor", valor);

                try
                {
                    conexao.Open();
                    object result = pesq.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {


                        int proximoID = Convert.ToInt32(result);
                        txtCodigoHistorico.Text = proximoID.ToString();

                        string sql = "SELECT nm_Cliente, dt_Entrada_Historico, dt_Saida_Historico, tp_Dispositivo FROM Historico WHERE id_Historico = @id";
                        SqlCommand cmd = new SqlCommand(sql, conexao);
                        cmd.Parameters.AddWithValue("@id", proximoID);


                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtNomeClienteHistorico.Text = reader["nm_Cliente"].ToString();
                            txtDataEntradaHistorico.Text = reader["dt_Entrada_Historico"].ToString();
                            txtDataSaidaHistorico.Text = reader["dt_Saida_Historico"].ToString();
                            txtTipoDispositivoHistorico.Text = reader["tp_Dispositivo"].ToString();
                        }
                        else
                        {
                            proximoID = 1;
                            cmd.Parameters.AddWithValue("@id", proximoID);

                            txtCodigoHistorico.Text = proximoID.ToString();
                            txtNomeClienteHistorico.Text = "";
                            txtDataEntradaHistorico.Text = "";
                            txtDataSaidaHistorico.Text = "";
                            txtTipoDispositivoHistorico.Text = "";
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

        private void btnPosteriorHistorico_Click_1(object sender, EventArgs e)
        {
            valor--;

            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string idmin = " SELECT CASE WHEN ISNULL(MAX(id_Historico), 0) - @valor < 0 THEN 0 ELSE ISNULL(MAX(id_Historico), 0) - @valor END AS idmin FROM Historico;";
                SqlCommand pesq = new SqlCommand(idmin, conexao);
                pesq.Parameters.AddWithValue("@valor", valor);

                try
                {
                    conexao.Open();
                    object result = pesq.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int proximoID = Convert.ToInt32(result);
                        txtCodigoHistorico.Text = proximoID.ToString();

                        string sql = "SELECT nm_Cliente, dt_Entrada_Historico, dt_Saida_Historico, tp_Dispositivo FROM Historico WHERE id_Historico = @id";
                        SqlCommand cmd = new SqlCommand(sql, conexao);
                        cmd.Parameters.AddWithValue("@id", proximoID);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtNomeClienteHistorico.Text = reader["nm_Cliente"].ToString();
                            txtDataEntradaHistorico.Text = reader["dt_Entrada_Historico"].ToString();
                            txtDataSaidaHistorico.Text = reader["dt_Saida_Historico"].ToString();
                            txtTipoDispositivoHistorico.Text = reader["tp_Dispositivo"].ToString();
                        }
                        else

                        {
                            proximoID = 1;
                            MessageBox.Show("Nenhum registro encontrado ou valor nulo.");
                            txtNomeClienteHistorico.Text = "";
                            txtDataEntradaHistorico.Text = "";
                            txtDataSaidaHistorico.Text = "";
                            txtTipoDispositivoHistorico.Text = "";
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

        private void btnPrimeiroHistorico_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string sql = "SELECT TOP 1 id_Historico, nm_Cliente, dt_Entrada_Historico, dt_Saida_Historico, tp_Dispositivo FROM Historico ORDER BY id_Historico ASC";
                SqlCommand cmd = new SqlCommand(sql, conexao);

                try
                {
                    conexao.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtCodigoHistorico.Text = reader["id_Historico"].ToString();
                        txtNomeClienteHistorico.Text = reader["nm_Cliente"].ToString();
                        txtDataEntradaHistorico.Text = reader["dt_Entrada_Historico"].ToString();
                        txtDataSaidaHistorico.Text = reader["dt_Saida_Historico"].ToString();
                        txtTipoDispositivoHistorico.Text = reader["tp_Dispositivo"].ToString();

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

        private void btnUltimoHistorico_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string sql = "SELECT TOP id_Historico, nm_Cliente, dt_Entrada_Historico, dt_Saida_Historico, tp_Dispositivo FROM Historico ORDER BY id_Historico DESC";
                SqlCommand cmd = new SqlCommand(sql, conexao);

                try
                {
                    conexao.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtCodigoHistorico.Text = reader["id_Historico"].ToString();
                        txtNomeClienteHistorico.Text = reader["nm_Cliente"].ToString();
                        txtDataEntradaHistorico.Text = reader["dt_Entrada_Historico"].ToString();
                        txtDataSaidaHistorico.Text = reader["dt_Saida_Historico"].ToString();
                        txtTipoDispositivoHistorico.Text = reader["tp_Dispositivo"].ToString();

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

        private void btnBuscarHistorico_Click_1(object sender, EventArgs e)
        {
            btnAnteriorHistorico.Enabled = true;
            btnPosteriorHistorico.Enabled = true;
            btnPrimeiroHistorico.Enabled = true;
            btnUltimoHistorico.Enabled = true;
            btnBuscarHistorico.Enabled = false;
        }
    }
}
