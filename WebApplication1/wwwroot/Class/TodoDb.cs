using Microsoft.EntityFrameworkCore;

namespace WebApplication1.wwwroot.Class
{


    class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options)
            : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}
