using AutoMapper;
using Sun.Domain;

namespace Sun.Application
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<City, CityViewModel>();
        }
    }
}
