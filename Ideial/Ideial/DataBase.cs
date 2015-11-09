using MySql.Data.MySqlClient;

namespace Ideial
{
    public class DataBase
    {
        public void Conetar()
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
        }
    }
}