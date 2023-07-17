namespace PracticeTask10
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("В какой регистр перевести\n 1. В верхний\n 2. В нижний\n 3. Первая буква большая");
			int ch = Convert.ToInt32(Console.ReadLine());
			switch (ch)
			{
				case 1:
					string str = Console.ReadLine();
					Console.WriteLine(str.ToUpper());
					break;
				case 2:
					str = Console.ReadLine();
					Console.WriteLine(str.ToLower());
					break;
				case 3:
					str = UpperFirstChar(Console.ReadLine());
					Console.WriteLine(str);
					break;
				default:
					Console.WriteLine("веедите число от 1 до 4");
					break;
			}
		}

        public static string UpperFirstChar(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            char[] chars = input.ToCharArray();
            chars[0] = char.ToUpper(chars[0]);
            return new string(chars);
        }
    }
}