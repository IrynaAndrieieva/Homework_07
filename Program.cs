using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese, put Enter from start");
            while (Console.ReadLine() != "exit")
            {
                Console.WriteLine("Write a");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Write b");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Write c");
                double c = Convert.ToDouble(Console.ReadLine());
                printRoots(a, b, c);
                Console.WriteLine("If you want close console put enter and write exit");
                Console.ReadKey();
                Console.Clear();
            }
                      
        }

        public static double getD(double a, double b, double c)
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            return D;
        }

        public static void getRoots(double a, double b, double c, out double x1, out double x2)
        {
            x1 = (-b + Math.Sqrt(getD(a, b, c))) / (2 * a);
            x2 = (-b - Math.Sqrt(getD(a, b, c))) / (2 * a);
        }

        public static void printRoots(double a, double b, double c)
        {
            double x1;
            double x2;
            getRoots(a, b, c, out x1, out x2);


            if (getD(a, b, c) > 0)

            {
                Console.WriteLine("Roots" + x1.ToString() + "\n" + x2.ToString());
            }

            if (getD(a, b, c) == 0)

            {
                Console.WriteLine("Roots x1 = x2 =" + x1.ToString());
            }

            if (getD(a, b, c) < 0)

            {
                Console.WriteLine("No roots");
            }
        }
    }

}
