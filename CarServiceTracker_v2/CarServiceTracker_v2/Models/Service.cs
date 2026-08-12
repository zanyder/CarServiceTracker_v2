using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CarServiceTracker_v2.CarServiceTracker_v2.Models
{

    // I don't think this class needs to be cloneable, but I'll leave it like this just in case
    public class Service:ICloneable
    {
        // Properties for the Service class
        [Key]
        public int ServiceId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public double Cost { get; set; } = 0;

        public double Duration { get; set; } = 0;

        // Default constructor
        public Service() { }

        // Parameterized constructor
        public Service(string name, double cost, double duration)
        {
            Name = name;
            Cost = cost;
            Duration = duration;
        }

        // Methods
        
        public object Clone()
        {
            return new Service(this.Name, this.Cost, this.Duration);
        }

    }
}
