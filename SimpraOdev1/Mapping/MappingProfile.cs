using AutoMapper;
using SimpraOdev1.Api.DTOs;
using SimpraOdev1.Core.Entities;

namespace SimpraOdev1.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Staff, StaffDTO>();
            CreateMap<StaffDTO, Staff>();        
        }
    }
}
