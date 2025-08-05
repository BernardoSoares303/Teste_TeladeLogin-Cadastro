using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace Teste_TeladeLogin_Cadastro
{
    public partial class TelaCadastro : Form
    {
        string usuario;
        string senha;
        string senhacrip;
        private Form f1;
        public TelaCadastro(Form f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }

        private void Text_Usuario_TextChanged(object sender, EventArgs e)
        {
            usuario = Text_Usuario.Text;
        }

        private void Text_Senha_TextChanged(object sender, EventArgs e)
        {
            senha = Text_Senha.Text;

            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(senha);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Converte bytes para string hexadecimal
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                senhacrip = sb.ToString();
            }
        }

        static string conexao = "Server=127.0.0.1;Port=3306;Database=appfofo;Uid=root;Pwd='' ;";

        static void inserirdados(string usuario, string senha)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();

                    string queryinsert = @"insert into usuarios (nome_usuario, senha_usuario) values (@nome_usuario, @senha_usuario);";
                    MySqlCommand cmd = new MySqlCommand(queryinsert, conn);

                    cmd.Parameters.AddWithValue("@nome_usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha_usuario", senha);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            inserirdados(usuario, senhacrip);
            this.Close();
            f1.Show();
        }
    }
}
    