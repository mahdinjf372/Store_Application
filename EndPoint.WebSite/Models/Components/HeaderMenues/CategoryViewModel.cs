using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Models.Components.HeaderMenues
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }

        public int? ParentCategoryId { get; set; }
        public CategoryViewModel ParentCategory { get; set; }

    }
}
