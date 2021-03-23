using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsAPI.Data.EFCore;
using ProductsAPI.Models;

namespace ProductsAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : BaseController<Products, EFCoreProductRepository>
    {
        public ProductsController(EFCoreProductRepository repository) : base(repository)
        {

        }
    }
}
