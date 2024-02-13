using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WatchCar.Models
{
    public class Manufacturer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ManufacturerId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        // Add any other properties for Manufacturer entity if needed

        // Navigation property for related cars
        public ICollection<Car> Cars { get; set; }
    }
}