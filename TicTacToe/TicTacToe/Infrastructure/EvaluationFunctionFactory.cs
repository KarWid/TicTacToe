using TicTacToe.Managers;
using TicTacToe.Managers.Abstract;

namespace TicTacToe.Infrastructure
{
    public class EvaluationFunctionFactory : IEvaluationFunctionFactory
    {
        public IEvaluationFunction GetEvaluationFunction(int functionNumber, int[,] board)
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