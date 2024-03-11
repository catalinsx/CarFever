using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Brand { get; set; } = string.Empty;
        [Required]
        public string Model { get; set; } = string.Empty;
        [Required]
        public string? ShortDescription { get; set; }
        [Required]
        public string? LongDescription { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Required]
        public int yearProduction { get; set; }
        [Required]
        public string horsePower { get; set; } = string.Empty;
        [Required]
        public string newtonMetters { get; set; } = string.Empty;
        [Required]
        public string engineCapacity { get; set; } = string.Empty;
        [Required]
        public string fuelType { get; set; } = string.Empty;
        [Required]
        public string gearBox { get; set; } = string.Empty;
        [Required]
        public string? ImageUrl { get; set; }
        [Required]
        public string? ImageThumbnailUrl { get; set; }
    }
}
