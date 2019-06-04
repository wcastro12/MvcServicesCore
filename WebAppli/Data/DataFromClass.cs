using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppli.Models;

namespace WebAppli.Data
{
    public class DataFromClass : IDataRepository
    {
        public async Task<List<Course>> getCourses()
        {
            List<Course> listCourse = new List<Course>();

            await Task.Run(() => {
                listCourse.AddRange(new List<Course>()
                                    { new Course() { CourseID=1, Name="Sociales" },
                                      new Course() { CourseID=2, Name="Quimica" }});
            });

            return listCourse;
        }

        public async Task<List<Student>> getStudents()
        {
            List<Student> Liststudent = new List<Student>();

           await Task.Run(() => {

               Liststudent.Add(new Student() { StudentID = 1, Name = "Paola" });
               Liststudent.Add(new Student() { StudentID = 2, Name = "Natalia" });

            });

            return Liststudent;
        }

    }
}
