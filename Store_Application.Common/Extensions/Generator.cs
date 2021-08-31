using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Common.Extentions
{
    public static class Generator
    {
        public static string GetImageName()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }
    }
}
