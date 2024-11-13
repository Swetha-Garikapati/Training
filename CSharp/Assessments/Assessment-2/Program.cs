using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    public abstract class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }
        public abstract bool IsPassed(double grade);
    }
    public class Undergraduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 70;
        }
    }
    public class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 80;
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the student type (Undergraduate/Graduate)");
            string studentType = Console.ReadLine();
            Console.WriteLine("Enter the student's name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the student's ID");
            int studentId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student's grade");
            double grade = double.Parse(Console.ReadLine());
            Student student;
            if (studentType.ToLower()=="undergraduate")
            {
                student = new Undergraduate { Name = name, StudentId = studentId, Grade = grade };
            }
            else if (studentType.ToLower()=="graduate")
            {
                student = new Graduate { Name = name, StudentId = studentId, Grade = grade };
            }
            else
            {
                Console.WriteLine("Invalid student type entered");
                return;
            }
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Name:{student.Name}");
            Console.WriteLine($"Student ID:{student.StudentId}");
            Console.WriteLine($"Grade:{student.Grade}");
            if (student.IsPassed(grade))
            {
                Console.WriteLine("Status:Passed");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Status:Failed");
                Console.Read();
            }
        }
    }
}
