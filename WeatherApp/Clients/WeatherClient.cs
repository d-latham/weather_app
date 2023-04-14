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
        string url = "http://api.weatherapi.com/v1/current.json?key=" + api_key;
        string paramaters ="&aqi=yes";
        string numDays = "7";
        
        if (location != null) {
            url += "&q=" + location;
        } 
        else {
            url += "&q=Columbus, Ga";
        }
        if (numberOfDays != null) {
            numDays = numberOfDays;
        }
        
        
        url += paramaters;
        Console.WriteLine(url);
        return await _client.GetFromJsonAsync<WeatherResponse>(url);
        
    }
}