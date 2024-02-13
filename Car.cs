using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WatchCar.Models
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarId { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]

        public double Rate { get; set; }


        public int lenght { get; set; }

        public string Color { get; set; }

        public bool IsDeleted { get; set; } // Soft delete flag
       

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        
        // Foreign key property
        public int ManufacturerId { get; set; }
        // Navigation property for related Manufacturer
        public Manufacturer Manufacturer { get; set; }
    }
}
