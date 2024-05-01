using System.ComponentModel.DataAnnotations;

namespace CIDM3312_Final_Project.Models
{
  public class User
  {
    public int UserId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public List<Recipe> Recipes {get; set;} = new List<Recipe>(); // Navigation property. A user can add MANY recipe
  }
}