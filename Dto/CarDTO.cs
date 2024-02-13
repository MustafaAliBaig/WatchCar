using System.ComponentModel.DataAnnotations;

namespace WatchCar.Models.Dto
{
    public class CarDTO
    {

        //public int CarId { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]

        public double Rate { get; set; }


        public int lenght { get; set; }

        public string Color { get; set; }

        public bool IsDeleted { get; set; } // Soft delete flag

       // public DateTime? DeletedDate { get; set; } // Date when the record was soft-deleted

        // Navigation property for related Manufacturer
        public int ManufacturerId { get; set; }
       // public Manufacturer Manufacturer { get; set; }
    }
}
