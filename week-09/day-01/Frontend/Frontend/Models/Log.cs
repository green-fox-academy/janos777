using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class Log
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Endpoint { get; set; }
        public string Data { get; set; }

        /*
        public Log(int id, DateTime createdAt, string endpoint, string data)
        {
            Id = id;
            CreatedAt = createdAt;
            Endpoint = endpoint;
            Data = data;
        }
        */
    }
}
