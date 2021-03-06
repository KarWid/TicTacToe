﻿using System;
using System.Drawing;
using System.Windows.Forms;
using TicTacToe.Enums;
using TicTacToe.Infrastructure.EvaluationFunctions.Concrete;
using TicTacToe.Managers;
using TicTacToe.Models;

namespace TicTacToe.Forms
{
    public partial class BoardForm : Form
    {
        private const int BUTTON_WIDTH = 40, BUTTON_HEIGHT = 40, WIN_CONDITION = 5;
        private const bool X_FIRST = true;

        private Button[,] _board;
        private GameManager _gameManager;
        private GameModeType _gameMode;
        MoveWeightsResult _moveWeightsResultPlayer1;
        MoveWeightsResult _moveWeightsResultPlayer2;
        private Color _defaultButtonBackColor;

        private int _rows, _columns, _depthSearch;

        public BoardForm()
        {
            InitializeComponent();
        }

        public BoardForm(GameModeType gameMode, int rows, int columns, int depthSearch, 
                         MoveWeightsResult moveWeightsResultPlayer1, MoveWeightsResult moveWeightsResultPlayer2)
        {
            InitializeComponent();

            FormManager.ActualForm = this;

            _gameMode = gameMode;
            _rows = rows;
            _columns = columns;
            _depthSearch = depthSearch;
            _moveWeightsResultPlayer1 = moveWeightsResultPlayer1;
            _moveWeightsResultPlayer2 = moveWeightsResultPlayer2;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            InitializeBoard();
            InitializeGameManager(_board);
        }

        private void InitializeBoard()
        {
            _board = new Button[_rows, _columns];

            for (int row = 0; row < _rows; row++)
            {
                for (int column = 0; column < _columns; column++)
                {
                    var button = new Button();

                    button.BackColor = SystemColors.ActiveCaption;
                    button.Location = new Point(column * BUTTON_WIDTH, row * BUTTON_HEIGHT);
                    button.Name = $"btn_{row}_{column}";
                    button.Size = new Size(BUTTON_WIDTH, BUTTON_HEIGHT);
                    button.TabIndex = 2;
                    button.TabStop = false;
                    button.Click += Button_Click;
                    button.Enabled = _gameMode != GameModeType.ComputerVsComputer;

                    _board[row, column] = button;
                    this.Controls.Add(button);
                }
            }

            if (GameModeType.ComputerVsComputer == _gameMode)
            {
                var button = new Button();

                button.Text = "Start";
                button.Size = new Size(100, 50);
                button.Click += StartButton_Click;
                button.Location = new Point((_columns + 1) * BUTTON_WIDTH, 0);

                this.Controls.Add(button);
            }

            _defaultButtonBackColor = _board[0, 0].BackColor;
        }

        private void InitializeGameManager(Button[,] board)
        {
            if (board == null)
            {
                Console.WriteLine("Board is null in Board Form");
            }

            var factory = new EvaluationFunctionFactory();

            var model = new GameManagerModel
            {
                GameMode = _gameMode,
                EvaluationFunctionFactory = factory,
                Rows = _rows,
                Columns = _columns,
                WinCondition = WIN_CONDITION,
                BoardLength = board.Length,
                XFirst = X_FIRST,
                DepthSearch = _depthSearch,
                MoveWeightsResultPlayer1 = _moveWeightsResultPlayer1,
                MoveWeightsResultPlayer2 = _moveWeightsResultPlayer2
            };

            _gameManager = new GameManager(model);
            _gameManager.EnableBtnsEventHandler += EnableButtons;
            _gameManager.ChangeBtnTextEventHandler += ChangeButtonText;
            _gameManager.EndGameMessagesEventHandler += GameManagerEndGameMessages;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            if (!String.IsNullOrEmpty(btn.Text))
            {
                return;
            }

            var splitName = btn.Name.Split('_');
            if (splitName.Length < 3) return;

            int x, y;

            if (!Int32.TryParse(splitName[1], out x)) return;
            if (!Int32.TryParse(splitName[2], out y)) return;

            var position = new Point(x, y);

            _gameManager.Move(position);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (_gameMode == GameModeType.ComputerVsComputer)
            {
                var btn = (Button)sender;
                btn.Hide();

                _gameManager.Start();
            }
        }

        private void EnableButtons(object sender, EventArgs e)
        {
            var enable = (bool)sender;

            for (int row = 0; row < _rows; row++)
            {
                for (int column = 0; column < _columns; column++)
                {
                    _board[row, column].Enabled = enable;
                }
            }
        }

        private void ChangeButtonText(object sender, ChangeBtnTextEventArgs e)
        {
            var button = _board[e.Position.X, e.Position.Y];

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    _board[i, j].BackColor = _defaultButtonBackColor;
                }
            }

            _board[e.Position.X, e.Position.Y].Text = e.Content;
            _board[e.Position.X, e.Position.Y].BackColor = Color.Yellow;
        }

        private void GameManagerEndGameMessages(object sender, EventArgs e)
        {
            var message = (string)sender;
            var result = MessageBox.Show(message);

            if (result == DialogResult.OK)
            {
                End();
            }
        }

        private void End()
        {
            FormManager.MainForm?.Show();
            FormManager.ActualForm?.Close();
        }
    }
}