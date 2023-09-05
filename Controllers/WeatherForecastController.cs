using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    
    public class WeatherForecastController : ControllerBase
    {
       

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IConfiguration _configuration;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,IConfiguration configuration)
        {


            _logger = logger;
            _configuration = configuration;
        }


        [HttpGet("/mc2")]

        public async Task<ActionResult<string>> sendtToMS2()
        {
            HttpClient httpClient = new HttpClient();


            httpClient.BaseAddress = new Uri(_configuration.GetSection("Urls")["MS2"]);

            var a= await httpClient.GetAsync("/from1");

            



            return await a.Content.ReadAsStringAsync();
        }

        [HttpGet("")]

        public  string hello()
        {
           


            return "from ms1";
        }


    }
}