﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Deck
{
    public abstract class DeckBase
    {
        //Using a List because I need a concept of order and indexing      
        internal List<CardBase> Cards = new List<CardBase>();

        //https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
        public void Shuffle()
        {
            var randy = new Random();
            for (int i = 0; i < Count - 1; i++)
            {
                var offset = randy.Next(Count - i);
                var t = Cards[i];
                Cards[i] = Cards[i + offset];
                Cards[i + offset] = t;
            }
        }

        //If I had more time to work on this, I'd do something fun here like implementing a bunch of sort algorithms and calling a delegate.
        public void Sort()
        {
            Cards.Sort();
        }

        public int Count { get { return Cards.Count(); } }

        public CardBase GetNext()
        {
            if (Count == 0) return null;
            var ret = Cards[0];
            Cards.RemoveAt(0);
            return ret;
        }

        public void PutOnBottom(CardBase c)
        {
            Cards.Add(c);           
        }

        public override string ToString()
        {
            return string.Join(",", Cards);
        }

        internal bool IsSorted()
        {
            if (Count < 2) return true;
            var sorted = true;
            for (int i = 0; i < Count - 1; i++)
            {
                if (Cards[i].CompareTo(Cards[i + 1]) > 0) 
                    sorted = false;
            }
            return sorted;
        }


    }
}
