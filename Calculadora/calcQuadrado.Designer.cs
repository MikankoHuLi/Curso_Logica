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
            result = new TextBox();
            calcBotao = new Button();
            erro = new Label();
            label4 = new Label();
            volRet = new TextBox();
            label5 = new Label();
            label7 = new Label();
            opcoesForma = new ComboBox();
            perimetroBut = new RadioButton();
            areaBut = new RadioButton();
            volumeBut = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(387, 84);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite o valor da base";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(540, 84);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Digite a altura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 84);
            label3.Name = "label3";
            label3.Size = new Size(177, 15);
            label3.TabIndex = 2;
            label3.Text = "O que você gostaria de calcular?";
            // 
            // baseRet
            // 
            baseRet.Location = new Point(398, 116);
            baseRet.Name = "baseRet";
            baseRet.Size = new Size(100, 23);
            baseRet.TabIndex = 3;
            // 
            // altRet
            // 
            altRet.Location = new Point(529, 116);
            altRet.Name = "altRet";
            altRet.Size = new Size(100, 23);
            altRet.TabIndex = 4;
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
            erro.Location = new Point(363, 254);
            erro.Name = "erro";
            erro.Size = new Size(0, 15);
            erro.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(658, 84);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 9;
            label4.Text = "Digite o comprimento";
            // 
            // volRet
            // 
            volRet.Enabled = false;
            volRet.Location = new Point(670, 116);
            volRet.Name = "volRet";
            volRet.Size = new Size(100, 23);
            volRet.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(348, 9);
            label5.Name = "label5";
            label5.Size = new Size(128, 15);
            label5.TabIndex = 11;
            label5.Text = "Calculadora de Formas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 84);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 13;
            label7.Text = "Selecione uma forma";
            // 
            // opcoesForma
            // 
            opcoesForma.FormattingEnabled = true;
            opcoesForma.Items.AddRange(new object[] { "Retângulo", "Quadrado", "Paralelepípedo", "Cubo" });
            opcoesForma.Location = new Point(29, 116);
            opcoesForma.Name = "opcoesForma";
            opcoesForma.Size = new Size(121, 23);
            opcoesForma.TabIndex = 14;
            opcoesForma.SelectedIndexChanged += opcoesForma_SelectedIndexChanged;
            // 
            // perimetroBut
            // 
            perimetroBut.AutoSize = true;
            perimetroBut.Location = new Point(226, 116);
            perimetroBut.Name = "perimetroBut";
            perimetroBut.Size = new Size(77, 19);
            perimetroBut.TabIndex = 15;
            perimetroBut.TabStop = true;
            perimetroBut.Text = "Perímetro";
            perimetroBut.UseVisualStyleBackColor = true;
            // 
            // areaBut
            // 
            areaBut.AutoSize = true;
            areaBut.Location = new Point(226, 141);
            areaBut.Name = "areaBut";
            areaBut.Size = new Size(49, 19);
            areaBut.TabIndex = 16;
            areaBut.TabStop = true;
            areaBut.Text = "Área";
            areaBut.UseVisualStyleBackColor = true;
            // 
            // volumeBut
            // 
            volumeBut.AutoSize = true;
            volumeBut.Location = new Point(226, 166);
            volumeBut.Name = "volumeBut";
            volumeBut.Size = new Size(65, 19);
            volumeBut.TabIndex = 17;
            volumeBut.TabStop = true;
            volumeBut.Text = "Volume";
            volumeBut.UseVisualStyleBackColor = true;
            // 
            // calcQuadrado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(volumeBut);
            Controls.Add(areaBut);
            Controls.Add(perimetroBut);
            Controls.Add(opcoesForma);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(volRet);
            Controls.Add(label4);
            Controls.Add(erro);
            Controls.Add(calcBotao);
            Controls.Add(result);
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
        private TextBox result;
        private Button calcBotao;
        private Label erro;
        private Label label4;
        private TextBox volRet;
        private Label label5;
        private Label label7;
        private ComboBox opcoesForma;
        private RadioButton perimetroBut;
        private RadioButton areaBut;
        private RadioButton volumeBut;
    }
}