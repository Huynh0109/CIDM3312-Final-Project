using System.ComponentModel.DataAnnotations;

namespace CIDM3312_Final_Project.Models
{
  public class Recipe
  {
    public int RecipeId { get; set; }
    public string RecipeName { get; set; } = string.Empty;

    [Display(Name = "Recipe Description")]
    [Required]
    public string RecipeDescription { get; set;} = string.Empty;

    [Display(Name = "Ingreadient")]
    [Required]
    public string Ingredient { get; set; } = string.Empty;
    public string Instruction { get; set; } = string.Empty;

    public int UserId { get; set; } // Foreign key
    public User User { get; set; } = null!; // Navigation property, each recipe posted by ONE user

    public List<Category> categories { get; set; } = null!; // Navigation property, each recipe can have MANY category

    public Tag tag { get; set; } = null!;
  }
}