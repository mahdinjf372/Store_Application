using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Models.Category.LoadSubCategories
{
    public class SubCategoryViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public bool isRemoved { get; set; }

        public int? ParentCategoryId { get; set; }
        public SubCategoryViewModel ParentCategory { get; set; }
       // public Domain.Entities.Product.Category ParentCategory { get; set; }

    }
}
