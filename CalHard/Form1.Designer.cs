namespace CalHard
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
            textNum = new TextBox();
            botaoMais = new Button();
            botaoMenos = new Button();
            botaoMult = new Button();
            botaoDiv = new Button();
            botaoResult = new Button();
            textCab = new Label();
            SuspendLayout();
            // 
            // textNum
            // 
            textNum.Location = new Point(339, 70);
            textNum.Name = "textNum";
            textNum.Size = new Size(100, 23);
            textNum.TabIndex = 0;
            // 
            // botaoMais
            // 
            botaoMais.Location = new Point(339, 111);
            botaoMais.Name = "botaoMais";
            botaoMais.Size = new Size(23, 23);
            botaoMais.TabIndex = 1;
            botaoMais.Text = "+";
            botaoMais.UseVisualStyleBackColor = true;
            botaoMais.Click += botaoMais_Click;
            // 
            // botaoMenos
            // 
            botaoMenos.Location = new Point(378, 111);
            botaoMenos.Name = "botaoMenos";
            botaoMenos.Size = new Size(23, 23);
            botaoMenos.TabIndex = 2;
            botaoMenos.Text = "-";
            botaoMenos.UseVisualStyleBackColor = true;
            botaoMenos.Click += botaoMenos_Click;
            // 
            // botaoMult
            // 
            botaoMult.Location = new Point(339, 140);
            botaoMult.Name = "botaoMult";
            botaoMult.Size = new Size(23, 23);
            botaoMult.TabIndex = 3;
            botaoMult.Text = "X";
            botaoMult.UseVisualStyleBackColor = true;
            botaoMult.Click += botaoMult_Click;
            // 
            // botaoDiv
            // 
            botaoDiv.Location = new Point(378, 140);
            botaoDiv.Name = "botaoDiv";
            botaoDiv.Size = new Size(23, 23);
            botaoDiv.TabIndex = 4;
            botaoDiv.Text = "/";
            botaoDiv.UseVisualStyleBackColor = true;
            botaoDiv.Click += botaoDiv_Click;
            // 
            // botaoResult
            // 
            botaoResult.Location = new Point(416, 111);
            botaoResult.Name = "botaoResult";
            botaoResult.Size = new Size(23, 52);
            botaoResult.TabIndex = 5;
            botaoResult.Text = "=";
            botaoResult.UseVisualStyleBackColor = true;
            botaoResult.Click += botaoResult_Click;
            // 
            // textCab
            // 
            textCab.AutoSize = true;
            textCab.Location = new Point(339, 26);
            textCab.Name = "textCab";
            textCab.Size = new Size(0, 15);
            textCab.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textCab);
            Controls.Add(botaoResult);
            Controls.Add(botaoDiv);
            Controls.Add(botaoMult);
            Controls.Add(botaoMenos);
            Controls.Add(botaoMais);
            Controls.Add(textNum);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNum;
        private Button botaoMais;
        private Button botaoMenos;
        private Button botaoMult;
        private Button botaoDiv;
        private Button botaoResult;
        private Label textCab;
    }
}
