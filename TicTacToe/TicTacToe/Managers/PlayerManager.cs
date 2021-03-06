﻿using System;
using System.Collections.Generic;
using System.Drawing;
using TicTacToe.Helpers;
using TicTacToe.Infrastructure.EvaluationFunctions.Abstract;
using TicTacToe.Models;

namespace TicTacToe.Managers
{
    public class PlayerManager
    {
        private int[,] _board; // values: 0 - empty field, 1 - first player's field, 2 - second player's field
        private IEvaluationFunction _evaluationFunction;
        private int _numberPlayer;
        private int _rows, _columns;
        private int _winCondition;
        private int _depthSearch;
        private MoveWeightsResult _moveWeightsResult;

        private Random _rand;

        public PlayerManager(IEvaluationFunction evaluationFunction, int[,] board, int numberPlayer, int winCondition, int depthSearch, MoveWeightsResult weightsResult)
        {
            _board = board;
            _evaluationFunction = evaluationFunction;
            _numberPlayer = numberPlayer;
            _rows = board.GetLength(0);
            _columns = board.GetLength(1);
            _winCondition = winCondition;
            _depthSearch = depthSearch;
            _rand = new Random();
            _moveWeightsResult = weightsResult;
        }

        public Point NextMove(int moves)
        {
            var localBoard = (int[,])_board.Clone();

            var result = MinMax(localBoard, _depthSearch, true, Int32.MinValue, Int32.MaxValue, _numberPlayer, new List<Point>());

            return result.Position;
        }

        /// <summary>
        /// Minimax (recursive) at level of depth for maximizing or minimizing player with alpha-beta cut-off
        /// </summary>
        /// <returns>MinIMaxModel with score and best position</returns>
        private MinIMaxModel MinMax(int[,] board, int depth, bool mySeed, int alpha, int beta, int numberPlayer, List<Point> moves)
        {
            Point? lastMove = null;

            if (moves.Count > 0)
            {
                lastMove = moves[moves.Count - 1];
            }

            var nextMoves = GenerateMoves(board, lastMove , numberPlayer);

            // mySeed is maximizing; while oppSeed is minimizing
            int score;
            int bestRow = -1;
            int bestCol = -1;

            if (nextMoves.Count == 0 || depth == 0)
            {
                score = _evaluationFunction.Evaluate(board, _winCondition, _rows, _columns, moves, _numberPlayer, _moveWeightsResult);
                return new MinIMaxModel
                {
                    Position = new Point(bestRow, bestCol),
                    Score = score
                };
            }
            else
            {
                for (int i=0; i < nextMoves.Count; i++)
                {
                    var nextMove = nextMoves[i];

                    // try this move for the current "player"
                    board[nextMove.X, nextMove.Y] = numberPlayer;
                    moves.Add(nextMove);

                    var nextNumberPlayer = numberPlayer == 2 ? 1 : 2;

                    score = MinMax(board, depth - 1, !mySeed, alpha, beta, nextNumberPlayer, moves).Score;

                    if (mySeed) // mySeed (computer) is maximizing player
                    {
                        if (score > alpha)
                        {
                            alpha = score;
                            bestRow = nextMove.X;
                            bestCol = nextMove.Y;
                        }
                    }
                    else // oppSeed is minimizing Player
                    {
                        if (score < beta)
                        {
                            beta = score;
                            bestRow = nextMove.X;
                            bestCol = nextMove.Y;
                        }
                    }

                    // undo move
                    board[nextMove.X, nextMove.Y] = 0;
                    moves.Remove(nextMove);

                    if (beta < alpha)
                    {
                        break;
                    }
                }

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
        private List<Point> GenerateMoves(int[,] board, Point? lastMove, int numberPlayer)
        {
            var result = new List<Point>();
            var possibleMoves = new List<Point>();

            if (lastMove != null)
            {
                var endGame = BoardHelper.IsEndGameByLastMove(board, _winCondition, _rows, _columns, lastMove, numberPlayer);
                if (endGame)
                {
                    return result;
                }
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