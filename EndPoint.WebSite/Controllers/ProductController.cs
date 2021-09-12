using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductFacad _productFacad;
        public ProductController(IProductFacad productFacad)
        {
            _productFacad = productFacad;
        }

        [Route("Products/{productId}")]
        public IActionResult Index(int productId)
        {
            ViewBag.ProductId = productId;
            var isExist = _productFacad.isExistProductService.Execute(productId);
            if (!isExist.Data)
            {
                return NotFound();
            }

            return View();

        }
    }
}
