namespace BowlingGame {
    class Program {
        private const int FRAME_SIZE = 10;

        static void Main(string[] args) {
            // Create a new game
            var game = new Game(FRAME_SIZE);
            // Create an instance of random
            Random random = new Random();
            // Roll the ball ten times for each of the ten frames
            for (int frame = 1; frame <= FRAME_SIZE; frame++) {
                Console.WriteLine("==========================================");
                Console.WriteLine($"Frame #{frame}");
                Console.WriteLine("==========================================");

                // Flag for special frame
                bool isSpecialFrame = frame == FRAME_SIZE;
                int rolls = isSpecialFrame ? 3 : 2;
                bool hasBonusRoll = false;
                while (rolls > 0) {
                    // Retrieve last roll
                    int lastRoll = rolls == 2 ? -1 : game.GetLastRoll();
                    // Generate random pin
                    int randomPin = random.Next(0, lastRoll >= 0 ? 11 - lastRoll : 11);
                    Console.WriteLine($"Pins knocked down on roll: {randomPin}");
                    // Roll
                    game.Roll(randomPin);

                    if (hasBonusRoll == false && isSpecialFrame)
                        hasBonusRoll = isSpecialFrame && game.IsStrike(game.GetCurrentRoll() - 1);

                    if ((randomPin == 10 && isSpecialFrame == false) ||
                        isSpecialFrame && rolls - 1 == 1 && !hasBonusRoll && !game.IsSpare(game.GetCurrentRoll() - 2)) {
                        break;
                    }

                    rolls--;
                }
            }

            // Print the final score
            Console.WriteLine("==========================================");
            Console.WriteLine("Your final score is: {0}", game.Score);
        }
    }
}




