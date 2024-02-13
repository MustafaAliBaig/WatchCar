using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WatchCar.Models.Dto
{
    public class CarListDTO
    {
       
        public int CarId { get; set; }

        
        public string Name { get; set; }

       

        public double Rate { get; set; }


        public int lenght { get; set; }

        public string Color { get; set; }

       // public bool IsDeleted { get; set; } // Soft delete flag


        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }


        // Foreign key property
        public int ManufacturerId { get; set; }
        // Navigation property for related Manufacturer
        public ManufacturerDTO Manufacturer { get; set; }
    }
}
