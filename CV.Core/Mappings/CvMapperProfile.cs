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
                .ForMember(x => x.Weight, o => o.ResolveUsing<SkillWeightResolver>());
            CreateMap<Project, ProjectModel>();
            CreateMap<ProjectSkill, SkillModel>()
                .ForMember(x => x.Description, o => o.MapFrom(src => src.Skill.Description))
                .ForMember(x => x.IconClass, o => o.MapFrom(src => src.Skill.IconClass))
                .ForMember(x => x.Id, o => o.MapFrom(src => src.SkillId))
                .ForMember(x => x.Name, o => o.MapFrom(src => src.Skill.Name))
                .ForMember(x => x.Versions, o => o.Ignore()) //Ignore at the moment but need to implement ProjectSkillVersion
                .ForMember(x => x.Weight, o => o.ResolveUsing<ProjectSkillWeightResolver>())
                .ForMember(x => x.UsageRating, o => o.MapFrom(src => src.UsageRating))
                .ForMember(x => x.InterestRating, o => o.MapFrom(src => src.Skill.InterestRating))
                .ForMember(x => x.ExperienceRating, o => o.MapFrom(src => src.Skill.ExperienceRating));
        }
    }
}
