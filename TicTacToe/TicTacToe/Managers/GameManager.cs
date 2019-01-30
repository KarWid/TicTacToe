using System;
using System.Drawing;
using TicTacToe.Helpers;
using TicTacToe.Enums;
using TicTacToe.Models;
using TicTacToe.Infrastructure.EvaluationFunctions.Abstract;

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

        private MoveWeightsResult _moveWeightsResult = new MoveWeightsResult
        {
            BlockedFivesWeight = 20,
            BlockedFoursWeight = 3,
            BlockedThirdsWeight = 2,
            BlockedTwoWeight = 1,
            SetFivesWeight = 10,
            SetFoursWeight = 8,
            SetThirdsWeight = 4,
            SetTwoWeight = 2
        };

        public event EventHandler<ChangeBtnTextEventArgs> ChangeBtnTextEventHandler;
        public event EventHandler EnableBtnsEventHandler;
        public event EventHandler EndGameMessagesEventHandler;

        public int DepthSearch { get; private set; }

        public GameManager(GameManagerModel model)
        {
            _rows = model.Rows;
            _columns = model.Columns;
            _winCondition = model.WinCondition;
            _gameMode = model.GameMode;

            _xTurn = model.XFirst;
            _firstPlayerMove = true;
            _boardLength = model.BoardLength;

            _gameManagerBoard = new GameManagerBoard(model.Rows, model.Columns);
            _evaluationFunctionFactory = model.EvalutaionFunctionFactory;

            DepthSearch = model.DepthSearch;

            InitializePlayers(model.GameMode);
        }

        public EndGameType Start()
        {
            return Move(_playerManager1.NextMove(_moves));
        }

        public EndGameType Move(Point position)
        {
            if (!position.IsValid(_rows, _columns))
            {
                return EndGameType.NotEndYet;
            }

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
                case EndGameType.Player1Won:
                case EndGameType.Player2Won:
                    EndGameMessagesEventHandler?.Invoke($"Game is over\nPlayer {(int)winner} won the game!", null);
                    return winner;
                case EndGameType.Remis:
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
                    _playerManager2 = new PlayerManager(_evaluationFunctionFactory.GetEvaluationFunction(_gameManagerBoard.Board, EvaluationFunctionType.Easy),
                                                        _gameManagerBoard.Board, 2, _winCondition, DepthSearch, _moveWeightsResult);
                    break;
                case GameModeType.ComputerVsComputer:
                    _playerManager1 = new PlayerManager(_evaluationFunctionFactory.GetEvaluationFunction(_gameManagerBoard.Board, EvaluationFunctionType.Easy),
                                                        _gameManagerBoard.Board, 1, _winCondition, DepthSearch, _moveWeightsResult);
                    _playerManager2 = new PlayerManager(_evaluationFunctionFactory.GetEvaluationFunction(_gameManagerBoard.Board, EvaluationFunctionType.Easy),
                                                        _gameManagerBoard.Board, 2, _winCondition, DepthSearch, _moveWeightsResult);
                    break;
                default:
                    break;
            }
        }

        private EndGameType ChangePlayer()
        {
            _xTurn = !_xTurn;
            _firstPlayerMove = !_firstPlayerMove;
            _moves++;

            return MoveIfComputer();
        }

        private EndGameType MoveIfComputer()
        {
            switch (_gameMode)
            {
                case GameModeType.PlayerVsComputer:
                    EnableBtnsEventHandler?.Invoke(_firstPlayerMove, null);
                    if (!_firstPlayerMove)
                    {
                        return Move(_playerManager2.NextMove(_moves));
                    }
                    break;
                case GameModeType.ComputerVsComputer:
                    if (_firstPlayerMove)
                    {
                        return Move(_playerManager1.NextMove(_moves));
                    }
                    return Move(_playerManager2.NextMove(_moves));
            }

            return EndGameType.NotEndYet;
        }
    }
}