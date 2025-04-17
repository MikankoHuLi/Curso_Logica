namespace ListaAtividades
{
    partial class CriarAtividade
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
            textBoxTitulo = new TextBox();
            textTitulo = new Label();
            buttonDescartar = new Button();
            buttonCriarTitulo = new Button();
            labelErro = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(310, 174);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(178, 23);
            textBoxTitulo.TabIndex = 0;
            // 
            // textTitulo
            // 
            textTitulo.AutoSize = true;
            textTitulo.Location = new Point(381, 141);
            textTitulo.Name = "textTitulo";
            textTitulo.Size = new Size(37, 15);
            textTitulo.TabIndex = 1;
            textTitulo.Text = "Título";
            // 
            // buttonDescartar
            // 
            buttonDescartar.Location = new Point(310, 203);
            buttonDescartar.Name = "buttonDescartar";
            buttonDescartar.Size = new Size(75, 23);
            buttonDescartar.TabIndex = 2;
            buttonDescartar.Text = "Descartar";
            buttonDescartar.UseVisualStyleBackColor = true;
            buttonDescartar.Click += buttonDescartar_Click;
            // 
            // buttonCriarTitulo
            // 
            buttonCriarTitulo.Location = new Point(413, 203);
            buttonCriarTitulo.Name = "buttonCriarTitulo";
            buttonCriarTitulo.Size = new Size(75, 23);
            buttonCriarTitulo.TabIndex = 3;
            buttonCriarTitulo.Text = "Criar";
            buttonCriarTitulo.UseVisualStyleBackColor = true;
            buttonCriarTitulo.Click += buttonCriarTitulo_Click;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(21, 413);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(38, 15);
            labelErro.TabIndex = 4;
            labelErro.Text = "label2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelErro);
            groupBox1.Controls.Add(textTitulo);
            groupBox1.Controls.Add(buttonCriarTitulo);
            groupBox1.Controls.Add(textBoxTitulo);
            groupBox1.Controls.Add(buttonDescartar);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(799, 450);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // CriarAtividade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "CriarAtividade";
            Text = "Criar Atividade";
            Load += CriarAtividade_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxTitulo;
        private Label textTitulo;
        private Button buttonDescartar;
        private Button buttonCriarTitulo;
        private Label labelErro;
        private GroupBox groupBox1;
    }
}