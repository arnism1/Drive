﻿using System.ComponentModel.DataAnnotations;


namespace Drive.Data.Entity
{
    public class Tours
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? EmployeeId { get; set; }
        public ApplicationUser Employee { get; set; }

        [Required]
        public int CardId { get; set; }
        public Car Car { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public TimeOnly Start { get; set; }

        [Required]
        public TimeOnly End { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly Date { get; set; }

        //  properties for Reiseweg (Travel Distance)
        [Required]
        public int OdometerStart { get; set; }

        [Required]
        public int OdometerEnd { get; set; }

        // Calculated property for the distance traveled
        public int DistanceTraveled { get; set; }

        // Existing calculated property for hours worked
        public double HoursWorked => Math.Round((End - Start).TotalHours, 2);
    }

}
