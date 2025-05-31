using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.TaskModule;
public class UserTask
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public DateTime Deadline { get; set; }
    public bool isCompleted { get; set; }
    // public DateOnly Reminder { get; set; }

    [ForeignKey("CategoryId")]
    public Category Category { get; set; }
    public int CategoryId { get; set; }

    // [ForeignKey("TaskListId")]
    // public int TaskListId { get; set; }
    // public TaskList TaskList { get; set; }
}
