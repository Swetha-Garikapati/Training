using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
   public interface IStudent
    {
        int Student_Id { get; set; }
        string Name { get; set; }
        void Show_details();
    }
    class Day_Scholar:IStudent
    {
       public int Student_Id { get; set; }
       public string Name { get; set; }
       public void Show_details()
        {
            Console.WriteLine("Student Id:{0},Student Name:{1}", Student_Id, Name);
        }
    }
    class Resident : IStudent
    {
        public int Student_Id { get; set; }
        public string Name { get; set; }
        public void Show_details()
        {
            Console.WriteLine("Student Id:{0},Student Name:{1}", Student_Id, Name);
        }
    }
    class Interface
    {
        static void Main()
        {
            Console.WriteLine("*****************Day Scholar details******************");
            Console.WriteLine("Enter Student Id");
            int sid1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name");
            string sname1 = Console.ReadLine();
            Console.WriteLine("*****************Resident details******************");
            Console.WriteLine("Enter Student Id");
            int sid2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name");
            string sname2 = Console.ReadLine();
            IStudent d = new Day_Scholar();
            d.Student_Id = sid1;
            d.Name = sname1;
            Console.WriteLine("*****************Display Day Scholar details******************");
            d.Show_details();
            IStudent r = new Resident();
            r.Student_Id = sid2;
            r.Name = sname2;
            Console.WriteLine("*****************Display Resident details******************");
            r.Show_details();
            Console.ReadLine();
        }
    }
}
