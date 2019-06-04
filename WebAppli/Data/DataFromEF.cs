using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppli.Models;

namespace WebAppli.Data
{
    public class DataFromEF : IDataRepository
    {
        public AplicationContext _Context;

        public Task<List<Student>> getStudents()
        {
            return _Context.Students.ToListAsync();
        }

        public Task<List<Course>> getCourses()
        {
            return _Context.Courses.ToListAsync();
        }

   

        public DataFromEF(AplicationContext Context)
        {
            this._Context = Context;
        }
    }
}
