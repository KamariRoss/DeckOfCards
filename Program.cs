using System;
using System.Collections.Generic;

namespace DeckOfCards
{
  class Program
  {
    static void Main(string[] args)
    {

      bool flag = true;
      while (flag)
      {

        Console.WriteLine("Lets play cards");

        var deckOfCards = new List<string>();

        // 1. Make a list called cardValues that has 2,3,4,5,6,7,8,9,10,jack,queen,king,ace
        var cardValues = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        // 2. Make a list called cardSymbol that has clubs, hearts, spades, diamonds
        var cardSymbol = new List<string>() { "Spades", "Hearts", "Clovers", "Diamonds" };

        // for(...BEFORE THE LOOP STARTS... ;  ... SHOULD WE KEEP GOING ...; ... DO THIS AFTER EACH TIME INSIDE THE LOOP ... )
        // 3. Start with the first entry from the suits list, clubs
        // 4. // for ( …. Something with the suites ….)
        for (int i = 0; i < cardSymbol.Count; i++)
        {
          var currentSymbol = cardSymbol[i];
          //   Console.WriteLine(currentSymbol);

          // 5. Go through each value from our values list
          // 6. // for (….. something with the values ….)
          for (int j = 0; j < cardValues.Count; j++)
          {
            var currentValue = cardValues[j];
            var cardReader = $"The card you drew was { currentValue} of { currentSymbol}";

            deckOfCards.Add(cardReader);
          }
        }


        var rnd = new Random();

        // Add the shuffle
        // for i from n - 1 down to 1 do:
        for (int deckCountDownIndex = deckOfCards.Count - 1; deckCountDownIndex >= 1; deckCountDownIndex--)
        {
          //   randomIndex = random integer (where 0 <= randomIndex <= i)
          var randomIndex = rnd.Next(deckCountDownIndex);
          //   swap deckOfCards[deckCountDownIndex] with deckOfCards[randomIndex]
          var cardOnTheRight = deckOfCards[deckCountDownIndex];
          var cardOnTheLeft = deckOfCards[randomIndex];

          deckOfCards[deckCountDownIndex] = cardOnTheLeft;
          deckOfCards[randomIndex] = cardOnTheRight;
        }

        var topcard = deckOfCards[0];
        Console.WriteLine($"Your card is{topcard}");

        //Demonstrate usage of arrays to model resources
        //Understand and implement algorithms
        //understand loops
        //our deck should contain 52 unique cards.
        // All cards should be represented as as string such as "Ace of Hearts"
        // There are four suits: "Clubs", "Diamonds", "Hearts", and "Spades".
        // There are 13 ranks: "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", and "King".
        // You will model these in code, in any way you see fit. It may require you to experiment and try a number of techniques. There are many valid solutions.
        // To shuffle the cards, you should implement the Fisher–Yates shuffle algorithm:
        // For our purposes, n is 52:
        /*for i from n - 1 down to 1 do:
              j = random integer (where 0 <= j <= i)
              swap items[i] with items[j] */
        // hint: really understand the algorithm before you try to implement it.
        //Once the program starts, you should create a new deck.
        //After deck creation, you should shuffle the deck using Fisher–Yates shuffle algorithm.
        //After the deck is shuffled, display the top card.
        //Give the user an option to see the next card or quit the program.

        Console.WriteLine("Would you like to shuffle cards agian? 'yes or 'no");
        string playAgain = null;
        playAgain = Console.ReadLine().ToLower();
        if (playAgain == "no")
          flag = false;

      }
    }
  }
}
