using ListingTodos.Model;
using System.Collections.Generic;

namespace ListingTodos.Repositories
{
    public interface IRepository
    {
        void Create(string title, bool isUrgent, bool isDone);
        List<Todo> Read();
        List<Todo> Read(bool isActive);
        void Update(int Id, string Title, string isUrgent, string isDone);
        void Delete(int Id);
        Todo SelectRow(int id);
    }
}
