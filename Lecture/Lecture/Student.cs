namespace Lecture;

class Student : Person
{
    // This is bad design used for simplicity (don't do this at home)
    Grade Grade { get; set; }
    public Student(string name) : base(name)
    {

    }
}
