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
        IProductService _svc;

        public ProductController(IProductService svc)
        {
            _svc = svc;
        }


        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            List<Product> products = _svc.GetProd();
            return products;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            Product product = _svc.GetById(id);
            return product;
            
        }

        // POST api/<ProductController>
        [HttpPost]
        public bool Post([FromBody] Product product)
        {
            bool status = _svc.AddProduct(product);
            return status;
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Product product)
        {
            if(id != product.Id)
            {
                return false;
            }
            bool status = _svc.UpdateProduct(product);
            return status;

        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            bool status = _svc.DeleteProduct(id);
            return status;
        }
    }
}
