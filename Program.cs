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
            Console.WriteLine("Write a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write c");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.ReadKey();
        }

        public double getD(double a, double b, double c)
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            return D;
        }

        public static void getRoots(double a, double b, double c, out double x1, out double x2)
        {
            x1 = (-b + Math.Sqrt(getD(a, b, c))) / (2 * a);
            x2 = (-b - Math.Sqrt(getD(a, b, c))) / (2 * a);
        }
    }
}
