using System.Drawing;

namespace TicTacToe.Managers.Abstract
{
    public interface IEvaluationFunction
    {
        int[,] Board { get; set; }
        Point Calculate();
    }
}