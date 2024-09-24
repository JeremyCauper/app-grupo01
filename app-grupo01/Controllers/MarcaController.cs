using app_grupo01.Data;
using app_grupo01.Models;
using Microsoft.AspNetCore.Mvc;

namespace app_grupo01.Controllers
{
    public class MarcaController : Controller
    {
        CRUD_Marca crud_marca = new CRUD_Marca();

        public IActionResult Index()
        {
            IEnumerable<Marca> arr_marca = crud_marca.ListarMarca();
            return View(arr_marca);
        }
    }
}
