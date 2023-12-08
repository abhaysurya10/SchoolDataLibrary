using SchoolDataLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolUnitTest
{
    [TestFixture]
    internal class TeacherTests
    {
        [Test]
        public void TestTeacherName()
        {

            Teacher myTeacher = new Teacher();
            myTeacher.Name = "Pallavi";

            string teacherName = myTeacher.Name;

            Assert.AreEqual("Pallavi", teacherName);
        }
        [Test]
        public void TestClassId()
        {

            Teacher myTeacher = new Teacher();
            myTeacher.Id = 1;

            int tecaherId = myTeacher.Id;

            Assert.AreEqual(1, tecaherId);
        }

    }

}
