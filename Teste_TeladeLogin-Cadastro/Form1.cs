namespace Teste_TeladeLogin_Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Coloque aqui o c�digo que deseja executar ao abrir o formul�rio
            InitializeComponent();
        }

        private void FazerCadastro_Click(object sender, EventArgs e)
        {
            TelaCadastro telacadastro = new TelaCadastro(this);
            this.Hide();
            telacadastro.Show();
        }

        private void FazerLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
