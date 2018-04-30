using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEnumerationTypesAndCollectionsV1._1
{
    public enum Suits
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts,
    }
    public enum Values
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }
    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public string Name
        {
            get
            {
                return names[(int)Value] + " " + suits[(int)Suit];
            }
        }
        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        private static string[] names0 = new string[]
        {
            "", "asów", "dwójek", "trójek", "czwrórek", "piątek", "szóstek", "siódemek", "ósemek", "dziewiątek", "dziesiątek", "waletów", "dam", "króli"
        };
        private static string[] names1 = new string[]
        {
            "", "asa", "dwójkę", "trójkę", "czwórkę", "piątke", "szóstkę", "siódemkę", "ósemkę", "dziewiątkę", "dziesiątkę", "waleta", "damę", "króla"
        };
        private static string[] names2AndMore = new string[]
        {
            "", "asy", "dwójki", "trójki", "czwórki", "piątki", "szóstki", "siódemki", "ósemki", "dziewiątki", "dziesiątki", "walety", "damy", "króle"
        };
        public static string Plural (Values value, int count)
        {
            if (count == 0)
                return names0[(int)value];
            if (count == 1)
                return names1[(int)value];
            return names2AndMore[(int)value];
        }
        private static string[] suits = new string[] { "pik", "trefl", "karo", "ker" };
        private static string[] names = new string[]
        {
            "", "As", "Dwójka", "Trójka", "Czwórka", "Piątka", "Szóstka", "Siódemka", "Ósemka", "Dziewątka", "Dziesiątka", "Walet", "Dama", "Król" };

    }
}
