using System;
namespace LB9_4
{
    class Trapezium
    {
        public void Calc(double a, double b, int n)
        {
            double h, x1, x2, res, sum = 0;
            h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                x1 = a + i * h;
                x2 = a + (i + 1) * h;
                sum += (Math.Exp(Math.Sin(x1)) + Math.Exp(Math.Sin(x2)));
            }
            res = sum * h / 2;
            Console.WriteLine($"Вiдповiдь: {Math.Round(res, 3)}");
        }
        public void Input(double a, double b, int n)
        {
            Console.WriteLine($"Введенi значення: [{a}, {b}, {n}]");
        }
    }
    public delegate void Fun(double a, double b, int n);
    class Program
    {
        static void Main(string[] args)
        {
            Trapezium t = new Trapezium();
            Fun f = new Fun(t.Input);
            f += new Fun(t.Calc);
            f(2, 5, 5);
        }
    }
}
