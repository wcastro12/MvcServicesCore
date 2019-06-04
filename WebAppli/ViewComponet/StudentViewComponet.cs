using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppli.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppli.Data;

namespace WebAppli.ViewComponet
{
    public class StudentViewComponent: ViewComponent
    {
        public IDataRepository _Context;
        public StudentViewComponent(IDataRepository Context)
        {
            this._Context = Context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _Context.getStudents());
        }
    }
}
