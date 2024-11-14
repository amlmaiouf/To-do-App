using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoApp.Models;

namespace ToDoApp.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public task NewTask { get; set; }

        public IActionResult OnPost()
        {
            
            return RedirectToPage("/Index");
        }
    }
}
