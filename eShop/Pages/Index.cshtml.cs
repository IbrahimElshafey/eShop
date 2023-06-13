using eShop.Abstraction.BusinessAbstraction;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eShop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IProductService _productService;

        public IndexModel(ILogger<IndexModel> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public void OnGet()
        {

        }
    }
}