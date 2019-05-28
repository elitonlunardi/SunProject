using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Sun.Domain;
using Sun.Infra.CrossCutting.Rest;

namespace Sun.Application
{
    public class CityAppService : ICityAppService
    {
        private readonly ICityRepository _cityRepository;
        private readonly IWeatherRepository _weatherRepository;
        private readonly IMapper _mapper;
        private readonly IRestClient _restClient;
        public CityAppService(ICityRepository cityRepository, IWeatherRepository weatherRepository, IMapper mapper, IRestClient restClient
            )
        {
            _cityRepository = cityRepository;
            _weatherRepository = weatherRepository;
            _mapper = mapper;
            _restClient = restClient;
        }

        public void Add(CityViewModel cityViewModel)
        {
            var request = _restClient.GetMethod(cityViewModel.Name);
            var group = request.list.GroupBy(c => c.dt_txt.Date);
            var media = group.Select(c => new
            {
                Data = c.Key,
                MediaWeather = c.Sum(a => a.main.temp) / c.Count()
            });

            var entity = _mapper.Map<City>(cityViewModel);
            media.ToList().ForEach(a => entity.AddWeather(new Weather(a.Data, a.MediaWeather)));
            _cityRepository.Add(entity);
            _cityRepository.SaveChanges();
        }

        public IEnumerable<CityViewModel> GetAll()
        {
            var cities = _cityRepository.GetAll().ProjectTo<CityViewModel>(_mapper.ConfigurationProvider);
            return cities;
        }

        public void Remove(Guid id)
        {
            _cityRepository.Remove(id);
            _cityRepository.SaveChanges();
        }

        public void Update(CityViewModel cityViewModel)
        {
            var map = _mapper.Map<City>(cityViewModel);
            _cityRepository.Update(map);
            _cityRepository.SaveChanges();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<WeatherViewModel> GetWeatherIdCity(string id)
        {
            var weathers = _weatherRepository.GetByCityId(Guid.Parse(id)).ProjectTo<WeatherViewModel>(_mapper.ConfigurationProvider).ToList();
            return weathers.ToList().OrderBy(a => a.Date);
        }
    }
}
