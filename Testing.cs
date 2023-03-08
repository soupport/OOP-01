using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        static void main(string[] args)
        {
            new Pack(); // Constructs a new Pack with normal values
                        // Calls the shuffleCardPack method which selects the different types.
            Pack.shuffleCardPack(1);
            // Calls the dealing methods
            Pack.deal();
            Pack.dealCard(51); // Verifies that the returned deck contains 52 cards as well as being in a different order (shuffled).
            new Pack();
            Pack.shuffleCardPack(2);
            Pack.deal();
            Pack.dealCard(51);

            new Pack();
            Pack.shuffleCardPack(3);
            Pack.deal();
            Pack.dealCard(51);

            Console.Read();
        }
    }
}
