using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculations;
using System.Threading.Tasks;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcul calculation = new Calcul();

            Console.WriteLine("Hello! This app can help you solve a quadratic equation");
            Console.WriteLine("Plese, put Enter from start");

            while (Console.ReadLine() != "exit")
            {
                Console.WriteLine("Write a");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Write b");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Write c");
                double c = Convert.ToDouble(Console.ReadLine());
                calculation.printRoots(a, b, c);
                Console.WriteLine("If you want close console put enter and write exit");
                Console.ReadKey();
                Console.Clear();
            }
                      
        }

        
    }

}
