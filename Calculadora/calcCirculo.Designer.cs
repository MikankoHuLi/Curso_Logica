namespace Calculadora
{
    partial class calcCirculo
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
            components = new System.ComponentModel.Container();
            textRaio = new TextBox();
            perimetro = new RadioButton();
            area = new RadioButton();
            diametro = new RadioButton();
            volume = new RadioButton();
            calc = new Button();
            textResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            erro = new Label();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            carinha = new Label();
            SuspendLayout();
            // 
            // textRaio
            // 
            textRaio.Location = new Point(263, 190);
            textRaio.Name = "textRaio";
            textRaio.Size = new Size(100, 23);
            textRaio.TabIndex = 0;
            // 
            // perimetro
            // 
            perimetro.AutoSize = true;
            perimetro.Location = new Point(102, 156);
            perimetro.Name = "perimetro";
            perimetro.Size = new Size(77, 19);
            perimetro.TabIndex = 1;
            perimetro.TabStop = true;
            perimetro.Text = "Perímetro";
            perimetro.UseVisualStyleBackColor = true;
            // 
            // area
            // 
            area.AutoSize = true;
            area.Location = new Point(102, 183);
            area.Name = "area";
            area.Size = new Size(49, 19);
            area.TabIndex = 2;
            area.TabStop = true;
            area.Text = "Área";
            area.UseVisualStyleBackColor = true;
            // 
            // diametro
            // 
            diametro.AutoSize = true;
            diametro.Location = new Point(102, 206);
            diametro.Name = "diametro";
            diametro.Size = new Size(74, 19);
            diametro.TabIndex = 3;
            diametro.TabStop = true;
            diametro.Text = "Diâmetro";
            diametro.UseVisualStyleBackColor = true;
            // 
            // volume
            // 
            volume.AutoSize = true;
            volume.Location = new Point(102, 231);
            volume.Name = "volume";
            volume.Size = new Size(65, 19);
            volume.TabIndex = 4;
            volume.TabStop = true;
            volume.Text = "Volume";
            volume.UseVisualStyleBackColor = true;
            // 
            // calc
            // 
            calc.Location = new Point(433, 190);
            calc.Name = "calc";
            calc.Size = new Size(75, 23);
            calc.TabIndex = 5;
            calc.Text = "Calcular";
            calc.UseVisualStyleBackColor = true;
            calc.Click += calc_Click;
            // 
            // textResult
            // 
            textResult.Enabled = false;
            textResult.Location = new Point(578, 191);
            textResult.Name = "textResult";
            textResult.Size = new Size(100, 23);
            textResult.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 126);
            label1.Name = "label1";
            label1.Size = new Size(177, 15);
            label1.TabIndex = 7;
            label1.Text = "O que você gostaria de calcular?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 157);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 8;
            label2.Text = "Insira o valor do raio";
            // 
            // erro
            // 
            erro.AutoSize = true;
            erro.Location = new Point(263, 231);
            erro.Name = "erro";
            erro.Size = new Size(0, 15);
            erro.TabIndex = 9;
            // 
            // carinha
            // 
            carinha.AutoSize = true;
            carinha.BackColor = Color.Transparent;
            carinha.Cursor = Cursors.No;
            carinha.Font = new Font("Segoe UI", 24F);
            carinha.ForeColor = SystemColors.ControlText;
            carinha.Location = new Point(376, 253);
            carinha.Name = "carinha";
            carinha.Size = new Size(44, 45);
            carinha.TabIndex = 10;
            carinha.Text = ":3";
            carinha.Click += carinha_Click;
            // 
            // calcCirculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(carinha);
            Controls.Add(erro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textResult);
            Controls.Add(calc);
            Controls.Add(volume);
            Controls.Add(diametro);
            Controls.Add(area);
            Controls.Add(perimetro);
            Controls.Add(textRaio);
            Name = "calcCirculo";
            Text = "calcCirculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textRaio;
        private RadioButton perimetro;
        private RadioButton area;
        private RadioButton diametro;
        private RadioButton volume;
        private Button calc;
        private TextBox textResult;
        private Label label1;
        private Label label2;
        private Label erro;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private Label carinha;
    }
}