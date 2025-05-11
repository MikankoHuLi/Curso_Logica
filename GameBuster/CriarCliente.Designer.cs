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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarCliente));
            buttonVoltarMenu = new Button();
            textNome = new TextBox();
            textEmail = new TextBox();
            textLogradouro = new TextBox();
            textNumero = new TextBox();
            textComplemento = new TextBox();
            textBairro = new TextBox();
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
            buttonCadastrar = new Button();
            groupBoxDadosCliente = new GroupBox();
            textCpf = new MaskedTextBox();
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
            textCep = new MaskedTextBox();
            groupBoxEndereço = new GroupBox();
            textCidade = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label4 = new Label();
            label1 = new Label();
            labelErro = new Label();
            groupBoxDadosCliente.SuspendLayout();
            groupBoxEndereço.SuspendLayout();
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
            buttonVoltarMenu.Location = new Point(1277, 707);
            buttonVoltarMenu.Name = "buttonVoltarMenu";
            buttonVoltarMenu.Size = new Size(75, 30);
            buttonVoltarMenu.TabIndex = 6;
            buttonVoltarMenu.Text = "Voltar ";
            buttonVoltarMenu.UseVisualStyleBackColor = false;
            buttonVoltarMenu.Click += buttonVoltarMenu_Click;
            // 
            // textNome
            // 
            textNome.Location = new Point(14, 37);
            textNome.Name = "textNome";
            textNome.Size = new Size(477, 23);
            textNome.TabIndex = 7;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(516, 37);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(199, 23);
            textEmail.TabIndex = 10;
            // 
            // textLogradouro
            // 
            textLogradouro.Location = new Point(14, 47);
            textLogradouro.Name = "textLogradouro";
            textLogradouro.Size = new Size(477, 23);
            textLogradouro.TabIndex = 12;
            // 
            // textNumero
            // 
            textNumero.Location = new Point(516, 47);
            textNumero.Name = "textNumero";
            textNumero.Size = new Size(100, 23);
            textNumero.TabIndex = 13;
            // 
            // textComplemento
            // 
            textComplemento.Location = new Point(628, 47);
            textComplemento.Name = "textComplemento";
            textComplemento.Size = new Size(100, 23);
            textComplemento.TabIndex = 14;
            // 
            // textBairro
            // 
            textBairro.Location = new Point(14, 97);
            textBairro.Name = "textBairro";
            textBairro.Size = new Size(215, 23);
            textBairro.TabIndex = 15;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelEmail.Location = new Point(515, 18);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(43, 17);
            labelEmail.TabIndex = 16;
            labelEmail.Text = "Email:";
            // 
            // labelCEP
            // 
            labelCEP.AutoSize = true;
            labelCEP.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelCEP.Location = new Point(251, 77);
            labelCEP.Name = "labelCEP";
            labelCEP.Size = new Size(34, 17);
            labelCEP.TabIndex = 17;
            labelCEP.Text = "CEP:";
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelCPF.Location = new Point(364, 72);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(34, 17);
            labelCPF.TabIndex = 18;
            labelCPF.Text = "CPF:";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelTelefone.Location = new Point(515, 72);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(61, 17);
            labelTelefone.TabIndex = 19;
            labelTelefone.Text = "Telefone:";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNome.Location = new Point(13, 18);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(48, 17);
            labelNome.TabIndex = 20;
            labelNome.Text = "Nome:";
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelLogradouro.Location = new Point(14, 28);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(82, 17);
            labelLogradouro.TabIndex = 21;
            labelLogradouro.Text = "Logradouro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 22;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelNumero.Location = new Point(516, 28);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(27, 17);
            labelNumero.TabIndex = 23;
            labelNumero.Text = "Nº:";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelBairro.Location = new Point(15, 78);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(47, 17);
            labelBairro.TabIndex = 24;
            labelBairro.Text = "Bairro:";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelComplemento.Location = new Point(628, 28);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(97, 17);
            labelComplemento.TabIndex = 25;
            labelComplemento.Text = "Complemento:";
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelCidade.Location = new Point(372, 78);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(52, 17);
            labelCidade.TabIndex = 27;
            labelCidade.Text = "Cidade:";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Anchor = AnchorStyles.None;
            buttonCadastrar.BackColor = Color.Transparent;
            buttonCadastrar.BackgroundImageLayout = ImageLayout.None;
            buttonCadastrar.Cursor = Cursors.Hand;
            buttonCadastrar.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonCadastrar.FlatStyle = FlatStyle.Flat;
            buttonCadastrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonCadastrar.ForeColor = Color.White;
            buttonCadastrar.Location = new Point(655, 597);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(81, 30);
            buttonCadastrar.TabIndex = 28;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // groupBoxDadosCliente
            // 
            groupBoxDadosCliente.Anchor = AnchorStyles.None;
            groupBoxDadosCliente.BackColor = Color.Transparent;
            groupBoxDadosCliente.Controls.Add(textCpf);
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
            groupBoxDadosCliente.FlatStyle = FlatStyle.Flat;
            groupBoxDadosCliente.ForeColor = SystemColors.ButtonFace;
            groupBoxDadosCliente.Location = new Point(239, 210);
            groupBoxDadosCliente.Name = "groupBoxDadosCliente";
            groupBoxDadosCliente.Size = new Size(911, 158);
            groupBoxDadosCliente.TabIndex = 29;
            groupBoxDadosCliente.TabStop = false;
            groupBoxDadosCliente.Text = "Dados básicos";
            // 
            // textCpf
            // 
            textCpf.Location = new Point(364, 92);
            textCpf.Mask = "00000000000";
            textCpf.Name = "textCpf";
            textCpf.Size = new Size(100, 23);
            textCpf.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(507, 71);
            label9.Name = "label9";
            label9.Size = new Size(12, 15);
            label9.TabIndex = 36;
            label9.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(507, 21);
            label8.Name = "label8";
            label8.Size = new Size(12, 15);
            label8.TabIndex = 35;
            label8.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(186, 73);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 34;
            label7.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(355, 71);
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
            label5.Location = new Point(5, 71);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 32;
            label5.Text = "*";
            // 
            // labelAsterisco
            // 
            labelAsterisco.AutoSize = true;
            labelAsterisco.ForeColor = Color.Red;
            labelAsterisco.Location = new Point(5, 21);
            labelAsterisco.Name = "labelAsterisco";
            labelAsterisco.Size = new Size(12, 15);
            labelAsterisco.TabIndex = 30;
            labelAsterisco.Text = "*";
            // 
            // maskTextTelefone
            // 
            maskTextTelefone.Location = new Point(516, 92);
            maskTextTelefone.Mask = "(99)00000-0000";
            maskTextTelefone.Name = "maskTextTelefone";
            maskTextTelefone.Size = new Size(115, 23);
            maskTextTelefone.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(194, 73);
            label3.Name = "label3";
            label3.Size = new Size(55, 17);
            label3.TabIndex = 26;
            label3.Text = "Genêro:";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Feminino", "Masculino", "NãoBinário", "Outro" });
            comboBoxGenero.Location = new Point(195, 92);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(121, 23);
            comboBoxGenero.TabIndex = 25;
            // 
            // labelDataDeNascimento
            // 
            labelDataDeNascimento.AutoSize = true;
            labelDataDeNascimento.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelDataDeNascimento.Location = new Point(13, 72);
            labelDataDeNascimento.Name = "labelDataDeNascimento";
            labelDataDeNascimento.Size = new Size(134, 17);
            labelDataDeNascimento.TabIndex = 24;
            labelDataDeNascimento.Text = "Data de Nascimento:";
            // 
            // maskedTextBoxDataDeNascimento
            // 
            maskedTextBoxDataDeNascimento.Location = new Point(14, 92);
            maskedTextBoxDataDeNascimento.Mask = "00/00/0000";
            maskedTextBoxDataDeNascimento.Name = "maskedTextBoxDataDeNascimento";
            maskedTextBoxDataDeNascimento.Size = new Size(134, 23);
            maskedTextBoxDataDeNascimento.TabIndex = 23;
            maskedTextBoxDataDeNascimento.ValidatingType = typeof(DateTime);
            // 
            // textCep
            // 
            textCep.Location = new Point(250, 97);
            textCep.Mask = "00000000";
            textCep.Name = "textCep";
            textCep.Size = new Size(100, 23);
            textCep.TabIndex = 37;
            // 
            // groupBoxEndereço
            // 
            groupBoxEndereço.Anchor = AnchorStyles.None;
            groupBoxEndereço.BackColor = Color.Transparent;
            groupBoxEndereço.Controls.Add(textCidade);
            groupBoxEndereço.Controls.Add(textCep);
            groupBoxEndereço.Controls.Add(label12);
            groupBoxEndereço.Controls.Add(label11);
            groupBoxEndereço.Controls.Add(label10);
            groupBoxEndereço.Controls.Add(label4);
            groupBoxEndereço.Controls.Add(label1);
            groupBoxEndereço.Controls.Add(labelLogradouro);
            groupBoxEndereço.Controls.Add(textLogradouro);
            groupBoxEndereço.Controls.Add(textNumero);
            groupBoxEndereço.Controls.Add(labelCidade);
            groupBoxEndereço.Controls.Add(textComplemento);
            groupBoxEndereço.Controls.Add(labelNumero);
            groupBoxEndereço.Controls.Add(labelBairro);
            groupBoxEndereço.Controls.Add(labelCEP);
            groupBoxEndereço.Controls.Add(labelComplemento);
            groupBoxEndereço.Controls.Add(textBairro);
            groupBoxEndereço.FlatStyle = FlatStyle.Flat;
            groupBoxEndereço.ForeColor = Color.White;
            groupBoxEndereço.Location = new Point(239, 374);
            groupBoxEndereço.Name = "groupBoxEndereço";
            groupBoxEndereço.Size = new Size(911, 144);
            groupBoxEndereço.TabIndex = 30;
            groupBoxEndereço.TabStop = false;
            groupBoxEndereço.Text = "Endereço";
            // 
            // textCidade
            // 
            textCidade.Location = new Point(372, 97);
            textCidade.Name = "textCidade";
            textCidade.Size = new Size(119, 23);
            textCidade.TabIndex = 42;
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
            label11.Location = new Point(363, 79);
            label11.Name = "label11";
            label11.Size = new Size(12, 15);
            label11.TabIndex = 40;
            label11.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(242, 78);
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
            labelErro.Anchor = AnchorStyles.None;
            labelErro.AutoSize = true;
            labelErro.BackColor = Color.Transparent;
            labelErro.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelErro.ForeColor = Color.White;
            labelErro.Location = new Point(639, 547);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(114, 17);
            labelErro.TabIndex = 31;
            labelErro.Text = "me deixe invisivel";
            // 
            // CriarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1364, 749);
            Controls.Add(labelErro);
            Controls.Add(groupBoxEndereço);
            Controls.Add(groupBoxDadosCliente);
            Controls.Add(buttonCadastrar);
            Controls.Add(label2);
            Controls.Add(buttonVoltarMenu);
            Name = "CriarCliente";
            Text = "CriarCliente";
            WindowState = FormWindowState.Maximized;
            Load += CriarCliente_Load;
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
        private TextBox textBox2;
        private TextBox textEmail;
        private TextBox textLogradouro;
        private TextBox textNumero;
        private TextBox textComplemento;
        private TextBox textBairro;
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
        private MaskedTextBox textCep;
        private MaskedTextBox textCpf;
        private TextBox textCidade;
    }
}