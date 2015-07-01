using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck
{
    public abstract class CardBase : IComparable
    {
        public abstract int CompareTo(object obj);
    }
}
