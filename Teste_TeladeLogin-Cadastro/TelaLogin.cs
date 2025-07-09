using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Teste_TeladeLogin_Cadastro
{
    public partial class TelaLogin : Form
    {
        static string conexao = "Server=127.0.0.1;Port=3306;Database=appfofo;Uid=root;Pwd='' ;";

        string usuario;
        string senha;
        
        TelaCep cep = new TelaCep();

        public TelaLogin()
        {
            InitializeComponent();

        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

            if (ValidarLogin(usuario, senha) == 1)
            {
                this.Close();
                cep.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalidos!");
            }


        }

        static int ValidarLogin(string usuario, string senha)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();

                string querySelect = @$"select count(id_usuario) from usuarios where nome_usuario = '{usuario}' and senha_usuario = '{senha}';";

                using (MySqlCommand cmd = new MySqlCommand(querySelect, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    conn.Close();
                    return count;
                }
            }
        }

        private void Login_Usuario_TextChanged(object sender, EventArgs e)
        {
            usuario = Login_Usuario.Text;
        }

        private void Login_Senha_TextChanged(object sender, EventArgs e)
        {
            senha = Login_Senha.Text;
        }
    }
}