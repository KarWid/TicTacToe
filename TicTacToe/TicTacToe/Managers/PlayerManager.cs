using System.Drawing;
using TicTacToe.Managers.Abstract;

namespace TicTacToe.Managers
{
    public class PlayerManager
    {
        private int[,] _board; // values: 0 - empty field, 1 - first player's field, 2 - second player's field
        private IEvaluationFunction _evaluationFunction;

        public PlayerManager(IEvaluationFunction evaluationFunction, int[,] board)
        {
            _board = board;
            _evaluationFunction = evaluationFunction;
        }

        public Point NextMove()
        {

            return _evaluationFunction.Calculate();
        }
    }
}