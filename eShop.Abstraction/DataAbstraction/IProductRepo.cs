using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eShop.Abstraction.Entities;

namespace eShop.Abstraction.DataAbstraction
{
    public interface IProductRepo
    {
        Task<int> AddProduct(Product product);
        IQueryable<Product> GetProducts();
    }
}
