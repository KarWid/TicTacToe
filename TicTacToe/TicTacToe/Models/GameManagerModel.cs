using TicTacToe.Enums;
using TicTacToe.Infrastructure.EvaluationFunctions.Abstract;

namespace TicTacToe.Models
{
    public class GameManagerModel
    {
        public GameModeType GameMode { get; set; }
        public IEvaluationFunctionFactory EvalutaionFunctionFactory { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        public int WinCondition { get; set; }
        public int BoardLength { get; set; }
        public bool XFirst { get; set; }
        public int DepthSearch { get; set; } = 2;
    }
}