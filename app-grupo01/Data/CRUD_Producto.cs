using app_grupo01.Models;
using MySql.Data.MySqlClient;

namespace app_grupo01.Data
{
    public class CRUD_Producto
    {

        Conexion cn = new Conexion();

        public IEnumerable<Producto> ListarProducto()
        {
            List<Producto> arr_producto = new List<Producto>();

            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_Filtro_Producto('', '', '', '')", cn.Conectar);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cn.Conectar.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Producto producto = new Producto()
                    {
                        id_producto = (int)dr[0],
                        codigo_producto = (Char)dr[1],
                        nombre_producto = dr[2] + "",
                        ganancia = (Decimal)dr[3],
                        venta = (Decimal)dr[4],
                        precio = (Decimal)dr[5],
                        id_marca = (int)dr[6],
                        id_categoria = (int)dr[7],
                        estatus = (bool)dr[8]
                    };

                    arr_producto.Add(producto);
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
            return arr_producto;
        }

    }
}
