using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAPI.Data
{
    public interface IRepository<Products> where Products : class, IEntity
    {
        Task<List<Products>> GetAll();
        Task<Products> Get(int id);
        Task<Products> Add(Products entity);
        Task<Products> Update(Products entity);
        Task<Products> Delete(int id);
    }
}
