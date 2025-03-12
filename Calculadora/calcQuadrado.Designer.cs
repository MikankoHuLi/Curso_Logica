namespace Calculadora
{
    partial class calcQuadrado
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            baseRet = new TextBox();
            altRet = new TextBox();
            opcoes = new ComboBox();
            result = new TextBox();
            calcBotao = new Button();
            erro = new Label();
            label4 = new Label();
            volRet = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 76);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite o valor da base";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 76);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Digite a altura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(624, 76);
            label3.Name = "label3";
            label3.Size = new Size(177, 15);
            label3.TabIndex = 2;
            label3.Text = "O que você gostaria de calcular?";
            // 
            // baseRet
            // 
            baseRet.Location = new Point(80, 108);
            baseRet.Name = "baseRet";
            baseRet.Size = new Size(100, 23);
            baseRet.TabIndex = 3;
            // 
            // altRet
            // 
            altRet.Location = new Point(279, 108);
            altRet.Name = "altRet";
            altRet.Size = new Size(100, 23);
            altRet.TabIndex = 4;
            // 
            // opcoes
            // 
            opcoes.FormattingEnabled = true;
            opcoes.Items.AddRange(new object[] { "Perímetro", "Área", "Volume" });
            opcoes.Location = new Point(649, 108);
            opcoes.Name = "opcoes";
            opcoes.Size = new Size(121, 23);
            opcoes.TabIndex = 5;
            // 
            // result
            // 
            result.Enabled = false;
            result.Location = new Point(363, 282);
            result.Name = "result";
            result.Size = new Size(100, 23);
            result.TabIndex = 6;
            // 
            // calcBotao
            // 
            calcBotao.Location = new Point(375, 197);
            calcBotao.Name = "calcBotao";
            calcBotao.Size = new Size(75, 23);
            calcBotao.TabIndex = 7;
            calcBotao.Text = "Calcular";
            calcBotao.UseVisualStyleBackColor = true;
            calcBotao.Click += calcBotao_Click;
            // 
            // erro
            // 
            erro.AutoSize = true;
            erro.Location = new Point(288, 265);
            erro.Name = "erro";
            erro.Size = new Size(0, 15);
            erro.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(426, 76);
            label4.Name = "label4";
            label4.Size = new Size(181, 15);
            label4.TabIndex = 9;
            label4.Text = "Digite o comprimento(caso haja)";
            // 
            // volRet
            // 
            volRet.Location = new Point(462, 108);
            volRet.Name = "volRet";
            volRet.Size = new Size(100, 23);
            volRet.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 9);
            label5.Name = "label5";
            label5.Size = new Size(143, 15);
            label5.TabIndex = 11;
            label5.Text = "Calculadora de Retângulo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7F);
            label6.Location = new Point(383, 33);
            label6.Name = "label6";
            label6.Size = new Size(67, 12);
            label6.TabIndex = 12;
            label6.Text = "(e formas 3d?)";
            // 
            // calcQuadrado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(volRet);
            Controls.Add(label4);
            Controls.Add(erro);
            Controls.Add(calcBotao);
            Controls.Add(result);
            Controls.Add(opcoes);
            Controls.Add(altRet);
            Controls.Add(baseRet);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "calcQuadrado";
            Text = "calcQuadrado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox baseRet;
        private TextBox altRet;
        private ComboBox opcoes;
        private TextBox result;
        private Button calcBotao;
        private Label erro;
        private Label label4;
        private TextBox volRet;
        private Label label5;
        private Label label6;
    }
}