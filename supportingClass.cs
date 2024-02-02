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
        // board to initialize empty game board.
        public void InitializeBoard(char[] gameboard)
        {
            for (int i = 0; i < 9; i++)
            {
                gameboard[i] = '\0'; // Initialize board with empty cells
            }
        }

        // print board method
        public void PrintBoard(char[] gameboard)
        {
            Console.WriteLine($" {gameboard[0]} | {gameboard[1]} | {gameboard[2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {gameboard[3]} | {gameboard[4]} | {gameboard[5]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {gameboard[6]} | {gameboard[7]} | {gameboard[8]} ");
        }

        //method to check for winners
        public bool CheckWinner(int player, char[] gameboard)
        {
            // Check rows, columns, and diagonals for a win
            bool isWinner =
                   (gameboard[0] == player && gameboard[1] == player && gameboard[2] == player) ||
                   (gameboard[3] == player && gameboard[4] == player && gameboard[5] == player) ||
                   (gameboard[6] == player && gameboard[7] == player && gameboard[8] == player) ||
                   (gameboard[0] == player && gameboard[3] == player && gameboard[6] == player) ||
                   (gameboard[1] == player && gameboard[4] == player && gameboard[7] == player) ||
                   (gameboard[2] == player && gameboard[5] == player && gameboard[8] == player) ||
                   (gameboard[0] == player && gameboard[4] == player && gameboard[8] == player) ||
                   (gameboard[2] == player && gameboard[4] == player && gameboard[6] == player);

            return isWinner;
        }

        // method to check if the board is full for tie
        public bool BoardIsFull(char[] gameboard)
        {
            bool isBoardFull = true;
            foreach (char cell in gameboard)
            {
                if (cell == '\0')
                {
                    isBoardFull = false;
                    break;
                }
            }

            return isBoardFull;
        }

    }

}