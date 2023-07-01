namespace PracticeTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Что нам известно?");
            Console.WriteLine("1. Два катета");
            Console.WriteLine("2. Гипотенуза и катет");
            var key = Console.ReadKey();
            Console.WriteLine("Введите их значения");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (key.KeyChar == '2')
            {
                int c = a * a + b * b;
                Console.WriteLine($"Третья сторона равна {Math.Sqrt(c)}");
            }
            else
            {
                int c = a * a - b * b;
                Console.WriteLine($"Третья сторона равна {c}");

            }

        }
    }
}