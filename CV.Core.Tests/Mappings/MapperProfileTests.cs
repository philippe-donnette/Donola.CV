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
        private MapperConfiguration mapperConfig;

        public MapperProfileTests()
        {
            mapperConfig = new MapperConfiguration(config =>
            {
                config.AddProfile(new CvMapperProfile());
            });
        }

        [Fact]
        public void CvMapperProfile_IsValid()
        {
            mapperConfig.AssertConfigurationIsValid();
        }

        //New test here to test individual mappings
    }
}
