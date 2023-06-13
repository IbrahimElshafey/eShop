using eShop.Abstraction.BusinessAbstraction;
using eShop.Abstraction.DataAbstraction;
using eShop.Abstraction.Entities;

namespace eShop.Implementation
{
    public class ProductService: IProductService
    {
        private readonly IProductRepo _productRepo;

        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }
        public Task<List<Product>> GetTop10()
        {
            return null;
        }
    }
}