using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Player //public so can test
    {
		public string Name { get; set; }

		/// <summary>
		/// P1 is X and P2 will be O
		/// </summary>
		public string Marker { get; set; }

		/// <summary>
		/// Flag to determine if it is the user's turn
		/// </summary>
		public bool IsTurn { get; set; }

        /// <summary>
        /// asks for a number and returns the coordinates the user wants to chose for their turn/play
        /// </summary>
        /// <param name="board">current state of the board</param>
        /// <returns> returns the Position on the board the player selected </returns>
		public Position GetPosition(Board board)
		{
			Position desiredCoordinate = null;
			while (desiredCoordinate is null)
			{
				Console.WriteLine("Please select a location");
				Int32.TryParse(Console.ReadLine(), out int position);
				desiredCoordinate = PositionForNumber(position);
			}
			return desiredCoordinate;

		}

        /// <summary>
        /// this converts the number the user chose to a coordinate
        /// </summary>
        /// <param name="position">Users choice/input as a number</param>
        /// <returns> returns position object with the coordinates filled in</returns>
		public static Position PositionForNumber(int position)
		{
			switch (position)
			{
				case 1: return new Position(0, 0); // Top Left
				case 2: return new Position(0, 1); // Top Middle
				case 3: return new Position(0, 2); // Top Right
				case 4: return new Position(1, 0); // Middle Left
				case 5: return new Position(1, 1); // Middle Middle
				case 6: return new Position(1, 2); // Middle Right
				case 7: return new Position(2, 0); // Bottom Left
				case 8: return new Position(2, 1); // Bottom Middle 
				case 9: return new Position(2, 2); // Bottom Right

				default: return null;
			}
		}
        /// <summary>
        /// this is the user's turn, asking for the number and placing their icon on the board or letting them know it is already taken 
        /// 1-12-19 jly modified code to handle if position already had marker
        /// </summary>
        /// <param name="board">current state of the board</param>
        public void TakeTurn(Board board)
		{
			IsTurn = true;
            do
            {
                Console.WriteLine($"{Name} it is your turn");

                Position position = GetPosition(board);

                if (Int32.TryParse(board.GameBoard[position.Row, position.Column], out int _))
                {
                    board.GameBoard[position.Row, position.Column] = Marker;
                    IsTurn = true;
                }
                else
                {
                    Console.WriteLine("This space is already occupied");
                    IsTurn = false;
                }
            } while (IsTurn == false);
            //IsTurn = false;
		}
	}
}
