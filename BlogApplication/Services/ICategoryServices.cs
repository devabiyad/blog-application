using BlogApplication.Models;

namespace BlogApplication.Services
{
    public interface ICategoryServices
    {
        public IEnumerable<Category> GetAllCategories();

        public void DeleteACategory(int id);

    }
}
