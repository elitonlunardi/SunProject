using System;

namespace Sun.Domain
{
    public interface IWeatherRepository : IRepository<Weather>
    {
        Weather GetByDate(DateTime date);
    }
}
