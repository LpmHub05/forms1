namespace forms1
{
    partial class frmCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aluguelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutencaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelatorioCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.SalvarAlteracoesClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.lblCelularCliente = new System.Windows.Forms.Label();
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            this.txtCelularCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.gbxOpcoesCliente = new System.Windows.Forms.GroupBox();
            this.btnSairCliente = new System.Windows.Forms.Button();
            this.btnLimparCliente = new System.Windows.Forms.Button();
            this.BtnImprimirCliente = new System.Windows.Forms.Button();
            this.btnSalvarCliente = new System.Windows.Forms.Button();
            this.btnAlterarCliente = new System.Windows.Forms.Button();
            this.btnRemoverCliente = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnUltimoCliente = new System.Windows.Forms.Button();
            this.btnPrimeiroCliente = new System.Windows.Forms.Button();
            this.btnPosteriorCliente = new System.Windows.Forms.Button();
            this.btnAnteriorCliente = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.banco_adminDataSet = new forms1.banco_adminDataSet();
            this.menuStrip1.SuspendLayout();
            this.gbxCliente.SuspendLayout();
            this.gbxOpcoesCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_adminDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GrayText;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.removerToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.mnRelatorioCliente,
            this.SalvarAlteracoesClienteToolStripMenuItem,
            this.limparToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aluguelToolStripMenuItem,
            this.manutencaoToolStripMenuItem,
            this.historicoToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.tipoDoProdutoToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarToolStripMenuItem.Image = global::forms1.Properties.Resources.cadastrar;
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(121, 27);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // aluguelToolStripMenuItem
            // 
            this.aluguelToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.aluguelToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aluguelToolStripMenuItem.Name = "aluguelToolStripMenuItem";
            this.aluguelToolStripMenuItem.Size = new System.Drawing.Size(190, 28);
            this.aluguelToolStripMenuItem.Text = "Aluguel";
            this.aluguelToolStripMenuItem.Click += new System.EventHandler(this.AluguelToolStripMenuItem_Click);
            // 
            // manutencaoToolStripMenuItem
            // 
            this.manutencaoToolStripMenuItem.Name = "manutencaoToolStripMenuItem";
            this.manutencaoToolStripMenuItem.Size = new System.Drawing.Size(190, 28);
            this.manutencaoToolStripMenuItem.Text = "Manutenção";
            this.manutencaoToolStripMenuItem.Click += new System.EventHandler(this.manutençãoToolStripMenuItem_Click);
            // 
            // historicoToolStripMenuItem
            // 
            this.historicoToolStripMenuItem.Name = "historicoToolStripMenuItem";
            this.historicoToolStripMenuItem.Size = new System.Drawing.Size(190, 28);
            this.historicoToolStripMenuItem.Text = "Histórico";
            this.historicoToolStripMenuItem.Click += new System.EventHandler(this.históricoToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(190, 28);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // tipoDoProdutoToolStripMenuItem
            // 
            this.tipoDoProdutoToolStripMenuItem.Name = "tipoDoProdutoToolStripMenuItem";
            this.tipoDoProdutoToolStripMenuItem.Size = new System.Drawing.Size(190, 28);
            this.tipoDoProdutoToolStripMenuItem.Text = "Tipo do Produto";
            this.tipoDoProdutoToolStripMenuItem.Click += new System.EventHandler(this.tipoDoProdutoToolStripMenuItem_Click);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.removerToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removerToolStripMenuItem.Image = global::forms1.Properties.Resources.reover;
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(116, 27);
            this.removerToolStripMenuItem.Text = "Remover";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.buscarToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarToolStripMenuItem.Image = global::forms1.Properties.Resources.busca;
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(102, 27);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.alterarToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarToolStripMenuItem.Image = global::forms1.Properties.Resources.altera;
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(97, 27);
            this.alterarToolStripMenuItem.Text = "Alterar";
            // 
            // mnRelatorioCliente
            // 
            this.mnRelatorioCliente.BackColor = System.Drawing.Color.Gray;
            this.mnRelatorioCliente.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnRelatorioCliente.Image = global::forms1.Properties.Resources.impr;
            this.mnRelatorioCliente.Name = "mnRelatorioCliente";
            this.mnRelatorioCliente.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.mnRelatorioCliente.Size = new System.Drawing.Size(114, 27);
            this.mnRelatorioCliente.Text = "Relatório";
            // 
            // SalvarAlteracoesClienteToolStripMenuItem
            // 
            this.SalvarAlteracoesClienteToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.SalvarAlteracoesClienteToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalvarAlteracoesClienteToolStripMenuItem.Image = global::forms1.Properties.Resources.salvaeui;
            this.SalvarAlteracoesClienteToolStripMenuItem.Name = "SalvarAlteracoesClienteToolStripMenuItem";
            this.SalvarAlteracoesClienteToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.SalvarAlteracoesClienteToolStripMenuItem.Size = new System.Drawing.Size(173, 27);
            this.SalvarAlteracoesClienteToolStripMenuItem.Text = "Salvar Alterações";
            this.SalvarAlteracoesClienteToolStripMenuItem.Click += new System.EventHandler(this.SalvarAlteracoesClienteToolStripMenuItem_Click);
            // 
            // limparToolStripMenuItem
            // 
            this.limparToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.limparToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparToolStripMenuItem.Image = global::forms1.Properties.Resources.vassoura_;
            this.limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            this.limparToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.limparToolStripMenuItem.Size = new System.Drawing.Size(101, 27);
            this.limparToolStripMenuItem.Text = "Limpar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Image = global::forms1.Properties.Resources.saiaaa;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(80, 27);
            this.sairToolStripMenuItem.Text = "Sai&r";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.ForeColor = System.Drawing.Color.White;
            this.lblCodigoCliente.Location = new System.Drawing.Point(8, 35);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(142, 20);
            this.lblCodigoCliente.TabIndex = 2;
            this.lblCodigoCliente.Text = "Código do Cliente: ";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.ForeColor = System.Drawing.Color.White;
            this.lblNomeCliente.Location = new System.Drawing.Point(8, 72);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(134, 20);
            this.lblNomeCliente.TabIndex = 3;
            this.lblNomeCliente.Text = "Nome do Cliente: ";
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCliente.ForeColor = System.Drawing.Color.White;
            this.lblEmailCliente.Location = new System.Drawing.Point(8, 109);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(132, 20);
            this.lblEmailCliente.TabIndex = 4;
            this.lblEmailCliente.Text = "E-mail do Cliente:";
            // 
            // lblCelularCliente
            // 
            this.lblCelularCliente.AutoSize = true;
            this.lblCelularCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelularCliente.ForeColor = System.Drawing.Color.White;
            this.lblCelularCliente.Location = new System.Drawing.Point(8, 147);
            this.lblCelularCliente.Name = "lblCelularCliente";
            this.lblCelularCliente.Size = new System.Drawing.Size(137, 20);
            this.lblCelularCliente.TabIndex = 5;
            this.lblCelularCliente.Text = "Celular do Cliente:";
            // 
            // gbxCliente
            // 
            this.gbxCliente.Controls.Add(this.txtCelularCliente);
            this.gbxCliente.Controls.Add(this.txtEmailCliente);
            this.gbxCliente.Controls.Add(this.txtNomeCliente);
            this.gbxCliente.Controls.Add(this.txtCodigoCliente);
            this.gbxCliente.Controls.Add(this.lblCelularCliente);
            this.gbxCliente.Controls.Add(this.lblEmailCliente);
            this.gbxCliente.Controls.Add(this.lblNomeCliente);
            this.gbxCliente.Controls.Add(this.lblCodigoCliente);
            this.gbxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCliente.Location = new System.Drawing.Point(151, 71);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Size = new System.Drawing.Size(525, 200);
            this.gbxCliente.TabIndex = 6;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Cliente";
            // 
            // txtCelularCliente
            // 
            this.txtCelularCliente.Enabled = false;
            this.txtCelularCliente.Location = new System.Drawing.Point(151, 147);
            this.txtCelularCliente.Name = "txtCelularCliente";
            this.txtCelularCliente.Size = new System.Drawing.Size(185, 26);
            this.txtCelularCliente.TabIndex = 9;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Enabled = false;
            this.txtEmailCliente.Location = new System.Drawing.Point(146, 109);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(262, 26);
            this.txtEmailCliente.TabIndex = 8;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(146, 72);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(262, 26);
            this.txtNomeCliente.TabIndex = 7;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigoCliente.Enabled = false;
            this.txtCodigoCliente.Location = new System.Drawing.Point(151, 32);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.ReadOnly = true;
            this.txtCodigoCliente.Size = new System.Drawing.Size(94, 26);
            this.txtCodigoCliente.TabIndex = 6;
            // 
            // gbxOpcoesCliente
            // 
            this.gbxOpcoesCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbxOpcoesCliente.Controls.Add(this.btnSairCliente);
            this.gbxOpcoesCliente.Controls.Add(this.btnLimparCliente);
            this.gbxOpcoesCliente.Controls.Add(this.BtnImprimirCliente);
            this.gbxOpcoesCliente.Controls.Add(this.btnSalvarCliente);
            this.gbxOpcoesCliente.Controls.Add(this.btnAlterarCliente);
            this.gbxOpcoesCliente.Controls.Add(this.btnRemoverCliente);
            this.gbxOpcoesCliente.Controls.Add(this.btnCadastrarCliente);
            this.gbxOpcoesCliente.Controls.Add(this.btnBuscarCliente);
            this.gbxOpcoesCliente.Controls.Add(this.btnUltimoCliente);
            this.gbxOpcoesCliente.Controls.Add(this.btnPrimeiroCliente);
            this.gbxOpcoesCliente.Controls.Add(this.btnPosteriorCliente);
            this.gbxOpcoesCliente.Controls.Add(this.btnAnteriorCliente);
            this.gbxOpcoesCliente.Location = new System.Drawing.Point(95, 287);
            this.gbxOpcoesCliente.Name = "gbxOpcoesCliente";
            this.gbxOpcoesCliente.Size = new System.Drawing.Size(651, 151);
            this.gbxOpcoesCliente.TabIndex = 7;
            this.gbxOpcoesCliente.TabStop = false;
            this.gbxOpcoesCliente.Text = "Opções";
            // 
            // btnSairCliente
            // 
            this.btnSairCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairCliente.Location = new System.Drawing.Point(533, 91);
            this.btnSairCliente.Name = "btnSairCliente";
            this.btnSairCliente.Size = new System.Drawing.Size(98, 41);
            this.btnSairCliente.TabIndex = 11;
            this.btnSairCliente.Text = "Sai&r";
            this.btnSairCliente.UseVisualStyleBackColor = true;
            this.btnSairCliente.Click += new System.EventHandler(this.btnSairCliente_Click);
            // 
            // btnLimparCliente
            // 
            this.btnLimparCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCliente.Location = new System.Drawing.Point(533, 27);
            this.btnLimparCliente.Name = "btnLimparCliente";
            this.btnLimparCliente.Size = new System.Drawing.Size(98, 41);
            this.btnLimparCliente.TabIndex = 10;
            this.btnLimparCliente.Text = "&Limpar";
            this.btnLimparCliente.UseVisualStyleBackColor = true;
            this.btnLimparCliente.Click += new System.EventHandler(this.btnLimparCliente_Click);
            // 
            // BtnImprimirCliente
            // 
            this.BtnImprimirCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimirCliente.Location = new System.Drawing.Point(429, 91);
            this.BtnImprimirCliente.Name = "BtnImprimirCliente";
            this.BtnImprimirCliente.Size = new System.Drawing.Size(98, 41);
            this.BtnImprimirCliente.TabIndex = 9;
            this.BtnImprimirCliente.Text = "&Imprimir";
            this.BtnImprimirCliente.UseVisualStyleBackColor = true;
            // 
            // btnSalvarCliente
            // 
            this.btnSalvarCliente.Enabled = false;
            this.btnSalvarCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCliente.Location = new System.Drawing.Point(325, 91);
            this.btnSalvarCliente.Name = "btnSalvarCliente";
            this.btnSalvarCliente.Size = new System.Drawing.Size(98, 41);
            this.btnSalvarCliente.TabIndex = 8;
            this.btnSalvarCliente.Text = "&Salvar";
            this.btnSalvarCliente.UseVisualStyleBackColor = true;
            this.btnSalvarCliente.Click += new System.EventHandler(this.BtnSalvarCliente_Click);
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarCliente.Location = new System.Drawing.Point(221, 91);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(98, 41);
            this.btnAlterarCliente.TabIndex = 7;
            this.btnAlterarCliente.Text = "Al&terar";
            this.btnAlterarCliente.UseVisualStyleBackColor = true;
            this.btnAlterarCliente.Click += new System.EventHandler(this.btnAlterarCliente_Click);
            // 
            // btnRemoverCliente
            // 
            this.btnRemoverCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverCliente.Location = new System.Drawing.Point(117, 91);
            this.btnRemoverCliente.Name = "btnRemoverCliente";
            this.btnRemoverCliente.Size = new System.Drawing.Size(98, 41);
            this.btnRemoverCliente.TabIndex = 6;
            this.btnRemoverCliente.Text = "R&emover";
            this.btnRemoverCliente.UseVisualStyleBackColor = true;
            this.btnRemoverCliente.Click += new System.EventHandler(this.btnRemoverCliente_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(13, 91);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(98, 41);
            this.btnCadastrarCliente.TabIndex = 5;
            this.btnCadastrarCliente.Text = "&Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.BtnCadastrarCliente_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(429, 27);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(98, 41);
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.Text = "&Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // btnUltimoCliente
            // 
            this.btnUltimoCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoCliente.Location = new System.Drawing.Point(325, 27);
            this.btnUltimoCliente.Name = "btnUltimoCliente";
            this.btnUltimoCliente.Size = new System.Drawing.Size(98, 41);
            this.btnUltimoCliente.TabIndex = 3;
            this.btnUltimoCliente.Text = "&Último";
            this.btnUltimoCliente.UseVisualStyleBackColor = true;
            this.btnUltimoCliente.Click += new System.EventHandler(this.btnUltimoCliente_Click);
            // 
            // btnPrimeiroCliente
            // 
            this.btnPrimeiroCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeiroCliente.Location = new System.Drawing.Point(221, 27);
            this.btnPrimeiroCliente.Name = "btnPrimeiroCliente";
            this.btnPrimeiroCliente.Size = new System.Drawing.Size(98, 41);
            this.btnPrimeiroCliente.TabIndex = 2;
            this.btnPrimeiroCliente.Text = "Pri&meiro";
            this.btnPrimeiroCliente.UseVisualStyleBackColor = true;
            this.btnPrimeiroCliente.Click += new System.EventHandler(this.btnPrimeiroCliente_Click);
            // 
            // btnPosteriorCliente
            // 
            this.btnPosteriorCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosteriorCliente.Location = new System.Drawing.Point(117, 27);
            this.btnPosteriorCliente.Name = "btnPosteriorCliente";
            this.btnPosteriorCliente.Size = new System.Drawing.Size(98, 41);
            this.btnPosteriorCliente.TabIndex = 1;
            this.btnPosteriorCliente.Text = "&Posterior";
            this.btnPosteriorCliente.UseVisualStyleBackColor = true;
            this.btnPosteriorCliente.Click += new System.EventHandler(this.btnPosteriorCliente_Click);
            // 
            // btnAnteriorCliente
            // 
            this.btnAnteriorCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorCliente.Location = new System.Drawing.Point(13, 27);
            this.btnAnteriorCliente.Name = "btnAnteriorCliente";
            this.btnAnteriorCliente.Size = new System.Drawing.Size(98, 41);
            this.btnAnteriorCliente.TabIndex = 0;
            this.btnAnteriorCliente.Text = "&Anterior";
            this.btnAnteriorCliente.UseVisualStyleBackColor = true;
            this.btnAnteriorCliente.Click += new System.EventHandler(this.BtnAnteriorCliente_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.banco_adminDataSet;
            this.bindingSource1.Position = 0;
            // 
            // banco_adminDataSet
            // 
            this.banco_adminDataSet.DataSetName = "banco_adminDataSet";
            this.banco_adminDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmCliente
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(910, 451);
            this.ControlBox = false;
            this.Controls.Add(this.gbxOpcoesCliente);
            this.Controls.Add(this.gbxCliente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            this.gbxOpcoesCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_adminDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnRelatorioCliente;
        private System.Windows.Forms.ToolStripMenuItem SalvarAlteracoesClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Label lblCelularCliente;
        private System.Windows.Forms.GroupBox gbxCliente;
        private System.Windows.Forms.TextBox txtCelularCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.ToolStripMenuItem aluguelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutencaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDoProdutoToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxOpcoesCliente;
        private System.Windows.Forms.Button btnSairCliente;
        private System.Windows.Forms.Button btnLimparCliente;
        private System.Windows.Forms.Button BtnImprimirCliente;
        private System.Windows.Forms.Button btnSalvarCliente;
        private System.Windows.Forms.Button btnAlterarCliente;
        private System.Windows.Forms.Button btnRemoverCliente;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnUltimoCliente;
        private System.Windows.Forms.Button btnPrimeiroCliente;
        private System.Windows.Forms.Button btnPosteriorCliente;
        private System.Windows.Forms.Button btnAnteriorCliente;
        private System.Windows.Forms.BindingSource bindingSource1;
        private banco_adminDataSet banco_adminDataSet;
    }
}

