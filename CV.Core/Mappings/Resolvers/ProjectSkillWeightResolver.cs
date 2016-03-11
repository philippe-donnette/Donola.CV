using AutoMapper;
using CV.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.Core.Mappings.Resolvers
{
    public class ProjectSkillWeightResolver : ValueResolver<ProjectSkill, int>
    {
        protected override int ResolveCore(ProjectSkill projectSkill)
        {
            return (int)Math.Round(Convert.ToDouble((projectSkill.UsageRating + projectSkill.Skill.InterestRating + projectSkill.Skill.ExperienceRating) / 3));
        }
    }
}
