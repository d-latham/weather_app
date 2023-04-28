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

    public async Task<WeatherResponse> getWeather(string pageaddress, string location, string numberOfDays, DateTime? date)
    {

        string pageA = pageaddress;
        string api_key = "d5f4a95b8c7a4c6eb1a125959231404";
<<<<<<< HEAD
        string url = "http://api.weatherapi.com/v1/"+pageA+".json?key=" + api_key;
        string paramaters = string.Empty;
=======
        string url = "https://api.weatherapi.com/v1/" + pageA + ".json?key=" + api_key;
        string paramaters = "&aqi=yes";
>>>>>>> main
        string numDays = "3";
        string dateDefault = "2023-04-15";



        if (location != null)
        {
            url += "&q=" + location;
<<<<<<< HEAD
        } 
        else {
            url += "&q=New Orleans";
        }
 
        if (numberOfDays != null) {
=======
        }
        else
        {
            url += "&q=81301";
        }
        if (numberOfDays != null)
        {
>>>>>>> main
            numDays = numberOfDays;
        }

        
<<<<<<< HEAD
        if(date!=null){
            dateDefault = date;
        }

        if(pageA == "current"){
            url += paramaters;
        }
        else if(pageA == "forecast"){
            paramaters = "&days=" + numDays + "&aqi=yes&alerts=yes";
            url += paramaters;
        }
        else{
            paramaters = "&dt="+date;
            url += paramaters;
        }
        
=======

        if (pageA == "current")
        {
            url += paramaters;
        }
        else if (pageA == "forecast")
        {
            paramaters = "&days=" + numDays + "&aqi=yes&alerts=yes" ;
            if (date.HasValue)
            {
                paramaters = paramaters + "&dt="  + date?.ToString("yyyy-MM-dd");
            }
            url += paramaters;
        }
        else
        {
            paramaters = "&dt=" + date;
            url += paramaters;
        }

>>>>>>> main
        Console.WriteLine(url);
        return await _client.GetFromJsonAsync<WeatherResponse>(url);

    }
}