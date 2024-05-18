using Microsoft.AspNetCore.Mvc;
using MVC_Project_BookStore.Data;

namespace MVC_Project_BookStore.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext context;

        public CategoriesController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var result = context.categories.ToList();
            return View(result);
        }
    }
}
