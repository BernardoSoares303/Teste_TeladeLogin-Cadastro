namespace Teste_TeladeLogin_Cadastro
{
    partial class TelaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            Text_Senha = new Guna.UI2.WinForms.Guna2TextBox();
            Cadastrar = new Guna.UI2.WinForms.Guna2Button();
            Text_Usuario = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // Text_Senha
            // 
            Text_Senha.BorderRadius = 14;
            Text_Senha.CustomizableEdges = customizableEdges1;
            Text_Senha.DefaultText = "";
            Text_Senha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Text_Senha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Text_Senha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Text_Senha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Text_Senha.FillColor = Color.FromArgb(255, 192, 255);
            Text_Senha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Senha.Font = new Font("Comic Sans MS", 21F, FontStyle.Bold);
            Text_Senha.ForeColor = Color.Black;
            Text_Senha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Senha.Location = new Point(203, 176);
            Text_Senha.Margin = new Padding(7, 8, 7, 8);
            Text_Senha.Name = "Text_Senha";
            Text_Senha.PlaceholderForeColor = Color.Black;
            Text_Senha.PlaceholderText = "Senha:";
            Text_Senha.SelectedText = "";
            Text_Senha.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Text_Senha.Size = new Size(369, 56);
            Text_Senha.TabIndex = 1;
            Text_Senha.TextOffset = new Point(4, 0);
            Text_Senha.TextChanged += Text_Senha_TextChanged;
            // 
            // Cadastrar
            // 
            Cadastrar.BorderRadius = 21;
            Cadastrar.CustomizableEdges = customizableEdges3;
            Cadastrar.DisabledState.BorderColor = Color.DarkGray;
            Cadastrar.DisabledState.CustomBorderColor = Color.DarkGray;
            Cadastrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Cadastrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Cadastrar.FillColor = Color.FromArgb(255, 192, 255);
            Cadastrar.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cadastrar.ForeColor = Color.Black;
            Cadastrar.Location = new Point(252, 262);
            Cadastrar.Margin = new Padding(2);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Cadastrar.Size = new Size(263, 66);
            Cadastrar.TabIndex = 2;
            Cadastrar.Text = "Cadastrar";
            Cadastrar.Click += Cadastrar_Click;
            // 
            // Text_Usuario
            // 
            Text_Usuario.BorderRadius = 14;
            Text_Usuario.CustomizableEdges = customizableEdges5;
            Text_Usuario.DefaultText = "";
            Text_Usuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Text_Usuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Text_Usuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Text_Usuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Text_Usuario.FillColor = Color.FromArgb(255, 192, 255);
            Text_Usuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Usuario.Font = new Font("Comic Sans MS", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Text_Usuario.ForeColor = Color.Black;
            Text_Usuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Usuario.Location = new Point(203, 80);
            Text_Usuario.Margin = new Padding(0, 13, 0, 13);
            Text_Usuario.Name = "Text_Usuario";
            Text_Usuario.PlaceholderForeColor = Color.Black;
            Text_Usuario.PlaceholderText = "Usuario:";
            Text_Usuario.SelectedText = "";
            Text_Usuario.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Text_Usuario.Size = new Size(369, 56);
            Text_Usuario.TabIndex = 0;
            Text_Usuario.TextOffset = new Point(4, 0);
            Text_Usuario.TextChanged += Text_Usuario_TextChanged;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 159, 253);
            ClientSize = new Size(789, 415);
            Controls.Add(Cadastrar);
            Controls.Add(Text_Senha);
            Controls.Add(Text_Usuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "TelaCadastro";
            Text = "TelaCadastro";
            Load += TelaCadastro_Load;
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox Text_Senha;
        private Guna.UI2.WinForms.Guna2Button Cadastrar;
        private Guna.UI2.WinForms.Guna2TextBox Text_Usuario;
    }
}