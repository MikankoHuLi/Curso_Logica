using MySql.Data.MySqlClient;

namespace login
{
    public partial class FormLogin : Form
    {
        /* List<string> listaUser = new List<string>()
         {"neymar.jr","pablo.vitar", "sukuna.silva" };


         List<string> listaSenha = new List<string>()
         {"BrunaS2!","Eoque11?", "Megum!666" };
        */

       private static readonly string  ConnectionString = "datasource=localhost;username=root;password=;database=senac;" ;
       private readonly MySqlConnection Connection = new MySqlConnection(ConnectionString);

        //List<Usuario> usuarios = new List<Usuario>();


        public FormLogin()
        {
            InitializeComponent();
            //usuarios.Add(new Usuario() { Email = "neymar.jr@email.com", Senha = "BrunaS2!" });
            //usuarios.Add(new Usuario() { Email = "pablo.vitar@email.com", Senha = "Eoque11?" });
            //usuarios.Add(new Usuario() { Email = "sukuna.silva@email.com", Senha = "Megum!666" });
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

            bool autenticado = false;

            //for (int i = 0; i < usuarios.Count; i++)
            //{

            //    if (usuarios[i].Email == userBusc && usuarios[i].Senha == senha)
            //    {

            //        autenticado = true;
            //    }
            //}

            try
            {
                Connection.Open();

                string query = $"SELECT senha FROM usuario WHERE email = '{userBusc}';"; 

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                autenticado = reader.Read() && reader.GetString(0) == senha;

            }
            catch
            {
                MessageBox.Show("Erro de Banco de Dados");
            }
            finally 
            {
                Connection.Close();
            }

            if (!autenticado)
            {

                labelresult.Text = "Usuario ou Senha incorretos...";

                labelresult.ForeColor = Color.Red;
               
                return;
            }

            labelresult.Text = "Usuário cadastrado com sucesso!";
            labelresult.ForeColor = Color.Green;
            textboxuser.Clear();
            textboxsenha.Clear();

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

            if (novaSenha.Any(char.IsWhiteSpace))
            {
                labelCadast.Text = "A senha nao deve ter espacos em branco";
                labelCadast.ForeColor = Color.Red;
                return;
            }

            bool encontrado = false;
            try
            {
                Connection.Open();

                string query = $"SELECT email FROM usuario WHERE email = '{novoUser}';";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                encontrado = reader.Read();

            }
            catch
            {
                MessageBox.Show("Erro de Banco de Dados");
            }
            finally
            {
                Connection.Close();
            }


            if (encontrado)
            {
                labelCadast.Text = "Já existe um usuário cadastrado";
                labelCadast.ForeColor = Color.Red;
                return;
            }


            try
            {
                Connection.Open();

                string query = $"INSERT INTO usuario (email,senha) VALUES ('{novoUser}','{novaSenha}');";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                mySqlCommand.ExecuteNonQuery();
                labelCadast.Text = "Usuário cadastrado com sucesso!";
                labelCadast.ForeColor = Color.Green;
                regUser.Clear();
                regSenha.Clear();

            }
            catch
            {
                MessageBox.Show("Erro de Banco de Dados");
            }
            finally
            {
                Connection.Close();
            }

           
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
