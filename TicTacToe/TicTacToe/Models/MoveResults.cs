namespace TicTacToe.Models
{
    public class MoveResults
    {
        public int SetFivesNumber { get; set; }
        public int SetFoursNumber { get; set; }
        public int SetThirdsNumber { get; set; }
        public int SetTwoNumber { get; set; }

        public int BlockedFivesNumber { get; set; }
        public int BlockedFoursNumber { get; set; }
        public int BlockedThirdsNumber { get; set; }
        public int BlockedTwoNumber { get; set; }

        public static int operator* (MoveResults moveResults, MoveWeightsResult moveWeightsResult)
        {
            int result = 0;

            result += moveResults.BlockedFivesNumber * moveWeightsResult.BlockedFivesWeight;
            result += moveResults.BlockedFoursNumber * moveWeightsResult.BlockedFoursWeight;
            result += moveResults.BlockedThirdsNumber * moveWeightsResult.BlockedThirdsWeight;
            result += moveResults.BlockedTwoNumber * moveWeightsResult.BlockedTwoWeight;

            result += moveResults.SetFivesNumber * moveWeightsResult.SetFivesWeight;
            result += moveResults.SetFoursNumber * moveWeightsResult.SetFoursWeight;
            result += moveResults.SetThirdsNumber * moveWeightsResult.SetThirdsWeight;
            result += moveResults.SetTwoNumber * moveWeightsResult.SetTwoWeight;

            return result;
        }
    }
}