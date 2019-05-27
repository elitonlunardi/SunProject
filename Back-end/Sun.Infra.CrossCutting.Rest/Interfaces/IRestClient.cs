using Sun.Infra.CrossCutting.Rest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sun.Infra.CrossCutting.Rest
{
    public interface IRestClient
    {
        OpenWeatherModel GetMethod(string cityName);
    }
}
