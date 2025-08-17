using Staffing.Entity;

namespace ProductCatlogAPI.UiManager
{
    public class UiManager
    {

        public void ShowProduct(List<Product> products)
        {
           foreach(Product prod in products)
            {
                Console.WriteLine($"Id :{prod.Id}, Title :{prod.Title}, Description : {prod.Description},Stock :{prod.Stock}");
            }
        }
    }
}
