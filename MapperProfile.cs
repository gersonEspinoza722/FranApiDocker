using AutoMapper;
using FranApiDocker.Dtos;
using FranApiDocker.Models;

namespace FranApiDocker
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Office, GetOfficeDto>();
        }
    }
}