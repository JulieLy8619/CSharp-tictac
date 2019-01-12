using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

        /// <summary>
        /// Prints the board to the screen
        /// </summary>
		public void DisplayBoard()
		{

            //TODO: Output the board to the console
            // I know it is a 3x3 board and will change it to .Lengths if we have to have a dynamically size changing board
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //Console.Write($"|{j + (i * 3)}|");
                    //Console.WriteLine(Board.GameBoard[i][j]);
                    //Console.WriteLine(GameBoard);
                    Console.Write("|");
                    System.Console.Write(GameBoard[i, j]);
                    Console.Write("|");
                }
                Console.WriteLine();
            }
            Console.WriteLine(); // because I like space

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine(GameBoard[3, 3]);
            //    }
            //}
            //Console.WriteLine(); // because I like space
        }
    }
}
