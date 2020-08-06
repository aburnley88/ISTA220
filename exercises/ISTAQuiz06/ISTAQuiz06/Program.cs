using System;
using System.Threading;

namespace ISTA420Quiz05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cards = { 0, 1 , 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
            21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43,
            44, 45, 46, 47, 48, 49, 50, 51};



            Console.WriteLine("This is cards console.\n");

            Console.WriteLine("\n\n====================Initialize new deck=====================================================\n\n");

            for (int i = 0; i < cards.Length; i++)
            {
                CardValue(i);
            }

            Console.WriteLine("\n\n====================Deal deck=======================================================================");

            Deal(cards);



            void CardValue(int k)
            {
                switch (k)
                {
                    case 0:
                        Console.Write("2 of Clubs, ");
                        break;
                    case 1:
                        Console.Write("3 of Clubs, ");
                        break;
                    case 2:
                        Console.Write("4 of Clubs, ");
                        break;
                    case 3:
                        Console.Write("5 of Clubs, ");
                        break;
                    case 4:
                        Console.Write("6 of Clubs, ");
                        break;
                    case 5:
                        Console.Write("7 of Clubs, ");
                        break;
                    case 6:
                        Console.Write("8 of Clubs, ");
                        break;
                    case 7:
                        Console.Write("9 of Clubs, ");
                        break;
                    case 8:
                        Console.Write("10 of Clubs, ");
                        break;
                    case 9:
                        Console.Write("Jack of Clubs, ");
                        break;
                    case 10:
                        Console.Write("Queen of Clubs, ");
                        break;
                    case 11:
                        Console.Write("King of Clubs, ");
                        break;
                    case 12:
                        Console.Write("Ace of Clubs,  ");
                        break;
                    case 13:
                        Console.Write("2 of Diamonds, ");
                        break;
                    case 14:
                        Console.Write("3 of Diamonds, ");
                        break;
                    case 15:
                        Console.Write("4 of Diamonds, ");
                        break;
                    case 16:
                        Console.Write("5 of Diamonds, ");
                        break;
                    case 17:
                        Console.Write("6 of Diamonds, ");
                        break;
                    case 18:
                        Console.Write("7 of Diamonds, ");
                        break;
                    case 19:
                        Console.Write("8 of Diamonds, ");
                        break;
                    case 20:
                        Console.Write("9 of Diamonds, ");
                        break;
                    case 21:
                        Console.Write("10 of Diamonds, ");
                        break;
                    case 22:
                        Console.Write("Jack of Diamonds, ");
                        break;
                    case 23:
                        Console.Write("Queen of Diamonds, ");
                        break;
                    case 24:
                        Console.Write("King of Diamonds, ");
                        break;
                    case 25:
                        Console.Write("Ace of Diamonds,  ");
                        break;
                    case 26:
                        Console.Write("2 of Hearts, ");
                        break;
                    case 27:
                        Console.Write("3 of Hearts, ");
                        break;
                    case 28:
                        Console.Write("4 of Hearts, ");
                        break;
                    case 29:
                        Console.Write("5 of Hearts, ");
                        break;
                    case 30:
                        Console.Write("6 of Hearts, ");
                        break;
                    case 31:
                        Console.Write("7 of Hearts, ");
                        break;
                    case 32:
                        Console.Write("8 of Hearts, ");
                        break;
                    case 33:
                        Console.Write("9 of Hearts, ");
                        break;
                    case 34:
                        Console.Write("10 of Hearts, ");
                        break;
                    case 35:
                        Console.Write("Jack of Hearts, ");
                        break;
                    case 36:
                        Console.Write("Queen of Hearts, ");
                        break;
                    case 37:
                        Console.Write("King of Hearts, ");
                        break;
                    case 38:
                        Console.Write("Ace of Hearts,  ");
                        break;
                    case 39:
                        Console.Write("2 of Spades, ");
                        break;
                    case 40:
                        Console.Write("3 of Spades, ");
                        break;
                    case 41:
                        Console.Write("4 of Spades, ");
                        break;
                    case 42:
                        Console.Write("5 of Spades, ");
                        break;
                    case 43:
                        Console.Write("6 of Spades, ");
                        break;
                    case 44:
                        Console.Write("7 of Spades, ");
                        break;
                    case 45:
                        Console.Write("8 of Spades, ");
                        break;
                    case 46:
                        Console.Write("9 of Spades, ");
                        break;
                    case 47:
                        Console.Write("10 of Spades, ");
                        break;
                    case 48:
                        Console.Write("Jack of Spades, ");
                        break;
                    case 49:
                        Console.Write("Queen of Spades, ");
                        break;
                    case 50:
                        Console.Write("King of Spades, ");
                        break;
                    case 51:
                        Console.Write("Ace of Spades, \n\n");
                        break;

                }

            }
            int Suit(int deck)
            {
                int suit;


                suit = deck / 13;
                switch (suit)
                {
                    case 0:
                        Console.WriteLine("Clubs");
                        break;
                    case 1:
                        Console.WriteLine("Diamonds");
                        break;
                    case 2:
                        Console.WriteLine("Hearts");
                        break;
                    case 3:
                        Console.WriteLine("Spades");
                        break;
                }
                return suit;

            }
            int Hand(int deck)
            {
                int hand;


                hand = deck / 13;
                switch (hand)
                {
                    case 0:
                        Console.WriteLine("~~North~~");
                        break;
                    case 1:
                        Console.WriteLine("~~East~~");
                        break;
                    case 2:
                        Console.WriteLine("~~South~~");
                        break;
                    case 3:
                        Console.WriteLine("~~West~~");
                        break;
                }
                return hand;
            }
            int Value(int k)
            {
                int value;


                value = k % 13;
                switch (value)
                {
                    case 0:
                        Console.Write("2 of ");
                        break;
                    case 1:
                        Console.Write("3 of ");
                        break;
                    case 2:
                        Console.Write("4 of ");
                        break;
                    case 3:
                        Console.Write("5 of ");
                        break;
                    case 4:
                        Console.Write("6 of ");
                        break;
                    case 5:
                        Console.Write("7 of ");
                        break;
                    case 6:
                        Console.Write("8 of ");
                        break;
                    case 7:
                        Console.Write("9 of ");
                        break;
                    case 8:
                        Console.Write("10 of ");
                        break;
                    case 9:
                        Console.Write("Jack of ");
                        break;
                    case 10:
                        Console.Write("Queen of ");
                        break;
                    case 11:
                        Console.Write("King of ");
                        break;
                    case 12:
                        Console.Write("Ace of ");
                        break;
                }
                return value;

            }
            void Deal(int[] deck)
            {

                Random r = new Random();

                for (int i = 0; i <= deck.Length - 1; i++)
                {
                    int temp = r.Next(0, 51);
                    Value(temp);
                    Suit(temp);
                    Hand(temp);

                }




            }
        }
    }
}
