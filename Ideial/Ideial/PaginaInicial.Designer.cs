namespace Ideial
{
    partial class PaginaInicial
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
            this.login = new System.Windows.Forms.Button();
            this.registo = new System.Windows.Forms.Button();
            this.utilizadorLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.utilizador = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.entrar = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(602, 12);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // registo
            // 
            this.registo.Location = new System.Drawing.Point(602, 41);
            this.registo.Name = "registo";
            this.registo.Size = new System.Drawing.Size(75, 23);
            this.registo.TabIndex = 1;
            this.registo.Text = "Registo";
            this.registo.UseVisualStyleBackColor = true;
            // 
            // utilizadorLabel
            // 
            this.utilizadorLabel.AutoSize = true;
            this.utilizadorLabel.Location = new System.Drawing.Point(13, 12);
            this.utilizadorLabel.Name = "utilizadorLabel";
            this.utilizadorLabel.Size = new System.Drawing.Size(50, 13);
            this.utilizadorLabel.TabIndex = 2;
            this.utilizadorLabel.Text = "Utilizador";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(13, 41);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // utilizador
            // 
            this.utilizador.Location = new System.Drawing.Point(69, 9);
            this.utilizador.Name = "utilizador";
            this.utilizador.Size = new System.Drawing.Size(100, 20);
            this.utilizador.TabIndex = 4;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(69, 38);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 5;
            // 
            // entrar
            // 
            this.entrar.Location = new System.Drawing.Point(602, 12);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(75, 23);
            this.entrar.TabIndex = 6;
            this.entrar.Text = "Entrar";
            this.entrar.UseVisualStyleBackColor = true;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(602, 41);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 23);
            this.voltar.TabIndex = 7;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            // 
            // PaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 315);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.password);
            this.Controls.Add(this.utilizador);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.utilizadorLabel);
            this.Controls.Add(this.registo);
            this.Controls.Add(this.login);
            this.Name = "PaginaInicial";
            this.Text = "Página Inicial";
            this.Load += new System.EventHandler(this.PaginaInicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button registo;
        private System.Windows.Forms.Label utilizadorLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox utilizador;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.Button voltar;
    }
}

