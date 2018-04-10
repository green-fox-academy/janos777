using ListingTodos.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Repositories
{
    public class Repository : IRepository
    {
        private TodoContext _context;

        public Repository(TodoContext context)
        {
            _context = context;
        }

        public void Create(string title)
        {
            _context.Add(new Todo { Title = title });
            _context.SaveChanges();
        }

        public List<Todo> Read()
        {
            return _context.Todos.ToList();
        }

        public void Update(Todo todo)
        {
            _context.Update(todo);
            _context.SaveChanges();
        }

        public void Delete(Todo todo)
        {
            _context.Remove(todo);
            _context.SaveChanges();
        }
    }
}
