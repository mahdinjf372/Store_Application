using Store_Application.Domain.Entities.Common;
using Store_Application.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Domain.Entities.Site
{
    public class Advertising : BaseEntity
    {
        public string Title { get; set; }

        public string ImageName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Description { get; set; }

        public string LinkTo { get; set; }

        public AdvertisingPlaces Place { get; set; }
    }
}
