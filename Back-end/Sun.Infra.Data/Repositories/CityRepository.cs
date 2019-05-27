using Sun.Domain;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Sun.Infra.Data
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(SunContext context) : base(context)
        {
        }

        public City GetByName(string name)
        {
            return _dbSet.AsNoTracking().FirstOrDefault(c => c.Name == name);
        }
    }
}
