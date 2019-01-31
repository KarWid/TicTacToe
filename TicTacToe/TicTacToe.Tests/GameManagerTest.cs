using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe.Enums;
using TicTacToe.Infrastructure.EvaluationFunctions.Concrete;
using TicTacToe.Managers;
using TicTacToe.Models;

namespace TicTacToe.Tests
{
    [TestClass]
    public class GameManagerTest
    {
        [TestMethod]
        public void EvaluationFunctionTests10x10x100()
        {
            // prepare data
            var factory = new EvaluationFunctionFactory();
            var results = new Dictionary<int, int>();

            var defensiveWeightPlayer1 = new MoveWeightsResult
            {
                BlockedFivesWeight = 1000,
                BlockedFoursWeight = 200,
                BlockedThirdsWeight = 50,
                BlockedTwoWeight = 20,
                SetFivesWeight = 4,
                SetFoursWeight = 3,
                SetThirdsWeight = 2,
                SetTwoWeight = 1
            };

            var offensiveWeightPlayer2 = new MoveWeightsResult
            {
                BlockedFivesWeight = 4,
                BlockedFoursWeight = 3,
                BlockedThirdsWeight = 2,
                BlockedTwoWeight = 1,
                SetFivesWeight = 1000,
                SetFoursWeight = 300,
                SetThirdsWeight = 100,
                SetTwoWeight = 10
            };

            var model = new GameManagerModel
            {
                GameMode = GameModeType.ComputerVsComputer,
                EvaluationFunctionFactory = factory,
                Rows = 10,
                Columns = 10,
                WinCondition = 5,
                BoardLength = 100,
                XFirst = true,
                DepthSearch = 2,
                MoveWeightsResultPlayer1 = defensiveWeightPlayer1,
                MoveWeightsResultPlayer2 = offensiveWeightPlayer2
            };

            results.Add(-1, 0);
            results.Add(0, 0);
            results.Add(1, 0);
            results.Add(2, 0);

            // do actions
            for (int i = 0; i < 100; i++)
            {
                GameManager gameManager = new GameManager(model);
                var result = gameManager.Start();
                results[(int)result]++;
            }

            string message = $"Liczba gier zakończonych błędem: {results[-1]}\n" +
                             $"Liczba gier zakończonych remisem: {results[0]}\n" +
                             $"Defensywny. Gracz wygrał {results[1]} gier\nOfensywny. Gracz wygrał {results[2]} gier.";

            Assert.AreEqual(0, -1, message);
        }
    }
}