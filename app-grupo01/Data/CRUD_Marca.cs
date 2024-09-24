using app_grupo01.Models;
using MySql.Data.MySqlClient;

namespace app_grupo01.Data
{
    public class CRUD_Marca
    {
        Conexion cn = new Conexion();

        public IEnumerable<Marca> ListarMarca()
        {
            List<Marca> arr_marca = new List<Marca>();

            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_Listar_Marca", cn.Conectar);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cn.Conectar.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Marca marca = new Marca()
                    {
                        id_marca = (int)dr[0],
                        nombre_marca = dr[1] + "",
                        estatus = (bool)dr[2]
                    };

                    arr_marca.Add(marca);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                cn.Desconectar();
            }
            return arr_marca;
        }

    }
}
