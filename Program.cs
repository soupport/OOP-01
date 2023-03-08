using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            new Pack(); // Create deck
            bool valid = false;
            while (!valid)
            {
                Console.Write("Shuffle type: ");
                string num = Console.ReadLine();
                // Convert user input to integer, if not, ask the user for input again.
                try
                {
                    int shuffleType = Convert.ToInt32(num);
                    valid = Pack.shuffleCardPack(shuffleType);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input an integer :(");
                }

            };

            int cards = 0;
            while (cards < 1 | cards > (Pack.pack.Count)) // Validates deck size range
            {
                Console.WriteLine("Deck size: " + Pack.pack.Count);
                Console.Write("How many people do you want to deal to: ");
                string dealnum = Console.ReadLine();
                try
                {
                    cards = Convert.ToInt32(dealnum);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input an integer :(");
                }
            }

            // Switch statement based on numCards
            if (cards == 1)
            {
                Pack.deal();
            }
            else
            {
                Pack.dealCard(cards);
            }

            Console.Read();
        }
    }
}
