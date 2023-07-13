namespace PracticeTask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введеите значения a, b, f");
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Введите другое число неравное 0");
                a = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("f = ");
            double f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Formula(a, b, f));

            double Formula (double a, double b, double f)
            {
                var result = (a + b - f / a) + f * a * a - (a + b);
                return result;
            }
        }
    }
}