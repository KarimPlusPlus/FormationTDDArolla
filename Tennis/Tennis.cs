namespace Tennis
{
    public class Tennis
    {
        public string ComputeScore(int score)
        {
            switch (score)
            {
                case 0:
                    return "Love";

                case 1:
                    return "Fifteen";

                case 2:
                    return "Thirty";

                case 3:
                    return "Forty";
            }
            return string.Empty;
        }

        public string ShowScore(int scoreJoueur1, int scoreJoueur2)
        {
            if (scoreJoueur1 == 3 && scoreJoueur2 == 3)
            {
                return "Deuce";
            }
            else if (scoreJoueur1 == 3 && scoreJoueur2 == 4)
            {
                return "Thirty - Advantage";
            }
            else if (scoreJoueur1 == 4 && scoreJoueur2 == 3)
            {
                return "Advantage - Thirty";
            }
            return $"{ComputeScore(scoreJoueur1)} - {ComputeScore(scoreJoueur2)}";
        }
    }
}