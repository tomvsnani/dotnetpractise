namespace WebApplication1
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public WeatherForecast() {

            List<int> list = new List<int>() { 1, 2, 3 };
            var a = list.Where(x => x % 2 == 0).ToList();

        }
    }
}