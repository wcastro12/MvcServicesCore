using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SelectEnum.Models;

namespace SelectEnum.Controllers
{
    public class DemoController : Controller
    {
        public readonly DataBaseContext Context;
        public DemoController(DataBaseContext _Context)
        {
            this.Context = _Context;

        }
        public IActionResult Index()
        {
            List<Category> Clist = new List<Category>();

            Clist = (from category in this.Context.Categorys
                     select category).ToList();


            Clist.Insert(0, new Category() { CategoryID = 0, Name = "Select" });

            ViewBag.ListC = Clist;
            return View();
        }

        public JsonResult GetSubCategory(int IdCategory)
        {
            List<SubCategory> Lsubcategory = new List<SubCategory>();
            Lsubcategory = (from subcategory in this.Context.SubCategorys
                            where subcategory.CategoryID == IdCategory
                            select subcategory).ToList();

            Lsubcategory.Insert(0, new SubCategory() { SubCategoryID = 0, Name = "Select" });

            return Json(new SelectList(Lsubcategory, "SubCategoryID", "Name"));

        }

        public JsonResult GetPorducts(int IdSubCategory)
        {
            List<MainProduct> Lsubproduct = new List<MainProduct>();
            Lsubproduct = (from products in this.Context.MainProducts
                            where products.SubCategoryID == IdSubCategory
                            select products).ToList();

            Lsubproduct.Insert(0, new MainProduct() { MainProductID = 0, Name = "Select" });

            return Json(new SelectList(Lsubproduct, "MainProductID", "Name"));

        }
    }
}