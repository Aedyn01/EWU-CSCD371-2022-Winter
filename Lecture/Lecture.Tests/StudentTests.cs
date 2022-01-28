namespace Lecture.Tests;

[TestClass]
public class StudentTests
{
    [TestMethod]
    public void Student_AssignGradeA_Success()
    {
        StudentTests student = new("Princess Buttercup");
        student.Grade = Grade.A;
        Assert.AreEqual<Grade>(Grade.A, student.Grade);
    }
}
