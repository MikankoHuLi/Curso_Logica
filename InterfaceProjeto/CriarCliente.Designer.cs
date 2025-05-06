namespace InterfaceProjeto
{
    partial class CriarCliente
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
            textNome = new TextBox();
            textCep = new TextBox();
            textCpf = new TextBox();
            textEmail = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            labelEmail = new Label();
            labelCEP = new Label();
            labelCPF = new Label();
            labelTelefone = new Label();
            labelNome = new Label();
            labelLogradouro = new Label();
            label2 = new Label();
            labelNumero = new Label();
            labelBairro = new Label();
            labelComplemento = new Label();
            labelCidade = new Label();
            textBox10 = new TextBox();
            buttonCadastrar = new Button();
            groupBoxDadosCliente = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            labelAsterisco = new Label();
            maskTextTelefone = new MaskedTextBox();
            label3 = new Label();
            comboBoxGenero = new ComboBox();
            labelDataDeNascimento = new Label();
            maskedTextBoxDataDeNascimento = new MaskedTextBox();
            groupBoxEndereço = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label4 = new Label();
            label1 = new Label();
            labelErro = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxDadosCliente.SuspendLayout();
            groupBoxEndereço.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dd2oj85_b5bab19d_e110_4f51_ae2b_ca39dd6d8d74;
            pictureBox1.Location = new Point(745, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // buttonVoltarMenu
            // 
            buttonVoltarMenu.Cursor = Cursors.Hand;
            buttonVoltarMenu.FlatStyle = FlatStyle.Flat;
            buttonVoltarMenu.Location = new Point(823, 552);
            buttonVoltarMenu.Name = "buttonVoltarMenu";
            buttonVoltarMenu.Size = new Size(75, 23);
            buttonVoltarMenu.TabIndex = 6;
            buttonVoltarMenu.Text = "Voltar ";
            buttonVoltarMenu.UseVisualStyleBackColor = true;
            buttonVoltarMenu.Click += buttonVoltarMenu_Click;
            // 
            // textNome
            // 
            textNome.Location = new Point(14, 37);
            textNome.Name = "textNome";
            textNome.Size = new Size(477, 23);
            textNome.TabIndex = 7;
            // 
            // textCep
            // 
            textCep.Location = new Point(249, 97);
            textCep.Name = "textCep";
            textCep.Size = new Size(100, 23);
            textCep.TabIndex = 8;
            // 
            // textCpf
            // 
            textCpf.Location = new Point(336, 92);
            textCpf.Name = "textCpf";
            textCpf.Size = new Size(155, 23);
            textCpf.TabIndex = 9;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(516, 37);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(199, 23);
            textEmail.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(14, 47);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(477, 23);
            textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(516, 47);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 13;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(628, 47);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 14;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(14, 97);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(215, 23);
            textBox9.TabIndex = 15;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(516, 19);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 16;
            labelEmail.Text = "Email:";
            // 
            // labelCEP
            // 
            labelCEP.AutoSize = true;
            labelCEP.Location = new Point(249, 79);
            labelCEP.Name = "labelCEP";
            labelCEP.Size = new Size(31, 15);
            labelCEP.TabIndex = 17;
            labelCEP.Text = "CEP:";
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Location = new Point(336, 76);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(31, 15);
            labelCPF.TabIndex = 18;
            labelCPF.Text = "CPF:";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(516, 74);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(54, 15);
            labelTelefone.TabIndex = 19;
            labelTelefone.Text = "Telefone:";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(14, 19);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(43, 15);
            labelNome.TabIndex = 20;
            labelNome.Text = "Nome:";
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(14, 29);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(72, 15);
            labelLogradouro.TabIndex = 21;
            labelLogradouro.Text = "Logradouro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(154, 15);
            label2.TabIndex = 22;
            label2.Text = "Informe os dados do cliente";
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(516, 29);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(24, 15);
            labelNumero.TabIndex = 23;
            labelNumero.Text = "Nº:";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(16, 79);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(41, 15);
            labelBairro.TabIndex = 24;
            labelBairro.Text = "Bairro:";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(628, 29);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(87, 15);
            labelComplemento.TabIndex = 25;
            labelComplemento.Text = "Complemento:";
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(400, 79);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(47, 15);
            labelCidade.TabIndex = 27;
            labelCidade.Text = "Cidade:";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(400, 97);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 26;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.BackgroundImageLayout = ImageLayout.None;
            buttonCadastrar.Cursor = Cursors.Hand;
            buttonCadastrar.FlatStyle = FlatStyle.Flat;
            buttonCadastrar.Location = new Point(428, 539);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(75, 23);
            buttonCadastrar.TabIndex = 28;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // groupBoxDadosCliente
            // 
            groupBoxDadosCliente.Controls.Add(label9);
            groupBoxDadosCliente.Controls.Add(label8);
            groupBoxDadosCliente.Controls.Add(label7);
            groupBoxDadosCliente.Controls.Add(label6);
            groupBoxDadosCliente.Controls.Add(label5);
            groupBoxDadosCliente.Controls.Add(labelAsterisco);
            groupBoxDadosCliente.Controls.Add(maskTextTelefone);
            groupBoxDadosCliente.Controls.Add(label3);
            groupBoxDadosCliente.Controls.Add(comboBoxGenero);
            groupBoxDadosCliente.Controls.Add(labelDataDeNascimento);
            groupBoxDadosCliente.Controls.Add(maskedTextBoxDataDeNascimento);
            groupBoxDadosCliente.Controls.Add(labelNome);
            groupBoxDadosCliente.Controls.Add(textNome);
            groupBoxDadosCliente.Controls.Add(textEmail);
            groupBoxDadosCliente.Controls.Add(labelCPF);
            groupBoxDadosCliente.Controls.Add(labelEmail);
            groupBoxDadosCliente.Controls.Add(labelTelefone);
            groupBoxDadosCliente.Controls.Add(textCpf);
            groupBoxDadosCliente.Location = new Point(12, 55);
            groupBoxDadosCliente.Name = "groupBoxDadosCliente";
            groupBoxDadosCliente.Size = new Size(776, 128);
            groupBoxDadosCliente.TabIndex = 29;
            groupBoxDadosCliente.TabStop = false;
            groupBoxDadosCliente.Text = "Dados básicos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(508, 76);
            label9.Name = "label9";
            label9.Size = new Size(12, 15);
            label9.TabIndex = 36;
            label9.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(508, 19);
            label8.Name = "label8";
            label8.Size = new Size(12, 15);
            label8.TabIndex = 35;
            label8.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(142, 76);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 34;
            label7.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(327, 74);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 33;
            label6.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(6, 71);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 32;
            label5.Text = "*";
            // 
            // labelAsterisco
            // 
            labelAsterisco.AutoSize = true;
            labelAsterisco.ForeColor = Color.Red;
            labelAsterisco.Location = new Point(6, 19);
            labelAsterisco.Name = "labelAsterisco";
            labelAsterisco.Size = new Size(12, 15);
            labelAsterisco.TabIndex = 30;
            labelAsterisco.Text = "*";
            // 
            // maskTextTelefone
            // 
            maskTextTelefone.Location = new Point(516, 92);
            maskTextTelefone.Mask = "(99) 00000-0000";
            maskTextTelefone.Name = "maskTextTelefone";
            maskTextTelefone.Size = new Size(115, 23);
            maskTextTelefone.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 76);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 26;
            label3.Text = "Genêro:";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Feminino", "Masculino", "NãoBinário", "Outro" });
            comboBoxGenero.Location = new Point(152, 92);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(121, 23);
            comboBoxGenero.TabIndex = 25;
            // 
            // labelDataDeNascimento
            // 
            labelDataDeNascimento.AutoSize = true;
            labelDataDeNascimento.Location = new Point(14, 71);
            labelDataDeNascimento.Name = "labelDataDeNascimento";
            labelDataDeNascimento.Size = new Size(117, 15);
            labelDataDeNascimento.TabIndex = 24;
            labelDataDeNascimento.Text = "Data de Nascimento:";
            // 
            // maskedTextBoxDataDeNascimento
            // 
            maskedTextBoxDataDeNascimento.Location = new Point(14, 92);
            maskedTextBoxDataDeNascimento.Mask = "00/00/0000";
            maskedTextBoxDataDeNascimento.Name = "maskedTextBoxDataDeNascimento";
            maskedTextBoxDataDeNascimento.Size = new Size(100, 23);
            maskedTextBoxDataDeNascimento.TabIndex = 23;
            maskedTextBoxDataDeNascimento.ValidatingType = typeof(DateTime);
            // 
            // groupBoxEndereço
            // 
            groupBoxEndereço.Controls.Add(label12);
            groupBoxEndereço.Controls.Add(label11);
            groupBoxEndereço.Controls.Add(label10);
            groupBoxEndereço.Controls.Add(label4);
            groupBoxEndereço.Controls.Add(label1);
            groupBoxEndereço.Controls.Add(labelLogradouro);
            groupBoxEndereço.Controls.Add(textBox6);
            groupBoxEndereço.Controls.Add(textBox7);
            groupBoxEndereço.Controls.Add(textBox10);
            groupBoxEndereço.Controls.Add(labelCidade);
            groupBoxEndereço.Controls.Add(textBox8);
            groupBoxEndereço.Controls.Add(labelNumero);
            groupBoxEndereço.Controls.Add(labelBairro);
            groupBoxEndereço.Controls.Add(textCep);
            groupBoxEndereço.Controls.Add(labelCEP);
            groupBoxEndereço.Controls.Add(labelComplemento);
            groupBoxEndereço.Controls.Add(textBox9);
            groupBoxEndereço.Location = new Point(12, 198);
            groupBoxEndereço.Name = "groupBoxEndereço";
            groupBoxEndereço.Size = new Size(776, 184);
            groupBoxEndereço.TabIndex = 30;
            groupBoxEndereço.TabStop = false;
            groupBoxEndereço.Text = "Endereço";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(508, 29);
            label12.Name = "label12";
            label12.Size = new Size(12, 15);
            label12.TabIndex = 41;
            label12.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(391, 79);
            label11.Name = "label11";
            label11.Size = new Size(12, 15);
            label11.TabIndex = 40;
            label11.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(240, 79);
            label10.Name = "label10";
            label10.Size = new Size(12, 15);
            label10.TabIndex = 39;
            label10.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(6, 79);
            label4.Name = "label4";
            label4.Size = new Size(12, 15);
            label4.TabIndex = 38;
            label4.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 37;
            label1.Text = "*";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(20, 395);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(100, 15);
            labelErro.TabIndex = 31;
            labelErro.Text = "me deixe invisivel";
            // 
            // CriarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 587);
            Controls.Add(labelErro);
            Controls.Add(groupBoxEndereço);
            Controls.Add(groupBoxDadosCliente);
            Controls.Add(buttonCadastrar);
            Controls.Add(label2);
            Controls.Add(buttonVoltarMenu);
            Controls.Add(pictureBox1);
            Name = "CriarCliente";
            Text = "CriarCliente";
            Load += CriarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxDadosCliente.ResumeLayout(false);
            groupBoxDadosCliente.PerformLayout();
            groupBoxEndereço.ResumeLayout(false);
            groupBoxEndereço.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonVoltarMenu;
        private TextBox textNome;
        private TextBox textCep;
        private TextBox textCpf;
        private TextBox textEmail;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label labelEmail;
        private Label labelCEP;
        private Label labelCPF;
        private Label labelTelefone;
        private Label labelNome;
        private Label labelLogradouro;
        private Label label2;
        private Label labelNumero;
        private Label labelBairro;
        private Label labelComplemento;
        private Label labelCidade;
        private TextBox textBox10;
        private Button buttonCadastrar;
        private GroupBox groupBoxDadosCliente;
        private Label labelDataDeNascimento;
        private MaskedTextBox maskedTextBoxDataDeNascimento;
        private Label label3;
        private ComboBox comboBoxGenero;
        private Label label6;
        private Label label5;
        private Label labelAsterisco;
        private MaskedTextBox maskTextTelefone;
        private Label label9;
        private Label label8;
        private Label label7;
        private GroupBox groupBoxEndereço;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label4;
        private Label label1;
        private Label labelErro;
    }
}