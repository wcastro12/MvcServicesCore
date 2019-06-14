using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SelectEnum.Models;
using SelectEnum.ViewModel;

namespace SelectEnum.Controllers
{
    public class CatController : Controller
    {
        public IActionResult Index()
        {
            List<Category> lc = new List<Category>();
            lc.Add(new Category() { CategoryID = 1, Name = "N" });
            lc.Add(new Category() { CategoryID = 2, Name = "N" });
            lc.Add(new Category() { CategoryID = 3, Name = "N" });
            lc.Add(new Category() { CategoryID = 4, Name = "N" });

            CategoryViewModel cvm = new CategoryViewModel();
            cvm.ListCategory = lc;
            cvm.SelectedMaz = string.Empty;
            return View(cvm);
        }
    }
}