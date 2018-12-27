namespace TicTacToe.Managers.Abstract
{
    public interface IEvaluationFunctionFactory
    {
        IEvaluationFunction GetEvaluationFunction(int functionNumber, int[,] board);
    }
}