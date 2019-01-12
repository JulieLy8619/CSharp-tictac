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
        /// 
        /// </summary>
		public void DisplayBoard()
		{

            //TODO: Output the board to the console
            // I know it is a 3x3 board and will change it to .Lengths if we have to have a dynamically size changing board
            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j < 4; j++) 
                {
                    Console.Write($"|{j+(i*3)}|");
                }
                Console.WriteLine();
            }
		
		}
	}
}
