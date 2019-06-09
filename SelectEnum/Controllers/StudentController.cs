using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SelectEnum.Models;

namespace SelectEnum.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var list = new List<SelectListItem>();
            list.Add(new SelectListItem()
            {
                Text = "select values",
                Value = ""
            });

            foreach (var item in Enum.GetValues(typeof(Branch)))
            {
                list.Add(new SelectListItem() { Text = Enum.GetName(typeof(Branch),item), Value = item.ToString() });
            }
            ViewBag.select = list;
            return View();
        }
    }
}