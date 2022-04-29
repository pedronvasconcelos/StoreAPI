using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace StoreAPI.Models;

public class Product
{
    [Key]
    [Required(ErrorMessage = "Product ID is required")]
    public int ProductId { get; set; }

    [Required(ErrorMessage = "The product name is required")]
    [StringLength(80, ErrorMessage = "The name must be between {2} and {1} characters",
    MinimumLength = 5)]
    public string? Name { get; set; }

    public string? ImageUrl { get; set; }

    [Required(ErrorMessage = "The product price is required")]
    [Column(TypeName = "decimal(10,2)")]
    [Range(0, 999999.99, ErrorMessage = "The price must be between {1} and {2}")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "The product description is required")]
    [StringLength(300, ErrorMessage = "The description has a maximum length of {1} characters")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "The product category is required")]
    public float Stock { get; set; }

    public DateTime RegisterDate { get; set; }

    public int CategoryId { get; set; }
    
    [JsonIgnore]
    public Category? Category { get; set; }

}