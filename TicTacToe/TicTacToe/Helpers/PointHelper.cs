using System.Drawing;

namespace TicTacToe.Helpers
{
    public static class PointHelper
    {
        public static bool IsValid(this Point position, int rows, int columns)
        {
            return (position.X >= 0&& position.X < rows)
                    || (position.Y >= 0 && position.Y < columns);
        }
    }
}