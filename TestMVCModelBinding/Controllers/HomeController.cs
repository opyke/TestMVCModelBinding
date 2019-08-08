using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestMVCModelBinding.Models;

namespace TestMVCModelBinding.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Payment
            {
                ClientCode = "1234",
                Name = "opyke@hotmail.com",
                Cards = new List<Card>
                                {
                                    new Card {Id = Guid.NewGuid(), Number = "1234-5678-1234-5678"},
                                    new Card {Id = Guid.NewGuid(), Number= "1234-5678-1234-5678"}
                                }
            };

            return View(model);
        }

        public IActionResult NextPage(Payment model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            return BadRequest();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}