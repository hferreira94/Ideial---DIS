using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }
    }
}
