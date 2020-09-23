using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RockPaperScissors.Models;
using System;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Game newGame = new Game("Rock", "Paper");
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }
    [TestMethod]
    public void GamePlay_ReturnsPlayGameResult_String()
    {
      //Arrange
      string input = "Rock";
      string input2 = "Scissors";
      Game newGame = new Game(input, input2);
      //Act
      string result = newGame.PlayGame();

      //Assert
      Assert.AreEqual(("I don't know what just happened?"), result);

    }
    [TestMethod]
    public void GamePlay_ReturnsPlayTie_String()
    {
      //Arrange
      string input = "Scissors";
      string input2 = "Scissors";
      Game newGame = new Game(input, input2);
      //Act
      string result = newGame.PlayGame();

      //Assert
      Assert.AreEqual(("It's a Tie!"), result);

    }
  }
}