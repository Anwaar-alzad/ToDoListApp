using Microsoft.AspNetCore.Mvc;
namespace WebApplication1.Models.TaskModule;

public class UserTasksController : Controller
{
    private readonly ApplicationDBContext _context;

    public UserTasksController(ApplicationDBContext context)
    {
        _context = context;
    }

    // GET: Show form
    public IActionResult Create()
    {
        return View();
    }

    // POST: Add task to DB
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(UserTask userTask)
    {
        if (ModelState.IsValid)
        {
            _context.Add(userTask);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index"); // or any view you want
        }

        return View(userTask);
    }
}
