using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SelectEnum.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        public string Name { get; set; }

        [NotMapped]
        public int ProductID { get; set; }
        [NotMapped]
        public int SubProductID { get; set; }
    }
}
