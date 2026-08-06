using CarServiceTracker_v2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarServiceTracker_v2.CarServiceTracker_v2.Models
{
    public class Estimate
    {
        // Properties for the Estimate class

        [Key]
        // This is done by default for an Int primary key, I'm being explicit for educational purposes
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public Customer? Customer { get; set; }

        [ForeignKey(nameof(Customer))]
        [Required]
        public int CustomerId { get; set; }

        [Required]
        public DateTimeOffset CreationDate { get; } = DateTimeOffset.UtcNow;

        // public ServiceList<Service> Services { get; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Estimate cost must be a non-negative value.")]
        public double EstimateCost { get; set; }
        [Required]
        [MaxLength(100)]
        public string TechnicianName { get; set; }

        // Constructor
        public Estimate()
        {
        
        }

        public Estimate(int customerId, double estimateCost, string technicianName)
        {
            CustomerId = customerId;
            EstimateCost = estimateCost;
            TechnicianName = technicianName;
        }

    }
}
