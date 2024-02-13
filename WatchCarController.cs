using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WatchCar.Data;
using WatchCar.Models;
using WatchCar.Models.Dto;

namespace WatchCar.Controllers
{
    [Route("api/CarApi")]
    [ApiController]
    public class WatchCarController : ControllerBase    
    {
     
            private readonly ApplicationDbContext _db;
            public WatchCarController(ApplicationDbContext db)
            {
                _db = db;
            }
        //[HttpGet]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //public ActionResult<IEnumerable<CarDTO>> GetCar()
        //{
        //    return Ok(_db.NewToy.ToList());


        //}

        //[HttpGet("{id:int}", Name = "GetCar")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public ActionResult<Car> GetCar(int id)
        //{
        //    if (id == 0)
        //    {
        //        return BadRequest();
        //    }
        //    var car = _db.NewToy.FirstOrDefault(u => u.CarId == id);
        //    if (car == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(car);
        //}

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<CarDTO>> GetCar(
            int pageNumber = 1, int pageSize = 10, string sortBy = "CarId", string sortOrder = "asc")
        {
            //IQueryable<Car> query = _db.NewToy.AsQueryable(); //Retriving only Car Table
            IQueryable<Car> query = _db.NewToy
                                .Include(c => c.Manufacturer) // Including  Manufacturer Table
                                .Where(c => !c.IsDeleted).AsQueryable();

            // Sorting
            switch (sortBy.ToLower())
            {
                case "name":
                    query = sortOrder.ToLower() == "desc" ? query.OrderByDescending(c => c.Name) : query.OrderBy(c => c.Name);
                    break;
                case "rate":
                    query = sortOrder.ToLower() == "desc" ? query.OrderByDescending(c => c.Rate) : query.OrderBy(c => c.Rate);
                    break;
                case "lenght":
                    query = sortOrder.ToLower() == "desc" ? query.OrderByDescending(c => c.lenght) : query.OrderBy(c => c.lenght);
                    break;
                case "color":
                    query = sortOrder.ToLower() == "desc" ? query.OrderByDescending(c => c.Color) : query.OrderBy(c => c.Color);
                    break;
                default: // Default sorting by CarId
                    query = sortOrder.ToLower() == "desc" ? query.OrderByDescending(c => c.CarId) : query.OrderBy(c => c.CarId);
                    break;
            }

            // Pagination Logic
            /* query = is the object from above code i.e; IQueryable<Car> 
             * Skip() is used to skip the pages which is already displayed, Eg: Skip(1-1)*10) where pagenumber is 1 and pageSize is 10 as mentioned in the function parameters
             * Hence this code Skip((pageNumber - 1) * pageSize) requests current page
             * var data = Enumerable.Range(1, 10); // Generate a sequence of integers from 1 to 10  
             * var skippedData = data.Skip(5); // Skip the first 5 elements
             * var data = Enumerable.Range(1, 10); // Generate a sequence of integers from 1 to 10
             * var takenData = data.Take(3); // Take the first 3 elements

             */
            var paginatedCars = query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            // Mapping to DTO
            var carDTOs = paginatedCars.Select(car => new CarListDTO
            {
               CarId = car.CarId,
                Name = car.Name,
                Rate = car.Rate,
                lenght = car.lenght,
                Color = car.Color,
                CreatedDate= car.CreatedDate,
                UpdatedDate= car.UpdatedDate,
                // Include Manufacturer data in DTO
                ManufacturerId = car.ManufacturerId,
                Manufacturer = new ManufacturerDTO() {ManufacturerId = car.ManufacturerId,Name=car.Manufacturer.Name }
            }).ToList();

            return Ok(carDTOs);
        }

        [HttpGet("{id:int}", Name = "GetCar")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<CarDTO> GetCar(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid ID");
            }

            // var car = _db.NewToy.FirstOrDefault(u => u.CarId == id);
            var car = _db.NewToy
                 .Include(c => c.Manufacturer) // Include related Manufacturer entity
                 .FirstOrDefault(u => u.CarId == id);

            if (car == null)
            {
                return NotFound("Car not found");
            }

            // Mapping to DTO
            var carDTO = new CarDTO
            {
                //CarId = car.CarId,
                Name = car.Name,
                Rate = car.Rate,
                lenght = car.lenght,
                Color = car.Color,
                // Including Manufacturer  in DTO
                ManufacturerId = car.ManufacturerId,
                //Manufacturer = car.Manufacturer
            };

            return Ok(carDTO);
        }
            [HttpPost]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status500InternalServerError)]
            public ActionResult<CarDTO> CreateCar([FromBody] CarDTO carDTO)
            {
            var checking = _db.NewToy.FirstOrDefault(u => u.Name.ToLower() == carDTO.Name.ToLower() && !u.IsDeleted);
                if (checking != null) //Checks if Car already exists in the car Table
                {
                    ModelState.AddModelError("Custom Error", "Car Model Already Exists");
                    return BadRequest(ModelState);
                }

            // Validate other properties of carDTO as needed

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //if (carDTO.CarId != 0)
            //{
            //    return BadRequest("Cannot specify CarId for a new entity.");
            //}

            if (carDTO == null) // car object should not be zero
                {
                    return BadRequest("Car data is required.");
                }
                //if (carDTO.CarId > 0) // If your assigning any value to the carid then it returns 500 internal Server Error
                //{
                //    return StatusCode(StatusCodes.Status500InternalServerError);
                //}

            // Check if the ManufacturerId provided in carDTO is valid
            var existingManufacturer = _db.Manufacturers.FirstOrDefault(m => m.ManufacturerId == carDTO.ManufacturerId);
            if (existingManufacturer == null)
            {
                ModelState.AddModelError("ManufacturerId", "Invalid ManufacturerId.");
                return BadRequest(ModelState);
            }

            Car model = new()
                {
                    //CarId = carDTO.CarId,
                    Name = carDTO.Name,
                    Rate = carDTO.Rate,
                    lenght = carDTO.lenght,
                    Color = carDTO.Color,
                     ManufacturerId = carDTO.ManufacturerId // Associate the new car with the specified manufacturer
            };
                _db.NewToy.Add(model);

                _db.SaveChanges();

            //carDTO.CarId = model.CarId; // Assign the newly generated CarId to the DTO
            //carDTO.Manufacturer = existingManufacturer; // Include Manufacturer data in DTO

            //return CreatedAtRoute("Creating Car",model);

           // return CreatedAtRoute("GetCar", new { id = model.CarId }); // Assuming you have a route named "GetCarById" to retrieve a car by its ID
                return Ok(carDTO);
        }

            [HttpDelete("{id:int}", Name = "DeleteCar")]
            [ProducesResponseType(StatusCodes.Status204NoContent)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            public IActionResult DeleteCar(int id)
            {
                if (id == 0)
                {
                    return BadRequest();

                }
                var car = _db.NewToy.FirstOrDefault(u => u.CarId == id);
                if (car == null)
                {
                    return NotFound();
                }

            // Soft delete the car by setting IsDeleted flag to true
            car.IsDeleted = true;
            //_db.NewToy.Remove(car);
                _db.SaveChanges();
                return NoContent();

            }
        }
    }

