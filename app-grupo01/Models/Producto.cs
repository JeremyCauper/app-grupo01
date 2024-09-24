using Org.BouncyCastle.Utilities;

namespace app_grupo01.Models
{
    public class Producto
    {
        public int id_producto { get; set; }

        public Char codigo_producto { get; set; }

        public String nombre_producto { get; set; }

        public Decimal ganancia { get; set; }

        public Decimal venta { get; set; }

        public Decimal precio { get; set; }

        public int id_marca { get; set; }

        public int id_categoria { get; set; }

        public bool estatus { get; set; }
    }
}
