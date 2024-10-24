using Flurl.Http;
using System.Globalization;
using WeatherApplication.Models;

namespace WeatherApplication.Services
{
    public class WeatherService
    {
       public async Task<ResponseModel> GetWeatherData(string location) 
       {
            string weatherApiUrl = AppConstants.WeatherApiUrl;
            string weatherApiKey = AppConstants.WeatherApiKey;
            try
            {
                LocationService locationService = new LocationService();
                var res = locationService.GetLocationData(location);
                dynamic coordinates;
                if (res.Result.IsSuccess)
                {
                    coordinates = res.Result.JsonData;
                    var longitude = Math.Round(coordinates[0], 6);
                    var latitude = Math.Round(coordinates[1], 6);
                    string apiUrl = $"{weatherApiUrl}?access_key={weatherApiKey}&query={latitude.ToString(CultureInfo.InvariantCulture)},{longitude.ToString(CultureInfo.InvariantCulture)}";
                    var response = await apiUrl.GetAsync();

                    if (response.StatusCode == 200)
                    {
                        var responseData = await response.GetJsonAsync<WeatherModel>();
                        return ResponseModel.Success(responseData);
                    }
                    return ResponseModel.Error(response.ResponseMessage.ToString());
                }
                return ResponseModel.Error(res.Result.ToString());
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync();
                return ResponseModel.Error(errorResponse);
            }
            
        }
    }
}
