using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Application.Common.Security
{
    public static class ImageChecker
    {
        public static bool IsImage(this Stream file)
        {
            try
            {
                var img = System.Drawing.Image.FromStream(file);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
