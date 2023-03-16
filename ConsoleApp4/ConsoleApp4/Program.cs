using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Shemoiyvanet Pirveli Ricxvi: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Shemoiyvanet Meore Ricxvi: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Shemoiyvanet Romel Xarisxshic Gindat Ayvana: ");
            int n = Convert.ToInt32(Console.ReadLine());

            MyMethod(a, b, n);
        }

       static void MyMethod(double a, double b, int n)
        {

            List<double> squares = new List<double>();
           
            for (double i = 0; i <= Math.Sqrt(b); i++)
            {

                if (Math.Sqrt(a) <= Math.Pow(i,n) && Math.Pow(i,n) >= Math.Sqrt(b))
                {

                    squares.Add(Math.Pow(i, n)); 

                }
                

            }

            Console.WriteLine($"Am Ricxvebs Shoris Kvadratuli Ricxvebis Raodenobaa : {squares.Count}");

        }
    }
}
