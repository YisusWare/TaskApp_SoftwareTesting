using Microsoft.EntityFrameworkCore;

namespace API_Tasks.Data
{
    public class TaskAppDbContext: DbContext
    {

        public TaskAppDbContext (DbContextOptions<TaskAppDbContext> options) { }
    }
}
