using app_grupo01.Models;
using MySql.Data.MySqlClient;


namespace app_grupo01.Data
{
    public class CRUD_Categoria
    {
        Conexion cn = new Conexion();

        
        /// consulta de la tabla de categorias
         public IEnumerable<Categoria> ListarCategoria()
        {
            List<Categoria> arr_categoria = new List<Categoria>();

            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_Listar_Categoria", cn.Conectar);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cn.Conectar.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Categoria categoria = new Categoria()
                    {
                        id_categoria = (int)dr[0],
                        nombre_categoria = dr[1] + "",
                        estatus = (bool)dr[2]
                    };

                    arr_categoria.Add(categoria);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                cn.Desconectar();
            }
            return arr_categoria;

        }


    }
}
