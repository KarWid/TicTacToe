using System.Collections.Generic;
using System.Drawing;
using TicTacToe.Helpers;
using TicTacToe.Infrastructure.EvaluationFunctions.Abstract;
using TicTacToe.Models;

namespace TicTacToe.Infrastructure.EvaluationFunctions.Concrete
{
    public class EvaluationFunction2 : IEvaluationFunction
    {
        public int Evaluate(int[,] board, int winCondition, int rows, int columns, List<Point> moves, int numberPlayer, MoveWeightsResult weights)
        {
            int result = 0;
            int currentNumberPlayer = numberPlayer;
            bool mySeed = true;

            moves.ForEach(move =>
            {
                board[move.X, move.Y] = 0;
            });

            for (int i=0; i < moves.Count; i++)
            {
                var model = BoardHelper.ResultsOnBoardByLastMove(board, winCondition, rows, columns, moves[i], currentNumberPlayer);

                if (mySeed)
                {
                    result += model * weights;
                }
                else
                {
                    result -= model * weights;
                }

                currentNumberPlayer = currentNumberPlayer == 1 ? 2 : 1;
                mySeed = !mySeed;
            }

            currentNumberPlayer = numberPlayer;
            moves.ForEach(move =>
            {
                board[move.X, move.Y] = currentNumberPlayer;
                currentNumberPlayer = currentNumberPlayer == 1 ? 2 : 1;
            });

            return result;
        }
    }
}