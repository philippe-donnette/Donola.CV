using AutoMapper;
using CV.Core.Models;
using CV.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.Core.Mappings.Resolvers
{
    public class SkillWeightResolver : IValueResolver<Skill, SkillModel, int>
    {
        public int Resolve(Skill source, SkillModel destination, int member, ResolutionContext context)
        {
            return (int)Math.Round(System.Convert.ToDouble((source.UsageRating + source.InterestRating + source.ExperienceRating) / 3));
        }
        /*
        protected override int ResolveCore(Skill skill)
        {
            return (int)Math.Round(Convert.ToDouble((skill.UsageRating + skill.InterestRating + skill.ExperienceRating) / 3));
        }
        */
    }
}
