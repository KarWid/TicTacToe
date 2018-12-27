using System;
using System.Drawing;
using TicTacToe.Helpers;
using TicTacToe.Enums;
using TicTacToe.Models;
using TicTacToe.Managers.Abstract;

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
        private IEvaluationFunctionFactory _evaluationFunctionFactory;


        public event EventHandler<ChangeBtnTextEventArgs> ChangeBtnTextEventHandler;
        public event EventHandler EnableBtnsEventHandler;
        public event EventHandler EndGameMessagesEventHandler;

        public GameManager(GameModeType gameMode, IEvaluationFunctionFactory evalutaionFunctionFactory, 
                           int rows, int columns, int winCondition, int boardLength, bool xFirst)
        {
            _rows = rows;
            _columns = columns;
            _winCondition = winCondition;
            _gameMode = gameMode;

            _xTurn = xFirst;
            _firstPlayerMove = true;
            _boardLength = boardLength;

            _gameManagerBoard = new GameManagerBoard(rows, columns);
            _evaluationFunctionFactory = evalutaionFunctionFactory;

            InitializePlayers(gameMode);
        }

        public int Start()
        {
            return Move(_playerManager1.NextMove());
        }

        public int Move(Point position)
        {
            if (!position.IsValid(_rows, _columns)) return -1;

            if (_gameManagerBoard.Board[position.X, position.Y] != 0)
            {
                throw new Exception("Bad move in game manager, position is busy");
            }

            ChangeBtnTextEventHandler?.Invoke(this, new ChangeBtnTextEventArgs(position, _xTurn ? "X" : "0"));
            _gameManagerBoard.Board[position.X, position.Y] = _firstPlayerMove ? 1 : 2;

            // if some1 win
            var winner = BoardHelper.IsEndGame(_gameManagerBoard.Board, _winCondition, _rows, _columns, _moves);

            switch (winner)
            {
                case 1:
                case 2:
                    EndGameMessagesEventHandler?.Invoke($"Game is over\nPlayer {winner} won the game!", null);
                    return winner;
                case 0:
                    EndGameMessagesEventHandler?.Invoke("Game is over\nNo one win the game", null);
                    return winner;
                default:
                    break;
            }

            return ChangePlayer();
        }

        private void InitializePlayers(GameModeType gameMode)
        {
            switch (gameMode)
            {
                case GameModeType.PlayerVsPlayer:
                    break;
                case GameModeType.PlayerVsComputer:
                    _playerManager2 = new PlayerManager(_evaluationFunctionFactory.GetEvaluationFunction(1, _gameManagerBoard.Board),
                                                        _gameManagerBoard.Board);
                    break;
                case GameModeType.ComputerVsComputer:
                    _playerManager1 = new PlayerManager(_evaluationFunctionFactory.GetEvaluationFunction(1, _gameManagerBoard.Board),
                                                        _gameManagerBoard.Board);
                    _playerManager2 = new PlayerManager(_evaluationFunctionFactory.GetEvaluationFunction(2, _gameManagerBoard.Board),
                                                        _gameManagerBoard.Board);
                    break;
                default:
                    break;
            }
        }

        private int ChangePlayer()
        {
            _xTurn = !_xTurn;
            _firstPlayerMove = !_firstPlayerMove;
            _moves++;

            return MoveIfComputer();
        }

        private int MoveIfComputer()
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

            return -1;
        }
    }
}