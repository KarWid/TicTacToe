namespace TicTacToe.Models
{
    public class GameManagerBoard
    {
        public int[,] Board { get; set; }

        public GameManagerBoard(int rows, int columns)
        {
            Board = new int[rows, columns];
        }
    }
}