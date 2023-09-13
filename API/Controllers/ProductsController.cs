using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext context;
        public ProductsController(StoreContext context)
        {
            this.context = context;
            
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var Products= await this.context.Products.ToListAsync();
            return Products;
        }

          [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct()
        {
            return await this.context.Products.FindAsync();
        }

    }
}