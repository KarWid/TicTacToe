using TicTacToe.Infrastructure.EvaluationFunctions.Abstract;

namespace TicTacToe.Infrastructure.EvaluationFunctions.Concrete
{
    public class EvaluationFunction2 : IEvaluationFunction
    {
        public int Evaluate(int[,] board /*Point position, czy to jest moj ruch, wagi*/)
        {
            // x1 = wygrywamgre()
            return 0;
        }
    }
}