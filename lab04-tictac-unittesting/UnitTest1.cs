using System;
using Xunit;
using Lab04_TicTacToe;
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
        //would have to set up a winning board to get it to return true, don't know how to set up the winning board as a the default
        //[Fact]
        //public void TestWinnerNotWorks()
        //{
        //    Board testGameBoard = new Board();
        //    Player player1 = new Player();
        //    player1.Name = "bob";
        //    Player player2 = new Player();
        //    player2.Name = "sally";
        //    Game testGame = new Game(player1, player2);

        //    Assert.True(testGame.CheckForWinner(testGameBoard));
        //}

        //Test that there is a switch in players between turns
        [Fact]
        public void TestSwitchWorks()
        {
            Board testGameBoard = new Board();
            Player player1 = new Player();
            player1.Name = "bob";
            player1.IsTurn = true;
            Player player2 = new Player();
            player2.Name = "sally";
            player2.IsTurn = false;
            Game testGame = new Game(player1, player2);
            testGame.SwitchPlayer();

            Assert.True(player2.IsTurn);
        }
        [Fact]
        public void TestSwitchNotWorks()
        {
            Board testGameBoard = new Board();
            Player player1 = new Player();
            player1.Name = "bob";
            player1.IsTurn = true;
            Player player2 = new Player();
            player2.Name = "sally";
            player2.IsTurn = false;
            Game testGame = new Game(player1, player2);
            testGame.SwitchPlayer();

            Assert.False(player1.IsTurn);
        }

        //Confirm that the position the player inputs correlates to the correct index of the array
        [Fact]
        public void TestPositionWorks()
        {
            Board testGameBoard = new Board();
            Player player1 = new Player();
            player1.Name = "bob";
            Player player2 = new Player();
            player2.Name = "sally";
            Game testGame = new Game(player1, player2);
            Position testPos = new Position(0,0);
            string a = testGameBoard.GameBoard[testPos.Row, testPos.Column];
            Assert.Equal("1", a);
        }
        [Fact]
        public void TestPositionNotWorks()
        {
            Board testGameBoard = new Board();
            Player player1 = new Player();
            player1.Name = "bob";
            Player player2 = new Player();
            player2.Name = "sally";
            Game testGame = new Game(player1, player2);
            Position testPos = new Position(0, 0);
            string a = testGameBoard.GameBoard[testPos.Row, testPos.Column];
            Assert.NotEqual("2", a);
        }

        //Julie unique testing: next player returns correct true or false
        [Fact]
        public void TestNextPlayerWorks()
        {
            Board testGameBoard = new Board();
            Player player1 = new Player();
            player1.Name = "bob";
            player1.IsTurn = true;
            Player player2 = new Player();
            player2.Name = "sally";
            player2.IsTurn = false;
            Game testGame = new Game(player1, player2);
            testGame.NextPlayer();

            Assert.Equal("bob", player1.Name);
        }
        [Fact]
        public void TestNextPlayerNotWorks()
        {
            Board testGameBoard = new Board();
            Player player1 = new Player();
            player1.Name = "bob";
            player1.IsTurn = true;
            Player player2 = new Player();
            player2.Name = "sally";
            player2.IsTurn = false;
            Game testGame = new Game(player1, player2);
            testGame.NextPlayer();

            Assert.NotEqual("bob", player2.Name);
        }

    }
}
