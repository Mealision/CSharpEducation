namespace PracticeTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int j = 0;
            while (true)
            {
                j++;
                Console.WriteLine(j);
                if (j == 10) break;
            }

            int l = 0;
            do
            {
                l++;
                Console.WriteLine(l);
            }
            while (l < 5);

            string str = "";
            for (int i = 0; i < 5; i++)
            {
                str += Console.ReadLine() + " ";
            }
            Console.WriteLine(str);

            int k = 0;
            string SecondString = "";
            while (k < 3)
            {
                SecondString += Console.ReadLine() + " ";
                k++;
            }
            Console.Write(SecondString);

            int g = 0;
            string ThirdString = "";
            do
            {
                g++;
                ThirdString += Console.ReadLine() + " ";
            }
            while (g < 3);
            Console.WriteLine(ThirdString);

        }
    }
}