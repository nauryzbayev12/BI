using AutoMapper;
using BI.Core;
using BI.Domain.DTOs;

namespace BI.API.Configurations
{
    public class MapperInitilizer : Profile
    {
        public MapperInitilizer()
        {
            CreateMap<Project, HotelDTO>().ReverseMap();
            CreateMap<Project, CreateHotelDTO>().ReverseMap();
            CreateMap<Project, UpdateHotelDTO>().ReverseMap();
            CreateMap<ApplicationUser, UserDTO>().ReverseMap();
        }
    }
}
