namespace BowlingGame {
    public class Game {
        // An array to keep track of the number of pins knocked down on each roll
        private int[] rolls = new int[21];
        private int currentRoll = 0;

        // The Roll method simulates rolling a ball and knocks down a certain number of pins
        public void Roll(int pins) {
            rolls[currentRoll++] = pins;
        }

        // Retrieve current roll
        public int GetCurrentRoll() {
            return currentRoll;
        }

        // Retrieve last roll
        public int GetLastRoll() {
            return currentRoll > 0 ? rolls[currentRoll - 1] : -1;
        }

        // The Score method calculates and returns the total score
        public int Score {
            get {
                int score = 0;
                int frameIndex = 0;

                for (int frame = 0; frame < 10; frame++) {
                    // If the current frame is a strike
                    if (IsStrike(frameIndex)) {
                        // Add the total number of pins knocked down in the next two rolls to the current score
                        score += 10 + StrikeBonus(frameIndex);
                        frameIndex++;
                    } else if (IsSpare(frameIndex)) {
                        // Add the total number of pins knocked down in the next roll to the current score
                        score += 10 + SpareBonus(frameIndex);
                        frameIndex += 2;
                    } else {
                        // Add the total number of pins knocked down in the current frame to the score
                        score += SumOfBallsInFrame(frameIndex);
                        frameIndex += 2;
                    }
                }

                return score;
            }
        }

        // Helper methods to check if the current frame is a strike or a spare
        public bool IsStrike(int frameIndex) {
            return rolls[frameIndex] == 10;
        }

        public bool IsSpare(int frameIndex) {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }

        // Helper method to calculate the bonus for a strike
        private int StrikeBonus(int frameIndex) {
            return rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }

        // Helper method to calculate the bonus for a spare
        private int SpareBonus(int frameIndex) {
            return rolls[frameIndex + 2];
        }

        // Helper method to calculate the total number of pins knocked down in a frame
        private int SumOfBallsInFrame(int frameIndex) {
            return rolls[frameIndex] + rolls[frameIndex + 1];
        }
    }
}
