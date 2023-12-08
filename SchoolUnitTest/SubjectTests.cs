using SchoolDataLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolUnitTest
{
    internal class SubjectTests
    {
        [Test]
        public void TestSubjectName()
        {
            Subject subject = new Subject();
            subject.Name = "Kannada";
            string subjectName = subject.Name;
            Assert.AreEqual("kannada", subjectName);
        }

        [Test]
        public void TestSubjectId()
        {

            Subject subject = new Subject();
            subject.Id = 5;
            int subjectId = subject.Id;
            Assert.AreEqual(5, subjectId);
        }
    }

}
