using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class Dountil
    {
        [JsonProperty("until")]
        public int? Number { get; set; }

        public Dountil(int? number)
        {
            Number = number;
        }

        public int? Sum(int? n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n + Sum(n - 1);
            }
        }

        public int? Factor(int? n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n * Factor(n - 1);
            }
        }
    }
}
