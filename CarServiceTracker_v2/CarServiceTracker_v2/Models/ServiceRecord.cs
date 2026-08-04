using System.ComponentModel.DataAnnotations;

namespace CarServiceTracker_v2.Models
{
    public class ServiceRecord
    {
        [Key]
        public int Id { get; set; }

        public int CarId { get; set; }
        public Car? Car { get; set; }

        public DateTime Date { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }

        public int? Mileage { get; set; }

        public decimal? Cost { get; set; }
    }
}
