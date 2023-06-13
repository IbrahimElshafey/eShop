using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eShop.Abstraction.Entities;

namespace eShop.Abstraction.BusinessAbstraction
{
    public interface IProductService
    {
        Task<List<Product>> GetTop10();
    }
}
