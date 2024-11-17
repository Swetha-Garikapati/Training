using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Emp
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public double EmpSalary { get; set; }
    }
     class Program3

        {


            static void Main()

            {

                Console.WriteLine("Enter List length:");

                int length = Convert.ToInt32(Console.ReadLine());

                List<Emp> emplist = new List<Emp> { };

                for (int i = 0; i < length; i++)

                {

                    Console.WriteLine("Enter Employee ID:");

                    int Employee_ID = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Employee Name:");

                    string Employee_Name = Console.ReadLine();

                    Console.WriteLine("Enter Employee City:");

                    string Employee_City = Console.ReadLine();

                    Console.WriteLine("Enter Employee Salary:");
                
                    double Employee_Salary = Convert.ToDouble(Console.ReadLine());

                    emplist.Add(new Emp
                    {
                        EmpId = Employee_ID,

                        EmpName = Employee_Name,

                        EmpCity = Employee_City,

                        EmpSalary = Employee_Salary
                    });

                }

                Console.WriteLine("-----Details of All employees--------");

                foreach (var All in emplist)

                {

                    Console.WriteLine("Employee ID:{0} Name: {1} City:{2} Salary:{3} ", All.EmpId, All.EmpName, All.EmpCity, All.EmpSalary);

                }

                Console.WriteLine("----- Employees whose salary is greater than 45000--------");

                foreach (var emp in emplist)

                {

                    if (emp.EmpSalary > 45000)

                        Console.WriteLine(emp.EmpName);

                }

                Console.WriteLine("----- Employees data who belong to Bangalore Region are--------");

                foreach (var emp in emplist)

                {

                    if (emp.EmpCity == "bengalore")

                        Console.WriteLine(emp.EmpName + "from" + emp.EmpCity);

                }

                IEnumerable<Emp> Sortedlist = emplist.OrderBy(n => n.EmpName);

                Console.WriteLine("----- Employees data by their names is Ascending order -------");

                foreach (var emp in Sortedlist)

                {

                    Console.WriteLine(emp.EmpName);

                }

                Console.ReadLine();

            }

        }

 }
