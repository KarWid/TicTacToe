using System.Drawing;
using TicTacToe.Helpers;
using TicTacToe.Infrastructure.EvaluationFunctions.Abstract;
using TicTacToe.Models;

namespace TicTacToe.Infrastructure.EvaluationFunctions.Concrete
{
    public class EvaluationFunction2 : IEvaluationFunction
    {
        public int Evaluate(int[,] board, int winCondition, int rows, int columns, Point? lastMove, int numberPlayer, MoveWeightsResult weights)
        {
            var model = BoardHelper.ResultsOnBoardByLastMove(board, winCondition, rows, columns, lastMove, numberPlayer);

            var result = model * weights;

            if (result > 19)
            {
                var x = 5;
            }

            return result;
        }
    }
}