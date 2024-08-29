using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();
            students.AddStudent(new Student("Arsen", 20, 85));
            students.AddStudent(new Student("Artur", 22, 92));
            students.AddStudent(new Student("Mane", 19, 95));
            students.AddStudent(new Student("Mariam", 21, 88));
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
            }
        }
    }
}
