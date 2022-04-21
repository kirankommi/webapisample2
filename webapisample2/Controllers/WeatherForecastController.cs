using Microsoft.AspNetCore.Mvc;

namespace webapisample2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        

        [HttpGet]
        public string Get()
        {
            return "kiran";
        }
    }
}