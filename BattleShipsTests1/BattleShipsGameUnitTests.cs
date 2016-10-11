using BattleShips;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BattleShips.Tests
{
    [TestClass()]
    public class BattleShipsGameUnitTests
    {
        private BattleShipsGame game;
        private Player player;
        private AIEasyPlayer ai; 

        [TestInitialize()]
        public void Setup()
        {
            game = new BattleShipsGame();
        }

        [TestMethod()]
        public void InitialisationTest()
        {
            // arrange
            ai = new AIEasyPlayer(game);

            // act
            var expected = ai.Game;
            var actual = game;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PlayerLimitTest()
        {
            // arrange is taken care of in Setup() method

            // act
            int expected = 2;
            int actual = game.Players.Length;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ApplicationException), "You cannot add another player, the game already has two players.")]
        public void AddPlayerLimitTest()
        {
            // arrange
            Player player1 = new Player(game);
            Player player2 = new Player(game);
            Player player3 = new Player(game);

            // act
            game.AddDeployedPlayer(player1);
            game.AddDeployedPlayer(player2);
            game.AddDeployedPlayer(player3);

            // assert is specified in [ExpectedException] option
        }
    }
}
