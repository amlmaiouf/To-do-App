using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoApp.Models;
using System.Collections.Generic;

namespace ToDoApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<task> Tasks { get; set; } = new List<task>();

        public void OnGet()
        {
            // Sample tasks for demonstration
            Tasks.Add(new task { Id = 1, Description = "Buy groceries", IsCompleted = false });
            Tasks.Add(new task { Id = 2, Description = "Clean the house", IsCompleted = true });
        }
    }
}

