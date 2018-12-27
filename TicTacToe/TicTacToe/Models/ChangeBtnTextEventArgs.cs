using System;
using System.Drawing;

namespace TicTacToe.Models
{
    public class ChangeBtnTextEventArgs : EventArgs
    {
        public Point Position { get; private set; }
        public string Content { get; private set; }

        public ChangeBtnTextEventArgs(Point position, string content)
        {
            Position = position;
            Content = content;
        }
    }
}