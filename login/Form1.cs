namespace login
{
    public partial class FormLogin : Form
    {
        List<string> listaUser = new List<string>()
        {"neymar.jr","pablo.vitar", "sukuna.silva" };

        List<string> listaSenha = new List<string>()
        {"BrunaS2!","Eoque11?", "Megum!666" };

        List<string> listaNum = new List<string>()
        {"0","1", "3","4","5","6","7","8","9" };

        List<string> listaChar = new List<string>()
        {"!","@", "#","$","%","&","*","+","-","_","=","?" };

        List<string> listaUp = new List<string>()
        {"A","B", "C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z" };

        List<string> listaLow = new List<string>()
        {"a","b", "c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z" };




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

            if (string.IsNullOrWhiteSpace(senha)) //(senha == null || senha == "")
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


            if (posicaoUserCerto != -1 && senha == listaSenha[posicaoUserCerto])
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

        private void regBotao_Click(object sender, EventArgs e)
        {
            string novoUser = regUser.Text;
            string novaSenha = regSenha.Text;
            
            if (string.IsNullOrWhiteSpace(novoUser))
            {
                labelCadast.Text = "usuário é obrigatório";
                labelCadast.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                labelCadast.Text = "senha é obrigatória";
                labelCadast.ForeColor = Color.Red;
                return;
            }

            if (novaSenha.Length < 8)
            {
                labelCadast.Text = "senha precisa conter no mínimo 8 caractéres";
                labelCadast.ForeColor = Color.Red;
                return;
            }

            if (!novaSenha.Any(char.IsDigit))
            {
                labelCadast.Text = "senha precisa conter números";
                labelCadast.ForeColor = Color.Red;
                return;
            }

            if (!novaSenha.Any(char.IsPunctuation) && !novaSenha.Any(char.IsSymbol) && !novaSenha.Contains("@"))
            {
                labelCadast.Text = "senha precisa conter pelo menos um caractérer especial";
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
                labelCadast.Text = "senha precisa conter pelo menos uma letra minúscula";
                labelCadast.ForeColor = Color.Red;
                return;
            }

            if (novaSenha.Contains(" "))
            {
                labelCadast.Text = "senha não pode conter espaço";
                labelCadast.ForeColor = Color.Red;
                return;
            }

            if (listaUser.Contains(novoUser))
            {
                labelCadast.Text = "Usuário já existe";
                labelCadast.ForeColor = Color.Red;
                return;
            }
  
                    listaUser.Add(novoUser);
                    listaSenha.Add(novaSenha);
                    labelCadast.Text = "Usuário criado com sucesso";
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
