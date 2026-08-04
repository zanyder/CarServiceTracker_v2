using System.ComponentModel.DataAnnotations;

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
        public int? OwnerId { get; set; }
        public Customer? Owner { get; set; }

        public ICollection<ServiceRecord>? ServiceRecords { get; set; }
    }
}
