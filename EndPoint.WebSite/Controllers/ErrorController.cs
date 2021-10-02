using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Controllers
{
    public class ErrorController : Controller
    {
        [Route("NotFound")]
        public IActionResult NotFound()
        {
            return View();
        }
    }
}
