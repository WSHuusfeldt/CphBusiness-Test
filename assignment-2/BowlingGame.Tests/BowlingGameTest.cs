using System;
using Xunit;

namespace BowlingGame.Tests
{
    public class BowlingGameTest
    {
        private BowlingGame g = new BowlingGame();

        private void rollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                g.roll(pins);
            }
        }

        [Fact]
        public void TestGutterGame()
        {
            rollMany(20, 0);
            Assert.Equal(0, g.score());
        }

        [Fact]
        public void testAllOnes()
        {
            rollMany(20, 1);
            Assert.Equal(20, g.score());
        }

        [Fact]
        public void testOneStrike()
        {
            rollStrike();
            g.roll(3);
            g.roll(4);
            rollMany(16, 0);
            Assert.Equal(24, g.score());
        }

        [Fact]
        public void testOneSpare()
        {
            rollSpare();
            g.roll(3);
            rollMany(17, 0);
            Assert.Equal(16, g.score());
        }

        [Fact]
        public void testPerfectGame()
        {
            rollMany(12, 10);
            Assert.Equal(300, g.score());
        }


        private void rollStrike()
        {
            g.roll(10);
        }

        private void rollSpare()
        {
            g.roll(5);
            g.roll(5);
        }
    }
}
