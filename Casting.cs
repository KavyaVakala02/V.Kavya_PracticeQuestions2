using System;

namespace practicequestions2
{
    // Base class Casting
    class Casting
    {  public string Name { get; set; }
        public Casting(string name)
        {
            Name = name;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Casting: {Name}");
        }
    }
    // Derived class Student
    class Student : Casting
    {
        public int StudentID { get; set; }
        public Student(string name, int studentID) : base(name)
        {
            StudentID = studentID;
        }
        public void ShowStudentInfo()
        {
            Console.WriteLine($"Student: {Name}, ID: {StudentID}");
        }
    }
}
