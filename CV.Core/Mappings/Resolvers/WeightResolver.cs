using AutoMapper;
using CV.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.Core.Mappings.Resolvers
{
    public class WeightResolver : ValueResolver<Skill, int>
    {
        protected override int ResolveCore(Skill skill)
        {
            return (int)Math.Round(Convert.ToDouble((skill.UsageRating + skill.InterestRating + skill.ExperienceRating) / 3));
        }
    }
}
