using System;
using System.Collections.Generic;
using System.Drawing;
using TicTacToe.Enums;
using TicTacToe.Helpers;
using TicTacToe.Infrastructure.EvaluationFunctions.Abstract;

namespace TicTacToe.Managers
{
    /*
        1. Rozkminic alfa-beta, czy jest ok inicjalizacja, czy mySeed powinien byc true czy false
        2. Usunac sprawdzenie całej planszy co kazdy generateMoves, wrzucić tam na przykład ostatni ruch, 
           a jeśli null to nie sprawdzać, bo to pierwsze wywołanie, a jeśli tak to gameManager juz o to zadbał
        3. Zmienić interfejs IEvaluationFunction na taki, który zależałby od wykonanego ostatniego ruchu i całej tablicy
    */ 
    public class PlayerManager
    {
        private int[,] _board; // values: 0 - empty field, 1 - first player's field, 2 - second player's field
        private IEvaluationFunction _evaluationFunction;
        private int _numberPlayer;
        private int _rows, _columns;
        private int _winCondition;
        private int _depthSearch;

        private Random _rand;

        public PlayerManager(IEvaluationFunction evaluationFunction, int[,] board, int numberPlayer, int winCondition, int depthSearch)
        {
            _board = board;
            _evaluationFunction = evaluationFunction;
            _numberPlayer = numberPlayer;
            _rows = board.GetLength(0);
            _columns = board.GetLength(1);
            _winCondition = winCondition;
            _depthSearch = depthSearch;
            _rand = new Random();
        }

        public Point NextMove(int moves)
        {
            var localBoard = (int[,])_board.Clone();

            var result = MinMax(localBoard, _depthSearch, true, Int32.MinValue, Int32.MaxValue, _numberPlayer, moves);

            return result.Position;
        }

        /// <summary>
        /// Minimax (recursive) at level of depth for maximizing or minimizing player with alpha-beta cut-off
        /// </summary>
        /// <returns>MinIMaxModel with score and best position</returns>
        private MinIMaxModel MinMax(int[,] board, int depth, bool mySeed, int alpha, int beta, int numberPlayer, int moves)
        {
            var nextMoves = GenerateMoves(board, moves);

            // mySeed is maximizing; while oppSeed is minimizing
            int score;
            int bestRow = -1;
            int bestCol = -1;

            if (nextMoves.Count == 0 || depth == 0)
            {
                score = _evaluationFunction.Evaluate(board);
                return new MinIMaxModel
                {
                    Position = new Point(bestRow, bestCol),
                    Score = score
                };
            }
            else
            {
                nextMoves.ForEach(nextMove =>
                {
                    // try this move for the current "player"
                    board[nextMove.X, nextMove.Y] = numberPlayer;

                    var nextNumberPlayer = numberPlayer == 2 ? 1 : 2;

                    if (mySeed) // mySeed (computer) is maximizing player
                    {
                        score = MinMax(board, depth - 1, !mySeed, alpha, beta, nextNumberPlayer, moves + 1).Score;
                        if (score > alpha)
                        {
                            alpha = score;
                            bestRow = nextMove.X;
                            bestCol = nextMove.Y;
                        }
                    }
                    else // oppSeed is minimizing Player
                    {
                        score = MinMax(board, depth - 1, !mySeed, alpha, beta, nextNumberPlayer, moves + 1).Score;
                        if (score < beta)
                        {
                            beta = score;
                            bestRow = nextMove.X;
                            bestCol = nextMove.Y;
                        }
                    }

                    // undo move
                    board[nextMove.X, nextMove.Y] = 0;

                    if (alpha > beta)
                    {
                        throw new Exception("alpha > beta");
                    }
                });

                return new MinIMaxModel
                {
                    Position = new Point(bestRow, bestCol),
                    Score = mySeed ? alpha : beta
                };
            }
        }

        /// <summary>
        /// Find all valid next moves. 
        /// </summary>
        /// <returns>List of moves in Point of (row, col) or empty list if gameover</returns>
        private List<Point> GenerateMoves(int[,] board, int moves)
        {
            var result = new List<Point>();
            var possibleMoves = new List<Point>();

            // If gameover, i.e., no next move
            // zmienic na podstawie ostatniego ruchu, jesli ostatni ruch null,
            // tzn. ze game manager to sprawdzenie zrobił
            var endGame = BoardHelper.IsEndGame(board, _winCondition, _rows, _columns, moves);
            if (endGame != EndGameType.NotEndYet)
            {
                return result;
            }

            // Search for empty cells and add to the List
            for (int row=0; row < _rows; row++)
            {
                for (int column = 0; column < _columns; column++)
                {
                    if (board[row, column] == 0)
                    {
                        possibleMoves.Add(new Point(row, column));
                    }
                }
            }

            while (possibleMoves.Count > 0)
            {
                var index = _rand.Next(0, possibleMoves.Count);

                var position = possibleMoves[index];
                result.Add(position);
                possibleMoves.RemoveAt(index);
            }

            return result;
        }

        private class MinIMaxModel
        {
            public int Score { get; set; }
            public Point Position { get; set; }
        }
    }
}