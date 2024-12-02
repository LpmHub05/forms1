namespace forms1
{
    partial class frmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxProduto = new System.Windows.Forms.GroupBox();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.cboTipoProduto = new System.Windows.Forms.ComboBox();
            this.txtQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.lblTipoProduto = new System.Windows.Forms.Label();
            this.lblQuantidadeProduto = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aluguelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutencaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RelatorioProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxOpcoesProduto = new System.Windows.Forms.GroupBox();
            this.btnSairProduto = new System.Windows.Forms.Button();
            this.btnLimparProduto = new System.Windows.Forms.Button();
            this.btnImprimirProduto = new System.Windows.Forms.Button();
            this.btnSalvarProduto = new System.Windows.Forms.Button();
            this.btnAlterarProduto = new System.Windows.Forms.Button();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.btnUltimoProduto = new System.Windows.Forms.Button();
            this.btnPrimeiroProduto = new System.Windows.Forms.Button();
            this.btnPosteriorProduto = new System.Windows.Forms.Button();
            this.btnAnteriorProduto = new System.Windows.Forms.Button();
            this.gbxProduto.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbxOpcoesProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxProduto
            // 
            this.gbxProduto.Controls.Add(this.txtDescricaoProduto);
            this.gbxProduto.Controls.Add(this.lblDescricaoProduto);
            this.gbxProduto.Controls.Add(this.cboTipoProduto);
            this.gbxProduto.Controls.Add(this.txtQuantidadeProduto);
            this.gbxProduto.Controls.Add(this.txtNomeProduto);
            this.gbxProduto.Controls.Add(this.txtCodigoProduto);
            this.gbxProduto.Controls.Add(this.lblTipoProduto);
            this.gbxProduto.Controls.Add(this.lblQuantidadeProduto);
            this.gbxProduto.Controls.Add(this.lblNomeProduto);
            this.gbxProduto.Controls.Add(this.lblCodigoProduto);
            this.gbxProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProduto.Location = new System.Drawing.Point(77, 68);
            this.gbxProduto.Name = "gbxProduto";
            this.gbxProduto.Size = new System.Drawing.Size(646, 200);
            this.gbxProduto.TabIndex = 9;
            this.gbxProduto.TabStop = false;
            this.gbxProduto.Text = "Produto";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Enabled = false;
            this.txtDescricaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoProduto.Location = new System.Drawing.Point(372, 51);
            this.txtDescricaoProduto.Multiline = true;
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(259, 124);
            this.txtDescricaoProduto.TabIndex = 20;
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.AutoSize = true;
            this.lblDescricaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoProduto.ForeColor = System.Drawing.Color.White;
            this.lblDescricaoProduto.Location = new System.Drawing.Point(379, 22);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(166, 20);
            this.lblDescricaoProduto.TabIndex = 10;
            this.lblDescricaoProduto.Text = "Descrição do Produto:";
            // 
            // cboTipoProduto
            // 
            this.cboTipoProduto.Enabled = false;
            this.cboTipoProduto.FormattingEnabled = true;
            this.cboTipoProduto.Items.AddRange(new object[] {
            "Smartphone",
            "Tablet",
            "Notebook"});
            this.cboTipoProduto.Location = new System.Drawing.Point(150, 147);
            this.cboTipoProduto.Name = "cboTipoProduto";
            this.cboTipoProduto.Size = new System.Drawing.Size(148, 28);
            this.cboTipoProduto.TabIndex = 9;
            // 
            // txtQuantidadeProduto
            // 
            this.txtQuantidadeProduto.Enabled = false;
            this.txtQuantidadeProduto.Location = new System.Drawing.Point(194, 109);
            this.txtQuantidadeProduto.Name = "txtQuantidadeProduto";
            this.txtQuantidadeProduto.Size = new System.Drawing.Size(125, 26);
            this.txtQuantidadeProduto.TabIndex = 8;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Enabled = false;
            this.txtNomeProduto.Location = new System.Drawing.Point(157, 72);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(188, 26);
            this.txtNomeProduto.TabIndex = 7;
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigoProduto.Enabled = false;
            this.txtCodigoProduto.Location = new System.Drawing.Point(157, 32);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.ReadOnly = true;
            this.txtCodigoProduto.Size = new System.Drawing.Size(74, 26);
            this.txtCodigoProduto.TabIndex = 6;
            // 
            // lblTipoProduto
            // 
            this.lblTipoProduto.AutoSize = true;
            this.lblTipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProduto.ForeColor = System.Drawing.Color.White;
            this.lblTipoProduto.Location = new System.Drawing.Point(10, 147);
            this.lblTipoProduto.Name = "lblTipoProduto";
            this.lblTipoProduto.Size = new System.Drawing.Size(125, 20);
            this.lblTipoProduto.TabIndex = 5;
            this.lblTipoProduto.Text = "Tipo do Produto:";
            // 
            // lblQuantidadeProduto
            // 
            this.lblQuantidadeProduto.AutoSize = true;
            this.lblQuantidadeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeProduto.ForeColor = System.Drawing.Color.White;
            this.lblQuantidadeProduto.Location = new System.Drawing.Point(10, 109);
            this.lblQuantidadeProduto.Name = "lblQuantidadeProduto";
            this.lblQuantidadeProduto.Size = new System.Drawing.Size(178, 20);
            this.lblQuantidadeProduto.TabIndex = 4;
            this.lblQuantidadeProduto.Text = "Quantidade do Produto:";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.ForeColor = System.Drawing.Color.White;
            this.lblNomeProduto.Location = new System.Drawing.Point(10, 72);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(141, 20);
            this.lblNomeProduto.TabIndex = 3;
            this.lblNomeProduto.Text = "Nome do Produto: ";
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProduto.ForeColor = System.Drawing.Color.White;
            this.lblCodigoProduto.Location = new System.Drawing.Point(10, 35);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(149, 20);
            this.lblCodigoProduto.TabIndex = 2;
            this.lblCodigoProduto.Text = "Código do Produto: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GrayText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.removerToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.RelatorioProdutoToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.limparToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.aluguelToolStripMenuItem,
            this.manutencaoToolStripMenuItem,
            this.historicoToolStripMenuItem,
            this.tipoDoProdutoToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarToolStripMenuItem.Image = global::forms1.Properties.Resources.cadastrar;
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(117, 27);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(190, 28);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // aluguelToolStripMenuItem
            // 
            this.aluguelToolStripMenuItem.Name = "aluguelToolStripMenuItem";
            this.aluguelToolStripMenuItem.Size = new System.Drawing.Size(190, 28);
            this.aluguelToolStripMenuItem.Text = "Aluguel";
            this.aluguelToolStripMenuItem.Click += new System.EventHandler(this.aluguelToolStripMenuItem_Click);
            // 
            // manutencaoToolStripMenuItem
            // 
            this.manutencaoToolStripMenuItem.Name = "manutencaoToolStripMenuItem";
            this.manutencaoToolStripMenuItem.Size = new System.Drawing.Size(190, 28);
            this.manutencaoToolStripMenuItem.Text = "Manutenção";
            this.manutencaoToolStripMenuItem.Click += new System.EventHandler(this.manutencaoToolStripMenuItem_Click);
            // 
            // historicoToolStripMenuItem
            // 
            this.historicoToolStripMenuItem.Name = "historicoToolStripMenuItem";
            this.historicoToolStripMenuItem.Size = new System.Drawing.Size(190, 28);
            this.historicoToolStripMenuItem.Text = "Histórico";
            this.historicoToolStripMenuItem.Click += new System.EventHandler(this.historicoToolStripMenuItem_Click);
            // 
            // tipoDoProdutoToolStripMenuItem
            // 
            this.tipoDoProdutoToolStripMenuItem.Name = "tipoDoProdutoToolStripMenuItem";
            this.tipoDoProdutoToolStripMenuItem.Size = new System.Drawing.Size(190, 28);
            this.tipoDoProdutoToolStripMenuItem.Text = "Tipo do Produto";
            this.tipoDoProdutoToolStripMenuItem.Click += new System.EventHandler(this.TipoDoProdutoToolStripMenuItem_Click);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.removerToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removerToolStripMenuItem.Image = global::forms1.Properties.Resources.reover;
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(112, 27);
            this.removerToolStripMenuItem.Text = "Remover";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.buscarToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarToolStripMenuItem.Image = global::forms1.Properties.Resources.busca;
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(98, 27);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.alterarToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarToolStripMenuItem.Image = global::forms1.Properties.Resources.altera;
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(93, 27);
            this.alterarToolStripMenuItem.Text = "Alterar";
            // 
            // RelatorioProdutoToolStripMenuItem
            // 
            this.RelatorioProdutoToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.RelatorioProdutoToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelatorioProdutoToolStripMenuItem.Image = global::forms1.Properties.Resources.impr;
            this.RelatorioProdutoToolStripMenuItem.Name = "RelatorioProdutoToolStripMenuItem";
            this.RelatorioProdutoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.RelatorioProdutoToolStripMenuItem.Size = new System.Drawing.Size(110, 27);
            this.RelatorioProdutoToolStripMenuItem.Text = "Relatório";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.salvarToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarToolStripMenuItem.Image = global::forms1.Properties.Resources.salvaeui;
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(92, 27);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // limparToolStripMenuItem
            // 
            this.limparToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.limparToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparToolStripMenuItem.Image = global::forms1.Properties.Resources.vassoura_;
            this.limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            this.limparToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.limparToolStripMenuItem.Size = new System.Drawing.Size(97, 27);
            this.limparToolStripMenuItem.Text = "Limpar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Image = global::forms1.Properties.Resources.saiaaa;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(76, 27);
            this.sairToolStripMenuItem.Text = "Sai&r";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // gbxOpcoesProduto
            // 
            this.gbxOpcoesProduto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbxOpcoesProduto.Controls.Add(this.btnSairProduto);
            this.gbxOpcoesProduto.Controls.Add(this.btnLimparProduto);
            this.gbxOpcoesProduto.Controls.Add(this.btnImprimirProduto);
            this.gbxOpcoesProduto.Controls.Add(this.btnSalvarProduto);
            this.gbxOpcoesProduto.Controls.Add(this.btnAlterarProduto);
            this.gbxOpcoesProduto.Controls.Add(this.btnRemoverProduto);
            this.gbxOpcoesProduto.Controls.Add(this.btnCadastrarProduto);
            this.gbxOpcoesProduto.Controls.Add(this.btnBuscarProduto);
            this.gbxOpcoesProduto.Controls.Add(this.btnUltimoProduto);
            this.gbxOpcoesProduto.Controls.Add(this.btnPrimeiroProduto);
            this.gbxOpcoesProduto.Controls.Add(this.btnPosteriorProduto);
            this.gbxOpcoesProduto.Controls.Add(this.btnAnteriorProduto);
            this.gbxOpcoesProduto.Location = new System.Drawing.Point(76, 287);
            this.gbxOpcoesProduto.Name = "gbxOpcoesProduto";
            this.gbxOpcoesProduto.Size = new System.Drawing.Size(647, 151);
            this.gbxOpcoesProduto.TabIndex = 12;
            this.gbxOpcoesProduto.TabStop = false;
            this.gbxOpcoesProduto.Text = "Opções";
            // 
            // btnSairProduto
            // 
            this.btnSairProduto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairProduto.Location = new System.Drawing.Point(533, 91);
            this.btnSairProduto.Name = "btnSairProduto";
            this.btnSairProduto.Size = new System.Drawing.Size(98, 41);
            this.btnSairProduto.TabIndex = 11;
            this.btnSairProduto.Text = "Sai&r";
            this.btnSairProduto.UseVisualStyleBackColor = true;
            this.btnSairProduto.Click += new System.EventHandler(this.btnSairProduto_Click_1);
            // 
            // btnLimparProduto
            // 
            this.btnLimparProduto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparProduto.Location = new System.Drawing.Point(533, 27);
            this.btnLimparProduto.Name = "btnLimparProduto";
            this.btnLimparProduto.Size = new System.Drawing.Size(98, 41);
            this.btnLimparProduto.TabIndex = 10;
            this.btnLimparProduto.Text = "&Limpar";
            this.btnLimparProduto.UseVisualStyleBackColor = true;
            // 
            // btnImprimirProduto
            // 
            this.btnImprimirProduto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirProduto.Location = new System.Drawing.Point(429, 91);
            this.btnImprimirProduto.Name = "btnImprimirProduto";
            this.btnImprimirProduto.Size = new System.Drawing.Size(98, 41);
            this.btnImprimirProduto.TabIndex = 9;
            this.btnImprimirProduto.Text = "&Imprimir";
            this.btnImprimirProduto.UseVisualStyleBackColor = true;
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.Enabled = false;
            this.btnSalvarProduto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarProduto.Location = new System.Drawing.Point(325, 91);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Size = new System.Drawing.Size(98, 41);
            this.btnSalvarProduto.TabIndex = 8;
            this.btnSalvarProduto.Text = "&Salvar";
            this.btnSalvarProduto.UseVisualStyleBackColor = true;
            this.btnSalvarProduto.Click += new System.EventHandler(this.btnSalvarProduto_Click_1);
            // 
            // btnAlterarProduto
            // 
            this.btnAlterarProduto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarProduto.Location = new System.Drawing.Point(221, 91);
            this.btnAlterarProduto.Name = "btnAlterarProduto";
            this.btnAlterarProduto.Size = new System.Drawing.Size(98, 41);
            this.btnAlterarProduto.TabIndex = 7;
            this.btnAlterarProduto.Text = "Al&terar";
            this.btnAlterarProduto.UseVisualStyleBackColor = true;
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverProduto.Location = new System.Drawing.Point(117, 91);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(98, 41);
            this.btnRemoverProduto.TabIndex = 6;
            this.btnRemoverProduto.Text = "R&emover";
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.Location = new System.Drawing.Point(13, 91);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(98, 41);
            this.btnCadastrarProduto.TabIndex = 5;
            this.btnCadastrarProduto.Text = "&Cadastrar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click_1);
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProduto.Location = new System.Drawing.Point(429, 27);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(98, 41);
            this.btnBuscarProduto.TabIndex = 4;
            this.btnBuscarProduto.Text = "&Buscar";
            this.btnBuscarProduto.UseVisualStyleBackColor = true;
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click_1);
            // 
            // btnUltimoProduto
            // 
            this.btnUltimoProduto.Enabled = false;
            this.btnUltimoProduto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoProduto.Location = new System.Drawing.Point(325, 27);
            this.btnUltimoProduto.Name = "btnUltimoProduto";
            this.btnUltimoProduto.Size = new System.Drawing.Size(98, 41);
            this.btnUltimoProduto.TabIndex = 3;
            this.btnUltimoProduto.Text = "&Último";
            this.btnUltimoProduto.UseVisualStyleBackColor = true;
            this.btnUltimoProduto.Click += new System.EventHandler(this.btnUltimoProduto_Click_1);
            // 
            // btnPrimeiroProduto
            // 
            this.btnPrimeiroProduto.Enabled = false;
            this.btnPrimeiroProduto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeiroProduto.Location = new System.Drawing.Point(221, 27);
            this.btnPrimeiroProduto.Name = "btnPrimeiroProduto";
            this.btnPrimeiroProduto.Size = new System.Drawing.Size(98, 41);
            this.btnPrimeiroProduto.TabIndex = 2;
            this.btnPrimeiroProduto.Text = "Pri&meiro";
            this.btnPrimeiroProduto.UseVisualStyleBackColor = true;
            this.btnPrimeiroProduto.Click += new System.EventHandler(this.btnPrimeiroProduto_Click_1);
            // 
            // btnPosteriorProduto
            // 
            this.btnPosteriorProduto.Enabled = false;
            this.btnPosteriorProduto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosteriorProduto.Location = new System.Drawing.Point(117, 27);
            this.btnPosteriorProduto.Name = "btnPosteriorProduto";
            this.btnPosteriorProduto.Size = new System.Drawing.Size(98, 41);
            this.btnPosteriorProduto.TabIndex = 1;
            this.btnPosteriorProduto.Text = "&Posterior";
            this.btnPosteriorProduto.UseVisualStyleBackColor = true;
            this.btnPosteriorProduto.Click += new System.EventHandler(this.btnPosteriorProduto_Click_1);
            // 
            // btnAnteriorProduto
            // 
            this.btnAnteriorProduto.Enabled = false;
            this.btnAnteriorProduto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorProduto.Location = new System.Drawing.Point(13, 27);
            this.btnAnteriorProduto.Name = "btnAnteriorProduto";
            this.btnAnteriorProduto.Size = new System.Drawing.Size(98, 41);
            this.btnAnteriorProduto.TabIndex = 0;
            this.btnAnteriorProduto.Text = "&Anterior";
            this.btnAnteriorProduto.UseVisualStyleBackColor = true;
            this.btnAnteriorProduto.Click += new System.EventHandler(this.btnAnteriorProduto_Click_1);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.gbxOpcoesProduto);
            this.Controls.Add(this.gbxProduto);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmProduto";
            this.Text = "frmProduto";
            this.gbxProduto.ResumeLayout(false);
            this.gbxProduto.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxOpcoesProduto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProduto;
        private System.Windows.Forms.TextBox txtQuantidadeProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Label lblTipoProduto;
        private System.Windows.Forms.Label lblQuantidadeProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RelatorioProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aluguelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutencaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDoProdutoToolStripMenuItem;
        private System.Windows.Forms.Label lblDescricaoProduto;
        private System.Windows.Forms.ComboBox cboTipoProduto;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.GroupBox gbxOpcoesProduto;
        private System.Windows.Forms.Button btnSairProduto;
        private System.Windows.Forms.Button btnLimparProduto;
        private System.Windows.Forms.Button btnImprimirProduto;
        private System.Windows.Forms.Button btnSalvarProduto;
        private System.Windows.Forms.Button btnAlterarProduto;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.Button btnUltimoProduto;
        private System.Windows.Forms.Button btnPrimeiroProduto;
        private System.Windows.Forms.Button btnPosteriorProduto;
        private System.Windows.Forms.Button btnAnteriorProduto;
    }
}