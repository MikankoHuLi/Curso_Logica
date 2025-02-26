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
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 82, 130);
            ClientSize = new Size(916, 535);
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
    }
}
