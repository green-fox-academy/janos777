using Frontend.Entities;
using Frontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Repositories
{
    public class Repository : IRepository
    {
        private LogContext _context;

        public Repository(LogContext context)
        {
            _context = context;
        }

        public void Create(string endpoint, string data)
        {
            _context.Add(new Log { CreatedAt = DateTime.Now, Endpoint = endpoint, Data = data });
            _context.SaveChanges();
        }

        public List<Log> Read()
        {
            throw new NotImplementedException();
        }

        public void Update(int Id, string Endpoint, string Data)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
