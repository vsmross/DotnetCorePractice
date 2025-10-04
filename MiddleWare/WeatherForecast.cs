using Newtonsoft.Json;

namespace MiddleWare
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }

    public class WeatherCondition
    {
        [JsonProperty("condition")]
        public string Condition { get; set; }
    }
}
