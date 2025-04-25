namespace ProjetoPi
{
    partial class CriarCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Nome = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            rua = new Label();
            textNome = new TextBox();
            textTelefone = new TextBox();
            textEmail = new TextBox();
            textCpf = new TextBox();
            textCep = new TextBox();
            button1 = new Button();
            labelErro = new Label();
            buttonCriar = new Button();
            SuspendLayout();
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(61, 81);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 0;
            Nome.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 126);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Telefone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 175);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 232);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 3;
            label3.Text = "cpf";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(521, 23);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 4;
            label4.Text = "endereço";
            // 
            // rua
            // 
            rua.AutoSize = true;
            rua.Location = new Point(439, 81);
            rua.Name = "rua";
            rua.Size = new Size(26, 15);
            rua.TabIndex = 5;
            rua.Text = "cep";
            // 
            // textNome
            // 
            textNome.Location = new Point(146, 81);
            textNome.Name = "textNome";
            textNome.Size = new Size(100, 23);
            textNome.TabIndex = 6;
            // 
            // textTelefone
            // 
            textTelefone.Location = new Point(146, 118);
            textTelefone.Name = "textTelefone";
            textTelefone.Size = new Size(100, 23);
            textTelefone.TabIndex = 7;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(146, 172);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(100, 23);
            textEmail.TabIndex = 8;
            // 
            // textCpf
            // 
            textCpf.Location = new Point(146, 224);
            textCpf.Name = "textCpf";
            textCpf.Size = new Size(100, 23);
            textCpf.TabIndex = 9;
            // 
            // textCep
            // 
            textCep.Location = new Point(505, 78);
            textCep.Name = "textCep";
            textCep.Size = new Size(100, 23);
            textCep.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(521, 223);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(12, 596);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(38, 15);
            labelErro.TabIndex = 12;
            labelErro.Text = "label5";
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(654, 585);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(75, 23);
            buttonCriar.TabIndex = 13;
            buttonCriar.Text = "Voltar";
            buttonCriar.UseVisualStyleBackColor = true;
            buttonCriar.Click += buttonCriar_Click;
            // 
            // CriarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 620);
            Controls.Add(buttonCriar);
            Controls.Add(labelErro);
            Controls.Add(button1);
            Controls.Add(textCep);
            Controls.Add(textCpf);
            Controls.Add(textEmail);
            Controls.Add(textTelefone);
            Controls.Add(textNome);
            Controls.Add(rua);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(Nome);
            Name = "CriarCliente";
            Text = "Criar Cliente";
            Load += CriarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nome;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label rua;
        private TextBox textNome;
        private TextBox textTelefone;
        private TextBox textEmail;
        private TextBox textCpf;
        private TextBox textCep;
        private Button button1;
        private Label labelErro;
        private Button buttonCriar;
    }
}
