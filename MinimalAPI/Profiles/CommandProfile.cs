using AutoMapper;
using MinimalAPI.Dtos;
using MinimalAPI.Models;

namespace MinimalAPI.Profiles
{
    public class CommandProfile : Profile
    {
        public CommandProfile()
        {
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
        }
    }
}