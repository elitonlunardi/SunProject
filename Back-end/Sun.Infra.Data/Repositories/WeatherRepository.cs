using Microsoft.EntityFrameworkCore;
using Sun.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sun.Infra.Data
{
    public class WeatherRepository : Repository<Weather>, IWeatherRepository
    {
        public WeatherRepository(SunContext context) : base(context)
        {
        }

        public IQueryable<Weather> GetByCityId(Guid IdCity)
        {
            return _dbSet.AsNoTracking().Where(w => w.CityId == IdCity).AsQueryable();
        }
    }
}
