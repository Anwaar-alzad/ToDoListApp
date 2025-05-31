using Microsoft.EntityFrameworkCore;

using WebApplication1.Models.TaskModule;

public class ApplicationDBContext : DbContext
{
    // constructor of class ApplicationDBContext 
    // constructor ApplicationDBContext gets called when an object of ApplicationDBContext is created
    // configuration details parameter DbContextOptions<ApplicationDBContext> options
    // parameter holds UseSqlServer + connectionString + any option you passed throught AddDBContext 
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
    : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<UserTask> UserTasks { get; set; }
    // public DbSet<TaskList> TaskLists { get; set; }



}
