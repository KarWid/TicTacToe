namespace TicTacToe.Models
{
    public class MoveWeightsResult
    {
        public int SetFivesWeight { get; set; }
        public int SetFoursWeight { get; set; }
        public int SetThirdsWeight { get; set; }
        public int SetTwoWeight { get; set; }

        public int BlockedFivesWeight { get; set; }
        public int BlockedFoursWeight { get; set; }
        public int BlockedThirdsWeight { get; set; }
        public int BlockedTwoWeight { get; set; }
    }
}