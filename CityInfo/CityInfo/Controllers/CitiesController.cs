using CityInfo.Models;
using CityInfo.Services;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        private readonly CitiesDataStore _citiesDataStore;

        public CitiesController(
            CitiesDataStore citiesDataStore)
        {
            _citiesDataStore = citiesDataStore ?? throw new ArgumentNullException(nameof(citiesDataStore));
        }


        [HttpGet()]
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {
            return Ok(_citiesDataStore.Cities);
        }


        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id)
        {
            // Find city
            var cityObj = _citiesDataStore.Cities.FirstOrDefault(c => c.Id == id);

            if (cityObj == null)
                return NotFound();
            else
                return Ok(cityObj);
        }

    }
}
