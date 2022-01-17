
using BlogApplication.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BlogApplication.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryServices ics;
        public CategoryController(ICategoryServices _ics)
        {
            ics = _ics;
        }
        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            if(userId == null)
            {
                return NotFound();
            }
            return View(ics.GetAllCategories());
        }
        public IActionResult Delete(int id)
        {
            ics.DeleteACategory(id);
            return RedirectToAction("Index");
        }
    }
}
