using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreAPI.Models;

[Table("Category")]
public class Category
{

    public Category()
    {
        Products = new Collection<Product>();
    }
    [Key]
    [Required(ErrorMessage = "Category Id is required")]
    public int CategoryId { get; set; }

    [Required(ErrorMessage = "Category Name is required")]
    [StringLength(40, ErrorMessage = "Category Name must be between {2} and {1} characters", MinimumLength = 2)]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Category Description is required")]
    [StringLength(300)]
    public string? ImageUrl { get; set; }

    public ICollection<Product>? Products { get; set; }
    
  
}
