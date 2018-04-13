using ListingTodos.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListingTodos.Repositories
{
    public class Repository : IRepository
    {
        private TodoContext _context;

        public Repository(TodoContext context)
        {
            _context = context;
        }

        public void Create(string title, bool isUrgent, bool isDone)
        {
            _context.Add(new Todo { Title = title, IsUrgent = isUrgent, IsDone = isDone });
            _context.SaveChanges();
        }

        public List<Todo> Read()
        {
            return _context.Todos.ToList();
        }

        public List<Todo> Read(bool isActive)
        {
            return _context.Todos.Where(t => t.IsDone != isActive).ToList();
        }

        public void Update(int id, string title, string isUrgent, string isDone)
        {
            Todo todo = _context.Todos.FirstOrDefault(t => t.Id == id);
            todo.Title = title ?? todo.Title;
            todo.IsUrgent = (isUrgent == "on") ? true : false;
            todo.IsDone = (isDone == "on") ? true : false;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Todo todo = _context.Todos.FirstOrDefault(t => t.Id == id);
            _context.Remove(todo);
            _context.SaveChanges();
        }

        public Todo SelectRow(int id)
        {
            return _context.Todos.FirstOrDefault(t => t.Id == id);
        }
    }
}
