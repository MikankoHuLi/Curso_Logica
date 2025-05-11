namespace InterfaceProjeto
{
    partial class Historico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historico));
            buttonVoltarMenu = new Button();
            dataGridPedidos = new DataGridView();
            textBuscarPedido = new TextBox();
            buttonBuscar = new Button();
            buttonRelatorio = new Button();
            comboRelatorio = new ComboBox();
            labelErro = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridPedidos).BeginInit();
            SuspendLayout();
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
            buttonVoltarMenu.Location = new Point(1817, 999);
            buttonVoltarMenu.Name = "buttonVoltarMenu";
            buttonVoltarMenu.Size = new Size(75, 30);
            buttonVoltarMenu.TabIndex = 7;
            buttonVoltarMenu.Text = "Voltar ";
            buttonVoltarMenu.UseVisualStyleBackColor = false;
            buttonVoltarMenu.Click += buttonVoltarMenu_Click;
            // 
            // dataGridPedidos
            // 
            dataGridPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPedidos.Location = new Point(591, 349);
            dataGridPedidos.Name = "dataGridPedidos";
            dataGridPedidos.Size = new Size(837, 512);
            dataGridPedidos.TabIndex = 8;
            // 
            // textBuscarPedido
            // 
            textBuscarPedido.Anchor = AnchorStyles.Top;
            textBuscarPedido.BackColor = Color.White;
            textBuscarPedido.Location = new Point(806, 300);
            textBuscarPedido.Name = "textBuscarPedido";
            textBuscarPedido.Size = new Size(388, 23);
            textBuscarPedido.TabIndex = 9;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Anchor = AnchorStyles.Top;
            buttonBuscar.BackColor = Color.Transparent;
            buttonBuscar.Cursor = Cursors.Hand;
            buttonBuscar.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonBuscar.ForeColor = Color.White;
            buttonBuscar.Location = new Point(1200, 295);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 30);
            buttonBuscar.TabIndex = 11;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonRelatorio
            // 
            buttonRelatorio.Anchor = AnchorStyles.Top;
            buttonRelatorio.BackColor = Color.Transparent;
            buttonRelatorio.Cursor = Cursors.Hand;
            buttonRelatorio.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonRelatorio.FlatStyle = FlatStyle.Flat;
            buttonRelatorio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonRelatorio.ForeColor = Color.White;
            buttonRelatorio.Location = new Point(1232, 900);
            buttonRelatorio.Name = "buttonRelatorio";
            buttonRelatorio.Size = new Size(75, 30);
            buttonRelatorio.TabIndex = 12;
            buttonRelatorio.Text = "Gerar";
            buttonRelatorio.UseVisualStyleBackColor = false;
            buttonRelatorio.Click += buttonRelatorio_Click;
            // 
            // comboRelatorio
            // 
            comboRelatorio.FormattingEnabled = true;
            comboRelatorio.Items.AddRange(new object[] { "Relatório de Pedidos Entregues", "Relatório Aluguéis por Cliente", "Relatório Jogos Mais Alugados", "Relatório Pedidos com Multa", "Relatório Jogos em Aluguel" });
            comboRelatorio.Location = new Point(842, 902);
            comboRelatorio.Name = "comboRelatorio";
            comboRelatorio.Size = new Size(384, 23);
            comboRelatorio.TabIndex = 13;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.BackColor = Color.Transparent;
            labelErro.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelErro.ForeColor = Color.White;
            labelErro.Location = new Point(1014, 968);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(114, 17);
            labelErro.TabIndex = 14;
            labelErro.Text = "me deixe invisivel";
            // 
            // Historico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(labelErro);
            Controls.Add(comboRelatorio);
            Controls.Add(buttonRelatorio);
            Controls.Add(buttonBuscar);
            Controls.Add(textBuscarPedido);
            Controls.Add(dataGridPedidos);
            Controls.Add(buttonVoltarMenu);
            Name = "Historico";
            Text = "Historico";
            WindowState = FormWindowState.Maximized;
            Load += Historico_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVoltarMenu;
        private DataGridView dataGridPedidos;
        private TextBox textBuscarPedido;
        private Button buttonBuscar;
        private Button buttonRelatorio;
        private ComboBox comboRelatorio;
        private Label labelErro;
    }
}