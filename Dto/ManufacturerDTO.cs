using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WatchCar.Models.Dto
{
    public class ManufacturerDTO
    {
        
        public int ManufacturerId { get; set; }

        public string Name { get; set; }

        // Add any other properties for Manufacturer entity if needed

        // Navigation property for related cars
        public ICollection<Car> Cars { get; set; }
    }
}
