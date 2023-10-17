using Microsoft.AspNetCore.Mvc;

namespace AspNETWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public WeatherController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<WeatherForecast>> GetWeatherForecasts()
        {
            var forecasts = _context.WeatherForecasts.ToList();
            return Ok(forecasts);
        }
    }

}