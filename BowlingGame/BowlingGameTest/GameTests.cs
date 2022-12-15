
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Tests {
    [TestClass]
    public class GameTests {
        private Game game;

        [TestInitialize]
        public void Setup() {
            game = new Game(10);
        }

        [TestMethod]
        public void TestGutterGame() {
            // Roll 20 times and knock down 0 pins on each roll
            RollMany(20, 0);

            // The final score should be 0
            Assert.AreEqual(0, game.Score);
        }

        [TestMethod]
        public void TestAllOnes() {
            // Roll 20 times and knock down 1 pin on each roll
            RollMany(20, 1);

            // The final score should be 20
            Assert.AreEqual(20, game.Score);
        }

        [TestMethod]
        public void TestOneSpare() {
            // Roll a spare on the first frame
            RollSpare();
            game.Roll(3);

            // Roll 17 times and knock down 0 pins on each roll
            RollMany(17, 0);

            // The final score should be 16
            Assert.AreEqual(16, game.Score);
        }

        [TestMethod]
        public void TestOneStrike() {
            // Roll a strike on the first frame
            RollStrike();
            game.Roll(3);
            game.Roll(4);

            // Roll 16 times and knock down 0 pins on each roll
            RollMany(16, 0);

            // The final score should be 24
            Assert.AreEqual(24, game.Score);
        }

        [TestMethod]
        public void TestGame() {
            // Roll 12 strikes
            RollMany(12, 10);

            // The final score should be 300
            Assert.AreEqual(300, game.Score);
        }

        // Helper methods to roll spares and strikes
        private void RollSpare() {
            game.Roll(5);
            game.Roll(5);
        }

        private void RollStrike() {
            game.Roll(10);
        }

        // Helper method to roll a number of times and knock down a certain number of pins each time
        private void RollMany(int rolls, int pins) {
            for (int i = 0; i < rolls; i++) {
                game.Roll(pins);
            }
        }
    }
}
