namespace login
{
    public partial class FormLogin : Form
    {
        /* List<string> listaUser = new List<string>()
         {"neymar.jr","pablo.vitar", "sukuna.silva" };


         List<string> listaSenha = new List<string>()
         {"BrunaS2!","Eoque11?", "Megum!666" };
        */


        List<Usuario> usuarios = new List<Usuario>();


        public FormLogin()
        {
            InitializeComponent();
            usuarios.Add(new Usuario() { Email = "neymar.jr@email.com", Senha = "BrunaS2!" });
            usuarios.Add(new Usuario() { Email = "pablo.vitar@email.com", Senha = "Eoque11?" });
            usuarios.Add(new Usuario() { Email = "sukuna.silva@email.com", Senha = "Megum!666" });
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textboxuser.Text == " ")
            {
                textboxuser.Clear();
                return;
            }
        }

        private void botaoentrar_Click(object sender, EventArgs e)
        {
            string userBusc = textboxuser.Text;
            string senha = textboxsenha.Text;
            

            if (string.IsNullOrWhiteSpace(userBusc)) // user == string.Empty string.NullOrWhiteSpace pode substituir 
            {
                labelresult.Text = "usu�rio � obrigat�rio";
                labelresult.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(senha)) //(senha == null || senha == "")
            {
                labelresult.Text = "senha � obrigat�ria";
                labelresult.ForeColor = Color.Red;
                return;
            }

            bool autenticado = false;
            
            for (int i = 0; i < usuarios.Count; i++)
            {
               
                if (usuarios[i].Email == userBusc && usuarios[i].Senha == senha)
                {
                    
                    autenticado = true;
                }
            }

            if (!autenticado)
            {

                labelresult.Text = "Usuario ou Senha incorretos...";

                labelresult.ForeColor = Color.Red;
               
                return;
            }



        }

        private void regBotao_Click(object sender, EventArgs e)
        {
            string novoUser = regUser.Text;
            string novaSenha = regSenha.Text;
            
            if (string.IsNullOrWhiteSpace(novoUser))
            {
                labelCadast.Text = "usu�rio � obrigat�rio";
                labelCadast.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                labelCadast.Text = "senha � obrigat�ria";
                labelCadast.ForeColor = Color.Red;
                return;
            }

            if (novaSenha.Length < 8)
            {
                labelCadast.Text = "senha precisa conter no m�nimo 8 caract�res";
                labelCadast.ForeColor = Color.Red;
                return;
            }

            if (!novaSenha.Any(char.IsDigit))
            {
                labelCadast.Text = "senha precisa conter n�meros";
                labelCadast.ForeColor = Color.Red;
                return;
            }

            if (!novaSenha.Any(char.IsPunctuation) && !novaSenha.Any(char.IsSymbol) && !novaSenha.Contains("@"))
            {
                labelCadast.Text = "senha precisa conter pelo menos um caract�rer especial";
                labelCadast.ForeColor = Color.Red;
                return;
            }

            if (!novaSenha.Any(char.IsUpper))
            {
                labelCadast.Text = "senha precisa conter pelo menos uma letra maiuscula";
                labelCadast.ForeColor = Color.Red;
                return;
            }

            if (!novaSenha.Any(char.IsLower))
            {
                labelCadast.Text = "senha precisa conter pelo menos uma letra min�scula";
                labelCadast.ForeColor = Color.Red;
                return;
            }

            if (novaSenha.Any(char.IsWhiteSpace))
            {
                labelCadast.Text = "A senha nao deve ter espacos em branco";
                labelCadast.ForeColor = Color.Red;
                return;
            }

            bool encontrado = false;
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].Email == novoUser)
                {
                    encontrado = true;
                }
            }

           
            if (encontrado)
            {
                labelCadast.Text = "J� existe um usu�rio cadastrado";
                labelCadast.ForeColor = Color.Red;
                return;
            }

            
            usuarios.Add(new Usuario() { Email = novoUser, Senha = novaSenha });
            labelCadast.Text = "Usu�rio cadastrado com sucesso!";
            labelCadast.ForeColor = Color.Green;
            regUser.Clear();
            regSenha.Clear();
        }
        /*
               for (int i = 0; i < novaSenha.Lenght; i++)
            {
                if (listaNum.Contains(novaSenha[i].ToString))
                {
                    temNum = true;
                    continue;
                }
                if (listaLow.Contains(novaSenha[i].ToString))
                {
                    temLow = true;
                    continue;
                }

               ...
            }

            ou 

            for (int i = 0; i < listaUp.Count; i++)
            {
                if (novaSenha.Contains(listaUp[i]))
                {
                    temUp = true;
                }
            }
             
             */
           

    private void label3_Click(object sender, EventArgs e) //emailbut
        {
            esqSenha.Text = "Verifique seu Email";
            esqSenha.ForeColor = Color.Green;
        }

      
    }
}
