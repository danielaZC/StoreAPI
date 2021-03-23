using ProductsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAPI.Data.EFCore
{
    public class EFCoreProductRepository : EfCoreRepository<Products, ProductsAPIContext>
    {
        public EFCoreProductRepository(ProductsAPIContext context) : base(context)
        {

        }
    }
}
