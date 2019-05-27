using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Sun.Infra.CrossCutting.Rest
{
    public class RestClient : IRestClient
    {
        private const string APIKEY = "31cea044be81ac381a55a8e2ada47788";
        private const string COUNTRY = "br";

        public OpenWeatherModel GetMethod(string cityName)
        {
            var client = new HttpClient();
            client.Timeout = new TimeSpan(0, 2, 0);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync($"http://api.openweathermap.org/data/2.5/forecast?q={cityName},{COUNTRY}&appId={APIKEY}&units=metric").Result;
            return JsonConvert.DeserializeObject<OpenWeatherModel>(response.Content.ReadAsStringAsync().Result);
        }
    }
}
