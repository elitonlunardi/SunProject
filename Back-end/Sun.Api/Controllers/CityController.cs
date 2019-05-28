using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sun.Application;

namespace Sun.Api.Controllers
{
    [Route("api/City")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityAppService _cityService;

        public CityController(ICityAppService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet]
        [Route("Index")]
        public string Index()
        {
            return "Index";
        }

        [HttpPost]
        [Route("AddCity")]
        public IActionResult AddCity(CityViewModel cityViewModel)
        {
            _cityService.Add(cityViewModel);
            return Ok("Sucesso");
        }

        [HttpGet]
        [Route("GetAllCities")]
        public IActionResult GetAllCities()
        {
            var cities = _cityService.GetAll();
            if (cities.ToList().Count > 0)
            {
                return Ok(cities);
            }
            return BadRequest("Nenhuma cidade encontrada.");
        }

        [HttpGet]
        [Route("GetWeathersByCityId")]
        public IActionResult GetWeather(string id)
        {
            var weathers = _cityService.GetWeatherIdCity(id);
            return Ok(weathers);
        }


    }
}