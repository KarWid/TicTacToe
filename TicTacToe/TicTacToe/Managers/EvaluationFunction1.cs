using System;
using System.Drawing;
using TicTacToe.Managers.Abstract;

namespace TicTacToe.Managers
{
    public class EvaluationFunction1 : IEvaluationFunction
    {
        public int[,] Board { get; set; }

        public EvaluationFunction1(int[,] board)
        {
            Board = board;
        }

        public Point Calculate()
        {
            var rand = new Random();
            int x = 0, y = 0;

            do
            {
                x = rand.Next(0, Board.GetLength(0));
                y = rand.Next(0, Board.GetLength(1));
            } while (Board[x, y] != 0);

            return new Point(x, y);
        }
    }
}