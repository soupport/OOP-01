using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public static List<Card> pack;

        public Pack()
        {
            //Begin the card pack here
            pack = new List<Card>();
            for (int i = 1; i <= 52; i++) {
                int v = 0;
                int s = 0;
                if (i % 13 == 0) // This prevents certain values from being set to 0 and the suit of a card from being set to -1.
                {
                    v = 13;
                    s = i / 13;
                }
              else
                {
                    v = i % 13;
                    s = (i / 13) + 1;
                }
                pack.Add(new Card() // This enhances the list (deck) by providing value and an appropriate fit.
                {
                    Value = (v),
                    Suit = (s),

            });
            }
            Console.WriteLine("The Pack was created");

        } 
        

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Rearrange the deck of cards depending on the type of shuffle.
            if (typeOfShuffle == 1) // The Fisher-Yates Shuffle
            {
                Console.WriteLine("The Fisher-Yates Shuffle");
                // Starting from the back of the deck, this comment swaps list items with a random item before itself.
                for (int i = (pack.Count - 1); (i > 1); i--) {
                    int j = new Random().Next(0, i);
                    Card temp = pack[j];
                    pack[j] = pack[i];
                    pack[i] = temp;
                }

                return true;
            }
            else if (typeOfShuffle == 2) // The Riffle Shuffle
            {
                Console.WriteLine("The Riffle Shuffle");
                List<Card> list1 = new List<Card>();
                List<Card> list2 = new List<Card>();
                for (int i = 0; (i < 52); i++)
                {
                    if (i < 26)
                    {
                        list1.Add(pack[i]); 
                    }
                    else
                    {
                        list2.Add(pack[i]);  
                    }
                }
                pack.Clear(); // Start at one end of the pack and take alternating cards, adding them one at a time to the back of the pack, as if performing a riffle shuffle.
                for (int i = 0; (i < 26); i++)
                {
                    pack.Add(list1[i]);
                    pack.Add(list2[i]);
                }

                    return true;
            }
            else if (typeOfShuffle == 3) // Completely No Shuffle
            {
                Console.WriteLine("Completely no shuffle");
                return true;
            }
            Console.WriteLine("Invalid input");
            return false; // If input is not valid, ask user to enter another input
        }

        public static Card deal()
        {

            // Deals one card
            Card dealt = pack[0];
            pack.RemoveAt(0);
            Console.WriteLine("Dealt: (V S) " + dealt.Value +" "+ dealt.Suit);
            Console.WriteLine("Dealt 1 card!");
            return dealt;

            // Both deal types only process the first value of a given set and ignore any repeat values.
            // Removes cards from the deck after each draw to allow for multiple draws to be looped if needed.
        }
        public static List<Card> dealCard(int amount)
        {
            // Deals 'amount' cards to players
            List<Card> dealt = new List<Card>();
            for (int i = 0; i < amount; i++) {
                dealt.Add(pack[0]);
                pack.RemoveAt(0);
                Console.WriteLine("Dealt: (V S) " + dealt[i].Value + " " + dealt[i].Suit);
            }

            Console.WriteLine("Dealt " + amount + " cards!");
            return dealt;

        }

    }
}
