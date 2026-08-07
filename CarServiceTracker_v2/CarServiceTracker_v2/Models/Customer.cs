using System.ComponentModel.DataAnnotations;

namespace CarServiceTracker_v2.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; } = null!;

        [MaxLength(50)]
        public string? Phone { get; set; }

        [MaxLength(200)]
        public string? Email { get; set; }

        [MaxLength(30)]
        public string? DriversLicenseNumber { get; set; }

        public ICollection<Car>? Cars { get;  set; }
    }
}
