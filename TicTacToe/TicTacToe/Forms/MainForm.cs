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

            int rows, columns, depthSearch;
            int blockedFivesWeightPlayer1, blockedFoursWeightPlayer1, blockedThirdsWeightPlayer1, blockedTwoWeightPlayer1; 
            int blockedFivesWeightPlayer2, blockedFoursWeightPlayer2, blockedThirdsWeightPlayer2, blockedTwoWeightPlayer2;
            int setFivesWeightPlayer1, setFoursWeightPlayer1, setThirdsWeightPlayer1, setTwoWeightPlayer1;
            int setFivesWeightPlayer2, setFoursWeightPlayer2, setThirdsWeightPlayer2, setTwoWeightPlayer2;

            if (!Int32.TryParse(RowsTb.Text, out rows) || rows < MINIMUM_BOARD_SIZE) errorMessage += "Bad number of rows\n";
            if (!Int32.TryParse(ColumnsTb.Text, out columns) || columns < MINIMUM_BOARD_SIZE) errorMessage += "Bad number of columns";
            if (!Int32.TryParse(DepthSearchTb.Text, out depthSearch) || depthSearch < 1) errorMessage += "Bad depth search";

            // player 1
            if (!Int32.TryParse(BlockedFivesWeightPlayer1Tb.Text, out blockedFivesWeightPlayer1) || blockedFivesWeightPlayer1 < 0) errorMessage += "Bad blocked Fives Weight Player 1";
            if (!Int32.TryParse(BlockedFourthWeightPlayer1Tb.Text, out blockedFoursWeightPlayer1) || blockedFoursWeightPlayer1 < 0) errorMessage += "Bad blocked Fours Weight Player 1";
            if (!Int32.TryParse(BlockedThirdsWeightPlayer1Tb.Text, out blockedThirdsWeightPlayer1) || blockedThirdsWeightPlayer1 < 0) errorMessage += "Bad blocked Thirds Weight Player 1";
            if (!Int32.TryParse(BlockedTwoWeightPlayer1Tb.Text, out blockedTwoWeightPlayer1) || blockedTwoWeightPlayer1 < 0) errorMessage += "Bad blocked Two Weight Player 1";

            if (!Int32.TryParse(SetFivesWeightPlayer1Tb.Text, out setFivesWeightPlayer1) || setFivesWeightPlayer1 < 0) errorMessage += "Bad set Fives Weight Player 1";
            if (!Int32.TryParse(SetFourthWeightPlayer1Tb.Text, out setFoursWeightPlayer1) || setFoursWeightPlayer1 < 0) errorMessage += "Bad set Fours Weight Player 1";
            if (!Int32.TryParse(SetThirdsWeightPlayer1Tb.Text, out setThirdsWeightPlayer1) || setThirdsWeightPlayer1 < 0) errorMessage += "Bad set Thirds Weight Player 1";
            if (!Int32.TryParse(SetTwoWeightPlayer1Tb.Text, out setTwoWeightPlayer1) || setTwoWeightPlayer1 < 0) errorMessage += "Bad set Two Weight Player 1";

            // player 2
            if (!Int32.TryParse(BlockedFivesWeightPlayer2Tb.Text, out blockedFivesWeightPlayer2) || blockedFivesWeightPlayer2 < 0) errorMessage += "Bad blocked Fives Weight Player 2";
            if (!Int32.TryParse(BlockedFourthWeightPlayer2Tb.Text, out blockedFoursWeightPlayer2) || blockedFoursWeightPlayer2 < 0) errorMessage += "Bad blocked Fours Weight Player 2";
            if (!Int32.TryParse(BlockedThirdsWeightPlayer2Tb.Text, out blockedThirdsWeightPlayer2) || blockedThirdsWeightPlayer2 < 0) errorMessage += "Bad blocked Thirds Weight Player 2";
            if (!Int32.TryParse(BlockedTwoWeightPlayer2Tb.Text, out blockedTwoWeightPlayer2) || blockedTwoWeightPlayer2 < 0) errorMessage += "Bad blocked Two Weight Player 2";

            if (!Int32.TryParse(SetFivesWeightPlayer2Tb.Text, out setFivesWeightPlayer2) || setFivesWeightPlayer2 < 0) errorMessage += "Bad set Fives Weight Player 2";
            if (!Int32.TryParse(SetFourthWeightPlayer2Tb.Text, out setFoursWeightPlayer2) || setFoursWeightPlayer2 < 0) errorMessage += "Bad set Fours Weight Player 2";
            if (!Int32.TryParse(SetThirdsWeightPlayer2Tb.Text, out setThirdsWeightPlayer2) || setThirdsWeightPlayer2 < 0) errorMessage += "Bad set Thirds Weight Player 2";
            if (!Int32.TryParse(SetTwoWeightPlayer2Tb.Text, out setTwoWeightPlayer2) || setTwoWeightPlayer2 < 0) errorMessage += "Bad set Two Weight Player 2";

            if (!String.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }

            MoveWeightsResult _moveWeightsResultPlayer1 = new MoveWeightsResult
            {
                BlockedFivesWeight = blockedFivesWeightPlayer1,
                BlockedFoursWeight = blockedFoursWeightPlayer1,
                BlockedThirdsWeight = blockedThirdsWeightPlayer1,
                BlockedTwoWeight = blockedTwoWeightPlayer1,
                SetFivesWeight = setFivesWeightPlayer1,
                SetFoursWeight = setFoursWeightPlayer1,
                SetThirdsWeight = setThirdsWeightPlayer1,
                SetTwoWeight = setTwoWeightPlayer1
            };

            MoveWeightsResult _moveWeightsResultPlayer2 = new MoveWeightsResult
            {
                BlockedFivesWeight = blockedFivesWeightPlayer2,
                BlockedFoursWeight = blockedFoursWeightPlayer2,
                BlockedThirdsWeight = blockedThirdsWeightPlayer2,
                BlockedTwoWeight = blockedTwoWeightPlayer2,
                SetFivesWeight = setFivesWeightPlayer2,
                SetFoursWeight = setFoursWeightPlayer2,
                SetThirdsWeight = setThirdsWeightPlayer2,
                SetTwoWeight = setTwoWeightPlayer2
            };

            var board = new BoardForm(gameModeType, rows, columns, depthSearch, _moveWeightsResultPlayer1, _moveWeightsResultPlayer2);
            board.Show();

            this.Hide();
        }
    }
}