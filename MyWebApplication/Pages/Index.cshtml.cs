using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyWebApplication.Models;
using MyWebApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApplication.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;
        private readonly ContosoCraftDatabaseContext _dbContext;
        //public JsonFileProductService ProductService;
        //public IEnumerable<Product> Products { get; private set; }

        //public IndexModel(ILogger<IndexModel> logger,
        //ContosoCraftDatabaseContext dbContext)
        //{
        //    _logger = logger;
        //    _dbContext = dbContext;
        //    //ProductService = productService;
        //}
        public IndexModel(ContosoCraftDatabaseContext dbContext)
        {
            //_logger = logger;
            //ProductsService = productsService;
            _dbContext = dbContext;


        }
        public IEnumerable<Product> getRecords { get; set; }

        public async Task OnGet()
        {
            //Products = ProductsService.GetProducts();
            getRecords = await _dbContext.Products.ToListAsync();
        }
        
    }
}
