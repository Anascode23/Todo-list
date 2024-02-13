using Microsoft.AspNetCore.Mvc;

namespace Todo_list.Controllers
{
    public class TodoController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
