using SelectEnum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectEnum.ViewModel
{
    public class CategoryViewModel
    {
        public string SelectedMaz { get; set; }
        public List<Category> ListCategory { get; set; }
    }
}
