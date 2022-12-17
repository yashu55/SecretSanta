using AutoMapper;
using SecretSanta.Models;
using SecretSanta.Dto;

namespace SecretSanta.Profiles
{
    public class TeammateProfiles : Profile
    {
        public TeammateProfiles()
        {
            //dto to object s
            CreateMap<Teammate, TeammateCreateDto>();
            CreateMap<Teammate, TeammateUpdateDto>();
            //object to dto
            CreateMap<TeammateReadDto, Teammate>();
            
            
        }
    }
}
