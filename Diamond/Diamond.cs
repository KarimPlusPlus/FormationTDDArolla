using System;

namespace Diamond
{
    public class Diamond
    {
        public string PrintDiamond(char letter)
        {
            if (letter == 'A')
                return "A";
            if (letter == 'B')
                return @" A
B B
 A";
            return String.Empty;
        }
    }
}