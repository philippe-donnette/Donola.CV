using AutoMapper;
using CV.Core.Mappings;
using CV.Core.Models;
using CV.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CV.Core.Tests.Mappings
{
    public class MapperProfileTests
    {
        private readonly MapperConfiguration _mapperConfig;
        private readonly IMapper _mapper;

        public MapperProfileTests()
        {
            _mapperConfig = new MapperConfiguration(config =>
            {
                config.AddProfile(new CvMapperProfile());
            });
            _mapper = _mapperConfig.CreateMapper();
        }

        [Fact]
        public void CvMapperProfile_IsValid()
        {
            _mapperConfig.AssertConfigurationIsValid();
        }

        [Fact]
        public void SkillToSkillModel()
        {
            var version1 = new SkillVersion { Id = 1, Name = "RC1", SkillId = 1 };
            var version2 = new SkillVersion { Id = 2, Name = "RC2", SkillId = 1 };
            var skill1 = new Skill
            {
                Id = 1,
                ExperienceRating = 10,
                InterestRating = 9,
                Name = "ASP.NET 5",
                UsageRating = 8,
                Description = "A description about asp.net 5",
                IconClass = "fa fa-something",
                IsVisible = true,
                Versions = new List<SkillVersion> { version1, version2 }
            };
            var skill2 = new Skill
            {
                Id = 2,
                ExperienceRating = 5,
                InterestRating = 6,
                Name = "AngularJS",
                UsageRating = 7,
                Description = "A description about AngularJS",
                IconClass = "fa fa-something",
                IsVisible = true,
                Versions = null
            };

            var skills = new List<Skill>
            {
                skill1,
                skill2
            };

            var model = _mapper.Map<IEnumerable<SkillModel>>(skills);

            var model1 = model.FirstOrDefault(x => x.Id == skill1.Id);
            Assert.Equal(skill1.Description, model1.Description);
            Assert.Equal(skill1.ExperienceRating, model1.ExperienceRating);
            Assert.Equal(skill1.IconClass, model1.IconClass);
            Assert.Equal(skill1.Id, model1.Id);
            Assert.Equal(skill1.InterestRating, model1.InterestRating);
            Assert.Equal(skill1.Name, model1.Name);
            Assert.Equal(skill1.UsageRating, model1.UsageRating);
            Assert.Equal(Convert.ToDouble((skill1.InterestRating + skill1.ExperienceRating + skill1.UsageRating) / 3), model1.Weight);
            Assert.Equal(skill1.Versions.Select(x => x.Name).ToList<string>(), model1.Versions);

            var model2 = model.FirstOrDefault(x => x.Id == skill2.Id);
            Assert.Equal(skill2.Description, model2.Description);
            Assert.Equal(skill2.ExperienceRating, model2.ExperienceRating);
            Assert.Equal(skill2.IconClass, model2.IconClass);
            Assert.Equal(skill2.Id, model2.Id);
            Assert.Equal(skill2.InterestRating, model2.InterestRating);
            Assert.Equal(skill2.Name, model2.Name);
            Assert.Equal(skill2.UsageRating, model2.UsageRating);
            Assert.Equal(Convert.ToDouble((skill2.InterestRating + skill2.ExperienceRating + skill2.UsageRating) / 3), model2.Weight);
            Assert.Equal(model2.Versions.Count, 0);
        }

        #region Project
        [Fact]
        public void ProjectToProjectModel()
        {
            var project1 = new Project { Id = 1, Name = "Project Number 1", Description = null, PrimaryImage = null, StartDate = DateTime.Now, Skills = null };
            var project2 = new Project { Id = 2, Name = "Project Number 2", Description = null, PrimaryImage = null, StartDate = DateTime.Now, Skills = null };
            var project3 = new Project { Id = 3, Name = "Project Number 3", Description = null, PrimaryImage = null, StartDate = DateTime.Now, Skills = null };
            var projects = new List<Project> { project1, project2, project3 };

            var model = _mapper.Map<IEnumerable<ProjectModel>>(projects);

            var model1 = model.FirstOrDefault(x => x.Id == project1.Id);
            Assert.Equal(project1.Description, model1.Description);
            Assert.Equal(project1.Id, model1.Id);
            Assert.Equal(project1.Name, model1.Name);
            Assert.Equal(project1.PrimaryImage, model1.PrimaryImage);
            Assert.Equal(project1.StartDate, model1.StartDate);

            var model2 = model.FirstOrDefault(x => x.Id == project2.Id);
            Assert.Equal(project2.Description, model2.Description);
            Assert.Equal(project2.Id, model2.Id);
            Assert.Equal(project2.Name, model2.Name);
            Assert.Equal(project2.PrimaryImage, model2.PrimaryImage);
            Assert.Equal(project2.StartDate, model2.StartDate);

            var model3 = model.FirstOrDefault(x => x.Id == project3.Id);
            Assert.Equal(project3.Description, model3.Description);
            Assert.Equal(project3.Id, model3.Id);
            Assert.Equal(project3.Name, model3.Name);
            Assert.Equal(project3.PrimaryImage, model3.PrimaryImage);
            Assert.Equal(project3.StartDate, model3.StartDate);
        }

        [Fact]
        public void ProjectSkillToSkillModel()
        {
            var projectSkill1 = new ProjectSkill { ProjectId = 1, SkillId = 1,
                Skill = new Skill { Id = 1, ExperienceRating = 10, InterestRating = 9, UsageRating = 8 },
                UsageRating = 7,
                Versions = new List<ProjectSkillVersion>
                {
                    new ProjectSkillVersion { ProjectId = 1, SkillId = 1, SkillVersionId = 1, Version = new SkillVersion { Name = "RC1", Id = 1, SkillId = 1 } },
                    new ProjectSkillVersion { ProjectId = 1, SkillId = 1, SkillVersionId = 2, Version = new SkillVersion { Name = "RC2", Id = 2, SkillId = 1 } }
                }
            };
            
            var model1 = _mapper.Map<SkillModel>(projectSkill1);

            Assert.Equal(projectSkill1.Skill.Description, model1.Description);
            Assert.Equal(projectSkill1.Skill.ExperienceRating, model1.ExperienceRating);
            Assert.Equal(projectSkill1.Skill.IconClass, model1.IconClass);
            Assert.Equal(projectSkill1.Skill.Id, model1.Id);
            Assert.Equal(projectSkill1.Skill.InterestRating, model1.InterestRating);
            Assert.Equal(projectSkill1.Skill.Name, model1.Name);
            Assert.Equal(projectSkill1.UsageRating, model1.UsageRating);
            Assert.Equal(projectSkill1.UsageRating, model1.Weight);
            Assert.Equal(projectSkill1.Versions.Select(x => x.Version.Name).ToList<string>(), model1.Versions);

            var projectSkill2 = new ProjectSkill
            {
                ProjectId = 2,
                SkillId = 2,
                Skill = new Skill { Id = 2, ExperienceRating = 4, InterestRating = 5, UsageRating = 6 },
                UsageRating = 8,
                Versions = null
            };

            var model2 = _mapper.Map<SkillModel>(projectSkill2);

            Assert.Equal(projectSkill2.Skill.Description, model2.Description);
            Assert.Equal(projectSkill2.Skill.ExperienceRating, model2.ExperienceRating);
            Assert.Equal(projectSkill2.Skill.IconClass, model2.IconClass);
            Assert.Equal(projectSkill2.Skill.Id, model2.Id);
            Assert.Equal(projectSkill2.Skill.InterestRating, model2.InterestRating);
            Assert.Equal(projectSkill2.Skill.Name, model2.Name);
            Assert.Equal(projectSkill2.UsageRating, model2.UsageRating);
            Assert.Equal(projectSkill2.UsageRating, model2.Weight);
            Assert.Equal(model2.Versions.Count, 0);
        }

        [Fact]
        public void ProjectImageToProjectImageModel()
        {
            var projectImage1 = new ProjectImage { Id = 1, Title = "Project Image Number 1", Description = null, ImageUrl = null, ProjectId = 1 };
            var projectImage2 = new ProjectImage { Id = 2, Title = "Project Image Number 2", Description = null, ImageUrl = null, ProjectId = 1 };
            var projectImage3 = new ProjectImage { Id = 3, Title = "Project Image Number 3", Description = null, ImageUrl = null, ProjectId = 1 };
            var projectImages = new List<ProjectImage> { projectImage1, projectImage2, projectImage3 };

            var model = _mapper.Map<IEnumerable<ImageModel>>(projectImages);

            var model1 = model.FirstOrDefault(x => x.Id == projectImage1.Id);
            Assert.Equal(projectImage1.Description, model1.Description);
            Assert.Equal(projectImage1.Id, model1.Id);
            Assert.Equal(projectImage1.Title, model1.Title);
            Assert.Equal(projectImage1.ImageUrl, model1.ImageUrl);

            var model2 = model.FirstOrDefault(x => x.Id == projectImage2.Id);
            Assert.Equal(projectImage2.Description, model2.Description);
            Assert.Equal(projectImage2.Id, model2.Id);
            Assert.Equal(projectImage2.Title, model2.Title);
            Assert.Equal(projectImage2.ImageUrl, model2.ImageUrl);

            var model3 = model.FirstOrDefault(x => x.Id == projectImage3.Id);
            Assert.Equal(projectImage3.Description, model3.Description);
            Assert.Equal(projectImage3.Id, model3.Id);
            Assert.Equal(projectImage3.Title, model3.Title);
            Assert.Equal(projectImage3.ImageUrl, model3.ImageUrl);
        }
        #endregion

        #region Experience
        [Fact]
        public void ExperienceToExperienceModel()
        {
            var exp1 = new Experience { Id = 1, CompanyName = "Company 1", City = "City 1", Country = "Country 1", WebsiteUrl = "Website 1", RoleTitle = "Role 1", Description = "Description 1", ImageUrl = "image1.png", EndDate = null, StartDate = new DateTime(2015, 12, 7), Skills = null };
            var exp2 = new Experience { Id = 2, CompanyName = "Company 2", City = "City 2", Country = "Country 2", WebsiteUrl = "Website 2", RoleTitle = "Role 2", Description = "Description 2", ImageUrl = "image2.jpg", EndDate = new DateTime(2012, 8, 20), StartDate = DateTime.Now, Skills = null };
            var exp3 = new Experience { Id = 3, CompanyName = "Company 3", City = "City 3", Country = "Country 3", WebsiteUrl = "Website 3", RoleTitle = "Role 3", Description = "Description 3", ImageUrl = "image3.gif", EndDate = null, StartDate = DateTime.Now, Skills = null };
            var exps = new List<Experience> { exp1, exp2, exp3 };

            var model = _mapper.Map<IEnumerable<ExperienceModel>>(exps);

            var model1 = model.FirstOrDefault(x => x.Id == exp1.Id);
            Assert.Equal(exp1.Description, model1.Description);
            Assert.Equal(exp1.Id, model1.Id);
            Assert.Equal(exp1.CompanyName, model1.CompanyName);
            Assert.Equal(exp1.Country, model1.Country);
            Assert.Equal(exp1.City, model1.City);
            Assert.Equal(exp1.WebsiteUrl, model1.WebsiteUrl);
            Assert.Equal(exp1.RoleTitle, model1.RoleTitle);
            Assert.Equal(exp1.ImageUrl, model1.ImageUrl);
            Assert.Equal(exp1.StartDate, model1.StartDate);
            Assert.Equal(exp1.EndDate, model1.EndDate);

            var model2 = model.FirstOrDefault(x => x.Id == exp2.Id);
            Assert.Equal(exp2.Description, model2.Description);
            Assert.Equal(exp2.Id, model2.Id);
            Assert.Equal(exp2.CompanyName, model2.CompanyName);
            Assert.Equal(exp2.Country, model2.Country);
            Assert.Equal(exp2.City, model2.City);
            Assert.Equal(exp2.WebsiteUrl, model2.WebsiteUrl);
            Assert.Equal(exp2.RoleTitle, model2.RoleTitle);
            Assert.Equal(exp2.ImageUrl, model2.ImageUrl);
            Assert.Equal(exp2.StartDate, model2.StartDate);
            Assert.Equal(exp2.EndDate, model2.EndDate);

            var model3 = model.FirstOrDefault(x => x.Id == exp3.Id);
            Assert.Equal(exp3.Description, model3.Description);
            Assert.Equal(exp3.Id, model3.Id);
            Assert.Equal(exp3.CompanyName, model3.CompanyName);
            Assert.Equal(exp3.Country, model3.Country);
            Assert.Equal(exp3.City, model3.City);
            Assert.Equal(exp3.WebsiteUrl, model3.WebsiteUrl);
            Assert.Equal(exp3.RoleTitle, model3.RoleTitle);
            Assert.Equal(exp3.ImageUrl, model3.ImageUrl);
            Assert.Equal(exp3.StartDate, model3.StartDate);
            Assert.Equal(exp3.EndDate, model3.EndDate);
        }
        #endregion
    }
}
