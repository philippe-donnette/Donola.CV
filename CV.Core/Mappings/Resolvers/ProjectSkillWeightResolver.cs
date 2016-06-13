using AutoMapper;
using CV.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.Core.Mappings.Resolvers
{
    public class ProjectSkillWeightResolver : IValueResolver<ProjectSkill, int>
    {
        public int Resolve(ProjectSkill source, ResolutionContext context)
        {
            return (int)Math.Round(Convert.ToDouble((source.UsageRating + source.Skill.InterestRating + source.Skill.ExperienceRating) / 3));
        }
        /*
        protected override int ResolveCore(ProjectSkill projectSkill)
        {
            return (int)Math.Round(Convert.ToDouble((projectSkill.UsageRating + projectSkill.Skill.InterestRating + projectSkill.Skill.ExperienceRating) / 3));
        }
        */
    }
}
