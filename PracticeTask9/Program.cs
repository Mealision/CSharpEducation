namespace PracticeTask9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char ch = Convert.ToChar(Console.ReadLine());
            int count = str.Count(f => f == ch);
            Console.WriteLine(count);

        }
    }
}