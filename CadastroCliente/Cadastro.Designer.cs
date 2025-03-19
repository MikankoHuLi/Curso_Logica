namespace CadastroCliente
{
    partial class Cadastro
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
            label1 = new Label();
            label2 = new Label();
            textNome = new TextBox();
            label3 = new Label();
            textTelefone = new MaskedTextBox();
            label4 = new Label();
            textNascimento = new MaskedTextBox();
            label5 = new Label();
            textEmail = new TextBox();
            label6 = new Label();
            textGenero = new ComboBox();
            label7 = new Label();
            textNomeSocial = new TextBox();
            label8 = new Label();
            checkEstrangeiro = new CheckBox();
            label9 = new Label();
            textEtnia = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            label10 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            textRua = new TextBox();
            textNumeroCasa = new TextBox();
            textComplemento = new TextBox();
            textBairro = new TextBox();
            textMunicipio = new TextBox();
            textEstado = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            butCadastro = new Button();
            button1 = new Button();
            cadastrolabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(284, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 36);
            label1.TabIndex = 0;
            label1.Text = "Formulário";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 20);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome*";
            // 
            // textNome
            // 
            textNome.Anchor = AnchorStyles.None;
            textNome.Location = new Point(166, 19);
            textNome.Name = "textNome";
            textNome.Size = new Size(100, 23);
            textNome.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 81);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 3;
            label3.Text = "Telefone*";
            // 
            // textTelefone
            // 
            textTelefone.Anchor = AnchorStyles.None;
            textTelefone.Location = new Point(166, 80);
            textTelefone.Mask = "(99) 00000-0000";
            textTelefone.Name = "textTelefone";
            textTelefone.Size = new Size(100, 23);
            textTelefone.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(9, 131);
            label4.Name = "label4";
            label4.Size = new Size(125, 42);
            label4.TabIndex = 5;
            label4.Text = "         Data\r\n de Nascimento*";
            // 
            // textNascimento
            // 
            textNascimento.Anchor = AnchorStyles.None;
            textNascimento.Location = new Point(166, 141);
            textNascimento.Mask = "00/00/0000";
            textNascimento.Name = "textNascimento";
            textNascimento.Size = new Size(100, 23);
            textNascimento.TabIndex = 6;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 203);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 7;
            label5.Text = "Email*";
            // 
            // textEmail
            // 
            textEmail.Anchor = AnchorStyles.None;
            textEmail.Location = new Point(166, 202);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(100, 23);
            textEmail.TabIndex = 8;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 386);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 9;
            label6.Text = "Gênero*";
            // 
            // textGenero
            // 
            textGenero.Anchor = AnchorStyles.None;
            textGenero.FormattingEnabled = true;
            textGenero.Items.AddRange(new object[] { " Masculino", " Feminino", " NãoBinario", " Outro" });
            textGenero.Location = new Point(155, 385);
            textGenero.Name = "textGenero";
            textGenero.Size = new Size(121, 23);
            textGenero.TabIndex = 10;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 264);
            label7.Name = "label7";
            label7.Size = new Size(98, 21);
            label7.TabIndex = 11;
            label7.Text = "Nome Social";
            // 
            // textNomeSocial
            // 
            textNomeSocial.Anchor = AnchorStyles.None;
            textNomeSocial.Location = new Point(166, 263);
            textNomeSocial.Name = "textNomeSocial";
            textNomeSocial.Size = new Size(100, 23);
            textNomeSocial.TabIndex = 12;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(27, 325);
            label8.Name = "label8";
            label8.Size = new Size(89, 21);
            label8.TabIndex = 13;
            label8.Text = "Estrangeiro";
            // 
            // checkEstrangeiro
            // 
            checkEstrangeiro.Anchor = AnchorStyles.None;
            checkEstrangeiro.AutoSize = true;
            checkEstrangeiro.Location = new Point(193, 326);
            checkEstrangeiro.Name = "checkEstrangeiro";
            checkEstrangeiro.Size = new Size(46, 19);
            checkEstrangeiro.TabIndex = 14;
            checkEstrangeiro.Text = "Sim";
            checkEstrangeiro.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(46, 448);
            label9.Name = "label9";
            label9.Size = new Size(51, 21);
            label9.TabIndex = 15;
            label9.Text = "Etnia*";
            // 
            // textEtnia
            // 
            textEtnia.Anchor = AnchorStyles.None;
            textEtnia.FormattingEnabled = true;
            textEtnia.Items.AddRange(new object[] { "Branco", "Negro", "Pardo", "Amarelo", "Indígena", "Outro" });
            textEtnia.Location = new Point(155, 447);
            textEtnia.Name = "textEtnia";
            textEtnia.Size = new Size(121, 23);
            textEtnia.TabIndex = 17;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.None;
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(216, 551);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(38, 19);
            radioButton1.TabIndex = 18;
            radioButton1.TabStop = true;
            radioButton1.Text = "PF";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(216, 576);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(35, 19);
            radioButton2.TabIndex = 19;
            radioButton2.TabStop = true;
            radioButton2.Text = "PJ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(textNome, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(textEtnia, 1, 7);
            tableLayoutPanel1.Controls.Add(textTelefone, 1, 1);
            tableLayoutPanel1.Controls.Add(textGenero, 1, 6);
            tableLayoutPanel1.Controls.Add(label8, 0, 5);
            tableLayoutPanel1.Controls.Add(textNomeSocial, 1, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label9, 0, 7);
            tableLayoutPanel1.Controls.Add(textNascimento, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(textEmail, 1, 3);
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 6);
            tableLayoutPanel1.Controls.Add(checkEstrangeiro, 1, 5);
            tableLayoutPanel1.Location = new Point(22, 55);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5000019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5000019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5000019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5000019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5000019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5000019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(288, 490);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(70, 559);
            label10.Name = "label10";
            label10.Size = new Size(47, 21);
            label10.TabIndex = 16;
            label10.Text = "Tipo*";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label11, 0, 0);
            tableLayoutPanel2.Controls.Add(label12, 0, 1);
            tableLayoutPanel2.Controls.Add(label13, 0, 2);
            tableLayoutPanel2.Controls.Add(label14, 0, 3);
            tableLayoutPanel2.Controls.Add(label15, 0, 4);
            tableLayoutPanel2.Controls.Add(label16, 0, 5);
            tableLayoutPanel2.Controls.Add(label17, 0, 6);
            tableLayoutPanel2.Controls.Add(textRua, 1, 0);
            tableLayoutPanel2.Controls.Add(textNumeroCasa, 1, 1);
            tableLayoutPanel2.Controls.Add(textComplemento, 1, 2);
            tableLayoutPanel2.Controls.Add(textBairro, 1, 3);
            tableLayoutPanel2.Controls.Add(textMunicipio, 1, 4);
            tableLayoutPanel2.Controls.Add(textEstado, 1, 5);
            tableLayoutPanel2.Controls.Add(maskedTextBox1, 1, 6);
            tableLayoutPanel2.Location = new Point(393, 55);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.Size = new Size(288, 490);
            tableLayoutPanel2.TabIndex = 21;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(22, 20);
            label11.Name = "label11";
            label11.Size = new Size(99, 21);
            label11.TabIndex = 22;
            label11.Text = "Logradouro*";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(34, 81);
            label12.Name = "label12";
            label12.Size = new Size(75, 21);
            label12.TabIndex = 23;
            label12.Text = "Número*";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(17, 142);
            label13.Name = "label13";
            label13.Size = new Size(109, 21);
            label13.TabIndex = 24;
            label13.Text = "Complemento";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(42, 203);
            label14.Name = "label14";
            label14.Size = new Size(59, 21);
            label14.TabIndex = 25;
            label14.Text = "Bairro*";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(29, 264);
            label15.Name = "label15";
            label15.Size = new Size(86, 21);
            label15.TabIndex = 26;
            label15.Text = "Município*";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(40, 325);
            label16.Name = "label16";
            label16.Size = new Size(63, 21);
            label16.TabIndex = 27;
            label16.Text = "Estado*";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.None;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(50, 386);
            label17.Name = "label17";
            label17.Size = new Size(44, 21);
            label17.TabIndex = 28;
            label17.Text = "CEP*";
            // 
            // textRua
            // 
            textRua.Anchor = AnchorStyles.None;
            textRua.Location = new Point(166, 19);
            textRua.Name = "textRua";
            textRua.Size = new Size(100, 23);
            textRua.TabIndex = 29;
            // 
            // textNumeroCasa
            // 
            textNumeroCasa.Anchor = AnchorStyles.None;
            textNumeroCasa.Location = new Point(166, 80);
            textNumeroCasa.Name = "textNumeroCasa";
            textNumeroCasa.Size = new Size(100, 23);
            textNumeroCasa.TabIndex = 30;
            // 
            // textComplemento
            // 
            textComplemento.Anchor = AnchorStyles.None;
            textComplemento.Location = new Point(166, 141);
            textComplemento.Name = "textComplemento";
            textComplemento.Size = new Size(100, 23);
            textComplemento.TabIndex = 31;
            // 
            // textBairro
            // 
            textBairro.Anchor = AnchorStyles.None;
            textBairro.Location = new Point(166, 202);
            textBairro.Name = "textBairro";
            textBairro.Size = new Size(100, 23);
            textBairro.TabIndex = 32;
            // 
            // textMunicipio
            // 
            textMunicipio.Anchor = AnchorStyles.None;
            textMunicipio.Location = new Point(166, 263);
            textMunicipio.Name = "textMunicipio";
            textMunicipio.Size = new Size(100, 23);
            textMunicipio.TabIndex = 33;
            // 
            // textEstado
            // 
            textEstado.Anchor = AnchorStyles.None;
            textEstado.FormattingEnabled = true;
            textEstado.Items.AddRange(new object[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Paraná", "Paraíba", "Pará", "Pernambuco", "Piauí", "Rio Grande do Norte", "Rio Grande do Sul", "Rio de Janeiro", "Rondônia", "Roraima", "Santa Catarina", "Sergipe", "São Paulo", "Tocantins" });
            textEstado.Location = new Point(155, 324);
            textEstado.Name = "textEstado";
            textEstado.Size = new Size(121, 23);
            textEstado.TabIndex = 34;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Anchor = AnchorStyles.None;
            maskedTextBox1.Location = new Point(166, 385);
            maskedTextBox1.Mask = "00000-9999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 35;
            // 
            // butCadastro
            // 
            butCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butCadastro.Location = new Point(481, 555);
            butCadastro.Name = "butCadastro";
            butCadastro.Size = new Size(118, 28);
            butCadastro.TabIndex = 22;
            butCadastro.Text = "Cadastrar";
            butCadastro.UseVisualStyleBackColor = true;
            butCadastro.Click += butCadastro_Click;
            // 
            // button1
            // 
            button1.Location = new Point(316, 401);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 23;
            button1.Text = "clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cadastrolabel
            // 
            cadastrolabel.AutoSize = true;
            cadastrolabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastrolabel.Location = new Point(452, 589);
            cadastrolabel.Name = "cadastrolabel";
            cadastrolabel.Size = new Size(0, 21);
            cadastrolabel.TabIndex = 24;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 619);
            Controls.Add(cadastrolabel);
            Controls.Add(button1);
            Controls.Add(butCadastro);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(radioButton2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(radioButton1);
            Name = "Cadastro";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textNome;
        private Label label3;
        private MaskedTextBox textTelefone;
        private Label label4;
        private MaskedTextBox textNascimento;
        private Label label5;
        private TextBox textEmail;
        private Label label6;
        private ComboBox textGenero;
        private Label label7;
        private TextBox textNomeSocial;
        private Label label8;
        private CheckBox checkEstrangeiro;
        private Label label9;
        private ComboBox textEtnia;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox textRua;
        private TextBox textNumeroCasa;
        private TextBox textComplemento;
        private TextBox textBairro;
        private TextBox textMunicipio;
        private ComboBox textEstado;
        private Button butCadastro;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private Label cadastrolabel;
    }
}
