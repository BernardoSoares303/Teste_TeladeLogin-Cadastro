namespace Teste_TeladeLogin_Cadastro
{
    partial class TelaCep
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtCep = new MaskedTextBox();
            label1 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            txtLogradouro = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtCep
            // 
            txtCep.CutCopyMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txtCep.Font = new Font("Segoe UI", 15F);
            txtCep.Location = new Point(12, 78);
            txtCep.Mask = "00000-000";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(173, 47);
            txtCep.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 255);
            label1.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(52, 31);
            label1.TabIndex = 1;
            label1.Text = "Cep";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 25;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(255, 192, 255);
            guna2Button1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(254, 78);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(197, 50);
            guna2Button1.TabIndex = 2;
            guna2Button1.Text = "Buscar Cep";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            txtLogradouro.Location = new Point(12, 218);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(329, 33);
            txtLogradouro.TabIndex = 3;
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            txtBairro.Location = new Point(397, 218);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(329, 33);
            txtBairro.TabIndex = 4;
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            txtCidade.Location = new Point(12, 316);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(329, 33);
            txtCidade.TabIndex = 5;
            // 
            // txtEstado
            // 
            txtEstado.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            txtEstado.Location = new Point(397, 316);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(329, 33);
            txtEstado.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 255);
            label2.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 184);
            label2.Name = "label2";
            label2.Size = new Size(61, 31);
            label2.TabIndex = 7;
            label2.Text = "Rua:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 192, 255);
            label3.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(397, 184);
            label3.Name = "label3";
            label3.Size = new Size(90, 31);
            label3.TabIndex = 8;
            label3.Text = "Bairro:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 192, 255);
            label4.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 282);
            label4.Name = "label4";
            label4.Size = new Size(90, 31);
            label4.TabIndex = 9;
            label4.Text = "Bairro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 192, 255);
            label5.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(398, 282);
            label5.Name = "label5";
            label5.Size = new Size(53, 31);
            label5.TabIndex = 10;
            label5.Text = "UF:";
            // 
            // TelaCep
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 159, 253);
            ClientSize = new Size(1127, 692);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEstado);
            Controls.Add(txtCidade);
            Controls.Add(txtBairro);
            Controls.Add(txtLogradouro);
            Controls.Add(guna2Button1);
            Controls.Add(label1);
            Controls.Add(txtCep);
            Name = "TelaCep";
            Text = "TelaCep";
            Load += TelaCep_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtCep;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private TextBox txtLogradouro;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtEstado;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}