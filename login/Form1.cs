namespace login
{
    public partial class FormLogin : Form
    {
        List<string> listaUser = new List<string>()
        {"neymar.jr","pablo.vitar", "sukuna.silva" } ;

        List<string> listaSenha = new List<string>()
        {"bruna","12345", "666" };

        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string exclui = textboxuser.Text;

            if (exclui == " ")
            {
                textboxuser.Text = "";
                return;
            }
        }

        private void botaoentrar_Click(object sender, EventArgs e)
        {
            string userBusc = textboxuser.Text;
            string senha = textboxsenha.Text;

            if (string.IsNullOrWhiteSpace(userBusc)) // user == string.Empty string.NullOrWhiteSpace pode substituir 
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

            int posicaoUserCerto = -1;

            for (int i = 0; i < listaUser.Count; i++)
            {
                if (userBusc == listaUser[i])
                {
                    posicaoUserCerto = i;
                }
                
            }

           
             if ( posicaoUserCerto != -1 && senha == listaSenha[posicaoUserCerto])
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
