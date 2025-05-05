namespace InterfaceProjeto
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
            pictureBox1 = new PictureBox();
            buttonVoltarMenu = new Button();
            textBuscarPedido = new TextBox();
            dataGridPedidos = new DataGridView();
            buttonBuscarPedido = new Button();
            buttonDetalhes = new Button();
            buttonFinalizar = new Button();
            buttonExtender = new Button();
            labelErroPedido = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPedidos).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dd2oj85_b5bab19d_e110_4f51_ae2b_ca39dd6d8d74;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // buttonVoltarMenu
            // 
            buttonVoltarMenu.Cursor = Cursors.Hand;
            buttonVoltarMenu.FlatStyle = FlatStyle.Flat;
            buttonVoltarMenu.Location = new Point(879, 547);
            buttonVoltarMenu.Name = "buttonVoltarMenu";
            buttonVoltarMenu.Size = new Size(75, 23);
            buttonVoltarMenu.TabIndex = 7;
            buttonVoltarMenu.Text = "Voltar ";
            buttonVoltarMenu.UseVisualStyleBackColor = true;
            buttonVoltarMenu.Click += buttonVoltarMenu_Click;
            // 
            // textBuscarPedido
            // 
            textBuscarPedido.Location = new Point(283, 41);
            textBuscarPedido.Name = "textBuscarPedido";
            textBuscarPedido.Size = new Size(240, 23);
            textBuscarPedido.TabIndex = 8;
            // 
            // dataGridPedidos
            // 
            dataGridPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPedidos.Location = new Point(128, 92);
            dataGridPedidos.Name = "dataGridPedidos";
            dataGridPedidos.Size = new Size(578, 400);
            dataGridPedidos.TabIndex = 9;
            // 
            // buttonBuscarPedido
            // 
            buttonBuscarPedido.Cursor = Cursors.Hand;
            buttonBuscarPedido.Location = new Point(540, 41);
            buttonBuscarPedido.Name = "buttonBuscarPedido";
            buttonBuscarPedido.Size = new Size(75, 23);
            buttonBuscarPedido.TabIndex = 10;
            buttonBuscarPedido.Text = "Buscar";
            buttonBuscarPedido.UseVisualStyleBackColor = true;
            buttonBuscarPedido.Click += buttonBuscarPedido_Click;
            // 
            // buttonDetalhes
            // 
            buttonDetalhes.Cursor = Cursors.Hand;
            buttonDetalhes.Location = new Point(723, 92);
            buttonDetalhes.Name = "buttonDetalhes";
            buttonDetalhes.Size = new Size(75, 23);
            buttonDetalhes.TabIndex = 11;
            buttonDetalhes.Text = "Detalhes";
            buttonDetalhes.UseVisualStyleBackColor = true;
            buttonDetalhes.Click += buttonDetalhes_Click;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.Cursor = Cursors.Hand;
            buttonFinalizar.Location = new Point(804, 469);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(75, 23);
            buttonFinalizar.TabIndex = 12;
            buttonFinalizar.Text = "Finalizar";
            buttonFinalizar.UseVisualStyleBackColor = true;
            buttonFinalizar.Click += buttonFinalizar_Click;
            // 
            // buttonExtender
            // 
            buttonExtender.Cursor = Cursors.Hand;
            buttonExtender.Location = new Point(723, 469);
            buttonExtender.Name = "buttonExtender";
            buttonExtender.Size = new Size(75, 23);
            buttonExtender.TabIndex = 13;
            buttonExtender.Text = "Extender";
            buttonExtender.UseVisualStyleBackColor = true;
            buttonExtender.Click += buttonExtender_Click;
            // 
            // labelErroPedido
            // 
            labelErroPedido.AutoSize = true;
            labelErroPedido.Location = new Point(131, 505);
            labelErroPedido.Name = "labelErroPedido";
            labelErroPedido.Size = new Size(100, 15);
            labelErroPedido.TabIndex = 14;
            labelErroPedido.Text = "me deixe invisivel";
            // 
            // EditarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 582);
            Controls.Add(labelErroPedido);
            Controls.Add(buttonExtender);
            Controls.Add(buttonFinalizar);
            Controls.Add(buttonDetalhes);
            Controls.Add(buttonBuscarPedido);
            Controls.Add(dataGridPedidos);
            Controls.Add(textBuscarPedido);
            Controls.Add(buttonVoltarMenu);
            Controls.Add(pictureBox1);
            Name = "EditarPedido";
            Text = "EditarPedido";
            Load += EditarPedido_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonVoltarMenu;
        private TextBox textBuscarPedido;
        private DataGridView dataGridPedidos;
        private Button buttonBuscarPedido;
        private Button buttonDetalhes;
        private Button buttonFinalizar;
        private Button buttonExtender;
        private Label labelErroPedido;
    }
}