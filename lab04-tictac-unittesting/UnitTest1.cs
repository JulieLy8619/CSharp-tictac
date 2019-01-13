using System;
using Xunit;
using static Lab04_TicTacToe.Program;
using Lab04_TicTacToe.Classes;

namespace lab04_tictac_unittesting
{
    public class UnitTest1
    {
        //Test for winners
        [Fact]
        public void TestWinnerWorks()
        {
            Board testGameBoard = new Board();
            Player player1 = new Player();
            player1.Name = "bob";
            Player player2 = new Player();
            player2.Name = "sally";
            Game testGame = new Game(player1, player2);

            Assert.False(testGame.CheckForWinner(testGameBoard));
        }
        [Fact]
        public void TestWinnerNotWorks()
        {
            Board testGameBoard = new Board();
            Player player1 = new Player();
            player1.Name = "bob";
            Player player2 = new Player();
            player2.Name = "sally";
            Game testGame = new Game(player1, player2);

            Assert.True(testGame.CheckForWinner(testGameBoard));
        }

        //Test that there is a switch in players between turns
        [Fact]
        public void TestSwitchWorks()
        {

        }
        //[Fact]
        //public void TestSwitchNotWorks()
        //{

        //}

        ////Confirm that the position the player inputs correlates to the correct index of the array
        //[Fact]
        //public void TestPositionWorks()
        //{

        //}
        //[Fact]
        //public void TestPositionNotWorks()
        //{

        //}

        ////Julie unique testing
        //[Fact]
        //public void TestJulieWorks()
        //{

        //}
        //[Fact]
        //public void TestJulieNotWorks()
        //{

        //}

    }
}
