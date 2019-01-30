using System.Drawing;
using TicTacToe.Enums;
using TicTacToe.Models;

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

        public static bool IsEndGameByLastMove(int[,] board, int winCondition, int rows, int columns, Point? lastMove, int numberPlayer)
        {
            if (lastMove == null)
            {
                return false;
            }

            var bool1 = CheckLeftToRightDownDiagonalByLastMoveSetCombo(board, rows, columns, lastMove, numberPlayer) == winCondition;
            var bool2 = CheckRightToLeftDownDiagonalByLastMoveSetCombo(board, rows, columns, lastMove, numberPlayer) == winCondition;
            var bool3 = CheckRowByLastMoveSetCombo(board, rows, columns, lastMove, numberPlayer) == winCondition;
            var bool4 = CheckColumnByLastMoveSetCombo(board, rows, columns, lastMove, numberPlayer) == winCondition;

            return bool1 || bool2 || bool3 || bool4;
        }

        public static MoveResults ResultsOnBoardByLastMove(int[,] board, int winCondition, int rows, int columns, Point? lastMove, int numberPlayer)
        {
            var result = new MoveResults();

            int combo = 0;

            // set combos
            combo = CheckRightToLeftDownDiagonalByLastMoveSetCombo(board, rows, columns, lastMove, numberPlayer);
            UpdateMoveResult(result, combo, false);

            combo = CheckLeftToRightDownDiagonalByLastMoveSetCombo(board, rows, columns, lastMove, numberPlayer);
            UpdateMoveResult(result, combo, false);

            combo = CheckRowByLastMoveSetCombo(board, rows, columns, lastMove, numberPlayer);
            UpdateMoveResult(result, combo, false);

            combo = CheckColumnByLastMoveSetCombo(board, rows, columns, lastMove, numberPlayer);
            UpdateMoveResult(result, combo, false);

            // blocked combos
            combo = CheckRightToLeftDownDiagonalByLastMoveBlockCombo(board, rows, columns, lastMove, numberPlayer);
            UpdateMoveResult(result, combo, true);

            combo = CheckLeftToRightDownDiagonalByLastMoveBlockCombo(board, rows, columns, lastMove, numberPlayer);
            UpdateMoveResult(result, combo, true);

            combo = CheckRowByLastMoveBlockCombo(board, rows, columns, lastMove, numberPlayer);
            UpdateMoveResult(result, combo, true);

            combo = CheckColumnByLastMoveBlockCombo(board, rows, columns, lastMove, numberPlayer);
            UpdateMoveResult(result, combo, true);

            return result;
        }

        #region Methods based on last move
        // sprawdzenie jaką kombinację dało radę utworzyć poprzez ostatni ruch
        public static int CheckRightToLeftDownDiagonalByLastMoveSetCombo(int[,] board, int rows, int columns, Point? lastMove, int numberPlayer)
        {
            int result = 0;

            if (lastMove == null)
            {
                return result;
            }

            var lastMoveNotNullable = (Point)lastMove;

            int row = lastMoveNotNullable.X;
            int column = lastMoveNotNullable.Y;

            // in the left down corner
            while (row < rows && column >= 0 && board[row, column] == numberPlayer)
            {
                result++;
                row++;
                column--;
            }

            // in the right upper corner
            row = lastMoveNotNullable.X - 1;
            column = lastMoveNotNullable.Y + 1;

            while (row >= 0 && column < columns && board[row, column] == numberPlayer)
            {
                result++;
                row--;
                column++;
            }

            return result;
        }

        // sprawdzenie jaką kombinację dało radę utworzyć poprzez ostatni ruch
        public static int CheckLeftToRightDownDiagonalByLastMoveSetCombo(int[,] board, int rows, int columns, Point? lastMove, int numberPlayer)
        {
            int result = 0;

            if (lastMove == null)
            {
                return result;
            }

            var lastMoveNotNullable = (Point)lastMove;

            // to the right down corner
            int row = lastMoveNotNullable.X;
            int column = lastMoveNotNullable.Y;

            while (row < rows && column <columns && board[row, column] == numberPlayer)
            {
                result++;
                row++;
                column++;
            }

            // to the left upper corner
            row = lastMoveNotNullable.X - 1;
            column = lastMoveNotNullable.Y - 1;

            while (row >= 0 && column >= 0 && board[row, column] == numberPlayer)
            {
                result++;
                row--;
                column--;
            }

            return result;
        }

        // sprawdzenie jaką kombinację dało radę utworzyć poprzez ostatni ruch w wierszu
        public static int CheckRowByLastMoveSetCombo(int[,] board, int rows, int columns, Point? lastMove, int numberPlayer)
        {
            if (lastMove == null)
            {
                return 0;
            }

            var lastMoveNotNullable = (Point)lastMove;

            int row = lastMoveNotNullable.X;

            if (row >= rows || row < 0)
            {
                return 0;
            }

            int result = 0;

            // to the right
            int column = lastMoveNotNullable.Y;

            while (column < columns && board[row, column] == numberPlayer)
            {
                result++;
                column++;
            }

            // to the left
            column = lastMoveNotNullable.Y - 1;

            while (column >= 0 && board[row, column] == numberPlayer)
            {
                result++;
                column--;
            }

            return result;
        }
        
        // sprawdzenie jaką kombinację dało radę utworzyć poprzez ostatni ruch w kolumnie
        public static int CheckColumnByLastMoveSetCombo(int[,] board, int rows, int columns, Point? lastMove, int numberPlayer)
        {
            if (lastMove == null)
            {
                return 0;
            }

            var lastMoveNotNullable = (Point)lastMove;

            int column = lastMoveNotNullable.Y;

            if (column >= columns || column < 0)
            {
                return 0;
            }

            int result = 0;
            int row = lastMoveNotNullable.X;
            
            // to up
            while (row < rows && board[row, column] == numberPlayer)
            {
                result++;
                row++;
            }

            // to down
            row = lastMoveNotNullable.X - 1;

            while (row >= 0 && board[row, column] == numberPlayer)
            {
                result++;
                row--;
            }

            return result;
        }

        // sprawdzenie jaką kombinację dało radę zablokować poprzez ostatni ruch
        public static int CheckRightToLeftDownDiagonalByLastMoveBlockCombo(int[,] board, int rows, int columns, Point? lastMove, int numberPlayer)
        {
            bool topSide = false;
            bool downSide = false;

            int result = 0;
            int enemyPlayer = numberPlayer == 1 ? 2 : 1;

            if (lastMove == null)
            {
                return result;
            }

            var lastMoveNotNullable = (Point)lastMove;

            int row = lastMoveNotNullable.X + 1;
            int column = lastMoveNotNullable.Y - 1;

            // in the left down corner
            while (row < rows && column >= 0 && board[row, column] == enemyPlayer)
            {
                result++;
                row++;
                column--;
                downSide = true;
            }

            // in the right upper corner
            row = lastMoveNotNullable.X - 1;
            column = lastMoveNotNullable.Y + 1;

            while (row >= 0 && column < columns && board[row, column] == enemyPlayer)
            {
                result++;
                row--;
                column++;
                topSide = true;
            }

            return (downSide && topSide) ? result + 1 : result;
        }

        // sprawdzenie jaką kombinację dało radę zablokować poprzez ostatni ruch
        public static int CheckLeftToRightDownDiagonalByLastMoveBlockCombo(int[,] board, int rows, int columns, Point? lastMove, int numberPlayer)
        {
            bool topSide = false;
            bool downSide = false;

            int result = 0;
            int enemyPlayer = numberPlayer == 1 ? 2 : 1;

            if (lastMove == null)
            {
                return result;
            }

            var lastMoveNotNullable = (Point)lastMove;

            // to the right down corner
            int row = lastMoveNotNullable.X + 1;
            int column = lastMoveNotNullable.Y + 1;

            while (row < rows && column < columns && board[row, column] == enemyPlayer)
            {
                result++;
                row++;
                column++;
                downSide = true;
            }

            // to the left upper corner
            row = lastMoveNotNullable.X - 1;
            column = lastMoveNotNullable.Y - 1;

            while (row >= 0 && column >= 0 && board[row, column] == enemyPlayer)
            {
                result++;
                row--;
                column--;
                topSide = true;
            }

            return (downSide && topSide) ? result + 1 : result;
        }

        // sprawdzenie jaką kombinację dało radę zablokować poprzez ostatni ruch
        public static int CheckRowByLastMoveBlockCombo(int[,] board, int rows, int columns, Point? lastMove, int numberPlayer)
        {
            bool leftSide = false;
            bool rightSide = false;

            int enemyPlayer = numberPlayer == 1 ? 2 : 1;

            if (lastMove == null)
            {
                return 0;
            }

            var lastMoveNotNullable = (Point)lastMove;

            int row = lastMoveNotNullable.X;

            if (row >= rows || row < 0)
            {
                return 0;
            }

            int result = 0;

            // to the right
            int column = lastMoveNotNullable.Y + 1;
            
            while (column < columns && board[row, column] == enemyPlayer)
            {
                result++;
                column++;
                rightSide = true;
            }

            // to the left
            column = lastMoveNotNullable.Y - 1;

            while (column >= 0 && board[row, column] == enemyPlayer)
            {
                result++;
                column--;
                leftSide = true;
            }

            return (leftSide && rightSide) ? result + 1 : result;
        }

        // sprawdzenie jaką kombinację dało radę zablokować poprzez ostatni ruch
        public static int CheckColumnByLastMoveBlockCombo(int[,] board, int rows, int columns, Point? lastMove, int numberPlayer)
        {
            bool upSide = false;
            bool downSide = false;

            int enemyPlayer = numberPlayer == 1 ? 2 : 1;

            if (lastMove == null)
            {
                return 0;
            }

            var lastMoveNotNullable = (Point)lastMove;

            int column = lastMoveNotNullable.Y;

            if (column >= columns || column < 0)
            {
                return 0;
            }

            int result = 0;
            int row = lastMoveNotNullable.X + 1;

            // to up
            while (row < rows && board[row, column] == enemyPlayer)
            {
                result++;
                row++;
                upSide = true;
            }

            // to down
            row = lastMoveNotNullable.X - 1;

            while (row >= 0 && board[row, column] == enemyPlayer)
            {
                result++;
                row--;
                downSide = true;
            }

            return (downSide && upSide) ? result + 1 : result;
        }
        #endregion

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

        private static void UpdateMoveResult(MoveResults moveResult, int value, bool isBlocked)
        {
            if (isBlocked)
            {
                switch (value)
                {
                    case 5:
                        moveResult.BlockedFivesNumber++;
                        break;
                    case 4:
                        moveResult.BlockedFoursNumber++;
                        break;
                    case 3:
                        moveResult.BlockedThirdsNumber++;
                        break;
                    case 2:
                        moveResult.BlockedTwoNumber++;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (value)
                {
                    case 5:
                        moveResult.SetFivesNumber++;
                        break;
                    case 4:
                        moveResult.SetFoursNumber++;
                        break;
                    case 3:
                        moveResult.SetThirdsNumber++;
                        break;
                    case 2:
                        moveResult.SetTwoNumber++;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}