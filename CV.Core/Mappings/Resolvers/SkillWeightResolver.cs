using AutoMapper;
using CV.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.Core.Mappings.Resolvers
{
    public class SkillWeightResolver : IValueResolver<Skill, int>
    {
        public int Resolve(Skill source, ResolutionContext context)
        {
            return (int)Math.Round(Convert.ToDouble((source.UsageRating + source.InterestRating + source.ExperienceRating) / 3));
        }
        /*
        protected override int ResolveCore(Skill skill)
        {
            return (int)Math.Round(Convert.ToDouble((skill.UsageRating + skill.InterestRating + skill.ExperienceRating) / 3));
        }
        */
    }
}
