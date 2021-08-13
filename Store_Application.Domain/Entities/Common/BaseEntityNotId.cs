using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Domain.Entities.Common
{
    public abstract class BaseEntityNotId
    {
        public DateTime InsertTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool isRemoved { get; set; } = false;
        public DateTime? RemovedTime { get; set; }
    }
}
