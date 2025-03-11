namespace Calculadora
{
    partial class Form1
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
            textnum1 = new TextBox();
            textnum2 = new TextBox();
            botaomais = new Button();
            textCabecario = new Label();
            novaCalc = new Label();
            SuspendLayout();
            // 
            // textnum1
            // 
            textnum1.Location = new Point(358, 104);
            textnum1.Name = "textnum1";
            textnum1.Size = new Size(100, 23);
            textnum1.TabIndex = 0;
            // 
            // textnum2
            // 
            textnum2.Location = new Point(358, 161);
            textnum2.Name = "textnum2";
            textnum2.Size = new Size(100, 23);
            textnum2.TabIndex = 1;
            // 
            // botaomais
            // 
            botaomais.Location = new Point(370, 207);
            botaomais.Name = "botaomais";
            botaomais.Size = new Size(75, 23);
            botaomais.TabIndex = 2;
            botaomais.Text = "+";
            botaomais.UseVisualStyleBackColor = true;
            botaomais.Click += botaomais_Click;
            // 
            // textCabecario
            // 
            textCabecario.AutoSize = true;
            textCabecario.Location = new Point(336, 48);
            textCabecario.Name = "textCabecario";
            textCabecario.Size = new Size(145, 15);
            textCabecario.TabIndex = 3;
            textCabecario.Text = "Insira valores para calcular";
            // 
            // novaCalc
            // 
            novaCalc.AutoSize = true;
            novaCalc.ForeColor = Color.Blue;
            novaCalc.Location = new Point(312, 257);
            novaCalc.Name = "novaCalc";
            novaCalc.Size = new Size(194, 15);
            novaCalc.TabIndex = 4;
            novaCalc.Text = "Tenta agora nossa nova calculadora";
            novaCalc.Click += novaCalc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(novaCalc);
            Controls.Add(textCabecario);
            Controls.Add(botaomais);
            Controls.Add(textnum2);
            Controls.Add(textnum1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textnum1;
        private TextBox textnum2;
        private Button botaomais;
        private Label textCabecario;
        private Label novaCalc;
    }
}
