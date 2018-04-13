using ListingTodos.Model;
using Microsoft.EntityFrameworkCore;

namespace ListingTodos
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
    }
}
