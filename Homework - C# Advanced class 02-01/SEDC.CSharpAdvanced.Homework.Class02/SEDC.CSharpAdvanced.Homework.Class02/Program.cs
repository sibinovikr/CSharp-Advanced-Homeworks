using SEDC.CSharpAdvanced.Homework.Class02.Classes;
using System;

namespace SEDC.CSharpAdvanced.Homework.Class02
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1, "Anna", "anaa01", "a@12345", 9);
            Student student2 = new Student(2, "Eva", "evva94", "a@12345", 8);
            Teacher teacher1 = new Teacher(3, "Alison", "ali123", "a@12345", "C#");
            Teacher teacher2 = new Teacher(4, "Joe", "joe92", "a@12345", "Java");
            student1.PrintUser();
            student2.PrintUser();
            teacher1.PrintUser();
            teacher2.PrintUser();

            Console.ReadLine();
        }
    }
}
