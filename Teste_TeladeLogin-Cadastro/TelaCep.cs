using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Teste_TeladeLogin_Cadastro
{
    public partial class TelaCep : Form
    {
        public TelaCep()
        {
            InitializeComponent();
        }

        private void TelaCep_Load(object sender, EventArgs e)
        {

        }

        public class Endereco
        {
            public string cep { get; set; }
            public string logradouro { get; set; }
            public string complemento { get; set; }
            public string bairro { get; set; }
            public string localidade { get; set; }
            public string uf { get; set; }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string cep = txtCep.Text.Trim().Replace("-", "");
            if (cep.Length != 8)
            {
                MessageBox.Show("CEP inválido!");
                MessageBox.Show("CEP inválido!");
                MessageBox.Show("CEP inválido!");

                return;
                //apenas 1 comentário
            }

            try
            {
                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString($"https://viacep.com.br/ws/{cep}/json/"); //
                    var endereco = JsonConvert.DeserializeObject<Endereco>(json); // ESSA É A NOSSA API =D

                    if (endereco.cep == null)
                    {
                        MessageBox.Show("CEP não encontrado.");
                        return;
                    }

                    txtLogradouro.Text = endereco.logradouro;
                    txtBairro.Text = endereco.bairro;
                    txtCidade.Text = endereco.localidade;
                    txtEstado.Text = endereco.uf;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar o CEP: " + ex.Message);
            }
        }
    }
}
