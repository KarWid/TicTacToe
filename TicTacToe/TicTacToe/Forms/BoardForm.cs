using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Enums;
using TicTacToe.Managers;

namespace TicTacToe.Forms
{
    public partial class BoardForm : Form
    {
        private const int BUTTON_WIDTH = 40, BUTTON_HEIGHT = 40, WIN_CONDITION = 5;
        private const bool X_FIRST = true;

        private Button[,] _board;
        private GameManager _gameManager;
        private GameModeType _gameMode;

        private int _rows, _columns;

        public BoardForm()
        {
            InitializeComponent();
        }

        public BoardForm(GameModeType gameMode, int rows, int columns)
        {
            InitializeComponent();

            FormManager.ActualForm = this;

            _gameMode = gameMode;
            _rows = rows;
            _columns = columns;
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
        }

        private void InitializeGameManager(Button[,] board)
        {
            if (board == null)
            {
                Console.WriteLine("Board is null in Board Form");
            }

            _gameManager = new GameManager(_gameMode, _rows, _columns, board, WIN_CONDITION, X_FIRST);
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
    }
}