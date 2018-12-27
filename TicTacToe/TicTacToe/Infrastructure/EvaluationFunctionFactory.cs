using TicTacToe.Managers;
using TicTacToe.Managers.Abstract;

namespace TicTacToe.Infrastructure
{
    public static class EvaluationFunctionFactory
    {
        public static IEvaluationFunction GetEvaluationFunction(int functionNumber, int[,] board)
        {
            IEvaluationFunction evaluationFunction;

            switch (functionNumber)
            {
                default:
                    evaluationFunction = new EvaluationFunction1(board);
                    break;
            }

            return evaluationFunction;
        }
    }
}