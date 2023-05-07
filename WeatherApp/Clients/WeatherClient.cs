using System.Net.Http.Json;
using WeatherApp.Models;

namespace WeatherApp.Clients;

public class WeatherClient
{
    private readonly HttpClient _client;

    public WeatherClient(HttpClient client)
    {
        _client = client;
    }

    public async Task<WeatherResponse> getWeather(string pageaddress, string? location, string? numberOfDays, string? date)
    {

        string pageA = pageaddress;
        string api_key = "d5f4a95b8c7a4c6eb1a125959231404";
        string url = "http://api.weatherapi.com/v1/"+pageA+".json?key=" + api_key;
        string paramaters = string.Empty;
        string numDays = "1";
        string dateDefault = "2023-04-15";



        if (location != null)
        {
            url += "&q=" + location;
        } 

 
        if (numberOfDays != null) {
            numDays = numberOfDays;
        }

        
        if(date!=null){
            dateDefault = date;
        }

        if(pageA == "astronomy"){
           paramaters = "&dt="+date;
            url += paramaters;
        }
        else if(pageA == "forecast"){
            paramaters = "&days=" + numDays + "&aqi=yes&alerts=yes";
            url += paramaters;
        }
        
        Console.WriteLine(url);
        return await _client.GetFromJsonAsync<WeatherResponse>(url);

    }
}