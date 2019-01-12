using TicTacToe.Enums;

namespace TicTacToe.Helpers
{
    public static class BoardHelper
    {
        /// <summary>
        /// Returns winner number.
        /// 0 when no one wins. -1 when game is not over.
        /// </summary>
        /// <param name="board"></param>
        /// <param name="winCondition"></param>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <returns></returns>
        public static EndGameType IsEndGame(int[,] board, int winCondition, int rows, int columns, int moves)
        {
            var result = CheckRows(board, winCondition, rows, columns);
            if (result != EndGameType.NotEndYet) return result;

            result = CheckColumns(board, winCondition, rows, columns);
            if (result != EndGameType.NotEndYet) return result;

            result = CheckLeftToRightDownDiagonals(board, winCondition, rows, columns);
            if (result != EndGameType.NotEndYet) return result;

            result = CheckRightToLeftDownDiagonals(board, winCondition, rows, columns);
            if (result != EndGameType.NotEndYet) return result;

            if (moves == (board.Length - 1)) return 0;

            return EndGameType.NotEndYet;
        }

        private static EndGameType CheckRows(int[,] board, int winCondition, int rows, int columns)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < (columns - winCondition + 1); column++)
                {
                    var value = board[row, column];
                    if (value == 0) continue;

                    var compared = true;

                    for (int matchColumn = 1; matchColumn < winCondition; matchColumn++)
                    {
                        if (board[row, column + matchColumn] != value)
                        {
                            compared = false;
                            break;
                        }
                    }

                    if (compared)
                    {
                        return (EndGameType)value;
                    }
                }
            }

            return EndGameType.NotEndYet;
        }

        private static EndGameType CheckColumns(int[,] board, int winCondition, int rows, int columns)
        {
            for (int column = 0; column < columns; column++)
            {
                for (int row = 0; row < (rows - winCondition + 1); row++)
                {
                    var value = board[row, column];
                    if (value == 0) continue;

                    var compared = true;

                    for (int matchRow = 1; matchRow < winCondition; matchRow++)
                    {
                        if (board[row + matchRow, column] != value)
                        {
                            compared = false;
                            break;
                        }
                    }

                    if (compared)
                    {
                        return (EndGameType)value;
                    }
                }
            }

            return EndGameType.NotEndYet;
        }

        private static EndGameType CheckLeftToRightDownDiagonals(int[,] board, int winCondition, int rows, int columns)
        {
            var result = EndGameType.NotEndYet;

            for (int row = rows - 1; row >=0; row--)
            {
                result = CheckLeftToRightDownDiagonal(board, winCondition, rows, columns, row, 0);
                if (result != EndGameType.NotEndYet) return result;
            }

            for (int column = 0; column < columns; column++)
            {
                result = CheckLeftToRightDownDiagonal(board, winCondition, rows, columns, 0, column);
                if (result != EndGameType.NotEndYet) return result;
            }
            
            return EndGameType.NotEndYet;
        }

        private static EndGameType CheckRightToLeftDownDiagonals(int[,] board, int winCondition, int rows, int columns)
        {
            var result = EndGameType.NotEndYet;
            var lastColumn = columns - 1;

            for (int row = rows - 1; row >= 0; row--)
            {
                result = CheckRightToLeftDownDiagonal(board, winCondition, rows, columns, row, lastColumn);
                if (result != EndGameType.NotEndYet) return result;
            }

            for (int column = lastColumn; column >= 0; column--)
            {
                result = CheckRightToLeftDownDiagonal(board, winCondition, rows, columns, 0, column);
                if (result != EndGameType.NotEndYet) return result;
            }

            return result;
        }

        private static EndGameType CheckLeftToRightDownDiagonal(int[,] board, int winCondition, int rows, int columns, int startRow, int startColumn)
        {
            int value = -1;
            bool compared = false;
            var stopCondition = winCondition - 1;

            for (int row = startRow, column = startColumn; (column < (columns - stopCondition) && (row < (rows - stopCondition)));
                 row++, column++)
            {
                value = board[row, column];
                if (value == 0) continue;
                compared = true;

                for (int i = row + 1, j = column + 1, k = 1; k < winCondition; k++, i++, j++)
                {
                    if (value != board[i, j])
                    {
                        compared = false;
                        break;
                    }
                }

                if (compared)
                {
                    return (EndGameType)value;
                }
            }

            return compared ? (EndGameType)value : EndGameType.NotEndYet;
        }

        private static EndGameType CheckRightToLeftDownDiagonal(int[,] board, int winCondition, int rows, int columns, int startRow, int startColumn)
        {
            int value = -1;
            bool compared = false;
            var stopCondition = winCondition - 1;

            for (int row = startRow, column = startColumn; (column >= stopCondition && (row < (rows - stopCondition)));
                 row++, column--)
            {
                value = board[row, column];
                if (value == 0) continue;
                compared = true;

                for (int i = row + 1, j = column - 1, k = 1; k < winCondition; k++, i++, j--)
                {
                    if (value != board[i, j])
                    {
                        compared = false;
                        break;
                    }
                }

                if (compared)
                {
                    return (EndGameType)value;
                }
            }

            return compared ? (EndGameType)value : EndGameType.NotEndYet;
        }
    }
}