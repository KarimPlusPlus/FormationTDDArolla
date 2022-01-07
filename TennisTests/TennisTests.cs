using NFluent;
using Xunit;

namespace TennisTests
{
    public class TennisTests
    {
        [Fact]
        public void ComputeScore_Love()
        {
            var subject = new Tennis.Tennis();

            string result = subject.ComputeScore(0);

            Check.That(result).IsEqualTo("Love");
        }

        [Fact]
        public void ComputeScore_Fifteen()
        {
            var subject = new Tennis.Tennis();

            string result = subject.ComputeScore(1);

            Check.That(result).IsEqualTo("Fifteen");
        }

        [Fact]
        public void ComputeScore_Thirty()
        {
            var subject = new Tennis.Tennis();

            string result = subject.ComputeScore(2);

            Check.That(result).IsEqualTo("Thirty");
        }

        [Fact]
        public void ComputeScore_Forty()
        {
            var subject = new Tennis.Tennis();

            string result = subject.ComputeScore(3);

            Check.That(result).IsEqualTo("Forty");
        }

        [Fact]
        public void ShowScore_1_0()
        {
            var scoreJoueur1 = 1;
            var scoreJoueur2 = 0;
            var subject = new Tennis.Tennis();

            string result = subject.ShowScore(scoreJoueur1, scoreJoueur2);

            Check.That(result).IsEqualTo("Fifteen - Love");
        }

        [Fact]
        public void ShowScore_Deuce()
        {
            var scoreJoueur1 = 3;
            var scoreJoueur2 = 3;
            var subject = new Tennis.Tennis();

            string result = subject.ShowScore(scoreJoueur1, scoreJoueur2);

            Check.That(result).IsEqualTo("Deuce");
        }

        [Fact]
        public void ShowScore_Player1_Advantage()
        {
            var scoreJoueur1 = 4;
            var scoreJoueur2 = 3;
            var subject = new Tennis.Tennis();

            string result = subject.ShowScore(scoreJoueur1, scoreJoueur2);

            Check.That(result).IsEqualTo("Advantage - Thirty");
        }

        [Fact]
        public void ShowScore_Player2_Advantage()
        {
            var scoreJoueur1 = 3;
            var scoreJoueur2 = 4;
            var subject = new Tennis.Tennis();

            string result = subject.ShowScore(scoreJoueur1, scoreJoueur2);

            Check.That(result).IsEqualTo("Thirty - Advantage");
        }
    }
}