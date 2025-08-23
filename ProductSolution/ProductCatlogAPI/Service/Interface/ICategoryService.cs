
using ProductCatlogAPI.Entity;

namespace ProductCatlogAPI.Service.Interface
{
    public interface ICategoryService
    {
        public List<Category> GetAllCat();
        public Category GetCatById(int catId);
        public bool AddCatService(Category category);
        public bool UpdateCatService(Category category);
        public bool DeleteCatService(int catId);
    }
}
