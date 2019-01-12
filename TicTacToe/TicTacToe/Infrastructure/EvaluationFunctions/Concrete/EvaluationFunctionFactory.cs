using TicTacToe.Enums;
using TicTacToe.Infrastructure.EvaluationFunctions.Abstract;

namespace TicTacToe.Infrastructure.EvaluationFunctions.Concrete
{
    public class EvaluationFunctionFactory : IEvaluationFunctionFactory
    {
        public IEvaluationFunction GetEvaluationFunction(int[,] board, EvaluationFunctionType functionType)
        {
            IEvaluationFunction evaluationFunction;

            switch (functionType)
            {
                case EvaluationFunctionType.Random:
                    evaluationFunction = new EvaluationFunction1();
                    break;
                case EvaluationFunctionType.Easy:
                    evaluationFunction = new EvaluationFunction2();
                    break;
                default:
                    evaluationFunction = new EvaluationFunction1();
                    break;
            }

            return evaluationFunction;
        }
    }
}