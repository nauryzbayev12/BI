using AutoMapper;
using BI.Core.DTOs;
using BI.Data;

namespace BI.Core.Configurations
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
