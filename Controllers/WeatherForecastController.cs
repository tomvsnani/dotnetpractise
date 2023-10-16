using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    
    public class WeatherForecastController : ControllerBase
    {
       

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IConfiguration _configuration;

        private readonly IHttpClientFactory _httpClientFactory;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,IConfiguration configuration/*IHttpClientFactory clientFactory*/ )
        {


            _logger = logger;
            _configuration = configuration;
           /* _httpClientFactory = clientFactory;*/

        }

/*
        [HttpGet("/mc2")]

        public async Task<ActionResult<string>> sendtToMS2()
        {

            var HttpClient = _httpClientFactory.CreateClient();

            HttpClient.BaseAddress = new Uri(_configuration.GetSection("Urls")["MS2"]);

            var a= await HttpClient.GetAsync("/from1");

            



            return await a.Content.ReadAsStringAsync();
        }*/

        [HttpGet("")]

        public  string hello()
        {

            return "from ms1 revision";
        }


    }
}