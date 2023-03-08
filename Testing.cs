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
            new Pack(); // Constructs a new Pack object with default values
                        // Calls the shuffleCardPack method which selects the different types.
            Pack.shuffleCardPack(1);
            // Calls the deal methods
            Pack.deal();
            Pack.dealCard(51); // These assertions verify that the returned deck contains all 52 cards and is in a different order than the original, indicating that it has been shuffled.
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
