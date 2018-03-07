using System;
using System.Collections.Generic;
using System.Text;

namespace Comparator
{
    class Thing : IComparable
    {
        private string Name;
        private bool Completed;

        public Thing(string name)
        {
            Name = name;
        }

        public void Complete()
        {
            Completed = true;
        }

        public int CompareTo(object obj)
        {
            return Completed.CompareTo(((Thing)obj).Completed);
        }

    }
}
