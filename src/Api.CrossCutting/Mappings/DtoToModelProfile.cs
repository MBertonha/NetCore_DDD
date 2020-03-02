using Api.Domain.Dtos.User;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            //Dto para model e model para Dto
            CreateMap<userModel, UserDto>().ReverseMap();
            CreateMap<userModel, UserDtoCreate>().ReverseMap();
            CreateMap<userModel, UserDtoUpdate>().ReverseMap();
        }
    }
}
