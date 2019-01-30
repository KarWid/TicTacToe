using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe.Helpers;

namespace TicTacToe.Tests
{
    [TestClass]
    public class BoardHelperTest
    {
        [TestMethod]
        public void CheckRightToLeftDownDiagonalByLastMove1()
        {
            // prepare data
            int rows = 10, columns = 10;
            int numberPlayer = 1;
            int[,] board = new int[rows, columns];
            Point move = new Point(5, 5);

            board[4, 6] = numberPlayer;
            board[5, 5] = numberPlayer;
            board[6, 4] = numberPlayer;

            // do actions
            var result = BoardHelper.CheckRightToLeftDownDiagonalByLastMoveSetCombo(board, rows, columns, move, numberPlayer);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void CheckRightToLeftDownDiagonalByLastMove2()
        {
            // prepare data
            int rows = 10, columns = 10;
            int numberPlayer = 1;
            int[,] board = new int[rows, columns];
            Point move = new Point(5, 5);

            board[4, 6] = numberPlayer;
            board[5, 5] = numberPlayer;
            board[7, 3] = numberPlayer;

            // do actions
            var result = BoardHelper.CheckRightToLeftDownDiagonalByLastMoveSetCombo(board, rows, columns, move, numberPlayer);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CheckLeftToRightDownDiagonalByLastMove1()
        {
            // prepare data
            int rows = 10, columns = 10;
            int numberPlayer = 1;
            int[,] board = new int[rows, columns];
            Point move = new Point(5, 5);

            board[4, 4] = numberPlayer;
            board[5, 5] = numberPlayer;
            board[6, 6] = numberPlayer;

            // do actions
            var result = BoardHelper.CheckLeftToRightDownDiagonalByLastMoveSetCombo(board, rows, columns, move, numberPlayer);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void CheckLeftToRightDownDiagonalByLastMove2()
        {
            // prepare data
            int rows = 10, columns = 10;
            int numberPlayer = 1;
            int[,] board = new int[rows, columns];
            Point move = new Point(5, 5);

            board[4, 4] = numberPlayer;
            board[5, 5] = numberPlayer;
            board[7, 7] = numberPlayer;

            // do actions
            var result = BoardHelper.CheckLeftToRightDownDiagonalByLastMoveSetCombo(board, rows, columns, move, numberPlayer);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CheckRowByLastMove1()
        {
            // prepare data
            int rows = 10, columns = 10;
            int numberPlayer = 1;
            int[,] board = new int[rows, columns];
            Point move = new Point(4, 5);

            board[4, 4] = numberPlayer;
            board[4, 5] = numberPlayer;
            board[4, 6] = numberPlayer;

            // do actions
            var result = BoardHelper.CheckRowByLastMoveSetCombo(board, rows, columns, move, numberPlayer);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void CheckRowByLastMove2()
        {
            // prepare data
            int rows = 10, columns = 10;
            int numberPlayer = 1;
            int[,] board = new int[rows, columns];
            Point move = new Point(4, 5);

            board[4, 4] = numberPlayer;
            board[4, 5] = numberPlayer;
            board[4, 7] = numberPlayer;

            // do actions
            var result = BoardHelper.CheckRowByLastMoveSetCombo(board, rows, columns, move, numberPlayer);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CheckColumnByLastMove1()
        {
            // prepare data
            int rows = 10, columns = 10;
            int numberPlayer = 1;
            int[,] board = new int[rows, columns];
            Point move = new Point(5, 5);

            board[4, 5] = numberPlayer;
            board[5, 5] = numberPlayer;
            board[6, 5] = numberPlayer;

            // do actions
            var result = BoardHelper.CheckColumnByLastMoveSetCombo(board, rows, columns, move, numberPlayer);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void CheckColumnByLastMove2()
        {
            // prepare data
            int rows = 10, columns = 10;
            int numberPlayer = 1;
            int[,] board = new int[rows, columns];
            Point move = new Point(5, 5);

            board[4, 5] = numberPlayer;
            board[5, 5] = numberPlayer;
            board[7, 5] = numberPlayer;

            // do actions
            var result = BoardHelper.CheckColumnByLastMoveSetCombo(board, rows, columns, move, numberPlayer);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CheckRightToLeftDownDiagonalByLastMoveBlock1()
        {
            // prepare data
            int rows = 10, columns = 10;
            int numberPlayer = 1;
            int enemyPlayer = 2;
            int[,] board = new int[rows, columns];
            Point move = new Point(5, 5);

            board[3, 7] = enemyPlayer;
            board[4, 6] = enemyPlayer;
            board[5, 5] = numberPlayer;
            board[6, 4] = enemyPlayer;
            board[7, 3] = enemyPlayer;

            // do actions
            var result = BoardHelper.CheckRightToLeftDownDiagonalByLastMoveBlockCombo(board, rows, columns, move, numberPlayer);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void CheckRightToLeftDownDiagonalByLastBlock2()
        {
            // prepare data
            int rows = 10, columns = 10;
            int numberPlayer = 1;
            int enemyPlayer = 2;
            int[,] board = new int[rows, columns];
            Point move = new Point(5, 5);

            board[3, 7] = enemyPlayer;
            board[4, 6] = enemyPlayer;
            board[5, 5] = numberPlayer;
            board[7, 3] = enemyPlayer;
            board[8, 2] = enemyPlayer;


            // do actions
            var result = BoardHelper.CheckRightToLeftDownDiagonalByLastMoveBlockCombo(board, rows, columns, move, numberPlayer);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CheckLeftToRightDownDiagonalByLastMoveBlock1()
        {
            // prepare data
            int rows = 10, columns = 10;
            int numberPlayer = 1;
            int enemyPlayer = 2;
            int[,] board = new int[rows, columns];
            Point move = new Point(5, 5);

            board[3, 3] = enemyPlayer;
            board[4, 4] = enemyPlayer;
            board[5, 5] = numberPlayer;
            board[6, 6] = enemyPlayer;
            board[7, 7] = enemyPlayer;

            // do actions
            var result = BoardHelper.CheckLeftToRightDownDiagonalByLastMoveBlockCombo(board, rows, columns, move, numberPlayer);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void CheckLeftToRightDownDiagonalByLastMoveBlock2()
        {
            // prepare data
            int rows = 10, columns = 10;
            int numberPlayer = 1;
            int enemyPlayer = 2;
            int[,] board = new int[rows, columns];
            Point move = new Point(5, 5);

            board[3, 3] = enemyPlayer;
            board[4, 4] = enemyPlayer;
            board[5, 5] = numberPlayer;
            board[7, 7] = enemyPlayer;
            board[8, 8] = enemyPlayer;

            // do actions
            var result = BoardHelper.CheckLeftToRightDownDiagonalByLastMoveBlockCombo(board, rows, columns, move, numberPlayer);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CheckRowByLastMoveBlock1()
        {
            // prepare data
            int rows = 10, columns = 10;
            int numberPlayer = 1;
            int enemyPlayer = 2;
            int[,] board = new int[rows, columns];
            Point move = new Point(5, 5);

            board[5, 3] = enemyPlayer;
            board[5, 4] = enemyPlayer;
            board[5, 5] = numberPlayer;
            board[5, 6] = enemyPlayer;
            board[5, 7] = enemyPlayer;

            // do actions
            var result = BoardHelper.CheckRowByLastMoveBlockCombo(board, rows, columns, move, numberPlayer);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void CheckRowByLastMoveBlock2()
        {
            // prepare data
            int rows = 10, columns = 10;
            int numberPlayer = 1;
            int enemyPlayer = 2;
            int[,] board = new int[rows, columns];
            Point move = new Point(5, 5);

            board[5, 3] = enemyPlayer;
            board[5, 4] = enemyPlayer;
            board[5, 5] = numberPlayer;
            board[5, 7] = enemyPlayer;
            board[5, 8] = enemyPlayer;

            // do actions
            var result = BoardHelper.CheckRowByLastMoveBlockCombo(board, rows, columns, move, numberPlayer);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CheckColumnByLastMoveBlock1()
        {
            // prepare data
            int rows = 10, columns = 10;
            int numberPlayer = 1;
            int enemyPlayer = 2;
            int[,] board = new int[rows, columns];
            Point move = new Point(5, 5);

            board[3, 5] = enemyPlayer;
            board[4, 5] = enemyPlayer;
            board[5, 5] = numberPlayer;
            board[6, 5] = enemyPlayer;
            board[7, 5] = enemyPlayer;

            // do actions
            var result = BoardHelper.CheckColumnByLastMoveBlockCombo(board, rows, columns, move, numberPlayer);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void CheckColumnByLastMoveBlock2()
        {
            // prepare data
            int rows = 10, columns = 10;
            int numberPlayer = 1;
            int enemyPlayer = 2;
            int[,] board = new int[rows, columns];
            Point move = new Point(5, 5);

            board[3, 5] = enemyPlayer;
            board[4, 5] = enemyPlayer;
            board[5, 5] = numberPlayer;
            board[7, 5] = enemyPlayer;
            board[8, 5] = enemyPlayer;

            // do actions
            var result = BoardHelper.CheckColumnByLastMoveBlockCombo(board, rows, columns, move, numberPlayer);

            Assert.AreEqual(2, result);
        }
    }
}