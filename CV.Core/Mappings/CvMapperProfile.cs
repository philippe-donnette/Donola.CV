using AutoMapper;
using CV.Core.Mappings.Resolvers;
using CV.Core.Models;
using CV.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.Core.Mappings
{
    public class CvMapperProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Skill, SkillModel>()
                .ForMember(x => x.Versions, o => o.MapFrom(src => src.Versions.Select(x => x.Name).ToList()))
                .ForMember(x => x.Weight, o => o.ResolveUsing<WeightResolver>());
            CreateMap<Project, ProjectModel>();
        }
    }
}
