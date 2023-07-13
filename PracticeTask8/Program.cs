namespace PracticeTask8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine($"{a} больше {b}");
            }
            else if (a == b)
            {
                Console.WriteLine($"{a} равно {b}");

            }
            else
            {
                Console.WriteLine($"{a} меньше {b}");
            }
            
        }
    }
}