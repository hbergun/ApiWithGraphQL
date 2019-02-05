using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Smile.Business.Abstract;
using Smile.Entities.Concrete;

namespace Smile.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET api/values
        [HttpGet]
        public IList<Product> Get()
        {
           return _productService.GetAll();
        }
    }
}