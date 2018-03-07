using System;
using System.Collections.Generic;
using System.Text;

namespace Comparator
{
    public class Domino : IComparable
    {
        public int[] Values;

        public Domino(int valueA, int valueB)
        {
            Values = new int[] { valueA, valueB };
        }

        public int[] GetValues()
        {
            return Values;
        }

        public int CompareTo(object obj)
        {
            return Values[0].CompareTo(((Domino)obj).Values[0]);
        }
    }
}