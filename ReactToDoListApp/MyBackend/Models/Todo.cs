using System;
using Microsoft.EntityFrameworkCore;

namespace MyBackend.Models
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public bool Completed { get; set; }
    }

    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<Todo> Todos { get; set; }
    }
}
