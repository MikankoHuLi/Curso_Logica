namespace InterfaceProjeto
{
    partial class CriarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarPedido));
            dataGridCliente = new DataGridView();
            buttonBuscarCliente = new Button();
            buttonBuscarPedido = new Button();
            textBoxBuscarCliente = new TextBox();
            textBoxBuscarJogo = new TextBox();
            buttonAdicionar = new Button();
            buttonRemover = new Button();
            buttonLimpar = new Button();
            dataGridJogo = new DataGridView();
            dataGridJogosPedido = new DataGridView();
            labelCliente = new Label();
            labelJogo = new Label();
            labelAvisoCliente = new Label();
            labelAvisoJogo = new Label();
            textData_Inicio = new TextBox();
            textData_Devolucao = new TextBox();
            labelData = new Label();
            labelValor = new Label();
            textValor = new TextBox();
            label1 = new Label();
            buttonSelecionarCliente = new Button();
            buttonFinalizarPedido = new Button();
            buttonVoltarMenu = new Button();
            labelAvisoListaJogo = new Label();
            comboBoxPagamento = new ComboBox();
            labelFormaDePagamento = new Label();
            labelPedidoFinalizado = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridJogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridJogosPedido).BeginInit();
            SuspendLayout();
            // 
            // dataGridCliente
            // 
            dataGridCliente.AllowUserToAddRows = false;
            dataGridCliente.AllowUserToDeleteRows = false;
            dataGridCliente.AllowUserToResizeColumns = false;
            dataGridCliente.AllowUserToResizeRows = false;
            dataGridCliente.BackgroundColor = Color.Gray;
            dataGridCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCliente.Location = new Point(300, 252);
            dataGridCliente.MultiSelect = false;
            dataGridCliente.Name = "dataGridCliente";
            dataGridCliente.ReadOnly = true;
            dataGridCliente.Size = new Size(536, 216);
            dataGridCliente.TabIndex = 8;
            // 
            // buttonBuscarCliente
            // 
            buttonBuscarCliente.BackColor = Color.Transparent;
            buttonBuscarCliente.Cursor = Cursors.Hand;
            buttonBuscarCliente.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonBuscarCliente.FlatStyle = FlatStyle.Flat;
            buttonBuscarCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscarCliente.ForeColor = Color.White;
            buttonBuscarCliente.Location = new Point(730, 198);
            buttonBuscarCliente.Name = "buttonBuscarCliente";
            buttonBuscarCliente.Size = new Size(75, 30);
            buttonBuscarCliente.TabIndex = 9;
            buttonBuscarCliente.Text = "Buscar\r\n";
            buttonBuscarCliente.UseVisualStyleBackColor = false;
            buttonBuscarCliente.Click += buttonBuscarCliente_Click;
            // 
            // buttonBuscarPedido
            // 
            buttonBuscarPedido.BackColor = Color.Transparent;
            buttonBuscarPedido.Cursor = Cursors.Hand;
            buttonBuscarPedido.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonBuscarPedido.FlatStyle = FlatStyle.Flat;
            buttonBuscarPedido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonBuscarPedido.ForeColor = Color.White;
            buttonBuscarPedido.Location = new Point(1445, 197);
            buttonBuscarPedido.Name = "buttonBuscarPedido";
            buttonBuscarPedido.Size = new Size(75, 30);
            buttonBuscarPedido.TabIndex = 10;
            buttonBuscarPedido.Text = "Buscar ";
            buttonBuscarPedido.UseVisualStyleBackColor = false;
            buttonBuscarPedido.Click += buttonBuscarPedido_Click;
            // 
            // textBoxBuscarCliente
            // 
            textBoxBuscarCliente.Location = new Point(395, 202);
            textBoxBuscarCliente.Name = "textBoxBuscarCliente";
            textBoxBuscarCliente.PlaceholderText = "Ex: João Mario";
            textBoxBuscarCliente.Size = new Size(329, 23);
            textBoxBuscarCliente.TabIndex = 11;
            // 
            // textBoxBuscarJogo
            // 
            textBoxBuscarJogo.BackColor = SystemColors.Window;
            textBoxBuscarJogo.Location = new Point(1110, 202);
            textBoxBuscarJogo.Name = "textBoxBuscarJogo";
            textBoxBuscarJogo.PlaceholderText = "Ex: Donkey Kong ";
            textBoxBuscarJogo.Size = new Size(329, 23);
            textBoxBuscarJogo.TabIndex = 12;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.BackColor = Color.Transparent;
            buttonAdicionar.Cursor = Cursors.Hand;
            buttonAdicionar.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonAdicionar.FlatStyle = FlatStyle.Flat;
            buttonAdicionar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonAdicionar.ForeColor = Color.White;
            buttonAdicionar.Location = new Point(1564, 252);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(81, 30);
            buttonAdicionar.TabIndex = 13;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = false;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.BackColor = Color.Transparent;
            buttonRemover.Cursor = Cursors.Hand;
            buttonRemover.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonRemover.FlatStyle = FlatStyle.Flat;
            buttonRemover.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonRemover.ForeColor = Color.White;
            buttonRemover.Location = new Point(1285, 570);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(75, 30);
            buttonRemover.TabIndex = 14;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = false;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.BackColor = Color.Transparent;
            buttonLimpar.Cursor = Cursors.Hand;
            buttonLimpar.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonLimpar.FlatStyle = FlatStyle.Flat;
            buttonLimpar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonLimpar.ForeColor = Color.White;
            buttonLimpar.Location = new Point(1285, 606);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(75, 30);
            buttonLimpar.TabIndex = 15;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = false;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // dataGridJogo
            // 
            dataGridJogo.AllowUserToAddRows = false;
            dataGridJogo.AllowUserToDeleteRows = false;
            dataGridJogo.AllowUserToResizeColumns = false;
            dataGridJogo.AllowUserToResizeRows = false;
            dataGridJogo.BackgroundColor = Color.Gray;
            dataGridJogo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridJogo.Location = new Point(1022, 252);
            dataGridJogo.MultiSelect = false;
            dataGridJogo.Name = "dataGridJogo";
            dataGridJogo.ReadOnly = true;
            dataGridJogo.Size = new Size(536, 216);
            dataGridJogo.TabIndex = 16;
            // 
            // dataGridJogosPedido
            // 
            dataGridJogosPedido.AllowUserToAddRows = false;
            dataGridJogosPedido.AllowUserToDeleteRows = false;
            dataGridJogosPedido.AllowUserToResizeColumns = false;
            dataGridJogosPedido.AllowUserToResizeRows = false;
            dataGridJogosPedido.BackgroundColor = Color.Gray;
            dataGridJogosPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridJogosPedido.Location = new Point(561, 570);
            dataGridJogosPedido.MultiSelect = false;
            dataGridJogosPedido.Name = "dataGridJogosPedido";
            dataGridJogosPedido.ReadOnly = true;
            dataGridJogosPedido.Size = new Size(697, 216);
            dataGridJogosPedido.TabIndex = 17;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.BackColor = Color.Transparent;
            labelCliente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCliente.ForeColor = Color.White;
            labelCliente.Location = new Point(337, 205);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(52, 17);
            labelCliente.TabIndex = 18;
            labelCliente.Text = "Cliente:";
            // 
            // labelJogo
            // 
            labelJogo.AutoSize = true;
            labelJogo.BackColor = Color.Transparent;
            labelJogo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJogo.ForeColor = Color.White;
            labelJogo.Location = new Point(1069, 205);
            labelJogo.Name = "labelJogo";
            labelJogo.Size = new Size(40, 17);
            labelJogo.TabIndex = 19;
            labelJogo.Text = "Jogo:";
            // 
            // labelAvisoCliente
            // 
            labelAvisoCliente.Anchor = AnchorStyles.None;
            labelAvisoCliente.AutoSize = true;
            labelAvisoCliente.BackColor = Color.Transparent;
            labelAvisoCliente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAvisoCliente.ForeColor = Color.White;
            labelAvisoCliente.Location = new Point(452, 489);
            labelAvisoCliente.Name = "labelAvisoCliente";
            labelAvisoCliente.Size = new Size(114, 17);
            labelAvisoCliente.TabIndex = 20;
            labelAvisoCliente.Text = "me deixe invisivel";
            // 
            // labelAvisoJogo
            // 
            labelAvisoJogo.Anchor = AnchorStyles.None;
            labelAvisoJogo.AutoSize = true;
            labelAvisoJogo.BackColor = Color.Transparent;
            labelAvisoJogo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelAvisoJogo.ForeColor = Color.White;
            labelAvisoJogo.Location = new Point(1128, 489);
            labelAvisoJogo.Name = "labelAvisoJogo";
            labelAvisoJogo.Size = new Size(114, 17);
            labelAvisoJogo.TabIndex = 21;
            labelAvisoJogo.Text = "me deixe invisivel";
            // 
            // textData_Inicio
            // 
            textData_Inicio.Location = new Point(614, 888);
            textData_Inicio.Name = "textData_Inicio";
            textData_Inicio.ReadOnly = true;
            textData_Inicio.Size = new Size(100, 23);
            textData_Inicio.TabIndex = 22;
            // 
            // textData_Devolucao
            // 
            textData_Devolucao.Location = new Point(742, 888);
            textData_Devolucao.Name = "textData_Devolucao";
            textData_Devolucao.ReadOnly = true;
            textData_Devolucao.Size = new Size(109, 23);
            textData_Devolucao.TabIndex = 23;
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.BackColor = Color.Transparent;
            labelData.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelData.ForeColor = Color.White;
            labelData.Location = new Point(569, 893);
            labelData.Name = "labelData";
            labelData.Size = new Size(39, 17);
            labelData.TabIndex = 24;
            labelData.Text = "Data:";
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.BackColor = Color.Transparent;
            labelValor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelValor.ForeColor = Color.White;
            labelValor.Location = new Point(1062, 844);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(42, 17);
            labelValor.TabIndex = 25;
            labelValor.Text = "Valor:";
            // 
            // textValor
            // 
            textValor.Location = new Point(1110, 842);
            textValor.Name = "textValor";
            textValor.ReadOnly = true;
            textValor.Size = new Size(100, 23);
            textValor.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(562, 533);
            label1.Name = "label1";
            label1.Size = new Size(93, 32);
            label1.TabIndex = 27;
            label1.Text = "Pedido";
            // 
            // buttonSelecionarCliente
            // 
            buttonSelecionarCliente.BackColor = Color.Transparent;
            buttonSelecionarCliente.Cursor = Cursors.Hand;
            buttonSelecionarCliente.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonSelecionarCliente.FlatStyle = FlatStyle.Flat;
            buttonSelecionarCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonSelecionarCliente.ForeColor = Color.White;
            buttonSelecionarCliente.Location = new Point(842, 252);
            buttonSelecionarCliente.Name = "buttonSelecionarCliente";
            buttonSelecionarCliente.Size = new Size(81, 30);
            buttonSelecionarCliente.TabIndex = 29;
            buttonSelecionarCliente.Text = "Selecionar";
            buttonSelecionarCliente.UseVisualStyleBackColor = false;
            buttonSelecionarCliente.Click += buttonSelecionarCliente_Click;
            // 
            // buttonFinalizarPedido
            // 
            buttonFinalizarPedido.BackColor = Color.Transparent;
            buttonFinalizarPedido.Cursor = Cursors.Hand;
            buttonFinalizarPedido.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonFinalizarPedido.FlatStyle = FlatStyle.Flat;
            buttonFinalizarPedido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonFinalizarPedido.ForeColor = Color.White;
            buttonFinalizarPedido.Location = new Point(916, 927);
            buttonFinalizarPedido.Name = "buttonFinalizarPedido";
            buttonFinalizarPedido.Size = new Size(75, 30);
            buttonFinalizarPedido.TabIndex = 30;
            buttonFinalizarPedido.Text = "Finalizar";
            buttonFinalizarPedido.UseVisualStyleBackColor = false;
            buttonFinalizarPedido.Click += buttonFinalizarPedido_Click;
            // 
            // buttonVoltarMenu
            // 
            buttonVoltarMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonVoltarMenu.BackColor = Color.Transparent;
            buttonVoltarMenu.Cursor = Cursors.Hand;
            buttonVoltarMenu.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonVoltarMenu.FlatStyle = FlatStyle.Flat;
            buttonVoltarMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVoltarMenu.ForeColor = Color.White;
            buttonVoltarMenu.Location = new Point(1662, 989);
            buttonVoltarMenu.Name = "buttonVoltarMenu";
            buttonVoltarMenu.Size = new Size(75, 30);
            buttonVoltarMenu.TabIndex = 31;
            buttonVoltarMenu.Text = "Voltar ";
            buttonVoltarMenu.UseVisualStyleBackColor = false;
            buttonVoltarMenu.Click += buttonVoltarMenu_Click;
            // 
            // labelAvisoListaJogo
            // 
            labelAvisoListaJogo.Anchor = AnchorStyles.None;
            labelAvisoListaJogo.AutoSize = true;
            labelAvisoListaJogo.BackColor = Color.Transparent;
            labelAvisoListaJogo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelAvisoListaJogo.ForeColor = Color.White;
            labelAvisoListaJogo.Location = new Point(832, 798);
            labelAvisoListaJogo.Name = "labelAvisoListaJogo";
            labelAvisoListaJogo.Size = new Size(114, 17);
            labelAvisoListaJogo.TabIndex = 32;
            labelAvisoListaJogo.Text = "me deixe invisivel";
            // 
            // comboBoxPagamento
            // 
            comboBoxPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPagamento.FormattingEnabled = true;
            comboBoxPagamento.Items.AddRange(new object[] { "Crédito", "Débito", "Dinheiro", "Pix" });
            comboBoxPagamento.Location = new Point(730, 844);
            comboBoxPagamento.Name = "comboBoxPagamento";
            comboBoxPagamento.Size = new Size(121, 23);
            comboBoxPagamento.TabIndex = 33;
            // 
            // labelFormaDePagamento
            // 
            labelFormaDePagamento.AutoSize = true;
            labelFormaDePagamento.BackColor = Color.Transparent;
            labelFormaDePagamento.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelFormaDePagamento.ForeColor = Color.White;
            labelFormaDePagamento.Location = new Point(569, 848);
            labelFormaDePagamento.Name = "labelFormaDePagamento";
            labelFormaDePagamento.Size = new Size(143, 17);
            labelFormaDePagamento.TabIndex = 34;
            labelFormaDePagamento.Text = "Forma de Pagamento:";
            // 
            // labelPedidoFinalizado
            // 
            labelPedidoFinalizado.Anchor = AnchorStyles.None;
            labelPedidoFinalizado.AutoSize = true;
            labelPedidoFinalizado.BackColor = Color.Transparent;
            labelPedidoFinalizado.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelPedidoFinalizado.ForeColor = Color.White;
            labelPedidoFinalizado.Location = new Point(866, 974);
            labelPedidoFinalizado.Name = "labelPedidoFinalizado";
            labelPedidoFinalizado.Size = new Size(114, 17);
            labelPedidoFinalizado.TabIndex = 35;
            labelPedidoFinalizado.Text = "me deixe invisivel";
            // 
            // CriarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1749, 1031);
            Controls.Add(labelPedidoFinalizado);
            Controls.Add(labelFormaDePagamento);
            Controls.Add(comboBoxPagamento);
            Controls.Add(labelAvisoListaJogo);
            Controls.Add(buttonVoltarMenu);
            Controls.Add(buttonFinalizarPedido);
            Controls.Add(buttonSelecionarCliente);
            Controls.Add(label1);
            Controls.Add(textValor);
            Controls.Add(labelValor);
            Controls.Add(labelData);
            Controls.Add(textData_Devolucao);
            Controls.Add(textData_Inicio);
            Controls.Add(labelAvisoJogo);
            Controls.Add(labelAvisoCliente);
            Controls.Add(labelJogo);
            Controls.Add(labelCliente);
            Controls.Add(dataGridJogosPedido);
            Controls.Add(dataGridJogo);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonRemover);
            Controls.Add(buttonAdicionar);
            Controls.Add(textBoxBuscarJogo);
            Controls.Add(textBoxBuscarCliente);
            Controls.Add(buttonBuscarPedido);
            Controls.Add(buttonBuscarCliente);
            Controls.Add(dataGridCliente);
            Name = "CriarPedido";
            Text = "CriarPedido";
            WindowState = FormWindowState.Maximized;
            Load += CriarPedido_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridJogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridJogosPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridCliente;
        private Button buttonBuscarCliente;
        private Button buttonBuscarPedido;
        private TextBox textBoxBuscarCliente;
        private TextBox textBoxBuscarJogo;
        private Button buttonAdicionar;
        private Button buttonRemover;
        private Button buttonLimpar;
        private DataGridView dataGridJogo;
        private DataGridView dataGridJogosPedido;
        private Label labelCliente;
        private Label labelJogo;
        private Label labelAvisoCliente;
        private Label labelAvisoJogo;
        private TextBox textData_Inicio;
        private TextBox textData_Devolucao;
        private Label labelData;
        private Label labelValor;
        private TextBox textValor;
        private Label label1;
        private Button buttonSelecionarCliente;
        private Button buttonFinalizarPedido;
        private Button button3;
        private Button buttonVoltarMenu;
        private Label labelAvisoListaJogo;
        private ComboBox comboBoxPagamento;
        private Label labelFormaDePagamento;
        private Label labelPedidoFinalizado;
    }
}