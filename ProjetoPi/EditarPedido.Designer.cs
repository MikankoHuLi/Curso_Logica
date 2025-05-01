namespace ProjetoPi
{
    partial class EditarPedido
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
            btnFinalizar = new Button();
            labelErroPedido = new Label();
            dataGridPedidos = new DataGridView();
            btnExtender = new Button();
            button1 = new Button();
            textBuscarPedido = new TextBox();
            buttonBuscaPedido = new Button();
            btnDetalhes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridPedidos).BeginInit();
            SuspendLayout();
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(364, 236);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(75, 23);
            btnFinalizar.TabIndex = 0;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // labelErroPedido
            // 
            labelErroPedido.AutoSize = true;
            labelErroPedido.Location = new Point(21, 410);
            labelErroPedido.Name = "labelErroPedido";
            labelErroPedido.Size = new Size(38, 15);
            labelErroPedido.TabIndex = 1;
            labelErroPedido.Text = "label1";
            // 
            // dataGridPedidos
            // 
            dataGridPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPedidos.Location = new Point(21, 109);
            dataGridPedidos.Name = "dataGridPedidos";
            dataGridPedidos.Size = new Size(240, 150);
            dataGridPedidos.TabIndex = 2;
            // 
            // btnExtender
            // 
            btnExtender.Location = new Point(445, 236);
            btnExtender.Name = "btnExtender";
            btnExtender.Size = new Size(75, 23);
            btnExtender.TabIndex = 3;
            btnExtender.Text = "Extender";
            btnExtender.UseVisualStyleBackColor = true;
            btnExtender.Click += btnExtender_Click;
            // 
            // button1
            // 
            button1.Location = new Point(445, 402);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBuscarPedido
            // 
            textBuscarPedido.Location = new Point(21, 71);
            textBuscarPedido.Name = "textBuscarPedido";
            textBuscarPedido.Size = new Size(240, 23);
            textBuscarPedido.TabIndex = 5;
            // 
            // buttonBuscaPedido
            // 
            buttonBuscaPedido.Location = new Point(274, 69);
            buttonBuscaPedido.Name = "buttonBuscaPedido";
            buttonBuscaPedido.Size = new Size(83, 25);
            buttonBuscaPedido.TabIndex = 6;
            buttonBuscaPedido.Text = "Buscar";
            buttonBuscaPedido.UseVisualStyleBackColor = true;
            buttonBuscaPedido.Click += buttonBuscaPedido_Click;
            // 
            // btnDetalhes
            // 
            btnDetalhes.Location = new Point(282, 236);
            btnDetalhes.Name = "btnDetalhes";
            btnDetalhes.Size = new Size(75, 23);
            btnDetalhes.TabIndex = 7;
            btnDetalhes.Text = "Detalhes";
            btnDetalhes.UseVisualStyleBackColor = true;
            btnDetalhes.Click += btnDetalhes_Click;
            // 
            // EditarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 439);
            Controls.Add(btnDetalhes);
            Controls.Add(buttonBuscaPedido);
            Controls.Add(textBuscarPedido);
            Controls.Add(button1);
            Controls.Add(btnExtender);
            Controls.Add(dataGridPedidos);
            Controls.Add(labelErroPedido);
            Controls.Add(btnFinalizar);
            Name = "EditarPedido";
            Text = "EditarPedido";
            Load += EditarPedido_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFinalizar;
        private Label labelErroPedido;
        private DataGridView dataGridPedidos;
        private Button btnExtender;
        private Button button1;
        private TextBox textBuscarPedido;
        private Button buttonBuscaPedido;
        private Button btnDetalhes;
    }
}