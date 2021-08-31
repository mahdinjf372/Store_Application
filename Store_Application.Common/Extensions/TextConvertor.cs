using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Common.Extentions
{
    static class TextConvertor
    {
        public static string FixTextInput(this string text)
        {
            return text.Trim().ToLower().Replace(" ", "");
        }
    }
}
