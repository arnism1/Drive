using System.ComponentModel.DataAnnotations;

namespace Drive.Data.Entity
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string Brand { get; set; }

        [Required]
        [MaxLength(128)]
        public string Model { get; set; }

        [Required]
        [MaxLength(128)]
        public string LicensePlate { get; set; }


        public ICollection<Tours> Tours { get; set; }
    }
}
