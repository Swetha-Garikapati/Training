using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    class CricketTeam
    {
        public void Pointscalculation(int no_of_matches)
        {
            int sum = 0;
            int score;
            for (int i=1; i<=no_of_matches;i++)
            {
                Console.WriteLine($"Enter score of match {i}");
                while (!int.TryParse(Console.ReadLine(), out score) || score < 0)
                {
                    Console.WriteLine("Invalid input");
                }
                sum += score;
            }
            double average = (double)sum / no_of_matches;
            Console.WriteLine($"\nTotal no.of matches:{no_of_matches}");
            Console.WriteLine($"Sum of scores:{sum}");
            Console.WriteLine($"Average:{average}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CricketTeam team = new CricketTeam();
            Console.WriteLine("Enter the no.of matches");
            int no_of_matches;
            while(!int.TryParse(Console.ReadLine(),out no_of_matches)||no_of_matches<=0)
            {
                Console.WriteLine("Invalid input");
            }
            team.Pointscalculation(no_of_matches);
            Console.Read();
        }
    }
}
