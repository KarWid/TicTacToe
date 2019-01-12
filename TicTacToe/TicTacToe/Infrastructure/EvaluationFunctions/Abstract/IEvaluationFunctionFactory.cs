using TicTacToe.Enums;

namespace TicTacToe.Infrastructure.EvaluationFunctions.Abstract
{
    public interface IEvaluationFunctionFactory
    {
        IEvaluationFunction GetEvaluationFunction(int[,] board, EvaluationFunctionType functionType);
    }
}