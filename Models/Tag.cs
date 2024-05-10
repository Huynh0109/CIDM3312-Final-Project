using System.ComponentModel.DataAnnotations;

namespace CIDM3312_Final_Project.Models
{
  public class Tag
  {    
    public int TagID { get; set; }
    public string TagName { get; set; } = string.Empty;

    public int RecipeID { get; set; }
    public Recipe? Recipe { get; set; } = null!;
  }
}