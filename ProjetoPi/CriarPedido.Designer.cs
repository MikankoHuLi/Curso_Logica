namespace ProjetoPi
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
            buttonCriarAluguel = new Button();
            label1 = new Label();
            Cliente = new Label();
            label3 = new Label();
            label4 = new Label();
            textData_Inicio = new TextBox();
            textData_Devolucao = new TextBox();
            labelValor = new Label();
            textValor = new TextBox();
            comboBoxPagamento = new ComboBox();
            label2 = new Label();
            dataGridJogo = new DataGridView();
            dataGridCliente = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            textBoxBuscarCliente = new TextBox();
            textBoxBuscarJogo = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dataGridView3 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridJogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // buttonCriarAluguel
            // 
            buttonCriarAluguel.Location = new Point(344, 552);
            buttonCriarAluguel.Name = "buttonCriarAluguel";
            buttonCriarAluguel.Size = new Size(75, 23);
            buttonCriarAluguel.TabIndex = 0;
            buttonCriarAluguel.Text = "Finalizar";
            buttonCriarAluguel.UseVisualStyleBackColor = true;
            buttonCriarAluguel.Click += buttonCriarAluguel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 617);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.Location = new Point(24, 73);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(44, 15);
            Cliente.TabIndex = 2;
            Cliente.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(423, 73);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 5;
            label3.Text = "Jogo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 355);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "Data";
            // 
            // textData_Inicio
            // 
            textData_Inicio.Enabled = false;
            textData_Inicio.Location = new Point(78, 352);
            textData_Inicio.Name = "textData_Inicio";
            textData_Inicio.ReadOnly = true;
            textData_Inicio.Size = new Size(127, 23);
            textData_Inicio.TabIndex = 7;
            // 
            // textData_Devolucao
            // 
            textData_Devolucao.Enabled = false;
            textData_Devolucao.Location = new Point(242, 352);
            textData_Devolucao.Name = "textData_Devolucao";
            textData_Devolucao.ReadOnly = true;
            textData_Devolucao.Size = new Size(131, 23);
            textData_Devolucao.TabIndex = 8;
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Location = new Point(465, 461);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(33, 15);
            labelValor.TabIndex = 9;
            labelValor.Text = "Valor";
            // 
            // textValor
            // 
            textValor.Enabled = false;
            textValor.Location = new Point(519, 458);
            textValor.Name = "textValor";
            textValor.ReadOnly = true;
            textValor.Size = new Size(100, 23);
            textValor.TabIndex = 10;
            // 
            // comboBoxPagamento
            // 
            comboBoxPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPagamento.FormattingEnabled = true;
            comboBoxPagamento.Items.AddRange(new object[] { "Crédito", "Débito" });
            comboBoxPagamento.Location = new Point(191, 453);
            comboBoxPagamento.Name = "comboBoxPagamento";
            comboBoxPagamento.Size = new Size(121, 23);
            comboBoxPagamento.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 456);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 12;
            label2.Text = "forma de pagamento";
            // 
            // dataGridJogo
            // 
            dataGridJogo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridJogo.Location = new Point(466, 113);
            dataGridJogo.Name = "dataGridJogo";
            dataGridJogo.Size = new Size(240, 153);
            dataGridJogo.TabIndex = 13;
            // 
            // dataGridCliente
            // 
            dataGridCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCliente.Location = new Point(66, 113);
            dataGridCliente.Name = "dataGridCliente";
            dataGridCliente.Size = new Size(240, 153);
            dataGridCliente.TabIndex = 14;
            // 
            // button2
            // 
            button2.Location = new Point(686, 574);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(723, 70);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 16;
            button3.Text = "buscar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBoxBuscarCliente
            // 
            textBoxBuscarCliente.Location = new Point(72, 73);
            textBoxBuscarCliente.Name = "textBoxBuscarCliente";
            textBoxBuscarCliente.Size = new Size(240, 23);
            textBoxBuscarCliente.TabIndex = 17;
            // 
            // textBoxBuscarJogo
            // 
            textBoxBuscarJogo.Location = new Point(483, 70);
            textBoxBuscarJogo.Name = "textBoxBuscarJogo";
            textBoxBuscarJogo.Size = new Size(223, 23);
            textBoxBuscarJogo.TabIndex = 18;
            // 
            // button4
            // 
            button4.Location = new Point(331, 72);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 19;
            button4.Text = "buscar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(331, 113);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 20;
            button5.Text = "selecionar";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(723, 121);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 21;
            button6.Text = "adicionar";
            button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(457, 352);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(240, 70);
            dataGridView3.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(413, 352);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 23;
            label5.Text = "pedido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(135, 323);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 24;
            label6.Text = "cliente selecionado";
            // 
            // CriarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 681);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dataGridView3);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBoxBuscarJogo);
            Controls.Add(textBoxBuscarCliente);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridCliente);
            Controls.Add(dataGridJogo);
            Controls.Add(label2);
            Controls.Add(comboBoxPagamento);
            Controls.Add(textValor);
            Controls.Add(labelValor);
            Controls.Add(textData_Devolucao);
            Controls.Add(textData_Inicio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Cliente);
            Controls.Add(label1);
            Controls.Add(buttonCriarAluguel);
            Name = "CriarPedido";
            Text = "CriarPedido";
            Load += CriarPedido_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridJogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCriarAluguel;
        private Label label1;
        private Label Cliente;
        private Label label3;
        private Label label4;
        private TextBox textData_Inicio;
        private TextBox textData_Devolucao;
        private Label labelValor;
        private TextBox textValor;
        private ComboBox comboBoxPagamento;
        private Label label2;
        private DataGridView dataGridJogo;
        private DataGridView dataGridCliente;
        private Button button2;
        private Button button3;
        private TextBox textBoxBuscarCliente;
        private TextBox textBoxBuscarJogo;
        private Button button4;
        private Button button5;
        private Button button6;
        private DataGridView dataGridView3;
        private Label label5;
        private Label label6;
    }
}