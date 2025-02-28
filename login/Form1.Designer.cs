namespace login
{
    partial class FormLogin
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
            textboxuser = new TextBox();
            textboxsenha = new TextBox();
            botaoentrar = new Button();
            email = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            labelresult = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            regUser = new TextBox();
            regSenha = new TextBox();
            regBotao = new Button();
            SuspendLayout();
            // 
            // textboxuser
            // 
            textboxuser.Location = new Point(409, 207);
            textboxuser.Name = "textboxuser";
            textboxuser.Size = new Size(100, 23);
            textboxuser.TabIndex = 0;
            textboxuser.TextChanged += textBox1_TextChanged;
            // 
            // textboxsenha
            // 
            textboxsenha.Location = new Point(409, 260);
            textboxsenha.Name = "textboxsenha";
            textboxsenha.Size = new Size(100, 23);
            textboxsenha.TabIndex = 1;
            // 
            // botaoentrar
            // 
            botaoentrar.Location = new Point(419, 322);
            botaoentrar.Name = "botaoentrar";
            botaoentrar.Size = new Size(75, 23);
            botaoentrar.TabIndex = 2;
            botaoentrar.Text = "entrar";
            botaoentrar.UseVisualStyleBackColor = true;
            botaoentrar.Click += botaoentrar_Click;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Century Gothic", 9F);
            email.Location = new Point(356, 209);
            email.Name = "email";
            email.Size = new Size(50, 17);
            email.TabIndex = 3;
            email.Text = "usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F);
            label2.Location = new Point(360, 262);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 4;
            label2.Text = "senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 50F);
            label1.Location = new Point(317, 45);
            label1.Name = "label1";
            label1.Size = new Size(305, 81);
            label1.TabIndex = 5;
            label1.Text = "Tumblr 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(399, 286);
            label3.Name = "label3";
            label3.Size = new Size(121, 17);
            label3.TabIndex = 6;
            label3.Text = "Esqueceu a senha?";
            // 
            // labelresult
            // 
            labelresult.AutoSize = true;
            labelresult.Font = new Font("Century Gothic", 9F);
            labelresult.Location = new Point(584, 207);
            labelresult.Name = "labelresult";
            labelresult.Size = new Size(0, 17);
            labelresult.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16F);
            label4.Location = new Point(945, 160);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 8;
            label4.Text = "Cadastre-se";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F);
            label5.Location = new Point(898, 215);
            label5.Name = "label5";
            label5.Size = new Size(51, 17);
            label5.TabIndex = 9;
            label5.Text = "Usuário";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F);
            label6.Location = new Point(904, 266);
            label6.Name = "label6";
            label6.Size = new Size(45, 17);
            label6.TabIndex = 10;
            label6.Text = "Senha";
            // 
            // regUser
            // 
            regUser.Location = new Point(973, 209);
            regUser.Name = "regUser";
            regUser.Size = new Size(100, 23);
            regUser.TabIndex = 11;
            // 
            // regSenha
            // 
            regSenha.Location = new Point(973, 262);
            regSenha.Name = "regSenha";
            regSenha.Size = new Size(100, 23);
            regSenha.TabIndex = 12;
            // 
            // regBotao
            // 
            regBotao.Location = new Point(984, 322);
            regBotao.Name = "regBotao";
            regBotao.Size = new Size(80, 23);
            regBotao.TabIndex = 13;
            regBotao.Text = "Cadastre-se";
            regBotao.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 82, 130);
            ClientSize = new Size(1364, 518);
            Controls.Add(regBotao);
            Controls.Add(regSenha);
            Controls.Add(regUser);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(labelresult);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(email);
            Controls.Add(botaoentrar);
            Controls.Add(textboxsenha);
            Controls.Add(textboxuser);
            Name = "FormLogin";
            Padding = new Padding(3);
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textboxuser;
        private TextBox textboxsenha;
        private Button botaoentrar;
        private Label email;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label labelresult;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox regUser;
        private TextBox regSenha;
        private Button regBotao;
    }
}
