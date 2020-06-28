using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is an array. (char = character. table = array. Prividing 1 to 9 and 0 is not used.)
            // tutorial form: https://www.c-sharpcorner.com/UploadFile/75a48f/tic-tac-toe-game-in-C-Sharp/
            char[] table = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            // Users guide board position.
            Console.WriteLine("Game Board Positions:");
            Console.WriteLine("-------------");
            Console.WriteLine("| 1 | 2 | 3 |");
            Console.WriteLine("-------------");
            Console.WriteLine("| 4 | 5 | 6 |");
            Console.WriteLine("-------------");
            Console.WriteLine("| 7 | 8 | 9 |");
            Console.WriteLine("-------------");
            Console.WriteLine("Game Board Status:");
            
            // Print table.
            // Citation from: https://www.youtube.com/watch?v=STuWW6pksXs
            Board(table);

            // Guide the user.
            Console.WriteLine("Player x, please enter a square number to place your token in:");

            
            // User input.
            //string userInput = Console.ReadLine();

            //Console.Clear();
            //while( ( userInput = Console.ReadLine() )  != "x" )
            //{
               // int result;
               // if ( userInput == "x" )
            //}
        }

        // Method to draw a functional board game table.  
        // Tutorial from: https://www.c-sharpcorner.com/UploadFile/75a48f/tic-tac-toe-game-in-C-Sharp/
        static void Board(char[] table)
        {
            Console.WriteLine("-------------");
            Console.WriteLine("|   |   |   |", table[1], table[2], table[3]);
            Console.WriteLine("-------------");
            Console.WriteLine("|   |   |   |", table[4], table[5], table[6]);
            Console.WriteLine("-------------");
            Console.WriteLine("|   |   |   |", table[7], table[8], table[9]);
            Console.WriteLine("-------------");
        }
    }
}
