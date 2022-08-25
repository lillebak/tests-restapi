using AutoMapper;
using CityInfo.Models;
using CityInfo.Services;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICityInfoRepository _cityInfoRepository;

        public CitiesController(
            ICityInfoRepository cityInfoRepository,
            IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _cityInfoRepository = cityInfoRepository ?? throw new ArgumentNullException(nameof(cityInfoRepository));
        }


        [HttpGet()]
        public async Task<ActionResult<IEnumerable<CityDto>>> GetCities()
        {
            var cityEntities = await _cityInfoRepository.GetCitiesAsync();

            return Ok(_mapper.Map<IEnumerable<CityWithoutPointsOfInterestDto>>(cityEntities));

            //return Ok(_citiesDataStore.Cities);
        }


        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id)
        {
            //// Find city
            //var cityObj = _citiesDataStore.Cities.FirstOrDefault(c => c.Id == id);

            //if (cityObj == null)
            //    return NotFound();
            //else
            //    return Ok(cityObj);
            return Ok();
        }

    }
}
