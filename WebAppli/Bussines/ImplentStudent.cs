using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppli.Models;

namespace WebAppli.Bussines
{
    public class ImplentStudent : IBookinproces
    {
        public void SetTime(Student student, DateTime dateInit, decimal value)
        {
            if (value > 0)
            {
                student.Name = "AAA";
            }
            else
            {
                student.Name = "BBB";
            }
        }
    }
}
