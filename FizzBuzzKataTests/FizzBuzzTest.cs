using NFluent;
using Xunit;

namespace FizzBuzzKataTests
{
    public class FizzBuzzTest
    {
        private const string FIZZ = "FIZZ";
        private const string BUZZ = "BUZZ";
        private const string FIZZBUZZ = "FIZZBUZZ";

        [Fact]
        public void ShouldReturnFizzFor3()
        {
            var subject = new FizzBuzzKata.FizzBuzz();

            var result = subject.Process(3);

            Check.That(result).Equals(FIZZ);
        }

        [Fact]
        public void ShouldReturnBuzz5()
        {
            var subject = new FizzBuzzKata.FizzBuzz();

            var result = subject.Process(5);

            Check.That(result).Equals(BUZZ);
        }

        [Fact]
        public void ShouldReturnFizzBuzz15()
        {
            var subject = new FizzBuzzKata.FizzBuzz();

            var result = subject.Process(15);

            Check.That(result).Equals(FIZZBUZZ);
        }

        [Fact]
        public void ShouldReturnTheNumberFor1()
        {
            var number = 1;
            var subject = new FizzBuzzKata.FizzBuzz();

            var result = subject.Process(number);

            var expectedResult = $"{number}";
            Check.That(result).Equals(expectedResult);
        }
    }
}