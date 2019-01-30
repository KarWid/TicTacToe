using System.Drawing;
using TicTacToe.Models;

namespace TicTacToe.Infrastructure.EvaluationFunctions.Abstract
{
    //http://www.ntu.edu.sg/home/ehchua/programming/java/javagame_tictactoe_ai.html?fbclid=IwAR1t4GHHMZCeeHFmU8MNSQv6sumnthugsb7Y05592qqvVZqUM_Nv4AaluWg
    public interface IEvaluationFunction
    {
        int Evaluate(int[,] board, int winCondition, int rows, int columns, Point? lastMove, int numberPlayer, MoveWeightsResult weights);
    }
}