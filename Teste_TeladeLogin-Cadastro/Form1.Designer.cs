namespace Teste_TeladeLogin_Cadastro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            FazerCadastro = new Guna.UI2.WinForms.Guna2Button();
            FazerLogin = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // FazerCadastro
            // 
            FazerCadastro.BorderRadius = 45;
            FazerCadastro.CustomizableEdges = customizableEdges1;
            FazerCadastro.DisabledState.BorderColor = Color.DarkGray;
            FazerCadastro.DisabledState.CustomBorderColor = Color.DarkGray;
            FazerCadastro.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            FazerCadastro.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            FazerCadastro.FillColor = Color.FromArgb(255, 192, 255);
            FazerCadastro.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold);
            FazerCadastro.ForeColor = Color.Black;
            FazerCadastro.Location = new Point(359, 387);
            FazerCadastro.Name = "FazerCadastro";
            FazerCadastro.ShadowDecoration.CustomizableEdges = customizableEdges2;
            FazerCadastro.Size = new Size(407, 105);
            FazerCadastro.TabIndex = 0;
            FazerCadastro.Text = "Fazer Cadastro";
            FazerCadastro.Click += FazerCadastro_Click;
            // 
            // FazerLogin
            // 
            FazerLogin.BorderRadius = 45;
            FazerLogin.CustomizableEdges = customizableEdges3;
            FazerLogin.DisabledState.BorderColor = Color.DarkGray;
            FazerLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            FazerLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            FazerLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            FazerLogin.FillColor = Color.FromArgb(255, 192, 255);
            FazerLogin.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold);
            FazerLogin.ForeColor = Color.Black;
            FazerLogin.Location = new Point(359, 513);
            FazerLogin.Name = "FazerLogin";
            FazerLogin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            FazerLogin.Size = new Size(407, 105);
            FazerLogin.TabIndex = 1;
            FazerLogin.Text = "Fazer Login";
            FazerLogin.Click += FazerLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._6207a59626ab99000460a364;
            pictureBox1.Location = new Point(441, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(354, 310);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = Properties.Resources.pngegg;
            pictureBox2.Location = new Point(344, 185);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(179, 163);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 159, 253);
            ClientSize = new Size(1127, 692);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(FazerLogin);
            Controls.Add(FazerCadastro);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Tela Inicial";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Fazer_Cadastro;
        private Guna.UI2.WinForms.Guna2Button FazerCadastro;
        private Guna.UI2.WinForms.Guna2Button FazerLogin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
