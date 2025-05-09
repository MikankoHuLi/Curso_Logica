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
            textBuscarPedido = new TextBox();
            buttonBuscar = new Button();
            dataGridPedidos = new DataGridView();
            comboRelatorio = new ComboBox();
            buttonRelatorio = new Button();
            label1 = new Label();
            label2 = new Label();
            buttonVoltar = new Button();
            labelErro = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridPedidos).BeginInit();
            SuspendLayout();
            // 
            // textBuscarPedido
            // 
            textBuscarPedido.Location = new Point(242, 74);
            textBuscarPedido.Name = "textBuscarPedido";
            textBuscarPedido.Size = new Size(195, 23);
            textBuscarPedido.TabIndex = 0;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(443, 73);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 1;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // dataGridPedidos
            // 
            dataGridPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPedidos.Location = new Point(201, 102);
            dataGridPedidos.Name = "dataGridPedidos";
            dataGridPedidos.Size = new Size(349, 150);
            dataGridPedidos.TabIndex = 2;
            // 
            // comboRelatorio
            // 
            comboRelatorio.FormattingEnabled = true;
            comboRelatorio.Items.AddRange(new object[] { "Relatório de Pedidos Entregues", "Relatório Aluguéis por Cliente", "Relatório de Aluguéis de Jogos", "Relatório Pedidos com Multa", "Jogos em Aluguel" });
            comboRelatorio.Location = new Point(242, 315);
            comboRelatorio.Name = "comboRelatorio";
            comboRelatorio.Size = new Size(195, 23);
            comboRelatorio.TabIndex = 3;
            // 
            // buttonRelatorio
            // 
            buttonRelatorio.Location = new Point(443, 314);
            buttonRelatorio.Name = "buttonRelatorio";
            buttonRelatorio.Size = new Size(75, 23);
            buttonRelatorio.TabIndex = 4;
            buttonRelatorio.Text = "Gerar";
            buttonRelatorio.UseVisualStyleBackColor = true;
            buttonRelatorio.Click += buttonRelatorio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 22);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 5;
            label1.Text = "Histórico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(358, 277);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 6;
            label2.Text = "Relatório";
            // 
            // buttonVoltar
            // 
            buttonVoltar.Location = new Point(713, 415);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(75, 23);
            buttonVoltar.TabIndex = 7;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = true;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(358, 370);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(100, 15);
            labelErro.TabIndex = 8;
            labelErro.Text = "me deixe invisivel";
            // 
            // Historico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelErro);
            Controls.Add(buttonVoltar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonRelatorio);
            Controls.Add(comboRelatorio);
            Controls.Add(dataGridPedidos);
            Controls.Add(buttonBuscar);
            Controls.Add(textBuscarPedido);
            Name = "Historico";
            Text = "Historico";
            Load += Historico_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBuscarPedido;
        private Button buttonBuscar;
        private DataGridView dataGridPedidos;
        private ComboBox comboRelatorio;
        private Button buttonRelatorio;
        private Label label1;
        private Label label2;
        private Button buttonVoltar;
        private Label labelErro;
    }
}