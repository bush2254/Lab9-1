using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            double F(double nn)
            {
                double X = 1;
                for (int i=1; i<=nn; i++)
                {
                    X *= i;
                }
                return X;
            }
            double Step (double A,double K)
            {
                double result = 1;
                for(int i=1;i <= K; i++)
                {
                    result *= A;
                }
                return result;
            }
            Console.Write("k=");
            double k = double.Parse(Console.ReadLine());
            Console.Write("t=");
            double t = double.Parse(Console.ReadLine());
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("y=");
            double y = double.Parse(Console.ReadLine());
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            double P = Sqrt(Step(a, k + 2) + Step(b, t - 2)) / (Step(a, k) * x - b) + F(Step(b, t) * y - a); ;
            Console.WriteLine($"P={P}");
        }
    }
}