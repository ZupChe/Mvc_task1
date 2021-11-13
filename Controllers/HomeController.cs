using Microsoft.AspNetCore.Mvc;
using Mvc_task1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Localization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace Mvc_task1.Controllers
{
    public class HomeController : Controller
    {
        public IStringLocalizer<Resource> localizer;
        private readonly IHostingEnvironment _env;

        public HomeController(IHostingEnvironment env,IStringLocalizer<Resource> localizer)
        {
            _env = env;
            this.localizer = localizer;
        }

        public IActionResult SetCulture(string culture, string sourceUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName, 
                CookieRequestCultureProvider.MakeCookieValue(
                    new RequestCulture(culture)
                    ),
                new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddYears(1)
                }
                );

            return Redirect(sourceUrl);
        }

        //GET : Home
        public IActionResult Index()
        {
           return View();
        }

        public IActionResult ONama()
        {
            return View();
        }

        public IActionResult Kontakt()
        {
            return View();
        }

        public IActionResult AddOglas()
        {
            return View("Dodaj");
        }

       
        public IActionResult Update(int Id)
        {
            Automobil model = Oglasavanje.GetAutomobil(Id);
            return View("Dodaj", model);
        }

         [Route("~/home/detail/{Id}")]
        public IActionResult Detail(int Id)
        {
            Automobil model = Oglasavanje.GetAutomobil(Id);
            return View("Detalji", model);
        }
        [Authorize]
        [Route("~/home/delete/{Id}")]
        public IActionResult Delete(int Id)
        {
            Automobil model = Oglasavanje.DeleteAutomobil(Id);
            TempData["Obrisano"] = model.Marka + " " + model.Model;
            return RedirectToAction("Index", "home");
        }


        
        [HttpPost]
        public IActionResult Index(Automobil automobil)
        {
            
             
            
            if (ModelState.IsValid)
            {
                foreach (var file in Request.Form.Files)
                {
                    if (file.Length > 0)
                    {
                        var filePath = Path.Combine(_env.ContentRootPath, "wwwroot\\images\\", file.FileName);
                        using (var outputStream = new FileStream(filePath, FileMode.Create))
                        {
                            file.CopyTo(outputStream);
                            automobil.Foto = Path.Combine("~/images/", file.FileName);
                        }

                    }
                }

                Oglasavanje.AddOglas(automobil);
                TempData["Marka"] = automobil.Marka + " " + automobil.Model;
                return RedirectToAction("Index");
            }
            else 
            {
                return View(); 
            }
          

            
        }

        [HttpPost]
        public IActionResult Update(Automobil automobil)
        {
            if (ModelState.IsValid)
            {
                if (Request.Form.Files.Count > 0)
                {
                    foreach (var file in Request.Form.Files)
                    {
                        if (file.Length > 0)
                        {
                            var filePath = Path.Combine(_env.ContentRootPath, "wwwroot\\images\\", file.FileName);
                            using (var outputStream = new FileStream(filePath, FileMode.Create))
                            {
                                file.CopyTo(outputStream);
                                automobil.Foto = Path.Combine("~/images/", file.FileName);
                            }
                        }
                    }
                }

                
                Oglasavanje.UpdateOglas(automobil, automobil.Id);
                TempData["Izmena"] = automobil.Marka + " " + automobil.Model;
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }
    }


}
