//Navid-Derakhshandeh
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hookes_Law_in_Spring_of_Automotive_Suspension
{
    class calculation
    {
        public calculation()
        {
            Console.WriteLine("Please Enter Diameter : ");
            double D = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter G of Spring : ");
            double G = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Number of Spring laps : ");
            double N = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Radius : ");
            double R = Double.Parse(Console.ReadLine());

            double x = (Math.Pow(D, 4)) * (G * Math.Pow(10, 11));
            double y = (64 * N) * (R * Math.Pow(10, 2));
            double K = x / y;

            Console.WriteLine("K Equal by : {0}.", K);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose your Formula : ");
            Console.WriteLine("1.Hookes Law in Spring of Automotive Suspension : ");
            Console.WriteLine("2.Test : ");
            int c = Int32.Parse(Console.ReadLine());

            do
            {
                switch (c)
                {
                    case 1:
                        calculation calc;
                        calc = new calculation();
                        break;
                    case 2:
                        Console.WriteLine("It's Test");
                        break;
                    default:
                        Console.WriteLine("End");
                        break;
                }
            }
            while
            ((c != 1) && (c != 2));

            Console.Read();
        }
    }
}
