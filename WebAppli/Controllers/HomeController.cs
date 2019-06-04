using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppli.Models;
using WebAppli.Services;
using Microsoft.AspNetCore.Http;


namespace WebAppli.Controllers
{
    public class HomeController : Controller
    {

        public string SSingletonInstance;
        public string SSingleton;
        public string STransing;
        public string SScode;
        public string SingletonInstance;
        public string Singleton;
        public string Transing;
        public string Scode;
        public HomeController(IsingletonInstanceOperation _SingletonInstanceOperation,
                                ITransingOperation _TransingOperation,
                                IsingletonOperation _SingletonOperation,
                                IScodeOperation _ScodeOperation,
                                OperationServices _OperationServices)
        {
            SSingletonInstance = _OperationServices.SingletonInstanceOperation.OperationId.ToString();
            SSingleton = _OperationServices.SingletonOperation.OperationId.ToString();
            STransing = _OperationServices.TransingOperation.OperationId.ToString();
            SScode = _OperationServices.ScodeOperation.OperationId.ToString();

            SingletonInstance = _SingletonInstanceOperation.OperationId.ToString();
            Singleton = _SingletonOperation.OperationId.ToString();
            Transing = _TransingOperation.OperationId.ToString();
            Scode = _ScodeOperation.OperationId.ToString();

        }
        public IActionResult Index()
        {
            ViewData["SSingletonInstance"] = this.SSingletonInstance;
            ViewData["SSingleton"] = this.SSingleton;
            ViewData["STransing"] = this.STransing;
            ViewData["SScode"] = this.SScode;

            ViewData["SingletonInstance"] = this.SingletonInstance;
            ViewData["Singleton"] =this.Singleton;
            ViewData["Transing"] = this.Transing;
            ViewData["Scode"] = this.Scode;

            //session
            HttpContext.Session.SetInt32("Key",1);

            return View();
        }

        public IActionResult About()
        {

            ViewBag.hello = HttpContext.Session.Get("Key");
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
