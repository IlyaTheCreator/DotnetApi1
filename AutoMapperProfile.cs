using Api.Dtos.Characters;
using Api.Models;
using AutoMapper; 

namespace Api 
{
    public class AutoMapperProfile : Profile 
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<GetCharacterDto, Character>();
            CreateMap<Character, AddCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}