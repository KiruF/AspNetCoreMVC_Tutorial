using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }

    [StringLength(54, MinimumLength = 3), Required]
    public string? Title { get; set; }

    [Display(Name = "Release Date"), DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Letters only and start with a capital")]
    [Required]
    [StringLength(34)]
    public string? Genre { get; set; }

    [Range(1, double.MaxValue), DataType(DataType.Currency), Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    [Range(1, 10)]
    public int? Rating { get; set; }
}