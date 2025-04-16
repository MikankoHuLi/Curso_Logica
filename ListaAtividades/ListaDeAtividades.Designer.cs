namespace ListaAtividades
{
    partial class ListaDeAtividades
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
            textAtividadeEmAndamento = new TextBox();
            buttonFinalizar = new Button();
            gridAtividades = new DataGridView();
            buttonCriar = new Button();
            buttonAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridAtividades).BeginInit();
            SuspendLayout();
            // 
            // textAtividadeEmAndamento
            // 
            textAtividadeEmAndamento.Location = new Point(23, 28);
            textAtividadeEmAndamento.Name = "textAtividadeEmAndamento";
            textAtividadeEmAndamento.ReadOnly = true;
            textAtividadeEmAndamento.Size = new Size(587, 23);
            textAtividadeEmAndamento.TabIndex = 0;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.Location = new Point(630, 27);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(158, 23);
            buttonFinalizar.TabIndex = 1;
            buttonFinalizar.Text = "Finalizar";
            buttonFinalizar.UseVisualStyleBackColor = true;
            // 
            // gridAtividades
            // 
            gridAtividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridAtividades.Location = new Point(23, 103);
            gridAtividades.Name = "gridAtividades";
            gridAtividades.Size = new Size(587, 322);
            gridAtividades.TabIndex = 2;
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(630, 402);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(158, 23);
            buttonCriar.TabIndex = 3;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.Location = new Point(630, 103);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(158, 23);
            buttonAtualizar.TabIndex = 4;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = true;
            // 
            // ListaDeAtividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAtualizar);
            Controls.Add(buttonCriar);
            Controls.Add(gridAtividades);
            Controls.Add(buttonFinalizar);
            Controls.Add(textAtividadeEmAndamento);
            Name = "ListaDeAtividades";
            Text = "Lista De Atividades";
            Load += ListaDeAtividades_Load;
            ((System.ComponentModel.ISupportInitialize)gridAtividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textAtividadeEmAndamento;
        private Button buttonFinalizar;
        private DataGridView gridAtividades;
        private Button buttonCriar;
        private Button buttonAtualizar;
    }
}
