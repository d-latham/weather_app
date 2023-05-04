using System.Text.Json.Serialization;
using System.Text.Json;

namespace WeatherApp.Models;

public record WeatherResponse {

    [JsonPropertyName("location")]
    public Location location {get; init;}
    [JsonPropertyName("current")]
    public Current current {get; init;}
    [JsonPropertyName("alerts")]
    public Alerts alerts {get; init;}
    [JsonPropertyName("forecast")]
    public Forecast forecast {get; init;}
    [JsonPropertyName("astronomy")]
    public Astronomy astronomy {get; init;}


   //// Trying out all classes
 
    public class AirQuality
    {
        public double co { get; set; }
        public double no2 { get; set; }
        public double o3 { get; set; }
        public double so2 { get; set; }
        public double pm2_5 { get; set; }
        public double pm10 { get; set; }

        [JsonPropertyName("us-epa-index")]
        public int usepaindex { get; set; }

        [JsonPropertyName("gb-defra-index")]
        public int gbdefraindex { get; set; }
    }

    public class Alert
    {
        public string headline { get; set; }
        public string msgtype { get; set; }
        public string severity { get; set; }
        public string urgency { get; set; }
        public string areas { get; set; }
        public string category { get; set; }
        public string certainty { get; set; }
        public string alertevent { get; set; }
        public string note { get; set; }
        public DateTime effective { get; set; }
        public DateTime expires { get; set; }
        public string desc { get; set; }
        public string instruction { get; set; }
    }

    public class Alerts
    {
        public List<Alert> alert { get; set; }
    }

    public class Astro
    {
        public string sunrise { get; set; }
        public string sunset { get; set; }
        public string moonrise { get; set; }
        public string moonset { get; set; }
        public string moon_phase { get; set; }
        public string moon_illumination { get; set; }
        public int is_moon_up { get; set; }
        public int is_sun_up { get; set; }
    }

    public class Condition
    {
        public string text { get; set; }
        public string icon { get; set; }
        public int code { get; set; }
    }

    public class Current
    {
        public int last_updated_epoch { get; set; }
        public string last_updated { get; set; }
        public double temp_c { get; set; }
        public double temp_f { get; set; }
        public int is_day { get; set; }
        public Condition condition { get; set; }
        public double wind_mph { get; set; }
        public double wind_kph { get; set; }
        public int wind_degree { get; set; }
        public string wind_dir { get; set; }
        public double pressure_mb { get; set; }
        public double pressure_in { get; set; }
        public double precip_mm { get; set; }
        public double precip_in { get; set; }
        public int humidity { get; set; }
        public int cloud { get; set; }
        public double feelslike_c { get; set; }
        public double feelslike_f { get; set; }
        public double vis_km { get; set; }
        public double vis_miles { get; set; }
        public double uv { get; set; }
        public double gust_mph { get; set; }
        public double gust_kph { get; set; }
        public AirQuality air_quality { get; set; }
    }

    public class Day
    {
        public double maxtemp_c { get; set; }
        public double maxtemp_f { get; set; }
        public double mintemp_c { get; set; }
        public double mintemp_f { get; set; }
        public double avgtemp_c { get; set; }
        public double avgtemp_f { get; set; }
        public double maxwind_mph { get; set; }
        public double maxwind_kph { get; set; }
        public double totalprecip_mm { get; set; }
        public double totalprecip_in { get; set; }
        public double totalsnow_cm { get; set; }
        public double avgvis_km { get; set; }
        public double avgvis_miles { get; set; }
        public double avghumidity { get; set; }
        public int daily_will_it_rain { get; set; }
        public int daily_chance_of_rain { get; set; }
        public int daily_will_it_snow { get; set; }
        public int daily_chance_of_snow { get; set; }
        public Condition condition { get; set; }
        public double uv { get; set; }
    }

    public class Forecast
    {
        public List<Forecastday> forecastday { get; set; }
    }

    public class Forecastday
    {
        public string date { get; set; }
        public int date_epoch { get; set; }
        public Day day { get; set; }
        public Astro astro { get; set; }
        public List<Hour> hour { get; set; }
    }

    public class Hour
    {
        public int time_epoch { get; set; }
        public string time { get; set; }
        public double temp_c { get; set; }
        public double temp_f { get; set; }
        public int is_day { get; set; }
        public Condition condition { get; set; }
        public double wind_mph { get; set; }
        public double wind_kph { get; set; }
        public int wind_degree { get; set; }
        public string wind_dir { get; set; }
        public double pressure_mb { get; set; }
        public double pressure_in { get; set; }
        public double precip_mm { get; set; }
        public double precip_in { get; set; }
        public int humidity { get; set; }
        public int cloud { get; set; }
        public double feelslike_c { get; set; }
        public double feelslike_f { get; set; }
        public double windchill_c { get; set; }
        public double windchill_f { get; set; }
        public double heatindex_c { get; set; }
        public double heatindex_f { get; set; }
        public double dewpoint_c { get; set; }
        public double dewpoint_f { get; set; }
        public int will_it_rain { get; set; }
        public int chance_of_rain { get; set; }
        public int will_it_snow { get; set; }
        public int chance_of_snow { get; set; }
        public double vis_km { get; set; }
        public double vis_miles { get; set; }
        public double gust_mph { get; set; }
        public double gust_kph { get; set; }
        public double uv { get; set; }
    }

    public class Location
    {
        public string name { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public string tz_id { get; set; }
        public int localtime_epoch { get; set; }
        public string localtime { get; set; }
    }

    public class Astronomy
    {
        public Astro astro { get; set; }
    }

    public class Root
    {
        public Location location { get; set; }
        public Current current { get; set; }
        public Forecast forecast { get; set; }
        public Alerts alerts { get; set; }
        public Astronomy astronomy { get; set; }
    
    }


   ///
    // public class locationData {
    //     public string name {get; init;}
    //     public string country {get; init;}
    //     public string region {get; init;}
    //     public string localTime {get; init;}
    // }

    // public class currentData {
    //     public double temp_c {get; init;}
    // }
}

// "last_updated_epoch": 1683153900,
//         "last_updated": "2023-05-03 23:45",
//         "temp_c": 8.0,
//         "temp_f": 46.4,
//         "is_day": 0,
//         "condition": {
//             "text": "Clear",
//             "icon": "//cdn.weatherapi.com/weather/64x64/night/113.png",
//             "code": 1000
//         },
//         "wind_mph": 11.9,
//         "wind_kph": 19.1,
//         "wind_degree": 80,
//         "wind_dir": "E",
//         "pressure_mb": 1022.0,
//         "pressure_in": 30.18,
//         "precip_mm": 0.0,
//         "precip_in": 0.0,
//         "humidity": 81,
//         "cloud": 0,
//         "feelslike_c": 5.5,
//         "feelslike_f": 41.9,
//         "vis_km": 10.0,
//         "vis_miles": 6.0,
//         "uv": 1.0,
//         "gust_mph": 14.3,
//         "gust_kph": 23.0
//     },