using System;

namespace ProjectPartB_B1
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards myDeck = new DeckOfCards();
            myDeck.CreateFreshDeck();
            Console.WriteLine($"\nA freshly created deck with {myDeck.Count} cards:");
            Console.WriteLine(myDeck);

            Console.WriteLine($"\nA sorted deck with {myDeck.Count} cards:");
            myDeck.Sort();
            Console.WriteLine(myDeck);

            Console.WriteLine($"\nA shuffled deck with {myDeck.Count} cards:");
            myDeck.Shuffle();
            Console.WriteLine(myDeck);

            HandOfCards player1 = new HandOfCards();
            HandOfCards player2 = new HandOfCards();


            int numberOfCards;
            while (!TryReadNrOfCards(out numberOfCards))
            {
                Console.WriteLine("Please enter a valid number of cards (1-5):");
            }

            int numberOfRounds;
            while (!TryReadNrOfRounds(out numberOfRounds))
            {
                Console.WriteLine("Please enter a valid number of rounds (1-5):");
            }

            //Your code to play the game comes here
        }

        /// <summary>
        /// Asking a user to give how many cards should be given to players.
        /// User enters an integer value between 1 and 5. 
        /// </summary>
        /// <param name="NrOfCards">Number of cards given by user</param>
        /// <returns>true - if value could be read and converted. Otherwise false</returns>
        private static bool TryReadNrOfCards(out int NrOfCards)
        {
          Console.Write("Enter number of cards (1-5): ");
            string input = Console.ReadLine();
            return int.TryParse(input, out NrOfCards) && NrOfCards >= 1 && NrOfCards <= 5;
        }

        /// <summary>
        /// Asking a user to give how many round should be played.
        /// User enters an integer value between 1 and 5. 
        /// </summary>
        /// <param name="NrOfRounds">Number of rounds given by user</param>
        /// <returns>true - if value could be read and converted. Otherwise false</returns>
        private static bool TryReadNrOfRounds(out int NrOfRounds)
        {
             Console.Write("Enter number of rounds (1-5): ");
            string input = Console.ReadLine();
            return int.TryParse(input, out NrOfRounds) && NrOfRounds >= 1 && NrOfRounds <= 5;
        }


        /// <summary>
        /// Removes from myDeck one card at the time and gives it to player1 and player2. 
        /// Repeated until players have recieved nrCardsToPlayer 
        /// </summary>
        /// <param name="myDeck">Deck to remove cards from</param>
        /// <param name="nrCardsToPlayer">Number of cards each player should recieve</param>
        /// <param name="player1">Player 1</param>
        /// <param name="player2">Player 2</param>
        private static void Deal(DeckOfCards myDeck, int nrCardsToPlayer, HandOfCards player1, HandOfCards player2)
        { }
        
        /// <summary>
        /// Determines and writes to Console the winner of player1 and player2. 
        /// Player with higest card wins. If both cards have equal value it is a tie.
        /// </summary>
        /// <param name="player1">Player 1</param>
        /// <param name="player2">Player 2</param>
        private static void DetermineWinner(HandOfCards player1, HandOfCards player2)
        { }
    }
}
