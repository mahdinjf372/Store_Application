using EndPoint.WebSite.Areas.Admin.Models.Product.Create;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Brands.Queries.GetBrands;
using Store_Application.Application.Services.Categories.Queries.GetCategories;
using Store_Application.Common.Security;
using Store_Application.Common.ViewModels;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store_Application.Domain.Entities.Product;
using Store_Application.Application.Services.Products.Commands.AddProduct;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductFacad _productFacad;
        private readonly ICategoryFacad _categoryFacad;
        private readonly IBrandFacad _brandFacad;

        public ProductController(IProductFacad productFacad, ICategoryFacad categoryFacad, IBrandFacad brandFacad)
        {
            _productFacad = productFacad;
            _categoryFacad = categoryFacad;
            _brandFacad = brandFacad;
        }

        public IActionResult Index(string searchKey = "", int page = 1)
        {
            ViewBag.searchKey = searchKey;
            ViewBag.page = page;

            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {

            ResultDto<List<ResultGetCategoriesDto>> cats = _categoryFacad.GetCategoriesService.Execute();
            ViewBag.Categories = new SelectList(cats.Data, "Id", "Title");

            ResultDto<List<ResultGetBrandsDto>> brands = _brandFacad.GetBrandsService.Execute();
            ViewBag.Brands = new SelectList(brands.Data, "Id", "Name");

            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateProductViewModel req)
        {
            var RequestValidator = new CreateProductViewModelValidator(_categoryFacad,_brandFacad);
            var Validator = RequestValidator.Validate(req);
            Validator.AddToModelState(ModelState, null);



            if (!ModelState.IsValid)
            {

                ResultDto<List<ResultGetCategoriesDto>> cats = _categoryFacad.GetCategoriesService.Execute();
                ViewBag.Categories = new SelectList(cats.Data, "Id", "Title", req.CategoryId);

                ResultDto<List<ResultGetCategoriesDto>> grps = _categoryFacad.GetCategoriesService.Execute(req.CategoryId);
                ViewBag.Groups = new SelectList(grps.Data, "Id", "Title", req.GroupId);

                ResultDto<List<ResultGetCategoriesDto>> subGrps = _categoryFacad.GetCategoriesService.Execute(req.GroupId);
                ViewBag.SubGroups = new SelectList(subGrps.Data, "Id", "Title", req.SubGroupId);

                ResultDto<List<ResultGetBrandsDto>> brands = _brandFacad.GetBrandsService.Execute();
                ViewBag.Brands = new SelectList(brands.Data, "Id", "Name", req.BrandId);

            }

            //return View(req);

            List<Image> images = new List<Image>();

            //Main image
            if (req.MainImage != null && req.MainImage.OpenReadStream().IsImage())
            {
                var name = Guid.NewGuid() + Path.GetExtension(req.MainImage.FileName);
                images.Add(new Image
                {
                    Name = name,
                    isMainImage = true
                });
                string savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ProductImages",
                    name);
                using (var stream = new FileStream(savePath, FileMode.Create))
                {
                    req.MainImage.CopyTo(stream);
                }
            }

            //gallery images
            if (req.GalleryImages!=null)
            {
                foreach (var image in req.GalleryImages)
                {
                    if (image.OpenReadStream().IsImage())
                    {
                        var name = Guid.NewGuid() + Path.GetExtension(image.FileName);
                        images.Add(new Image
                        {
                            Name = name,
                            isMainImage = false
                        });
                        string savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ProductImages",
                            name);
                        using (var stream = new FileStream(savePath, FileMode.Create))
                        {
                            image.CopyTo(stream);
                        }
                    }
                }
            }

            //description images
            var des = req.Description;

            RequestAddProductDto product = new RequestAddProductDto()
            {
                BrandId = req.BrandId,
                CategoryId = req.CategoryId,
                GroupId = req.GroupId,
                SubGroupId = req.SubGroupId,
                Description = req.Description,
                Displayed = req.Displayed,
                DiscountAmount = req.DiscountAmount,
                Inventory = req.Inventory,
                Price = req.Price,
                ShortDescription = req.ShortDescription,
                Title = req.Title,
                Images = images
            };

            //_productFacad.AddProductService.Execute(product);
            return View(req);
           //return Redirect("/Admin/Product");
        }

        public PartialViewResult LoadSubCategories(int id)
        {
            var model = _categoryFacad.GetCategoriesService.Execute(id);
            return PartialView("_LoadSubCategories", model);
        }

        private System.Drawing.Image Base64ToImage(string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            System.Drawing.Image image = System.Drawing.Image.FromStream(new MemoryStream(bytes));

            return image;
        }

        //private string[] FindDescriptionImages(string description)
        //{
        //    int first = description.IndexOf("<img ") + "methods".Length;
        //    int last = description.LastIndexOf("methods");
        //    string str2 = description.Substring(first, last - first);
        //}
    }
}
