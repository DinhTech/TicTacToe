using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - load the game board - use 2d array. pass 2 variables char = player, int = square. passing x or 0
            // 2 - prompt the player 1 - player gives int
            // 3 - check is there a line form - form line to see if its a winner.
            // 4 - reload the board - if no winner reload the board with the selection x or o.
            // 5 - prompt the player 2 - whatever is player 2.
            // 6 - repeat #2
            // 7 - repeat #1
            
            // Requirements:
            // Player 1
            // Player 2
            // Winner/Draw state
            // Clear player's turn
            // Current board status (Square taken)
            // Prompt for a square number must indicate the current player
            // Error message if player makes invalid input; player must be prompted again
            // Game board data must be stored in a two-dimensional array of characters
            // Game end prompt player to play again y/n
            // Main() method, a PlayGame() method, and a PrintGameBoard() method
            // maintainable as well as functional
            // Not crash due to an unhandled exception

            // Citation from tutorial: https://www.c-sharpcorner.com/UploadFile/75a48f/tic-tac-toe-game-in-C-Sharp/
            // This is an array. (char = character. table = array. Providing numbers 1 to 9 but 0 is not used.)
            char[] table = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int player = 1; // Set player.

            // Users guide board position instruction.
            Console.WriteLine("Game Board Positions:");
            Console.WriteLine("-------------");
            Console.WriteLine("| 1 | 2 | 3 |");
            Console.WriteLine("-------------");
            Console.WriteLine("| 4 | 5 | 6 |");
            Console.WriteLine("-------------");
            Console.WriteLine("| 7 | 8 | 9 |");
            Console.WriteLine("-------------");
            Console.WriteLine("Game Board Status:");
            
            // Print board table function in main method.
            // Citation from tutorial: https://www.youtube.com/watch?v=STuWW6pksXs
            Board(table);

            // Citation from tutorial: https://www.c-sharpcorner.com/UploadFile/75a48f/tic-tac-toe-game-in-C-Sharp/
            // Player's condition to have a Value 1, or, else 2.
            if (player % 2 == 0) // checking the turn of the player  
            {
                Console.WriteLine("Player 2's turn!");
            }
            else
            {
                Console.WriteLine("Player 1's turn!");
            }

            // User input.
            //string userInput = Console.ReadLine();

            //Console.Clear();

            // Guide for the user.
            Console.WriteLine( "Please enter a number choice 1 to 9 to place your token in a square.\nPlease type exit to end game at anytime.");
            string userInput; // Declare a variable.
            // Accept commands.
            while( ( userInput = Console.ReadLine() )  != "exit" )
            {
                //int result;
                if ( userInput == "1" )
                {
                    
                }
                else
                {
                    Console.WriteLine( "Invalid command, please try again.");
                }
                // Guide for the user.
                Console.WriteLine( "Please enter a number choice 1 to 9 to place your token in a square.\nPlease type exit to end game at anytime.");
            }
        }

        // Citation from tutorial: https://www.c-sharpcorner.com/UploadFile/75a48f/tic-tac-toe-game-in-C-Sharp/
        // Method to draw a functional board game table. 
        // Ex: table[1], table[2], table[3]); are borrowed from that tutorial.
        static void Board(char[] table)
        {
            Console.WriteLine("-------------");
            Console.WriteLine("|   |   |   |", table[1], table[2], table[3]);
            Console.WriteLine("-------------");
            Console.WriteLine("|   |   |   |", table[4], table[5], table[6]);
            Console.WriteLine("-------------");
            Console.WriteLine("|   |   |   |", table[7], table[8], table[9]);
            Console.WriteLine("-------------");

            Console.WriteLine("Player 1 = X");
            Console.WriteLine("Player 2 = O");
        }

        /*static int player()
        {

        }*/
    }
}
