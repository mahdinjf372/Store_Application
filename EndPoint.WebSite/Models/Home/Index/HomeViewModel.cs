using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Models.Home.Index
{
    public class HomeViewModel
    {
        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }

    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? ParentId { get; set; }
        public CategoryViewModel Parent { get; set; }
        public List<CategoryViewModel> SubCategories { get; set; }
    }
}
