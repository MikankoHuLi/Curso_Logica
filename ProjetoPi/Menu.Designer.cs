namespace ProjetoPi
{
    partial class Menu
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
            btnCriar = new Button();
            btnEditar = new Button();
            btnCadastrarCliente = new Button();
            SuspendLayout();
            // 
            // btnCriar
            // 
            btnCriar.Location = new Point(88, 239);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(98, 23);
            btnCriar.TabIndex = 0;
            btnCriar.Text = "Criar Pedido";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(302, 239);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(135, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar Pedido";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.Location = new Point(558, 239);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(119, 23);
            btnCadastrarCliente.TabIndex = 2;
            btnCadastrarCliente.Text = "Cadastrar Cliente";
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            btnCadastrarCliente.Click += btnCadastrarCliente_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrarCliente);
            Controls.Add(btnEditar);
            Controls.Add(btnCriar);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCriar;
        private Button btnEditar;
        private Button btnCadastrarCliente;
    }
}