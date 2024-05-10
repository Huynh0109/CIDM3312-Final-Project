using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIDM3312_Final_Project.Models;

namespace CIDM3312_Final_Project.Pages.Recipes
{
    public class IndexModel : PageModel
    {
        private readonly CIDM3312_Final_Project.Models.RecipeDbContext _context;

        public IndexModel(CIDM3312_Final_Project.Models.RecipeDbContext context)
        {
            _context = context;
        }

        public IList<Recipe> Recipe { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;

        public int PageSize {get; set;} = 4;

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set; }

        public async Task OnGetAsync()
        {

            var query = _context.Recipes.Select(r => r);
            var query1 = _context.Tags.Select(t => t);

            switch (CurrentSort)
            {
                case "recipe_asc":
                    query = query.OrderBy(r => r.RecipeName);
                    break;
                case "recipe_desc":
                    query = query.OrderByDescending(r => r.RecipeName);
                    break;
                case "tag_asc":
                    query1 = query1.OrderBy(t => t.TagName);
                    break;
                case "tag_desc":
                    query1 = query1.OrderByDescending(t => t.TagName);
                    break;
            }

            Recipe = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
