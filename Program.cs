using supportingClass;
// Group 1-13
// Landon Webb, Zach Hansen, Kelsey Corfield, Ian Purnell
// Tic tac toe game program
class Program
{
    static void Main()
    {
        SupportingClass sC = new SupportingClass();
        // Player 1 is X and Player 2 is O
        int player = 1;

        // Welcome the user to the game
        Console.WriteLine("Welcome to the world-famous TIC TAC TOE CHAMPIONSHIP!!!!!!!");

        // Generating the game board with some nice suspense
        Console.Write("Generating the game board");
        Thread.Sleep(400);
        Console.Write(".");
        Thread.Sleep(400);
        Console.Write(".");
        Thread.Sleep(400);
        Console.Write(".\n");

        // Make the gameboard array
        char[] gameboard = new char[9];
        sC.InitializeBoard(gameboard);

        // Take the player's guess
        //for (int i = 0; i < gameboard.Length; i++)
        while (true)
        {
            Console.WriteLine($"Player {player},Please choose a number between 1 and 9 to make your move!");

            // Convert user input to integer
            int position;
            while (!int.TryParse(Console.ReadLine(), out position) || position < 1 || position > 9 || gameboard[position - 1] != '\0')
            {
                Console.WriteLine("Invalid move! Try again.");
            }

            // Set the corresponding symbol based on the player
            gameboard[position - 1] = (player == 1) ? 'X' : 'O';

            // display the board.
            sC.PrintBoard(gameboard);

            // check for winner or for a tie.
            if (sC.CheckWinner((player == 1) ? 'X' : 'O', gameboard))
            {
                Console.WriteLine($"Player {player} wins!");
                break; // Exit the game loop if a player wins
            }
            else if (sC.BoardIsFull(gameboard))
            {
                Console.WriteLine("It's a tie!");
                break;
            }

            // change player
            player = (player == 1) ? 2 : 1;
            
        }
        // Call the winners method

       
    }

}





