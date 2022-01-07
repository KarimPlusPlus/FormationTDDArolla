using NFluent;
using Xunit;

namespace DiamondKataTests
{
    public class DiamondKataTests

    {
        [Fact]
        public void Diamond_A()
        {
            var subject = new Diamond.Diamond();

            var result = subject.PrintDiamond('A');

            Check.That(result).IsEqualTo("A");
        }

        [Fact]
        public void Diamond_B()
        {
            var expectedResult = " A\r\nB B\r\n A";
            var subject = new Diamond.Diamond();

            var result = subject.PrintDiamond('B');
            var a = (int)'A';
            var b = (int)'B';
            var c = (int)'C';
            Check.That(result).IsEqualTo(expectedResult);

        }
    }
}

//A

//-A
//B-B
//-A

//22A
//1B1B
//C333C
//1B1B
//22A

//333A
//22B22B
//C55555C
//22B22B
//333A
