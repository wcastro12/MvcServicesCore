using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppli.Models;

namespace WebAppli.Bussines
{
    public interface IBookinproces
    {
        void SetTime(Student student, DateTime dateInit, decimal value);
    }
}
