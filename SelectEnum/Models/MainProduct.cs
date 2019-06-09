using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SelectEnum.Models
{
    public class MainProduct
    {
        [Key]
        public int MainProductID { get; set; }

        public string Name { get; set; }

        public int SubCategoryID { get; set; }
    }
}
