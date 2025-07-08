namespace Teste_TeladeLogin_Cadastro
{
    partial class TelaLogin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            Login_Usuario = new Guna.UI2.WinForms.Guna2TextBox();
            Login_Senha = new Guna.UI2.WinForms.Guna2TextBox();
            Login = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // Login_Usuario
            // 
            Login_Usuario.BorderRadius = 14;
            Login_Usuario.CustomizableEdges = customizableEdges1;
            Login_Usuario.DefaultText = "";
            Login_Usuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Login_Usuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Login_Usuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Login_Usuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Login_Usuario.FillColor = Color.FromArgb(255, 192, 255);
            Login_Usuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Login_Usuario.Font = new Font("Comic Sans MS", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login_Usuario.ForeColor = Color.Black;
            Login_Usuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Login_Usuario.Location = new Point(285, 102);
            Login_Usuario.Margin = new Padding(0, 22, 0, 22);
            Login_Usuario.Name = "Login_Usuario";
            Login_Usuario.PlaceholderForeColor = Color.Black;
            Login_Usuario.PlaceholderText = "Usuario:";
            Login_Usuario.SelectedText = "";
            Login_Usuario.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Login_Usuario.Size = new Size(527, 93);
            Login_Usuario.TabIndex = 1;
            Login_Usuario.TextOffset = new Point(4, 0);
            Login_Usuario.TextChanged += Login_Usuario_TextChanged;
            // 
            // Login_Senha
            // 
            Login_Senha.BorderRadius = 14;
            Login_Senha.CustomizableEdges = customizableEdges3;
            Login_Senha.DefaultText = "";
            Login_Senha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Login_Senha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Login_Senha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Login_Senha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Login_Senha.FillColor = Color.FromArgb(255, 192, 255);
            Login_Senha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Login_Senha.Font = new Font("Comic Sans MS", 21F, FontStyle.Bold);
            Login_Senha.ForeColor = Color.Black;
            Login_Senha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Login_Senha.Location = new Point(285, 255);
            Login_Senha.Margin = new Padding(10, 13, 10, 13);
            Login_Senha.Name = "Login_Senha";
            Login_Senha.PlaceholderForeColor = Color.Black;
            Login_Senha.PlaceholderText = "Senha:";
            Login_Senha.SelectedText = "";
            Login_Senha.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Login_Senha.Size = new Size(527, 93);
            Login_Senha.TabIndex = 2;
            Login_Senha.TextOffset = new Point(4, 0);
            Login_Senha.TextChanged += Login_Senha_TextChanged;
            // 
            // Login
            // 
            Login.BorderRadius = 45;
            Login.CustomizableEdges = customizableEdges5;
            Login.DisabledState.BorderColor = Color.DarkGray;
            Login.DisabledState.CustomBorderColor = Color.DarkGray;
            Login.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Login.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Login.FillColor = Color.FromArgb(255, 192, 255);
            Login.Font = new Font("Comic Sans MS", 35F, FontStyle.Bold);
            Login.ForeColor = Color.Black;
            Login.Location = new Point(357, 417);
            Login.Name = "Login";
            Login.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Login.Size = new Size(376, 110);
            Login.TabIndex = 3;
            Login.Text = "Login";
            Login.Click += Login_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 159, 253);
            ClientSize = new Size(1127, 692);
            Controls.Add(Login);
            Controls.Add(Login_Senha);
            Controls.Add(Login_Usuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaLogin";
            Text = "TelaLogin";
            Load += TelaLogin_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox Login_Usuario;
        private Guna.UI2.WinForms.Guna2TextBox Login_Senha;
        private Guna.UI2.WinForms.Guna2Button Login;
    }
}