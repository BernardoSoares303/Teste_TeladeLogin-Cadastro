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
            Text_Usuario = new Guna.UI2.WinForms.Guna2TextBox();
            Text_Senha = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // Text_Usuario
            // 
            Text_Usuario.BorderRadius = 25;
            Text_Usuario.CustomizableEdges = customizableEdges1;
            Text_Usuario.DefaultText = "";
            Text_Usuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Text_Usuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Text_Usuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Text_Usuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Text_Usuario.FillColor = Color.FromArgb(255, 192, 255);
            Text_Usuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Usuario.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Text_Usuario.ForeColor = Color.Black;
            Text_Usuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Usuario.Location = new Point(258, 92);
            Text_Usuario.Margin = new Padding(0, 8, 0, 8);
            Text_Usuario.Name = "Text_Usuario";
            Text_Usuario.PlaceholderForeColor = Color.Black;
            Text_Usuario.PlaceholderText = "Usuario:";
            Text_Usuario.SelectedText = "";
            Text_Usuario.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Text_Usuario.Size = new Size(262, 50);
            Text_Usuario.TabIndex = 0;
            Text_Usuario.TextOffset = new Point(4, 0);
            Text_Usuario.TextChanged += Text_Usuario_TextChanged;
            // 
            // Text_Senha
            // 
            Text_Senha.BorderRadius = 25;
            Text_Senha.CustomizableEdges = customizableEdges3;
            Text_Senha.DefaultText = "";
            Text_Senha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Text_Senha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Text_Senha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Text_Senha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Text_Senha.FillColor = Color.FromArgb(255, 192, 255);
            Text_Senha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Senha.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Text_Senha.ForeColor = Color.Black;
            Text_Senha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_Senha.Location = new Point(258, 171);
            Text_Senha.Margin = new Padding(4, 5, 4, 5);
            Text_Senha.Name = "Text_Senha";
            Text_Senha.PlaceholderForeColor = Color.Black;
            Text_Senha.PlaceholderText = "Senha:";
            Text_Senha.SelectedText = "";
            Text_Senha.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Text_Senha.Size = new Size(262, 53);
            Text_Senha.TabIndex = 1;
            Text_Senha.TextOffset = new Point(4, 0);
            Text_Senha.TextChanged += Text_Senha_TextChanged;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 35;
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(255, 192, 255);
            guna2Button1.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(276, 248);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(219, 79);
            guna2Button1.TabIndex = 2;
            guna2Button1.Text = "Cadastrar";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 159, 253);
            ClientSize = new Size(800, 450);
            Controls.Add(guna2Button1);
            Controls.Add(Text_Senha);
            Controls.Add(Text_Usuario);
            Name = "TelaCadastro";
            Text = "TelaCadastro";
            Load += TelaCadastro_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox Text_Usuario;
        private Guna.UI2.WinForms.Guna2TextBox Text_Senha;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}