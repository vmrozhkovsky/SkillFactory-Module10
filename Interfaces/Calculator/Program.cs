namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalc calc = new Calc();
            double a;
            double b;
            double c;
            calc.ReadUserNumbers(out a, out b);
            c = calc.Sum(a, b);
            Console.WriteLine(c.ToString());
        }
    }
}