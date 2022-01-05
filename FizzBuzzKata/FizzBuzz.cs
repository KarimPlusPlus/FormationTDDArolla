namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        private const string FIZZ = "FIZZ";
        private const string BUZZ = "BUZZ";
        private const string FIZZBUZZ = "FIZZBUZZ";

        public string Process(int number)
        {
            var isDivisibleBy3 = (number % 3) == 0;
            var isDivisibleBy5 = (number % 5) == 0;

            if (isDivisibleBy3 && isDivisibleBy5)
            {
                return FIZZBUZZ;
            }
            else if (isDivisibleBy3)
            {
                return FIZZ;
            }
            else if (isDivisibleBy5)
            {
                return BUZZ;
            }

            return $"{number}";
        }
    }
}