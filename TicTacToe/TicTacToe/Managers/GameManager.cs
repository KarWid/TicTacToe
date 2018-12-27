﻿using System;
using System.Drawing;
using System.Windows.Forms;
using TicTacToe.Helpers;
using TicTacToe.Enums;
using TicTacToe.Models;
using TicTacToe.Infrastructure;

namespace TicTacToe.Managers
{
    public class GameManager
    {
        private bool _xTurn, _firstPlayerMove;
        private int _rows, _columns, _winCondition, _moves, _boardLength;
        private GameModeType _gameMode;
        private GameManagerBoard _gameManagerBoard;
        private PlayerManager _playerManager1;
        private PlayerManager _playerManager2;

        public event EventHandler<ChangeBtnTextEventArgs> ChangeBtnTextEventHandler;
        public event EventHandler EnableBtnsEventHandler;

        public GameManager(GameModeType gameMode, int rows, int columns, int winCondition, int boardLength, bool xFirst)
        {
            _rows = rows;
            _columns = columns;
            _winCondition = winCondition;
            _gameMode = gameMode;

            _xTurn = xFirst;
            _firstPlayerMove = true;
            _boardLength = boardLength;

            _gameManagerBoard = new GameManagerBoard(rows, columns);

            InitializePlayers(gameMode);
        }

        public void Start()
        {
            Move(_playerManager1.NextMove());
        }

        // to do
        public bool Move(Point position)
        {
            if (!position.IsValid(_rows, _columns)) return false;

            DialogResult dialogResult;

            if (_gameManagerBoard.Board[position.X, position.Y] != 0)
            {
                dialogResult = MessageBox.Show("You cant move here, because this field is busy\n" +
                                               "Do you want to try again? If no, go back to the main view", 
                                               "Bad move", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    return MoveIfComputer();
                }
                else
                {
                    return End();
                }
            }

            ChangeBtnTextEventHandler?.Invoke(this, new ChangeBtnTextEventArgs(position, _xTurn ? "X" : "0"));

            _gameManagerBoard.Board[position.X, position.Y] = _firstPlayerMove ? 1 : 2;

            // if some1 win
            var winner = BoardHelper.IsEndGame(_gameManagerBoard.Board, _winCondition, _rows, _columns, _moves);

            switch (winner)
            {
                case 1:
                case 2:
                    dialogResult = MessageBox.Show($"Game is over\nPlayer {winner} won the game!");
                    if (dialogResult == DialogResult.OK) return End();
                    break;
                case 0:
                    dialogResult = MessageBox.Show("Game is over\nNo one win the game");
                    if (dialogResult == DialogResult.OK) return End();
                    break;
                default:
                    break;
            }

            ChangePlayer();

            return true;
        }

        private void InitializePlayers(GameModeType gameMode)
        {
            var function1 = EvaluationFunctionFactory.GetEvaluationFunction(1, _gameManagerBoard.Board);

            switch (gameMode)
            {
                case GameModeType.PlayerVsPlayer:
                    break;
                case GameModeType.PlayerVsComputer:
                    _playerManager2 = new PlayerManager(EvaluationFunctionFactory.GetEvaluationFunction(1, _gameManagerBoard.Board),
                                                        _gameManagerBoard.Board);
                    break;
                case GameModeType.ComputerVsComputer:
                    _playerManager1 = new PlayerManager(EvaluationFunctionFactory.GetEvaluationFunction(1, _gameManagerBoard.Board),
                                                        _gameManagerBoard.Board);
                    _playerManager2 = new PlayerManager(EvaluationFunctionFactory.GetEvaluationFunction(2, _gameManagerBoard.Board),
                                                        _gameManagerBoard.Board);
                    break;
                default:
                    break;
            }
        }

        private void ChangePlayer()
        {
            _xTurn = !_xTurn;
            _firstPlayerMove = !_firstPlayerMove;
            _moves++;

            MoveIfComputer();
        }

        private bool MoveIfComputer()
        {
            switch (_gameMode)
            {
                case GameModeType.PlayerVsComputer:
                    EnableBtnsEventHandler?.Invoke(_firstPlayerMove, null);
                    if (!_firstPlayerMove)
                    {
                        return Move(_playerManager2.NextMove());
                    }
                    break;
                case GameModeType.ComputerVsComputer:
                    if (_firstPlayerMove)
                    {
                        return Move(_playerManager1.NextMove());
                    }
                    return Move(_playerManager2.NextMove());
            }

            return false;
        }

        // to do
        private bool End()
        {
            FormManager.MainForm?.Show();
            FormManager.ActualForm?.Close();
            return false;
        }
    }
}