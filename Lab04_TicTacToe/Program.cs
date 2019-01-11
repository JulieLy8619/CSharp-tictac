using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    public class Program //made it public so I could access it for testing
    {
        static void Main(string[] args)
        {
            //just testing object and its function
            Board ticTacBoard = new Board();
            ticTacBoard.DisplayBoard();
            Console.ReadLine(); //so it doesn't auto exit
        }
    }
}
