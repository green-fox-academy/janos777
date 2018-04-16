using Frontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Repositories
{
    public interface IRepository
    {
        void Create(string endpoint, string data);
        List<Log> Read();
        void Update(int Id, string Endpoint, string Data);
        void Delete(int Id);
    }
}
