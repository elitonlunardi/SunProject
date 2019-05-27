using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sun.Application;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;

namespace Sun.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ICityAppService _cityService;

        public ValuesController(ICityAppService cityService)
        {
            _cityService = cityService;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetAsync()
        {


            //HttpClient client = new HttpClient();
            //client.Timeout = new TimeSpan(0, 2, 0);

            //var request = new HttpRequestMessage
            //{
            //    Method = HttpMethod.Get,
            //    RequestUri = new Uri("http://api.openweathermap.org/data/2.5/forecast?q=brusque,br&appId=31cea044be81ac381a55a8e2ada47788&units=metric")

            //};
            ////http://api.openweathermap.org/data/2.5/forecast?q=brusque,br&appId=31cea044be81ac381a55a8e2ada47788&units=metric
            ////http://api.openweathermap.org/data/2.5/forecast?q={RestOptions.City},{RestOptions.Country}&appId={ApiKey}&units=metric
            //var answer = await client.SendAsync(request).ConfigureAwait(false);
            //answer.EnsureSuccessStatusCode();
            //var responseBody = await answer.Content.ReadAsStringAsync().ConfigureAwait(false);
            //var json = JsonConvert.DeserializeObject<OpenWeatherModel>(responseBody);
            _cityService.Add(new CityViewModel { Id = Guid.NewGuid(), Name = "teste" });
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        //public class Rest
        //{
        //    public RestOptions RestOptions { get; set; }
        //    private const string ApiKey = "31cea044be81ac381a55a8e2ada47788";

        //    public Rest(RestOptions restOptions)
        //    {
        //        RestOptions = restOptions;
        //    }

        //    public async Task<string> GetMethod()
        //    {
        //        HttpClient client = new HttpClient();
        //        client.Timeout = new TimeSpan(0, 2, 0);

        //        var request = new HttpRequestMessage
        //        {
        //            Method = HttpMethod.Get,
        //            RequestUri = new Uri("http://api.openweathermap.org/data/2.5/forecast?q={RestOptions.City},{RestOptions.Country}&appId={ApiKey}&units=metric")

        //        };
        //        //http://api.openweathermap.org/data/2.5/forecast?q=brusque,br&appId=31cea044be81ac381a55a8e2ada47788&units=metric
        //        var answer = await client.SendAsync(request).ConfigureAwait(false);
        //        answer.EnsureSuccessStatusCode();
        //        var responseBody = await answer.Content.ReadAsStringAsync().ConfigureAwait(false);
        //        //.ConfigureAwait(true);

        //        return responseBody;
        //    }

        //}

        //public class RestOptions
        //{
        //    public string City { get; set; }
        //    public string Country { get; set; }

        //    public RestOptions(string city, string country)
        //    {
        //        City = city;
        //        Country = country;
        //    }
        //}

        public class OpenWeatherModel
        {
            public string cod { get; set; }
            public List<list> list { get; set; }
        }

        public class list
        {
            public DateTime dt_txt { get; set; }
            public main main { get; set; }
        }


        public class main
        {
            public double temp { get; set; }
        }
    }
}
