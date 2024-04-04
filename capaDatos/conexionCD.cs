using MySql.Data.MySqlClient;
using System.Configuration;

namespace capaDatos
{
    public class conexionCD
    {
        static public MySqlConnection cnx()
        {
            string connetionString = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;

            MySqlConnection connetion = new MySqlConnection(connetionString);

            return connetion;
        }
    }
}
