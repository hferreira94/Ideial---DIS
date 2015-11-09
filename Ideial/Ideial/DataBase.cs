using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ideial
{
    public class DataBase
    {
        private MySqlCommand _cmdDataBase;
        private MySqlConnection _conDataBase;
        private MySqlDataReader _myReader;

        public void Conetar()
        {
            string constring = "Server=localhost;Database=mydb;Uid=root;Pwd=;";
            _conDataBase = new MySqlConnection(constring);
        }

        public int Login(TextBox utilizador, TextBox password)
        {
            Conetar();
            int valor = 0;
            string query = "SELECT * FROM conta WHERE utilizador='" + utilizador.Text + "' AND password='" + password.Text + "';";
            _cmdDataBase = new MySqlCommand(query, _conDataBase);
            try
            {
                _conDataBase.Open();
                _myReader = _cmdDataBase.ExecuteReader(); 
                while (_myReader.Read())
                {
                }
                if (_myReader.HasRows)
                {
                    MessageBox.Show("Login Correto");
                    valor = 1;
                }
                else
                {
                    MessageBox.Show("Login Incorreto! Volte a Introduzir as suas Credenciais");
                    valor = 0;
                }                
                _myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return valor;
        }
    }
}