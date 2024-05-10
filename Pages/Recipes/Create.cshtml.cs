using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CIDM3312_Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace CIDM3312_Final_Project.Pages.Recipes
{
    public class CreateModel : PageModel
    {
        private readonly CIDM3312_Final_Project.Models.RecipeDbContext _context;

        public CreateModel(CIDM3312_Final_Project.Models.RecipeDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Recipe Recipe { get; set; } = default!;

        [BindProperty]
        public Tag Tag { get; set; } = default!;

        [BindProperty]
        public Category Category { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Recipes.Add(Recipe);
            _context.Tags.Add(Tag);
            _context.Categories.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
