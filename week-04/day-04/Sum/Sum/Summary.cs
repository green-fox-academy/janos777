using System;
using System.Collections.Generic;
using System.Text;

namespace Sum
{
    public class Summary
    {
        public int Summed(List<int> numbers)
        {
            int result = 0;

            try
            {
                foreach (var item in numbers)
                {
                    result += item;
                }

                return result;
            }
            
            catch (NullReferenceException error)
            {
                throw new NullReferenceException();
            }
        }
    }
}