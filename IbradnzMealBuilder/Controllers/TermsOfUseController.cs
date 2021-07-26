using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IbradnzMealBuilder.Controllers
{
    public class TermsOfUseController : Controller
    {
        public IActionResult Index()
        {
            return View();  
        }

        public FileResult GetTermOfUse()
        {
            var path = "wwwroot/termofuse.pdf";
            var fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            return File(fileStream, "application/pdf");
        }
    }
}
