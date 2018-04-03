using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloToAllTheWorld.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public string Content { get; set; }
        static private int counter;

        public Greeting()
        {
            Id = counter++;
        }

        public Greeting(string content)
        {
            Id = counter++;
            Content = content;
        }
    }
}
