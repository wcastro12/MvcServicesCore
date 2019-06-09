using System;
using Xunit;
using WebAppli.Models;
using WebAppli.Bussines;

namespace netCore.UnitTest
{
    public class UnitTestStudent
    {
        [Fact]
        public void MakeStudent()
        {
            //set
            var Student = new Student() { StudentID = 2, Name = "AAA" };
            var Studentb = new Student() { StudentID = 2, Name = "zzz" };
            //aser
            var obj = new ImplentStudent();
            obj.SetTime(Studentb, DateTime.Now, 1);

            Assert.Equal(Student.Name, Studentb.Name);

                }
    }
}
