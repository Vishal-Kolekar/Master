using ProductCatlogAPI.Service.Interface;
using ProductCatlogAPI.Entity;
using ProductCatlogAPI.Repository.Interface;

namespace ProductCatlogAPI.Service.Implementation
{
    public class CategoryService:ICategoryService
    {
        public ICategoryRepo _catRepo;

        public CategoryService(ICategoryRepo catRepo)
        {
            _catRepo = catRepo;
        }

        public List<Category> GetAllCat()
        {
            return _catRepo.GetAllCategory();   
        }

        public Category GetCatById(int catId)
        {
            return _catRepo.GetCategoryById(catId);
        }

        public bool AddCatService(Category category)
        {
            bool status = _catRepo.AddCategory(category);
            return status;
        }

        public bool UpdateCatService(Category category)
        {
            bool status = _catRepo.UpdateCategory(category);
            return status;

        }

        public bool DeleteCatService(int catId)
        {
            bool status = _catRepo.DeleteCategory(catId);
            return status;
        }
    }
}
