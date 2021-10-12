using Store_Application.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Domain.Entities.Statistic
{
    public class SearchKeyInfo : BaseEntity<long>
    {
        public string SearchKey { get; set; }
    }
}
