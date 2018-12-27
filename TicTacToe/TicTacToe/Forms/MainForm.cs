using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TicTacToe.Enums;
using TicTacToe.Managers;
using TicTacToe.Models;

namespace TicTacToe.Forms
{
    public partial class MainForm : Form
    {
        private const int MINIMUM_BOARD_SIZE = 5;

        private List<GameMode> _gameModes;

        public MainForm()
        {
            InitializeComponent();

            FormManager.ActualForm = this;

            InitializePrivateValues();
            InitializeGameModeListBox();
        }

        private void InitializePrivateValues()
        {
            _gameModes = new List<GameMode>();
            _gameModes.Add(new GameMode { Name = "Player vs Player", Type = GameModeType.PlayerVsPlayer });
            _gameModes.Add(new GameMode { Name = "Player vs Computer", Type = GameModeType.PlayerVsComputer });
            _gameModes.Add(new GameMode { Name = "Computer vs Computer", Type = GameModeType.ComputerVsComputer });
        }

        private void InitializeGameModeListBox()
        {
            if (_gameModes == null || _gameModes.Count == 0) return;

            GameModeListBox.Items.Add(_gameModes[0].Name);
            GameModeListBox.Items.Add(_gameModes[1].Name);
            GameModeListBox.Items.Add(_gameModes[2].Name);

            GameModeListBox.SetSelected(1, true);
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            var errorMessage = String.Empty;
            var gameModeType = GameModeType.ComputerVsComputer;

            var gameModeName = (string)GameModeListBox.SelectedItem;

            if (gameModeName == null)
            {
                errorMessage += "Choose mode game\n";
            }
            else
            {
                gameModeType = _gameModes.Where(x => x.Name == gameModeName).FirstOrDefault().Type;
            }

            int rows, columns;

            if (!Int32.TryParse(RowsTb.Text, out rows) || rows < MINIMUM_BOARD_SIZE) errorMessage += "Bad number of rows\n";
            if (!Int32.TryParse(ColumnsTb.Text, out columns) || columns < MINIMUM_BOARD_SIZE) errorMessage += "Bad number of columns";

            if (!String.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }

            var board = new BoardForm(gameModeType, rows, columns);
            board.Show();

            this.Hide();
        }
    }
}