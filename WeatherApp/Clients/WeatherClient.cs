using System.Net.Http.Json;
using WeatherApp.Models;

namespace WeatherApp.Clients;

public class WeatherClient {
    private readonly HttpClient _client;

    public WeatherClient(HttpClient client) {
        _client = client;
    }

    public async Task<WeatherResponse> getWeather (string location, string numberOfDays) {
        string api_key = "d5f4a95b8c7a4c6eb1a125959231404";
        string url = "https://api.weatherapi.com/v1/forecast.json?key=" + api_key;
        string numDays = "3";
        
        
        if (location != null) {
            url += "&q=" + location;
        } 
        else {
            url += "&q=81303";
        }
        if (numberOfDays != null) {
            numDays = numberOfDays;
        }
        
        string paramaters ="&aqi=yes&days=" + numDays + "&alerts=yes";
        url += paramaters;
        Console.WriteLine(url);
        //url = "https://api.weatherapi.com/v1/forecast.json?key=d5f4a95b8c7a4c6eb1a125959231404&q=81303&days=3&aqi=yes&alerts=yes";
        return await _client.GetFromJsonAsync<WeatherResponse>(url);
        
    }
}