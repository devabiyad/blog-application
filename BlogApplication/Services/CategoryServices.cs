using BlogApplication.Context;
using BlogApplication.Models;

namespace BlogApplication.Services
{
    public class CategoryServices : ICategoryServices
    {
        MvcContext db;
        public CategoryServices(MvcContext _db)
        {
            db = _db;
        }
        public void DeleteACategory(int id)
        {
            Category category = db.Categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                db.Remove(category);
                db.SaveChanges();
            }
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return (db.Categories.Select(c => c).ToList());
        }
    }
}
