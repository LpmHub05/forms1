using MySql.Data.MySqlClient;
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
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;



namespace forms1
{
    public partial class frmCliente : Form
    {
        int valor = 0;

        private DataTable dataTable;
        string sqli = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Desktop\Documents\banco_admin.mdf;Integrated Security=True;Connect Timeout=30";
        public frmCliente()
        {
            InitializeComponent();
            frmSplashScreen frmSplashScreen = new frmSplashScreen();

            frmSplashScreen.ShowDialog();
            Thread.Sleep(1);
        }
        private void AluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAluguel OutroForm = new frmAluguel();
            OutroForm.Show();
            Hide();
        }
        private void manutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManutencao OutroForm = new frmManutencao();
            OutroForm.Show();
            Hide();
        }
        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorico OutroForm = new frmHistorico();
            OutroForm.Show();
            Hide();
        }
        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto OutroForm = new frmProduto();
            OutroForm.Show();
            Hide();
        }
        private void tipoDoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoProduto OutroForm = new frmTipoProduto();
            OutroForm.Show();
            Hide();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSairCliente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCadastrarCliente_Click(object sender, EventArgs e)
        {
            txtCodigoCliente.ReadOnly = true;
            txtCodigoCliente.Enabled = false;
            btnSalvarCliente.Enabled = true;
            txtNomeCliente.Enabled = true;
            txtEmailCliente.Enabled = true;
            txtEmailCliente.Enabled = true;
            txtCelularCliente.Enabled = true;
            btnCadastrarCliente.Enabled = false;
            btnBuscarCliente.Enabled = false;
            btnLimparCliente.Enabled = true;
            btnRemoverCliente.Enabled = false;
            btnAlterarCliente.Enabled = false;
            BtnImprimirCliente.Enabled = false;
            btnAnteriorCliente.Enabled = false;
            btnPosteriorCliente.Enabled = false;
            btnPrimeiroCliente.Enabled = false;
            btnUltimoCliente.Enabled = false;
            cadastrarToolStripMenuItem.Enabled = false;
            removerToolStripMenuItem.Enabled = false;
            buscarToolStripMenuItem.Enabled = false;
            alterarToolStripMenuItem.Enabled = false;
            mnRelatorioCliente.Enabled = false;
            SalvarAlteracoesClienteToolStripMenuItem.Enabled = false;
            limparToolStripMenuItem.Enabled = false;

            txtNomeCliente.Text = "";
            txtEmailCliente.Text = "";
            txtCelularCliente.Text = "";


            string id = "SELECT ISNULL(MAX(id_Cliente), 0) + 1 FROM Cliente";

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
                        txtCodigoCliente.Text = proximoID.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Erro no cadastro.");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no cadastro: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
        private void BtnSalvarCliente_Click(object sender, EventArgs e)
        {
            txtCodigoCliente.ReadOnly = true;
            txtCodigoCliente.Enabled = false;
            btnSalvarCliente.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtEmailCliente.Enabled = false;
            txtCelularCliente.Enabled = false;
            btnCadastrarCliente.Enabled = true;
            btnBuscarCliente.Enabled = true;
            btnLimparCliente.Enabled = false;
            btnRemoverCliente.Enabled = true;
            btnAlterarCliente.Enabled = true;
            BtnImprimirCliente.Enabled = true;
            btnAnteriorCliente.Enabled = true;
            btnPosteriorCliente.Enabled = true;
            btnPrimeiroCliente.Enabled = true;
            btnUltimoCliente.Enabled = true;
            cadastrarToolStripMenuItem.Enabled = true;
            removerToolStripMenuItem.Enabled = true;
            buscarToolStripMenuItem.Enabled = true;
            alterarToolStripMenuItem.Enabled = true;
            mnRelatorioCliente.Enabled = true;
            SalvarAlteracoesClienteToolStripMenuItem.Enabled = true;
            limparToolStripMenuItem.Enabled = true;


            string nome = txtNomeCliente.Text;
            string email = txtEmailCliente.Text;
            string celular = txtCelularCliente.Text;


            string sql = "INSERT INTO Cliente(nm_Cliente, email_Cliente, tel_Cliente) VALUES(@nome, @email, @celular)";

            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                SqlCommand cmd = new SqlCommand(sql, conexao);


                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@celular", celular);


                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();

                    txtCelularCliente.Text = "";
                    txtEmailCliente.Text = "";
                    txtNomeCliente.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
        private void BtnAnteriorCliente_Click(object sender, EventArgs e)
        {
            txtCodigoCliente.ReadOnly = true;
            txtCodigoCliente.Enabled = false;

            valor--;

            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string idmin = "SELECT * FROM Cliente WHERE id_Cliente = @valor";
                SqlCommand pesq = new SqlCommand(idmin, conexao);
                pesq.Parameters.AddWithValue("@valor", valor);

                try
                {
                    conexao.Open();
                    object result = pesq.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {

                            int proximoID = Convert.ToInt32(result);
                            txtCodigoCliente.Text = proximoID.ToString();

                            string sql = "SELECT nm_Cliente, email_Cliente, tel_Cliente FROM Cliente WHERE id_Cliente = @id";
                            SqlCommand cmd = new SqlCommand(sql, conexao);
                            cmd.Parameters.AddWithValue("@id", proximoID);
                            
                       
                        SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.Read())
                            {
                               
                                txtNomeCliente.Text = reader["nm_Cliente"].ToString();
                                txtEmailCliente.Text = reader["email_Cliente"].ToString();
                                txtCelularCliente.Text = reader["tel_Cliente"].ToString();
                            }
                            else
                            { 
                               
                                proximoID = 1;
                                cmd.Parameters.AddWithValue("@id", proximoID);

                                txtCodigoCliente.Text = proximoID.ToString();
                                txtCelularCliente.Text = "";
                                txtEmailCliente.Text = "";
                                txtNomeCliente.Text = "";
                               
                            }
                            reader.Close();
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar cliente: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void btnPosteriorCliente_Click(object sender, EventArgs e)
        {
            txtCodigoCliente.ReadOnly = true;
            txtCodigoCliente.Enabled = false;

            valor++;

            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string idmin = "SELECT * FROM Cliente WHERE id_Cliente = @valor";
                SqlCommand pesq = new SqlCommand(idmin, conexao);
                pesq.Parameters.AddWithValue("@valor", valor);

                try
                {
                    conexao.Open();
                    object result = pesq.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int proximoID = Convert.ToInt32(result);
                        txtCodigoCliente.Text = proximoID.ToString();

                        string sql = "SELECT nm_Cliente, email_Cliente, tel_Cliente FROM Cliente WHERE id_Cliente = @id";
                        SqlCommand cmd = new SqlCommand(sql, conexao);
                        cmd.Parameters.AddWithValue("@id", proximoID);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtNomeCliente.Text = reader["nm_Cliente"].ToString();
                            txtEmailCliente.Text = reader["email_Cliente"].ToString();
                            txtCelularCliente.Text = reader["tel_Cliente"].ToString();
                        }
                        else

                        {
                            proximoID = 1;
                            MessageBox.Show("Cliente não encontrado.");
                            txtCodigoCliente.Text = "";
                            txtCelularCliente.Text = "";
                            txtEmailCliente.Text = "";
                            txtNomeCliente.Text = "";
                        }
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar cliente: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void btnPrimeiroCliente_Click(object sender, EventArgs e)
        {
            txtCodigoCliente.ReadOnly = true;
            txtCodigoCliente.Enabled = false;

            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                valor = 1;
                string sql = "SELECT * FROM Cliente WHERE id_Cliente = 1";
                SqlCommand cmd = new SqlCommand(sql, conexao);

                try
                {
                    conexao.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtCodigoCliente.Text = reader["id_Cliente"].ToString();
                        txtNomeCliente.Text = reader["nm_Cliente"].ToString();
                        txtEmailCliente.Text = reader["email_Cliente"].ToString();
                        txtCelularCliente.Text = reader["tel_Cliente"].ToString();

                        MessageBox.Show("Cliente encontrado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar cliente: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
        private void btnUltimoCliente_Click(object sender, EventArgs e)
        {
            txtCodigoCliente.ReadOnly = true;
            txtCodigoCliente.Enabled = false;

            using (SqlConnection conexao = new SqlConnection(sqli))
            {

                string sqlMaxId = "SELECT MAX(id_Cliente) FROM Cliente";
                SqlCommand cmdMaxId = new SqlCommand(sqlMaxId, conexao);

                try
                {
                    conexao.Open();
                    object result = cmdMaxId.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        int maxId = Convert.ToInt32(result);
                        txtCodigoCliente.Text = maxId.ToString();
                        valor = maxId;

                        string sqlDetalhes = "SELECT nm_Cliente, email_Cliente, tel_Cliente FROM Cliente WHERE id_Cliente = @id_Cliente";
                        SqlCommand cmdDetalhes = new SqlCommand(sqlDetalhes, conexao);
                        cmdDetalhes.Parameters.AddWithValue("@id_Cliente", maxId);

                        SqlDataReader reader = cmdDetalhes.ExecuteReader();

                        if (reader.Read())
                        {

                            txtNomeCliente.Text = reader["nm_Cliente"].ToString();
                            txtEmailCliente.Text = reader["email_Cliente"].ToString();
                            txtCelularCliente.Text = reader["tel_Cliente"].ToString();

                            MessageBox.Show("Cliente encontrado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Cliente não encontrado.");
                        }

                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar o registro: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            txtCodigoCliente.ReadOnly = false;
            txtCodigoCliente.Enabled = true;
            txtCodigoCliente.Focus();

            string IDCliente = txtCodigoCliente.Text;

            if (!string.IsNullOrWhiteSpace(IDCliente))
            {
                using (SqlConnection conexao = new SqlConnection(sqli))
                {
                    string sql = "SELECT nm_Cliente, email_Cliente, tel_Cliente FROM Cliente WHERE id_Cliente = @codigo";
                    SqlCommand cmd = new SqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@codigo", IDCliente);

                    try
                    {
                        conexao.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtNomeCliente.Text = reader["nm_Cliente"].ToString();
                            txtEmailCliente.Text = reader["email_Cliente"].ToString();
                            txtCelularCliente.Text = reader["tel_Cliente"].ToString();

                            MessageBox.Show("Cliente encontrado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Cliente não encontrado.");

                            txtCodigoCliente.Clear();
                            txtCodigoCliente.Focus();
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar cliente: " + ex.Message);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Cliente não encontrado.");
            }
        }

        private void btnLimparCliente_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in gbxCliente.Controls)
            {
                if (ctrl is TextBox tx) tx.Text = string.Empty;
            }
        }

        private void btnRemoverCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoCliente.Text))
            {
                MessageBox.Show("Nenhum cliente selecionado para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmar = MessageBox.Show("Tem certeza de que deseja remover este registro?", "Confirmar Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                using (SqlConnection conexao = new SqlConnection(sqli))
                {
                    string sql = "DELETE FROM Cliente WHERE id_Cliente = @codigo";
                    SqlCommand cmd = new SqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@codigo", txtCodigoCliente.Text);

                    try
                    {
                        conexao.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro removido com sucesso!");
                            txtCodigoCliente.Clear();
                            txtNomeCliente.Clear();
                            txtEmailCliente.Clear();
                            txtCelularCliente.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Registro não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao remover registro: " + ex.Message);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
            }
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            txtCodigoCliente.ReadOnly = true;
            txtCodigoCliente.Enabled = false;
            txtCelularCliente.Enabled = true;
            txtNomeCliente.Enabled = true;
            txtEmailCliente.Enabled = true;

            txtCelularCliente.Text = "";
            txtEmailCliente.Text = "";
            txtNomeCliente.Text = "";
        }

        private void SalvarAlteracoesClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCodigoCliente.ReadOnly = true;
            txtCodigoCliente.Enabled = false;
            txtCelularCliente.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtEmailCliente.Enabled = false;

            string nome = txtNomeCliente.Text;
            string email = txtEmailCliente.Text;
            string celular = txtCelularCliente.Text;

            using (SqlConnection conexao = new SqlConnection(sqli))
            {
                string idmin = "UPDATE Cliente SET nm_Cliente = @nome, email_Cliente = @email, tel_Cliente = @celular WHERE id_Cliente = @valor";
                SqlCommand cmd = new SqlCommand(idmin, conexao);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@celular", celular);

                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar cliente: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
    }
}