using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppli.Models;

namespace WebAppli.Models
{
    public class AplicationContext:DbContext
    {

        public AplicationContext(DbContextOptions<AplicationContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }


    }
}
