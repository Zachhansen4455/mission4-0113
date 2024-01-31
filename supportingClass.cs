using System;

namespace TicTacToe
{
    public class SupportingClass
    {
        // print board method
        public void PrintBoard(char[,] board)
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.Write(board[x, y] == '\0' ? "  " : $"{board[x, y]} ");
                    if (y < 2) Console.Write("|");
                }
                Console.WriteLine();
                if (x < 2) Console.WriteLine("-----");
            }
        }
        
    }
}
