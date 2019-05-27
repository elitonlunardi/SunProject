using System;
using AutoMapper;
using Sun.Application;
using Microsoft.Extensions.DependencyInjection;


namespace Sun.Api.Extensions
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            services.AddAutoMapper();
            AutoMapperConfig.RegisterMappings();
        }
    }
}
