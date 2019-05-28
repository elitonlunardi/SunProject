using System;
using System.Collections.Generic;
using System.Linq;

namespace Sun.Domain
{
    public interface IWeatherRepository : IRepository<Weather>
    {
        IQueryable<Weather> GetByCityId(Guid IdCity);
    }
}
