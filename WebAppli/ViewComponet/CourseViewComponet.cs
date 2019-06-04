using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppli.Data;
using WebAppli.Models;

namespace WebAppli.ViewComponet
{

    public class CourseViewComponent : ViewComponent
    {
        IDataRepository _context;
        public CourseViewComponent(IDataRepository Context)
        {
            this._context = Context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await this._context.getCourses());
        }

    }
}
