using System.ComponentModel.DataAnnotations;

namespace CIDM3312_Final_Project.Models
{
  public class Category
  {
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = string.Empty;
    
    public int RecipeId { get; set; } // Foreign Key
    public Recipe Recipe { get; set; } = null!; // Navigation property
  }
}