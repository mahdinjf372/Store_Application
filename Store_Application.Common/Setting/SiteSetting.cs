using System.IO;

namespace Store_Application.Common.Setting
{
    public class SiteSetting
    {
        public static string SiteDomain = "https://localhost:5001";
        public static string ProductImagesPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\ProductImages\\");
    }
}
