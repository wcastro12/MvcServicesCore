using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SelectEnum.Models;

namespace SelectEnum.Controllers
{
    public class GuestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GuestFrom()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GuestFrom(GuestParty GuestParty)
        {
            return View("Thanks", GuestParty);
        }
    }
}