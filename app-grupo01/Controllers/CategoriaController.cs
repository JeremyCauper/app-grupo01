using app_grupo01.Data;
using app_grupo01.Models;
using Microsoft.AspNetCore.Mvc;

namespace app_grupo01.Controllers
{
    public class CategoriaController : Controller
    { 
        CRUD_Categoria crud_categoria = new CRUD_Categoria();
    public IActionResult Index()
        {
        IEnumerable<Categoria> arr_categoria = crud_categoria.ListarCategoria();
        return View(arr_categoria);
        }
    }
}
