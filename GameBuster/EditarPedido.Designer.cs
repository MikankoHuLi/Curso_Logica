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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarPedido));
            textBuscarPedido = new TextBox();
            dataGridPedidos = new DataGridView();
            buttonBuscarPedido = new Button();
            buttonDetalhes = new Button();
            buttonFinalizar = new Button();
            buttonExtender = new Button();
            buttonVoltarMenu = new Button();
            labelErroPedido = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridPedidos).BeginInit();
            SuspendLayout();
            // 
            // textBuscarPedido
            // 
            textBuscarPedido.Anchor = AnchorStyles.Top;
            textBuscarPedido.BackColor = Color.White;
            textBuscarPedido.Location = new Point(634, 343);
            textBuscarPedido.Name = "textBuscarPedido";
            textBuscarPedido.Size = new Size(443, 25);
            textBuscarPedido.TabIndex = 8;
            // 
            // dataGridPedidos
            // 
            dataGridPedidos.Anchor = AnchorStyles.None;
            dataGridPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPedidos.Location = new Point(272, 414);
            dataGridPedidos.Name = "dataGridPedidos";
            dataGridPedidos.Size = new Size(1251, 573);
            dataGridPedidos.TabIndex = 9;
            // 
            // buttonBuscarPedido
            // 
            buttonBuscarPedido.Anchor = AnchorStyles.Top;
            buttonBuscarPedido.BackColor = Color.Transparent;
            buttonBuscarPedido.Cursor = Cursors.Hand;
            buttonBuscarPedido.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonBuscarPedido.FlatStyle = FlatStyle.Flat;
            buttonBuscarPedido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscarPedido.ForeColor = Color.White;
            buttonBuscarPedido.Location = new Point(1083, 339);
            buttonBuscarPedido.Name = "buttonBuscarPedido";
            buttonBuscarPedido.Size = new Size(75, 30);
            buttonBuscarPedido.TabIndex = 10;
            buttonBuscarPedido.Text = "Buscar";
            buttonBuscarPedido.UseVisualStyleBackColor = false;
            buttonBuscarPedido.Click += buttonBuscarPedido_Click;
            // 
            // buttonDetalhes
            // 
            buttonDetalhes.Anchor = AnchorStyles.None;
            buttonDetalhes.BackColor = Color.Transparent;
            buttonDetalhes.Cursor = Cursors.Hand;
            buttonDetalhes.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonDetalhes.FlatStyle = FlatStyle.Flat;
            buttonDetalhes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonDetalhes.ForeColor = Color.White;
            buttonDetalhes.Location = new Point(1531, 414);
            buttonDetalhes.Name = "buttonDetalhes";
            buttonDetalhes.Size = new Size(75, 30);
            buttonDetalhes.TabIndex = 11;
            buttonDetalhes.Text = "Detalhes";
            buttonDetalhes.UseVisualStyleBackColor = false;
            buttonDetalhes.Click += buttonDetalhes_Click;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.Anchor = AnchorStyles.None;
            buttonFinalizar.BackColor = Color.Transparent;
            buttonFinalizar.Cursor = Cursors.Hand;
            buttonFinalizar.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonFinalizar.FlatStyle = FlatStyle.Flat;
            buttonFinalizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonFinalizar.ForeColor = Color.White;
            buttonFinalizar.Location = new Point(1623, 953);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(75, 30);
            buttonFinalizar.TabIndex = 12;
            buttonFinalizar.Text = "Finalizar";
            buttonFinalizar.UseVisualStyleBackColor = false;
            buttonFinalizar.Click += buttonFinalizar_Click;
            // 
            // buttonExtender
            // 
            buttonExtender.Anchor = AnchorStyles.None;
            buttonExtender.BackColor = Color.Transparent;
            buttonExtender.Cursor = Cursors.Hand;
            buttonExtender.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonExtender.FlatStyle = FlatStyle.Flat;
            buttonExtender.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonExtender.ForeColor = Color.White;
            buttonExtender.Location = new Point(1531, 953);
            buttonExtender.Name = "buttonExtender";
            buttonExtender.Size = new Size(75, 30);
            buttonExtender.TabIndex = 13;
            buttonExtender.Text = "Extender";
            buttonExtender.UseVisualStyleBackColor = false;
            buttonExtender.Click += buttonExtender_Click;
            // 
            // buttonVoltarMenu
            // 
            buttonVoltarMenu.Anchor = AnchorStyles.None;
            buttonVoltarMenu.BackColor = Color.Transparent;
            buttonVoltarMenu.Cursor = Cursors.Hand;
            buttonVoltarMenu.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonVoltarMenu.FlatStyle = FlatStyle.Flat;
            buttonVoltarMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonVoltarMenu.ForeColor = Color.White;
            buttonVoltarMenu.Location = new Point(1817, 989);
            buttonVoltarMenu.Name = "buttonVoltarMenu";
            buttonVoltarMenu.Size = new Size(75, 30);
            buttonVoltarMenu.TabIndex = 14;
            buttonVoltarMenu.Text = "Voltar";
            buttonVoltarMenu.UseVisualStyleBackColor = false;
            buttonVoltarMenu.Click += buttonVoltarMenu_Click_1;
            // 
            // labelErroPedido
            // 
            labelErroPedido.Anchor = AnchorStyles.None;
            labelErroPedido.AutoSize = true;
            labelErroPedido.BackColor = Color.Transparent;
            labelErroPedido.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelErroPedido.ForeColor = Color.White;
            labelErroPedido.Location = new Point(924, 996);
            labelErroPedido.Name = "labelErroPedido";
            labelErroPedido.Size = new Size(114, 17);
            labelErroPedido.TabIndex = 32;
            labelErroPedido.Text = "me deixe invisivel";
            // 
            // EditarPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(labelErroPedido);
            Controls.Add(buttonVoltarMenu);
            Controls.Add(buttonExtender);
            Controls.Add(buttonFinalizar);
            Controls.Add(buttonDetalhes);
            Controls.Add(buttonBuscarPedido);
            Controls.Add(dataGridPedidos);
            Controls.Add(textBuscarPedido);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "EditarPedido";
            Text = "EditarPedido";
            WindowState = FormWindowState.Maximized;
            Load += EditarPedido_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBuscarPedido;
        private DataGridView dataGridPedidos;
        private Button buttonBuscarPedido;
        private Button buttonDetalhes;
        private Button buttonFinalizar;
        private Button buttonExtender;
        private Button buttonVoltarMenu;
        private Label labelErroPedido;
    }
}