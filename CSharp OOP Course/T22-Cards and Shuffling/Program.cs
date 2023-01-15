using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T22
{
    public enum Suite
    {
        Spade,
        Heart,
        Diamond,
        Club
    }

    public enum Values 
    {
        A,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eighth,
        Nine,
        Ten,
        J,
        Q,
        K                
    }

   

    public class Card
    {
        public Suite Suite { get; set; }
        public Values Value { get; set; }
               

        public Card() { }

        public Card(Suite suite, Values Value)
        {
            this.Suite = suite;
            this.Value = Value;

        }

        public virtual string ToString()
        {
            return Suite + " # " + Value;
        }

    }

    public class Deck
    {
        // properties of the deck
        private List<Card> cards = new List<Card>(); //

        public List<Card> Cards { get { return cards; } }

        public List<Card> ShuffledDeck { get { return shuffledDeck; } }
        private List<Card> shuffledDeck = new List<Card>();

        // constructor
        public Deck()
        {
            // Add 52 cards to this deck
            foreach (Suite s in Enum.GetValues(typeof(Suite)))
            {
                foreach(Values v in Enum.GetValues(typeof(Values)))
                {
                    cards.Add(new Card(s, v));
                    
                }
                
            }
        }
        
    }
 
    internal class Program
    {
        static void TestDeck()
        {
            Deck deck = new Deck();
            Console.WriteLine("\n-------\n Deck\n-------\n");
            foreach (Card item in deck.Cards)
            {
                Console.WriteLine(item.ToString());
            }

            Random rnd = new Random();

            for (var i = deck.Cards.Count - 1; i > 0; i--)
            {
                var card = deck.Cards[i];             
                var index = rnd.Next(0, i + 1);
                deck.Cards[i] = deck.Cards[index];
                deck.Cards[index] = card;
            }

            // Multiple Shuffles can be done by uncommenting

            //for (var i = deck.Cards.Count - 1; i > 0; i--)
            //{
            //    var card = deck.Cards[i];
            //    var index = rnd.Next(0, i + 1);
            //    deck.Cards[i] = deck.Cards[index];
            //    deck.Cards[index] = card;
            //}

            //for (var i = deck.Cards.Count - 1; i > 0; i--)
            //{
            //    var card = deck.Cards[i];
            //    var index = rnd.Next(0, i + 1);
            //    deck.Cards[i] = deck.Cards[index];
            //    deck.Cards[index] = card;
            //}

            Console.WriteLine("\n--------\nShuffled\n--------\n");
            foreach (Card item in deck.Cards)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static void Main(string[] args)
        {
            TestDeck();       
        }
    }
}
