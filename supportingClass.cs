using Microsoft.VisualBasic;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Xml.Linq;

namespace supportingClass
{
    // the supporting class (with whichever name you choose) will:
    // Receive the “board” array from the driver class
    // Contain a method that prints the board based on the information passed to it
    // Contain a method that receives the game board array as input and returns if there is a winner and who it was
    public class SupportingClass
    {
        static char[] board = new char[9];

        // print board method
        public void PrintBoard(char[] board)
        {
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
            Console.WriteLine("---|---|---");
        }

        //method to check for winners
        public bool CheckWinner(char player)
        {
            // Check rows, columns, and diagonals for a win
            bool isWinner = 
                   (board[0] == player && board[1] == player && board[2] == player) ||
                   (board[3] == player && board[4] == player && board[5] == player) ||
                   (board[6] == player && board[7] == player && board[8] == player) ||
                   (board[0] == player && board[3] == player && board[6] == player) ||
                   (board[1] == player && board[4] == player && board[7] == player) ||
                   (board[2] == player && board[5] == player && board[8] == player) ||
                   (board[0] == player && board[4] == player && board[8] == player) ||
                   (board[2] == player && board[4] == player && board[6] == player);

            //check for a tie and full board
            bool isBoardFull = true;
            foreach (char cell in board)
            {
                if (cell == '\0')
                {
                    isBoardFull = false;
                    break;
                }
            }

            return isWinner || (isBoardFull && !isWinner);
        }

        //method that sees if board is fu
    }

}