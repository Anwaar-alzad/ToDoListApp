namespace WebApplication1.Models.TaskModule;

public class TaskList
{

    public int Id { get; set; }
    // public Category Category { get; set; }
    public List<UserTask> UserTasks { get; set; } = new List<UserTask>();

}
