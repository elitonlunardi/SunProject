using System;
using System.Collections.Generic;

namespace Sun.Infra.CrossCutting.Rest
{
    public class OpenWeatherModel
    {
        public List<Group> list { get; set; }
    }

    public class Group
    {
        public DateTime dt_txt { get; set; }
        public WeatherModel main { get; set; }
    }


    public class WeatherModel
    {
        public double temp { get; set; }
    }
}
