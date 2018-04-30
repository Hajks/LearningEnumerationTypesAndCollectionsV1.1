using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningEnumerationTypesAndCollectionsV1._1
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;

        public Player(String name, Random random, TextBox textBoxOnForm)
        {
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;// ???
        }
        public IEnumerable<Values> PullOutBooks()
        {
            List <Values> books = new List<Values>();
            for (int i = 1; i <= 13 ; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                    if (cards.Peek(card).Value == value)
                        howMany++;
                if (howMany == 4)
                {
                    books.Add(value);
                    for (int card = cards.Count - 1; card >= 0; card--)
                        cards.Deal(card);
                }
            }
            return books;
        }
        public Values GetRandomValue()
        {

        }
        public Deck DoYouHaveAny(Values value)
        {
            Deck myCards = cards.PullOutValues(value);
            tex
        }
    }
}
