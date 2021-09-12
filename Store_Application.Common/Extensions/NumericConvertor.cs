using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Common.Extentions
{
    public static class NumericConvertor
    {
        public static string FixedToView(this decimal input)
        {
            return input.ToString("N0");
        }

        public static string FixedToView(this decimal? input)
        {
            if (input==null)
            {
                return "";
            }
            return input?.ToString("N0");
        }
    }
}
