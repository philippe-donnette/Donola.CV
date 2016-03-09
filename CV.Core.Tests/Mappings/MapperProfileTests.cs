using AutoMapper;
using CV.Core.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CV.Core.Tests.Mappings
{
    public class MapperProfileTests
    {
        [Fact]
        public void CvMapperProfile_IsValid()
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.AddProfile(new CvMapperProfile());
            });

            mapperConfig.AssertConfigurationIsValid();
        }
    }
}
