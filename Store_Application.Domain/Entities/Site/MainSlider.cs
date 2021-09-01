using Store_Application.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Domain.Entities.Site
{
    public class MainSlider : BaseEntity
    {
        public string Title { get; set; }

        public string ImageName { get; set; }

        public string LinkTo { get; set; }
  
    }
}
