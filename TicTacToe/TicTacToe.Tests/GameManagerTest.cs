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

            var model = new GameManagerModel
            {
                GameMode = GameModeType.ComputerVsComputer,
                EvalutaionFunctionFactory = factory,
                Rows = 10,
                Columns = 10,
                WinCondition = 5,
                BoardLength = 100,
                XFirst = true,
                DepthSearch = 3
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
                             $"1. Gracz wygrał {results[1]} gier\n2. Gracz wygrał {results[2]} gier.";

            Assert.AreEqual(0, -1, message);
        }
    }
}
