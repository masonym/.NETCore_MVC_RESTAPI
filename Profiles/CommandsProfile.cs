using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //maps between source and destination object
            //in this case, source is commands object, destination is dto
            CreateMap<Command, CommandReadDto>();
        }
    }
}