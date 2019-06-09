using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SelectEnum.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryID { get; set; }

        public string Name { get; set; }

        public int CategoryID { get; set; }

    }
}
