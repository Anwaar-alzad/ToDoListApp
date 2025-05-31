namespace WebApplication1.Models.TaskModule;

public class Category
{
    public int Id { get; set; }
    public CategoryNames CategoryNames { get; set; }

    public List<UserTask> UserTasks { get; set; }
}
