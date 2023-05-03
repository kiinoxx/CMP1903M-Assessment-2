using System;
using System.Collections.Generic;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        private List<MathCard> pack;

        public Pack()
        {
            pack = new List<MathCard>();
            for (int i = 1; i <= 13; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    pack.Add(new MathCard(i, j));
                }
            }
            for (int i = 1; i <= 4; i++) // Adding operator cards
            {
                pack.Add(new MathCard(i, 5));
            }
        }

        public void ShuffleCardPack()
        {
            Random rand = new Random();
            for (int i = pack.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                MathCard temp = pack[i];
                pack[i] = pack[j];
                pack[j] = temp;
            }
        }

        public MathCard[] DealMathCards()
        {
            MathCard[] cards = new MathCard[3];
            cards[0] = DealNumberCard();
            cards[1] = DealOperatorCard();
            cards[2] = DealNumberCard();
            return cards;
        }

        private MathCard DealNumberCard()
        {
            MathCard card = null;
            while (card == null || card.IsOperator())
            {
                card = DealCard();
            }
            return card;
        }

        private MathCard DealOperatorCard()
        {
            MathCard card = null;
            while (card == null || !card.IsOperator())
            {
                card = DealCard();
            }
            return card;
        }

        private MathCard DealCard()
        {
            if (pack.Count > 0)
            {
                MathCard card = pack[0];
                pack.RemoveAt(0);
                return card;
            }
            else
            {
                return null;
            }
        }

        public List<MathCard> GetPack()
        {
            return pack;
        }
    }
}
