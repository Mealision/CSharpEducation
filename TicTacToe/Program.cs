namespace TicTacToe
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            char[,] chars = { { '*', '*', '*' }, { '*', '*', '*' }, { '*', '*', '*' } };
            PlaceChar(chars);
        }

        static void DrawField(char[,] chars)
        {
            Console.Clear();
            for (int i = 0; i < chars.GetLength(0); i++)
            {
                for (int j = 0; j < chars.GetLength(1); j++)
                {
                    Console.Write(chars[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void PlaceChar(char[,] chars)
        {
            bool player = true; // true - 1ый игрок(Х) false - 2ой игрок(О)
            for (int i = 0; i < 5; i++) // После написания метода на проверку поменять на while
            {
                if (player)
                {
                    Console.WriteLine("Первый игрок. Введи позицию Х");
                    int str = Convert.ToInt16(Console.ReadLine());
                    int col = Convert.ToInt16(Console.ReadLine());
                    chars[str - 1, col - 1] = 'X';
                    player = false;
                }
                else
                {
                    Console.WriteLine("Второй игрок. Введи позицию O");
                    int str = Convert.ToInt16(Console.ReadLine());
                    int col = Convert.ToInt16(Console.ReadLine());
                    chars[str - 1, col - 1] = 'O';
                    player = true;
                }
                DrawField(chars);
                if (CheckForWin(chars))
                {
                    if (player == false) Console.WriteLine("Первый игрок победил");
                    else Console.WriteLine("Второй игрок победил");
                }
            }
        }

        static bool CheckForWin(char[,] chars) // проверяет ничью и выигрыш
        {
            // победа по горизонатли
            for (int i = 0; i < 3; i++)
            {
                if (chars[i, 1] == chars[i, 2] && chars[i, 2] == chars[i, 3])
                {
                    return true;
                }
            }
            // победа по вертикали
            for (int i = 0; i < 3; i++)
            {
                if (chars[1, i] == chars[2, i] && chars[2, i] == chars[3, i])
                {
                    return true;
                }
            }
            // победа по диагонали
            if ((chars[0, 0] == chars[1, 1] && chars[1, 1] == chars[2, 2])
                || (chars[2, 2] == chars[1, 1] && chars[1, 1] == chars[2, 0])) return true;
            else return false;

        }
    }
}