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
            //HttpClient client = new HttpClient();
            //client.Timeout = new TimeSpan(0, 2, 0);

            //var request = new HttpRequestMessage
            //{
            //    Method = HttpMethod.Get,
            //    RequestUri = new Uri($"http://api.openweathermap.org/data/2.5/forecast?q={cityName},{COUNTRY}&appId={APIKEY}&units=metric")

            //};
            //var answer = await client.SendAsync(request).ConfigureAwait(false);
            //answer.EnsureSuccessStatusCode();
            //var responseBody = await answer.Content.ReadAsStringAsync().ConfigureAwait(false);
            //;
            //Response = weatherList;
            //return await Task.FromResult(weatherList);



            var client = new HttpClient();
            client.Timeout = new TimeSpan(0, 2, 0);
            //client.BaseAddress = new Uri("http://api.openweathermap.org/data/2.5/forecast?q={cityName},{COUNTRY}&appId={APIKEY}&units=metric");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string key = $"http://api.openweathermap.org/data/2.5/forecast?q={cityName},{COUNTRY}&appId={APIKEY}&units=metric";
            HttpResponseMessage response = client.GetAsync(key).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            var weatherList = JsonConvert.DeserializeObject<OpenWeatherModel>(result);
            return weatherList;

        }
    }
}
