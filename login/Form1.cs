namespace login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string rac = textboxuser.Text;

            if (rac == " ")
            {
                textboxuser.Text = "";
                return;
            }
        }

        private void botaoentrar_Click(object sender, EventArgs e)
        {
            string user = textboxuser.Text;
            string senha = textboxsenha.Text;

            if (user == null || user == "") // user == string.Empty string.NullOrWhiteSpace pode substituir 
            {
                labelresult.Text = "usuário é obrigatório";
                labelresult.ForeColor = Color.Red;
                return;
            }

            if (senha == null || senha == "")
            {
                labelresult.Text = "senha é obrigatória";
                labelresult.ForeColor = Color.Red;
                return;
            }

            if (user == "Dinizo" && senha == "12345")
            {
                labelresult.Text = "autenticado com sucesso";
                labelresult.ForeColor = Color.Green;
            }

            else 
            {
                labelresult.Text = "usuário ou senha incorretos";
                labelresult.ForeColor = Color.Red;
            }
            

        }
    }
}
