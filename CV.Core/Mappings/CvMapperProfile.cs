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
                .ForMember(x => x.Versions, o => o.MapFrom(src => src.Versions != null 
                    ? src.Versions.Select(x => x.Name).ToList()
                    : null)
                    )
                .ForMember(x => x.Weight, o => o.ResolveUsing<SkillWeightResolver>());
            #region Project
            CreateMap<Project, ProjectModel>();
            CreateMap<ProjectSkill, SkillModel>()
                .ForMember(x => x.Description, o => o.MapFrom(src => src.Skill.Description))
                .ForMember(x => x.IconClass, o => o.MapFrom(src => src.Skill.IconClass))
                .ForMember(x => x.Id, o => o.MapFrom(src => src.SkillId))
                .ForMember(x => x.Name, o => o.MapFrom(src => src.Skill.Name))
                .ForMember(x => x.Versions, o => o.MapFrom(src => src.Versions != null 
                    ? src.Versions.Select(x => x.Version != null ? x.Version.Name : null).ToList()
                    : null)
                    )
                .ForMember(x => x.Weight, o => o.MapFrom(src => src.UsageRating))
                .ForMember(x => x.UsageRating, o => o.MapFrom(src => src.UsageRating))
                .ForMember(x => x.InterestRating, o => o.MapFrom(src => src.Skill.InterestRating))
                .ForMember(x => x.ExperienceRating, o => o.MapFrom(src => src.Skill.ExperienceRating));
            CreateMap<ProjectImage, ImageModel>();
            #endregion
            #region Experience
            CreateMap<Experience, ExperienceModel>();
            CreateMap<ExperienceSkill, SkillModel>()
                .ForMember(x => x.Description, o => o.MapFrom(src => src.Skill.Description))
                .ForMember(x => x.IconClass, o => o.MapFrom(src => src.Skill.IconClass))
                .ForMember(x => x.Id, o => o.MapFrom(src => src.SkillId))
                .ForMember(x => x.Name, o => o.MapFrom(src => src.Skill.Name))
                .ForMember(x => x.Versions, o => o.MapFrom(src => src.Versions != null
                    ? src.Versions.Select(x => x.Version != null ? x.Version.Name : null).ToList()
                    : null)
                    )
                .ForMember(x => x.Weight, o => o.MapFrom(src => src.UsageRating))
                .ForMember(x => x.UsageRating, o => o.MapFrom(src => src.UsageRating))
                .ForMember(x => x.InterestRating, o => o.MapFrom(src => src.Skill.InterestRating))
                .ForMember(x => x.ExperienceRating, o => o.MapFrom(src => src.Skill.ExperienceRating));
            #endregion
            #region Person
            CreateMap<Person, PersonModel>();
            #endregion
            #region Qualification
            CreateMap<Qualification, QualificationModel>();
            #endregion
            #region Training
            CreateMap<Training, TrainingModel>();
            #endregion
            #region Card
            CreateMap<Card, CardModel>();
            #endregion
        }
    }
}
