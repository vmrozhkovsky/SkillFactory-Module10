namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();
            ICalc calc = new Calc(logger);
            double a;
            double b;
            double c;
            calc.ReadUserNumbers(out a, out b);
            c = calc.Sum(a, b);
            logger.Event($"Сумма введенных чисел: {c.ToString()}");
        }
    }
}