
using MySql.Data.MySqlClient;
using ProductCatlogAPI.Entity;
using ProductCatlogAPI.Repository.Interface;

namespace ProductCatlogAPI.Repository.Implementation
{
    public class CategoryRepo :ICategoryRepo
    {
        List<Category> categories = new List<Category>();

        string connectionString = "server = localhost; database= product; port = 3306; user = root; password= password;";

      
       public List<Category> GetAllCategory()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM CATEGORY", connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Category category = new Category
                    {
                        CatId = reader.GetInt32("CatId"),
                        CategoryName = reader.GetString("CategoryName")
                    };

                    categories.Add(category);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return categories;
        }

        public Category GetCategoryById(int catId)
        {
            throw new NotImplementedException();
        }

        public bool AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCategory(int catId)
        {
            throw new NotImplementedException();
        }
    }
}
