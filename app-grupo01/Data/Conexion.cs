using MySql.Data.MySqlClient;

namespace app_grupo01.Data
{
    public class Conexion
    {
        private MySqlConnection cnx = new MySqlConnection("Server=servidor-bd-grupo01.mysql.database.azure.com;UserID=jhuertas;Password=senati@2024;Database=bd_ds504;SslMode=Required;");

        public MySqlConnection Conectar 
        { 
            get { return cnx; }
        }

        public void Desconectar()
        {
            cnx.Close();
        }


    }
}
