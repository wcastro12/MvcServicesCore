using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectEnum.Models
{
    public class Student
    {
        public Branch Branch { get; set; }
    }

    public enum Branch {
        CT,ST,MX
    }
}
