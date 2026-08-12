using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarServiceTracker_v2.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Make { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Model { get; set; } = null!;

        public int Year { get; set; }

        [MaxLength(50)]
        public string? VIN { get; set; }

        // Owner
        [ForeignKey(nameof(Customer))]
        public int? OwnerId { get; set; }
        public Customer? Owner { get; set; }

        public ICollection<Invoice>? ServiceRecords { get; set; }
    }
}
