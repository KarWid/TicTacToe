using System.Drawing;

namespace TicTacToe.Managers.Abstract
{
    //http://www.ntu.edu.sg/home/ehchua/programming/java/javagame_tictactoe_ai.html?fbclid=IwAR1t4GHHMZCeeHFmU8MNSQv6sumnthugsb7Y05592qqvVZqUM_Nv4AaluWg
    public interface IEvaluationFunction
    {
        int[,] Board { get; set; }
        Point Calculate();
    }
}