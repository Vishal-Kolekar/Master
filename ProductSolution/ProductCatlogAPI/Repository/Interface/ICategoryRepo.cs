using ProductCatlogAPI.Entity;

namespace ProductCatlogAPI.Repository.Interface
{
    public interface ICategoryRepo
    {
        public List<Category> GetAllCategory();
        public Category GetCategoryById(int catId);
        public bool AddCategory(Category category);
        public bool UpdateCategory(Category category);
        public bool DeleteCategory(int catId);
    }
}
