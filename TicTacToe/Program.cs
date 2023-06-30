namespace TicTacToe
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            char[,] chars = { { '*', '*', '*' }, { '*', '*', '*' }, { '*', '*', '*' } };
            DrawField(chars);
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
            while(!CheckForWin(chars) && !CheckForTie(chars)) // После написания метода на проверку поменять на while
            {
                if (player)
                {
                    Console.WriteLine("Первый игрок. Введи позицию Х");
                    int str = Convert.ToInt16(Console.ReadLine());
                    int col = Convert.ToInt16(Console.ReadLine());
                    if (str > 3 || col > 3)
                    {
                        Console.WriteLine("Введите число не больше 3");
                    }
                    else
                    {
                        if (chars[str - 1, col - 1] == '*')
                        {
                            chars[str - 1, col - 1] = 'X';
                            player = false;
                            DrawField(chars);

                        }
                        else Console.WriteLine("Эта позиция уже занята. Введите новую");
                    }
                }
                else
                {
                    Console.WriteLine("Второй игрок. Введи позицию O");
                    int str = Convert.ToInt16(Console.ReadLine());
                    int col = Convert.ToInt16(Console.ReadLine());
                    if (chars[str - 1, col - 1] == '*')
                    {
                        chars[str - 1, col - 1] = 'O';
                        player = true;
                        DrawField(chars);   

                    }
                    else Console.WriteLine("Эта позиция уже занята. Введите новую");
                }
                //DrawField(chars);
                
                if (CheckForWin(chars))
                {
                    if (player == false) Console.WriteLine("Первый игрок победил");
                    else  Console.WriteLine("Второй игрок победил");
                }
                
            }
            if (CheckForTie(chars))
            {
                Console.WriteLine("Ничья");
            }
        }

        static bool CheckForWin(char[,] chars) // проверяет ничью и выигрыш
        {
            // победа по горизонатли
            for (int i = 0; i < 3; i++)
            {
                if (chars[i, 0] == chars[i, 1] && chars[i, 1] == chars[i, 2] && chars[i, 0] != '*')
                {
                    return true;
                }
            }
            // победа по вертикали
            for (int i = 0; i < 3; i++)
            {
                if (chars[0, i] == chars[1, i] && chars[1, i] == chars[2, i] && chars[0, i] != '*')
                {
                    return true;
                }
            }
            // победа по диагонали
            if ((chars[0, 0] == chars[1, 1] && chars[1, 1] == chars[2, 2] && chars[1,1] != '*')
                || (chars[0, 2] == chars[1, 1] && chars[1, 1] == chars[2, 0]) && chars[0,2] != '*') return true;
            else return false;
        }

        static bool CheckForTie(char[,] chars)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (chars[i, j] == '*')
                    {
                        return false; 
                    }
                }
            }
            return true; 
        }
    }
}