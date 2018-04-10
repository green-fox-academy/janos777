using ListingTodos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Repositories
{
    public interface IRepository
    {
        void Create(string title);
        List<Todo> Read();
        void Update(Todo todo);
        void Delete(Todo todo);
    }
}
