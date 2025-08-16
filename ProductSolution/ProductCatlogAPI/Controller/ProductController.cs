using Microsoft.AspNetCore.Mvc;
using Staffing.Repository.Implementation;
using Staffing.Repository.Interface;
using Staffing.Service;
using Staffing.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductCatlogAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductRepo repo = new ProductRepo();
        //IProductService svc = new ProductService(repo);


        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
        
            IProductService svc = new ProductService(repo);
            List<Product> products = svc.GetProd();
            return products;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            IProductService svc = new ProductService(repo);
            Product product = svc.GetById(id);
            return product;
            
        }

        // POST api/<ProductController>
        [HttpPost]
        public bool Post([FromBody] Product product)
        {
            IProductService svc = new ProductService(repo);
            bool status = svc.AddProduct(product);
            return status;
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Product product)
        {
            IProductService svc = new ProductService(repo);

            //Product prod = svc.GetById(id);
            bool status = svc.UpdateProduct(product);
            return status;

        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            IProductService svc = new ProductService(repo);
            bool status = svc.DeleteProduct(id);
            return status;
        }
    }
}
