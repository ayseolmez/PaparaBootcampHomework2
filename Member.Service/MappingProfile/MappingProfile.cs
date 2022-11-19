using AutoMapper;
using Member.Service.DTOs;
using System;

namespace Member.Service.MappingProfile
{
    using Member.Domain.Entities;
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Member, MemberDto>().ReverseMap();
        }
    }
}
