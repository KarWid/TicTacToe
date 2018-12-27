using System.Windows.Forms;

namespace TicTacToe.Models
{
    public class GameManagerBoard
    {
        public Button[,] BoardButtons { get; set; }
        public int[,] Board { get; set; }

        public GameManagerBoard(int rows, int columns, Button[,] board)
        {
            BoardButtons = board;
            Board = new int[rows, columns];
        }
    }
}