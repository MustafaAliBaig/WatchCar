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
            //IQueryable<Car> query = _db.NewToy.AsQueryable();
            IQueryable<Car> query = _db.NewToy
                                .Include(c => c.Manufacturer) // Include related Manufacturer entity
                                .AsQueryable();

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

            // Pagination
            var paginatedCars = query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            // Mapping to DTO
            var carDTOs = paginatedCars.Select(car => new CarDTO
            {
                CarId = car.CarId,
                Name = car.Name,
                Rate = car.Rate,
                lenght = car.lenght,
                Color = car.Color,
                // Include Manufacturer data in DTO
                Manufacturer = car.Manufacturer
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
                CarId = car.CarId,
                Name = car.Name,
                Rate = car.Rate,
                lenght = car.lenght,
                Color = car.Color,
                // Include Manufacturer data in DTO
                Manufacturer = car.Manufacturer
            };

            return Ok(carDTO);
        }
        [HttpPost]
            [ProducesResponseType(StatusCodes.Status201Created)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status500InternalServerError)]
            public ActionResult<CarDTO> CreateCar([FromBody] CarDTO carDTO)
            {
                if (_db.NewToy.FirstOrDefault(u => u.Name.ToLower() == carDTO.Name.ToLower()) != null)
                {
                    ModelState.AddModelError("Custom Error", "Car Model Already Exists");
                    return BadRequest(ModelState);
                }
                if (carDTO == null)
                {
                    return BadRequest(carDTO);
                }
                if (carDTO.CarId > 0)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

                Car model = new()
                {
                    CarId = carDTO.CarId,
                    Name = carDTO.Name,
                    Rate = carDTO.Rate,
                    lenght = carDTO.lenght,
                    Color = carDTO.Color,
                    
                };
                _db.NewToy.Add(model);
                _db.SaveChanges();
                return CreatedAtRoute("GetCar", new { id = carDTO.CarId }, carDTO);

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
                var villa = _db.NewToy.FirstOrDefault(u => u.CarId == id);
                if (villa == null)
                {
                    return NotFound();
                }
                _db.NewToy.Remove(villa);
                _db.SaveChanges();
                return NoContent();

            }
        }
    }

