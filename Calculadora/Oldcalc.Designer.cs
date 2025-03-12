namespace Calculadora
{
    partial class Oldcalc
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
            caixaNum1 = new NumericUpDown();
            caixaNum2 = new NumericUpDown();
            botaoResult = new Button();
            operador = new Label();
            comboBox1 = new ComboBox();
            textResult = new TextBox();
            monthCalendar1 = new MonthCalendar();
            cabecario = new Label();
            premio = new Label();
            radioSoma = new RadioButton();
            radioSub = new RadioButton();
            radioMult = new RadioButton();
            radioDiv = new RadioButton();
            dica1check = new CheckBox();
            dica1 = new Label();
            dica2check = new CheckBox();
            dica2 = new Label();
            dica3check = new CheckBox();
            dica3 = new Label();
            calcQuad = new Label();
            ((System.ComponentModel.ISupportInitialize)caixaNum1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)caixaNum2).BeginInit();
            SuspendLayout();
            // 
            // textnum1
            // 
            textnum1.Location = new Point(39, 99);
            textnum1.Name = "textnum1";
            textnum1.Size = new Size(100, 23);
            textnum1.TabIndex = 0;
            // 
            // textnum2
            // 
            textnum2.Location = new Point(39, 142);
            textnum2.Name = "textnum2";
            textnum2.Size = new Size(100, 23);
            textnum2.TabIndex = 1;
            // 
            // botaomais
            // 
            botaomais.Location = new Point(49, 184);
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
            novaCalc.Location = new Point(292, 334);
            novaCalc.Name = "novaCalc";
            novaCalc.Size = new Size(213, 15);
            novaCalc.TabIndex = 4;
            novaCalc.Text = "Tenta agora nossa nova calculadora =D";
            novaCalc.Click += novaCalc_Click;
            // 
            // caixaNum1
            // 
            caixaNum1.Location = new Point(345, 99);
            caixaNum1.Name = "caixaNum1";
            caixaNum1.Size = new Size(120, 23);
            caixaNum1.TabIndex = 5;
            // 
            // caixaNum2
            // 
            caixaNum2.Location = new Point(345, 161);
            caixaNum2.Name = "caixaNum2";
            caixaNum2.Size = new Size(120, 23);
            caixaNum2.TabIndex = 6;
            // 
            // botaoResult
            // 
            botaoResult.Location = new Point(367, 268);
            botaoResult.Name = "botaoResult";
            botaoResult.Size = new Size(75, 23);
            botaoResult.TabIndex = 7;
            botaoResult.Text = "calcular";
            botaoResult.UseVisualStyleBackColor = true;
            botaoResult.Click += botaoResult_Click;
            // 
            // operador
            // 
            operador.AutoSize = true;
            operador.Location = new Point(396, 134);
            operador.Name = "operador";
            operador.Size = new Size(15, 15);
            operador.TabIndex = 8;
            operador.Text = "+";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox1.Location = new Point(344, 239);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textResult
            // 
            textResult.Enabled = false;
            textResult.Location = new Point(355, 199);
            textResult.Name = "textResult";
            textResult.Size = new Size(100, 23);
            textResult.TabIndex = 10;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.Window;
            monthCalendar1.Location = new Point(545, 99);
            monthCalendar1.MinDate = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 11;
            monthCalendar1.TodayDate = new DateTime(2025, 3, 11, 0, 0, 0, 0);
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // cabecario
            // 
            cabecario.AutoSize = true;
            cabecario.Location = new Point(585, 48);
            cabecario.Name = "cabecario";
            cabecario.Size = new Size(141, 15);
            cabecario.TabIndex = 12;
            cabecario.Text = "Adivinhe meu aniversário";
            // 
            // premio
            // 
            premio.AutoSize = true;
            premio.Location = new Point(607, 276);
            premio.Name = "premio";
            premio.Size = new Size(0, 15);
            premio.TabIndex = 13;
            // 
            // radioSoma
            // 
            radioSoma.AutoSize = true;
            radioSoma.Location = new Point(180, 99);
            radioSoma.Name = "radioSoma";
            radioSoma.Size = new Size(55, 19);
            radioSoma.TabIndex = 14;
            radioSoma.TabStop = true;
            radioSoma.Text = "Soma";
            radioSoma.UseVisualStyleBackColor = true;
            radioSoma.CheckedChanged += radioSoma_CheckedChanged;
            // 
            // radioSub
            // 
            radioSub.AutoSize = true;
            radioSub.Location = new Point(180, 134);
            radioSub.Name = "radioSub";
            radioSub.Size = new Size(78, 19);
            radioSub.TabIndex = 15;
            radioSub.TabStop = true;
            radioSub.Text = "Subtração";
            radioSub.UseVisualStyleBackColor = true;
            radioSub.CheckedChanged += radioSub_CheckedChanged;
            // 
            // radioMult
            // 
            radioMult.AutoSize = true;
            radioMult.Location = new Point(180, 165);
            radioMult.Name = "radioMult";
            radioMult.Size = new Size(97, 19);
            radioMult.TabIndex = 16;
            radioMult.TabStop = true;
            radioMult.Text = "Multiplicação";
            radioMult.UseVisualStyleBackColor = true;
            radioMult.CheckedChanged += radioMult_CheckedChanged;
            // 
            // radioDiv
            // 
            radioDiv.AutoSize = true;
            radioDiv.Location = new Point(180, 199);
            radioDiv.Name = "radioDiv";
            radioDiv.Size = new Size(63, 19);
            radioDiv.TabIndex = 17;
            radioDiv.TabStop = true;
            radioDiv.Text = "Divisão";
            radioDiv.UseVisualStyleBackColor = true;
            radioDiv.CheckedChanged += radioDiv_CheckedChanged;
            // 
            // dica1check
            // 
            dica1check.AutoSize = true;
            dica1check.Location = new Point(565, 308);
            dica1check.Name = "dica1check";
            dica1check.Size = new Size(95, 19);
            dica1check.TabIndex = 18;
            dica1check.Text = "Primeira dica";
            dica1check.UseVisualStyleBackColor = true;
            dica1check.CheckedChanged += dica1check_CheckedChanged;
            // 
            // dica1
            // 
            dica1.AutoSize = true;
            dica1.Location = new Point(666, 309);
            dica1.Name = "dica1";
            dica1.Size = new Size(0, 15);
            dica1.TabIndex = 19;
            // 
            // dica2check
            // 
            dica2check.AutoSize = true;
            dica2check.Location = new Point(565, 334);
            dica2check.Name = "dica2check";
            dica2check.Size = new Size(97, 19);
            dica2check.TabIndex = 20;
            dica2check.Text = "Segunda dica";
            dica2check.UseVisualStyleBackColor = true;
            dica2check.CheckedChanged += dica2check_CheckedChanged;
            // 
            // dica2
            // 
            dica2.AutoSize = true;
            dica2.Location = new Point(666, 338);
            dica2.Name = "dica2";
            dica2.Size = new Size(0, 15);
            dica2.TabIndex = 21;
            // 
            // dica3check
            // 
            dica3check.AutoSize = true;
            dica3check.Location = new Point(565, 359);
            dica3check.Name = "dica3check";
            dica3check.Size = new Size(91, 19);
            dica3check.TabIndex = 22;
            dica3check.Text = "Terceira dica";
            dica3check.UseVisualStyleBackColor = true;
            dica3check.CheckedChanged += dica3check_CheckedChanged;
            // 
            // dica3
            // 
            dica3.AutoSize = true;
            dica3.Location = new Point(666, 363);
            dica3.Name = "dica3";
            dica3.Size = new Size(0, 15);
            dica3.TabIndex = 23;
            // 
            // calcQuad
            // 
            calcQuad.AutoSize = true;
            calcQuad.ForeColor = Color.Blue;
            calcQuad.Location = new Point(292, 363);
            calcQuad.Name = "calcQuad";
            calcQuad.Size = new Size(226, 15);
            calcQuad.TabIndex = 24;
            calcQuad.Text = "ou então nossa calculadora de quadrados";
            calcQuad.Click += calcQuad_Click;
            // 
            // Oldcalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calcQuad);
            Controls.Add(dica3);
            Controls.Add(dica3check);
            Controls.Add(dica2);
            Controls.Add(dica2check);
            Controls.Add(dica1);
            Controls.Add(dica1check);
            Controls.Add(radioDiv);
            Controls.Add(radioMult);
            Controls.Add(radioSub);
            Controls.Add(radioSoma);
            Controls.Add(premio);
            Controls.Add(cabecario);
            Controls.Add(monthCalendar1);
            Controls.Add(textResult);
            Controls.Add(comboBox1);
            Controls.Add(operador);
            Controls.Add(botaoResult);
            Controls.Add(caixaNum2);
            Controls.Add(caixaNum1);
            Controls.Add(novaCalc);
            Controls.Add(textCabecario);
            Controls.Add(botaomais);
            Controls.Add(textnum2);
            Controls.Add(textnum1);
            Name = "Oldcalc";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)caixaNum1).EndInit();
            ((System.ComponentModel.ISupportInitialize)caixaNum2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textnum1;
        private TextBox textnum2;
        private Button botaomais;
        private Label textCabecario;
        private Label novaCalc;
        private NumericUpDown caixaNum1;
        private NumericUpDown caixaNum2;
        private Button botaoResult;
        private Label operador;
        private ComboBox comboBox1;
        private TextBox textResult;
        private MonthCalendar monthCalendar1;
        private Label cabecario;
        private Label premio;
        private RadioButton radioSoma;
        private RadioButton radioSub;
        private RadioButton radioMult;
        private RadioButton radioDiv;
        private CheckBox dica1check;
        private Label dica1;
        private CheckBox dica2check;
        private Label dica2;
        private CheckBox dica3check;
        private Label dica3;
        private Label calcQuad;
    }
}
