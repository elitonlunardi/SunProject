using System;
using System.Net.Http;

namespace Sun.Infra.CrossCutting.Rest
{
    public class Rest
    {
        public RestOptions RestOptions { get; set; }
        private const string ApiKey = "31cea044be81ac381a55a8e2ada47788";

        public Rest(RestOptions restOptions)
        {
            RestOptions = restOptions;
        }

        public void GetMethod()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.Timeout = new TimeSpan(0, 2, 0);
            var response = httpClient.GetAsync($@"
http://api.openweathermap.org/data/2.5/forecast?q={RestOptions.City},{RestOptions.Country}&appId={ApiKey}&units=metric
                                        ");
        }

    }



    public class RestOptions
    {
        public string City { get; set; }
        public string Country { get; set; }

        public RestOptions(string city, string country)
        {
            City = city;
            Country = country;
        }
    }
}
