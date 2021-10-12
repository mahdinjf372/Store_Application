using Store_Application.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Domain.Entities.Statistic
{
    public class SiteRequest : BaseEntity<long>
    {
        public string Ip { get; set; }
        public bool HasFormContentType { get; set; }
        public bool HasJsonContentType { get; set; }
        public bool IsHttps { get; set; }
        public string Methode { get; set; }
        public string Path { get; set; }
        public bool IsAuthenticated { get; set; }
        public int? UserId { get; set; }
        public Guid? BrowserId { get; set; }
    }
}
