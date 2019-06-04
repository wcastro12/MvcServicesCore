using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppli.Models;

namespace WebAppli.Data
{
    public interface IDataRepository
    {
        Task<List<Student>> getStudents();

        Task<List<Course>> getCourses();
    }
}
