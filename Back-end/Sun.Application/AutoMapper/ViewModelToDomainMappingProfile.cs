
using AutoMapper;
using Sun.Domain;

namespace Sun.Application
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CityViewModel, City>();
            CreateMap<WeatherViewModel, Weather>();
        }
    }
}
