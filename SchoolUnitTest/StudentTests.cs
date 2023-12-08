using SchoolDataLib;

namespace SchoolUnitTest
{
    internal class StudentTests
    {
        [Test]
        public void TestStudentName()
        {

            Student student = new Student();
            student.Name = "Abhay";

            string studentName = student.Name;

            Assert.AreEqual("Abhay", studentName);
        }
        [Test]
        public void TestStudentAddress()
        {
            Student student = new Student();
            student.Address = "Chikkamagaluru";

            string studentAddress = student.Address;
            Assert.AreEqual("Chikkamagaluru", studentAddress);
        }
    }

}