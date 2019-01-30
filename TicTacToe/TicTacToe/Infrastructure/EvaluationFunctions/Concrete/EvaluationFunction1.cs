using System;
using System.Drawing;
using TicTacToe.Infrastructure.EvaluationFunctions.Abstract;
using TicTacToe.Models;

namespace TicTacToe.Infrastructure.EvaluationFunctions.Concrete
{
    public class EvaluationFunction1 : IEvaluationFunction
    {
        public int Evaluate(int[,] board, int winCondition, int rows, int columns, Point? lastMove, int numberPlayer, MoveWeightsResult weights)
        {
            throw new NotImplementedException();
        }
    }
}