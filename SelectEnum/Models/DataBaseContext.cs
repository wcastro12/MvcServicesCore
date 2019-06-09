using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectEnum.Models
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {

        }

        public DbSet<MainProduct> MainProducts { get; set; }
        public DbSet<SubCategory> SubCategorys { get; set; }
        public DbSet<Category> Categorys { get; set; }
    }
}
