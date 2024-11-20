using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public Box(double length,double breadth)
        {
            Length = length;
            Breadth = breadth;
        }
        public static Box AddBoxes(Box box1,Box box2)
        {
            double newLength = box1.Length + box2.Length;
            double newBreadth = box1.Breadth + box2.Breadth;
            return new Box(newLength, newBreadth);
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Length:{Length},Breadth:{Breadth}");
        }
    }
    class Test
    {
        public static void Main()
        {
            Console.WriteLine("Enter box1 details");
            double length1 = Convert.ToDouble(Console.ReadLine());
            double breadth1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter box2 details");
            double length2 = Convert.ToDouble(Console.ReadLine());
            double breadth2 = Convert.ToDouble(Console.ReadLine());
            Box box1 = new Box(length1, breadth1);
            Box box2 = new Box(length2, breadth2);
            Box box3 = Box.AddBoxes(box1, box2);
            Console.WriteLine("Displaying the details of third box");
            box3.DisplayDetails();
            Console.Read();
        }
    }
}
