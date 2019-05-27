using System;
using System.Collections.Generic;
using System.Text;

namespace Sun.Application
{
    public interface ICityAppService : IDisposable
    {
        void Add(CityViewModel cityViewModel);
        void Update(CityViewModel cityViewModel);
        void Remove(Guid id);
        IEnumerable<CityViewModel> GetAll();
    }
}
