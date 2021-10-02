using EndPoint.WebSite.Areas.Admin.Models.Common;
using EndPoint.WebSite.Areas.Admin.Models.Product.ChangeProductSliders;
using EndPoint.WebSite.Areas.Admin.Models.Product.Create;
using EndPoint.WebSite.Areas.Admin.Models.Product.Edit;
using EndPoint.WebSite.Areas.Admin.Models.Product.LoadGalleryImages;
using EndPoint.WebSite.Areas.Admin.Models.Product.LoadProducts;
using EndPoint.WebSite.Areas.Admin.Models.Product.LoadProductSliders;
using EndPoint.WebSite.Areas.Admin.Models.Product.LoadSubCategories;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Brands.Queries.GetBrandsForAdmin;
using Store_Application.Application.Services.Categories.Queries.GetCategoriesForAdmin;
using Store_Application.Application.Services.Products.Commands.AddGalleryImage;
using Store_Application.Application.Services.Products.Commands.AddProduct;
using Store_Application.Application.Services.Products.Commands.EditProduct;
using Store_Application.Application.Services.Products.Queries.GetProductsForAdmin;
using Store_Application.Application.Services.ProductSliders.Commands.AddProductSlider;
using Store_Application.Application.Services.ProductSliders.Commands.DeleteProductSlider;
using Store_Application.Common.Extentions;
using Store_Application.Common.Security;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Enums;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = nameof(Roles.Admin) + "," + nameof(Roles.Operator))]

    public class ProductController : Controller
    {
        private readonly IProductFacad _productFacad;
        private readonly ICategoryFacad _categoryFacad;
        private readonly IBrandFacad _brandFacad;
        private readonly IProductSlidersFacad _productSlidersFacad;
        private readonly ISlidersFacad _slidersFacad;


        public ProductController(IProductFacad productFacad,
            ICategoryFacad categoryFacad,
            IBrandFacad brandFacad,
            IProductSlidersFacad productSlidersFacad,
            ISlidersFacad slidersFacad)
        {
            _productFacad = productFacad;
            _categoryFacad = categoryFacad;
            _brandFacad = brandFacad;
            _productSlidersFacad = productSlidersFacad;
            _slidersFacad = slidersFacad;
        }

        [HttpGet]
        public IActionResult Index(string searchKey = "", int page = 1, int take =  10)
        {
            ViewBag.searchKey = searchKey;
            ViewBag.page = page;
            ViewBag.take = take;
            return View();
        }

        #region Product

        [HttpGet]
        public IActionResult Create()
        {

            ResultDto<List<ResultGetCategoriesForAdminDto>> cats = _categoryFacad.GetCategoriesForAdminService.Execute(IgnoreFilters: false);
            ViewBag.Categories = new SelectList(cats.Data, "Id", "Title");

            ResultDto<List<ResultGetBrandsForAdminDto>> brands = _brandFacad.GetBrandsForAdminService.Execute(IgnoreFilters: false);
            ViewBag.Brands = new SelectList(brands.Data, "Id", "Name");

            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateProductViewModel req)
        {
            var RequestValidator = new CreateProductViewModelValidator(_productFacad, _categoryFacad, _brandFacad);
            var Validator = RequestValidator.Validate(req);
            Validator.AddToModelState(ModelState, null);

            if (!ModelState.IsValid)
            {
                ResultDto<List<ResultGetCategoriesForAdminDto>> cats = _categoryFacad.GetCategoriesForAdminService.Execute(IgnoreFilters: true);
                ViewBag.Categories = new SelectList(cats.Data, "Id", "Title", req.CategoryId);

                ResultDto<List<ResultGetCategoriesForAdminDto>> grps = _categoryFacad.GetCategoriesForAdminService.Execute(req.CategoryId, IgnoreFilters: true);
                ViewBag.Groups = new SelectList(grps.Data, "Id", "Title", req.GroupId);

                ResultDto<List<ResultGetCategoriesForAdminDto>> subGrps = _categoryFacad.GetCategoriesForAdminService.Execute(req.GroupId, IgnoreFilters: true);
                ViewBag.SubGroups = new SelectList(subGrps.Data, "Id", "Title", req.SubGroupId);

                ResultDto<List<ResultGetBrandsForAdminDto>> brands = _brandFacad.GetBrandsForAdminService.Execute(IgnoreFilters: false);
                ViewBag.Brands = new SelectList(brands.Data, "Id", "Name", req.BrandId);

                return View(req);
            }

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
                MainImage = req.MainImage,
                GalleryImages = req.GalleryImages
            };

            _productFacad.AddProductService.Execute(product);
            return Redirect("/Admin/Product");
        }

        [HttpGet]
        public IActionResult Edit(int productId)
        {
            var res = _productFacad.GetProductForAdminService.Execute(productId);
            if (res.IsSuccess)
            {
                var product = res.Data;
                ResultDto<List<ResultGetCategoriesForAdminDto>> cats = _categoryFacad.GetCategoriesForAdminService.Execute(IgnoreFilters: false);
                ViewBag.Categories = new SelectList(cats.Data, "Id", "Title", product.CategoryId);

                ResultDto<List<ResultGetCategoriesForAdminDto>> grps = _categoryFacad.GetCategoriesForAdminService.Execute(product.CategoryId, IgnoreFilters: false);
                ViewBag.Groups = new SelectList(grps.Data, "Id", "Title", product.GroupId);

                ResultDto<List<ResultGetCategoriesForAdminDto>> subGrps = _categoryFacad.GetCategoriesForAdminService.Execute(product.GroupId, IgnoreFilters: false);
                ViewBag.SubGroups = new SelectList(subGrps.Data, "Id", "Title", product.SubgroupId);

                ResultDto<List<ResultGetBrandsForAdminDto>> brands = _brandFacad.GetBrandsForAdminService.Execute(IgnoreFilters: false);
                ViewBag.Brands = new SelectList(brands.Data, "Id", "Name", product.BrandId);

                var model = new EditProductViewModel()
                {
                    Id = product.Id,
                    Title = product.Title,
                    ShortDescription = product.ShortDescription,
                    Description = product.Decription,
                    Inventory = product.Inventory,
                    Price = product.Price,
                    DiscountAmount = product.DiscountAmount,
                    CategoryId = product.CategoryId,
                    GroupId = product.GroupId,
                    SubgroupId = product.SubgroupId,
                    BrandId = product.BrandId,
                    Displayed = product.Displayed,
                    Image = product.Images.SingleOrDefault(i => i.IsMainImages).Name,
                };

                return View(model);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(EditProductViewModel req)
        {
            var RequestValidator = new EditProductViewModelValidator(_productFacad, _categoryFacad, _brandFacad);
            var Validator = RequestValidator.Validate(req);
            Validator.AddToModelState(ModelState, null);

            if (!ModelState.IsValid)
            {
                ResultDto<List<ResultGetCategoriesForAdminDto>> cats = _categoryFacad.GetCategoriesForAdminService.Execute(IgnoreFilters: true);
                ViewBag.Categories = new SelectList(cats.Data, "Id", "Title", req.CategoryId);

                ResultDto<List<ResultGetCategoriesForAdminDto>> grps = _categoryFacad.GetCategoriesForAdminService.Execute(req.CategoryId, IgnoreFilters: true);
                ViewBag.Groups = new SelectList(grps.Data, "Id", "Title", req.GroupId);

                ResultDto<List<ResultGetCategoriesForAdminDto>> subGrps = _categoryFacad.GetCategoriesForAdminService.Execute(req.GroupId, IgnoreFilters: true);
                ViewBag.SubGroups = new SelectList(subGrps.Data, "Id", "Title", req.SubgroupId);

                ResultDto<List<ResultGetBrandsForAdminDto>> brands = _brandFacad.GetBrandsForAdminService.Execute(IgnoreFilters: false);
                ViewBag.Brands = new SelectList(brands.Data, "Id", "Name", req.BrandId);

                return View(req);
            }

            RequestEditProductDto product = new RequestEditProductDto()
            {
                Id = req.Id,
                BrandId = req.BrandId,
                CategoryId = req.CategoryId,
                GroupId = req.GroupId,
                SubGroupId = req.SubgroupId,
                Description = req.Description,
                Displayed = req.Displayed,
                DiscountAmount = req.DiscountAmount,
                Inventory = req.Inventory,
                Price = req.Price,
                ShortDescription = req.ShortDescription,
                Title = req.Title,
                Image = req.Image,
                MainImage = req.MainImage
            };

            _productFacad.EditProductService.Execute(product);
            return Redirect("/Admin/Product");
        }

        [HttpPost]
        public IActionResult DeleteProduct(int id)
        {
            var isExist = _productFacad.isExistProductService.Execute(id);
            if (isExist.Data)
            {
                var res = _productFacad.DeleteProductService.Execute(id);
                return Json(res);
            }

            return Json(false);
        }

        [HttpPost]
        public PartialViewResult LoadProducts(string searchKey = null, int page = 1, int take = 10)
        {
            ViewBag.searchKey = searchKey;
            ViewBag.page = page;
            ViewBag.take = take;

            var res = _productFacad.GetProductsForAdminService.Execute(new RequestGetProductsForAdminDto { Searchkey = searchKey, Page = page, Take = take });

            LoadProductsViewModel model = new LoadProductsViewModel();
            model.Products = res.Data.Products.Select(p => new ProductViewModel
            {
                Id = p.Id,
                Title = p.Title,
                Displayed = p.Displayed,
                ImageTitle = p.ImageTitle,
                Inventory = p.Inventory,
                IsRemoved = p.IsRemoved,
                Price = p.Price,
                CategoryTitle = p.CategoryTitle,
                GroupTitle = p.GroupTitle,
                SubgroupTitle = p.SubgroupTitle
            }).ToList();

            model.Paging = new PagingViewModel
            {
                CurrentPage = res.Data.CurrentPage,
                PageCount = res.Data.PageCount
            };

            return PartialView("/Areas/Admin/Views/Product/_LoadProducts.cshtml", model);
        }

        #endregion

        #region Gallery

        [HttpPost]
        public IActionResult AddImageToGallery(int productId, List<IFormFile> images)
        {
            if (_productFacad.isExistProductService.Execute(productId).Data)
            {
                List<requestAddGalleryImageDto> galleryImages = new List<requestAddGalleryImageDto>();

                foreach (var image in images)
                {
                    var galleryImage = new requestAddGalleryImageDto();
                    galleryImage.ProductId = productId;
                    galleryImage.Name = "default.jpg";

                    if (image.OpenReadStream().IsImage())
                    {
                        galleryImage.Name = Generator.GetImageName() + Path.GetExtension(image.FileName);
                        string savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images\\page-single-product\\product-img",
                            galleryImage.Name);
                        using (var stream = new FileStream(savePath, FileMode.Create))
                        {
                            image.CopyTo(stream);
                        }
                        galleryImages.Add(galleryImage);
                    }
                    else
                    {
                        return Json(false);
                    }
                }

                var res = _productFacad.AddGalleryImageService.Execute(galleryImages);
                return Json(res);
            }

            return Json(false);
        }

        [HttpPost]
        public IActionResult DeleteImageFromGallery(int imageId)
        {
            var isExist = _productFacad.isExistImageService.Execute(imageId);
            if (isExist.Data)
            {
                var res = _productFacad.DeleteImageService.Execute(imageId);
                var image = _productFacad.GetGalleryImageForAdminService.Execute(imageId).Data;
                if (image.Name != "default.jpg")
                {
                    string deletePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images\\page-single-product\\product-img",
                        image.Name);
                    //if (System.IO.File.Exists(deletePath))
                    //  System.IO.File.Delete(deletePath);
                }

                return Json(res);
            }
            else
            {
                return Json(isExist);
            }
        }

        [HttpPost]
        public PartialViewResult LoadGalleryImages(int productId)
        {
            var res = _productFacad.GetGalleryImagesForAdminService.Execute(productId);
            List<GalleryImageViewModel> model = res.Data.Select(i => new GalleryImageViewModel
            {
                Id = i.Id,
                Name = i.Name
            }).ToList();
            return PartialView("/Areas/Admin/Views/Product/_LoadGalleryImages.cshtml", model);

        }

        #endregion

        #region Category

        [HttpPost]
        public PartialViewResult LoadSubCategories(int id)
        {
            var categories = _categoryFacad.GetCategoriesForAdminService.Execute(id, IgnoreFilters: false);

            List<SubCategoryViewModel> model = categories.Data.Select(c => new SubCategoryViewModel
            {
                Id = c.Id,
                ImageName = c.ImageName,
                isRemoved = c.isRemoved,
                ParentCategoryId = c.ParentCategoryId,
                Title = c.Title
            }).ToList();

            return PartialView("_LoadSubCategories", model);
        }

        #endregion

        #region ProductSliders

        [HttpPost]
        public PartialViewResult LoadProductSliders(int productId)
        {
            LoadProductSlidersViewModel model = new LoadProductSlidersViewModel();
            ViewBag.ProductId = productId;

            var productSliders = _productSlidersFacad.GetProductSlidersService.Execute(productId);

            var sliders = _slidersFacad.GetSlidersForAdminService.Execute();

            model.Sliders = sliders.Data.Select(s=> new Models.Product.LoadProductSliders.SliderViewModel
            {
                Id = s.Id,
                Title = s.Title
            }).ToList();

            model.productSliders = productSliders.Data.Select(ps => new ProductSlidersViewModel
            {
                Id = ps.Id,
                SliderId = ps.SliderId
            }).ToList();

            return PartialView("/Areas/Admin/Views/Product/_LoadProductSliders.cshtml", model);
        }

        public IActionResult ChangeProductSliders(ChangeProductSlidersViewModel req)
        {
            ResultDto res = new ResultDto();

            if (req.Sliders.Any())
            {
                foreach (var slider in req.Sliders)
                {
                    if (slider.Checked)
                    {
                        if (!_productSlidersFacad.IsExistProductSliderService.Execute(req.ProductId,slider.SliderId).Data)
                        {
                            _productSlidersFacad.AddProductSliderService.Execute(new RequestAddProductSliderDto
                            {
                                ProductId = req.ProductId,
                                SliderId = slider.SliderId
                            });
                        }
                    }
                    else
                    {
                        if (_productSlidersFacad.IsExistProductSliderService.Execute(req.ProductId, slider.SliderId).Data)
                        {
                            _productSlidersFacad.DeleteProductSliderService.Execute(new RequestDeleteProductSliderDto
                            {
                                ProductId = req.ProductId,
                                SliderId = slider.SliderId
                            });
                        }
                    }
                }
            }
            res.IsSuccess = true;
            res.Message = "اسلایدر های محصول با موفقیت تغییر یافت";
            return Json(res);
        }


        #endregion

    }


}
