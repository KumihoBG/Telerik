using System;

/*
 * Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
 * The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds). 
 * The card faces should start from 2 to A.
 * Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
*/

class PrintDeckOfCards
{
    static void Main()
    {
        char cardSymbol = '\0';
        string[] cardSuits = { "spades","clubs","hearts","diamonds" };

        for(int cardIndex = 2; cardIndex <= 14;cardIndex++)
        {
            for(int i = 0; i < cardSuits.Length; i++)
            {
                if (cardIndex <= 10)
                {

                    Console.Write("{0} of {1} ", cardIndex, cardSuits[i]);
                }
                else
                {
                    switch(cardIndex)
                    {
                        case 11:
                            {
                                cardSymbol = 'J';
                                break;
                            }
                        case 12:
                            {
                                cardSymbol = 'Q';
                                break;
                            }

                        case 13:
                            {
                                cardSymbol = 'K';
                                break;
                            }

                        case 14:
                            {
                                cardSymbol = 'A';
                                break;
                            }
                    }

                    Console.Write("{0} of {1} ", cardSymbol, cardSuits[i]);
                }
            }

            Console.Write("\n");
        }
    }
}

