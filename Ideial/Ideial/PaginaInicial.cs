using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ideial
{
    public partial class PaginaInicial : Form
    {
        public PaginaInicial()
        {
            InitializeComponent();
            EstadoInicial();
        }

        private void PaginaInicial_Load(object sender, EventArgs e)
        {
            
        }

        private void login_Click(object sender, EventArgs e)
        {
            registo.Visible = false;
            login.Visible = false;
            entrar.Visible = true;
            utilizadorLabel.Visible = true;
            utilizador.Visible = true;
            passwordLabel.Visible = true;
            password.Visible = true;
            voltar.Visible = true;
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            int valor=0;
            DataBase verificarLogin=new DataBase();
            valor=verificarLogin.Login(utilizador, password);
            if (valor == 0)
            {
                EstadoLogin();
            }
            else
            {
                EstadoInicial();
            }
        }

        public void EstadoInicial()
        {
            utilizadorLabel.Visible = false;
            utilizador.Visible = false;
            passwordLabel.Visible = false;
            password.Visible = false;
            entrar.Visible = false;
            voltar.Visible = false;
            registo.Visible = true;
            login.Visible = true;
            utilizadorRegisto.Visible = false;
            passwordRegisto.Visible = false;
            passwordRegisto2.Visible = false;
            email.Visible = false;
            confirmarPasswordLabel.Visible = false;
            emailLabel.Visible = false;
            registar.Visible = false;
        }

        public void EstadoLogin()
        {
            registo.Visible = false;
            login.Visible = false;
            entrar.Visible = true;
            utilizadorLabel.Visible = true;
            utilizador.Visible = true;
            passwordLabel.Visible = true;
            password.Visible = true;
            voltar.Visible = true;
        }

        public void EstadoRegisto()
        {
            utilizadorLabel.Visible = true;
            utilizador.Visible = false;
            passwordLabel.Visible = true;
            password.Visible = false;
            entrar.Visible = false;
            voltar.Visible = true;
            registo.Visible = false;
            login.Visible = false;
            utilizadorRegisto.Visible = true;
            passwordRegisto.Visible = true;
            passwordRegisto2.Visible = true;
            email.Visible = true;
            confirmarPasswordLabel.Visible = true;
            emailLabel.Visible = true;
            registar.Visible = true;
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void registo_Click(object sender, EventArgs e)
        {
            EstadoRegisto();
        }

        private void registar_Click(object sender, EventArgs e)
        {
            int valor = 0;
            bool verifica = false;
            DataBase verificarRegisto = new DataBase();
            if (passwordRegisto.Text != passwordRegisto2.Text)
            {
                MessageBox.Show("Passwords introduzidas não combinam!");
            }
            else
            {
                verifica = emailIsValid(email.Text);
                if (verifica == true)
                {
                    valor = verificarRegisto.Registo(utilizadorRegisto, passwordRegisto, email);
                }
                else
                {
                    MessageBox.Show("Email Inválido!");
                    EstadoRegisto();
                }
            }           
            if (valor == 0)
            {
                EstadoRegisto();
            }
            else
            {
                EstadoInicial();
            }
        }

        public static bool emailIsValid(string email)
        {
            string expressao;
            expressao = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expressao))
            {
                if (Regex.Replace(email, expressao, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
