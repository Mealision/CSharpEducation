namespace PracticeTask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = Convert.ToInt32(Console.ReadLine());
            string symbol = Console.ReadLine();
            int i = 0;
            string space = "", star = "";
            while (i < height)
            {
                space = "";
                star = "";
                for (int j  = 0; j < height - i; j++) { space += " "; }
                for (int j = 0; j < 2 * i + 1; j++) { star += symbol; }
                Console.WriteLine(space + star);
                i++;
            }
        }
    }
}