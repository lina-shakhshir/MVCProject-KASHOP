using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, 1000)]
        public decimal Price { get; set; }

        [Required]
        public string Description { get; set; }

        public double Rate { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string? Image { get; set; }
    }
}
