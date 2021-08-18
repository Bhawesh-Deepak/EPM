using EPM.UI.Helper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EPM.UI.Controllers.Product
{
    [CustomAuthenticate]
    public class ProductController : Controller
    {
        private readonly IHostingEnvironment _IhostingEnviroment;
        public ProductController(IHostingEnvironment hostingEnvironment)
        {
            _IhostingEnviroment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View("~/Views/Product/CreateProduct.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(EPM.Core.Master.Product model,
                IFormFile ProductImage)
        {
            var upload = Path.Combine(_IhostingEnviroment.WebRootPath, "ProductImage//");
            using (FileStream fs = new FileStream(Path.Combine(upload, ProductImage.FileName), FileMode.Create))
            {
                await ProductImage.CopyToAsync(fs);
            }

            return Json("");


        }
    }
}
