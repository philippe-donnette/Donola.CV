using CV.DataAccessLayer.Contexts;
using CV.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.DataAccessLayer.Initializers
{
    public static class CvRealDataInitializer
    {
        public static void EnsureSeedRealData(this CvDbContext context)
        {
            CreateExperiences(context);
        }

        #region Skills
        private static Skill php { get; set; }
        private static Skill mysql { get; set; }
        private static Skill asp { get; set; }
        private static Skill asp_net { get; set; }
        private static Skill sqlserver { get; set; }
        private static Skill visual_studio { get; set; }
        private static Skill csharp { get; set; }
        private static Skill dotnet { get; set; }
        private static Skill oracle { get; set; }
        private static Skill windows { get; set; }
        #endregion

        #region SkillVersions
        private static SkillVersion php_4_3 { get; set; }
        private static SkillVersion mysql_4_0_6 { get; set; }
        private static SkillVersion asp_3_0 { get; set; }
        private static SkillVersion asp_net_2_0 { get; set; }
        private static SkillVersion sqlserver_2000 { get; set; }
        private static SkillVersion visual_studio_2003 { get; set; }
        private static SkillVersion csharp_1_2 { get; set; }
        private static SkillVersion dotnet_1_1 { get; set; }
        private static SkillVersion oracle_8 { get; set; }
        private static SkillVersion windows_xp { get; set; }
        private static SkillVersion windows_server_2003 { get; set; }
        #endregion

        private static int CreateSkills(CvDbContext context)
        {
            if (!context.Skills.Any())
            {
                #region php
                php = new Skill
                {
                    Description = "PHP is a server-side scripting language designed for web development but also used as a general-purpose programming language.",
                    ExperienceRating = 4,
                    InterestRating = 1,
                    IconClass = "devicons devicons-php",
                    IsVisible = true,
                    Name = "php",
                    UsageRating = 1
                };
                #endregion
                #region mysql
                mysql = new Skill
                {
                    Description = "MySQL is an open-source relational database management system (RDBMS).",
                    ExperienceRating = 4,
                    InterestRating = 3,
                    IconClass = "devicons devicons-mysql",
                    IsVisible = true,
                    Name = "MySQL",
                    UsageRating = 3
                };
                #endregion
                #region asp
                asp = new Skill
                {
                    Description = "Active Server Pages (ASP), later known as Classic ASP or ASP Classic, is Microsoft's first server-side script engine for dynamically generated web pages.",
                    ExperienceRating = 5,
                    InterestRating = 1,
                    IconClass = null,
                    IsVisible = true,
                    Name = "ASP",
                    UsageRating = 1
                };
                #endregion
                #region asp.net
                asp = new Skill
                {
                    Description = "ASP.NET is a server-side web application framework designed for web development to produce dynamic web pages. It was developed by Microsoft to allow programmers to build dynamic web sites, web applications and web services.",
                    ExperienceRating = 9,
                    InterestRating = 10,
                    IconClass = "devicons devicons-dot-net",
                    IsVisible = true,
                    Name = "ASP.NET",
                    UsageRating = 9
                };
                #endregion
                #region sql server
                sqlserver = new Skill
                {
                    Description = "Microsoft SQL Server is a relational database management system developed by Microsoft.",
                    ExperienceRating = 9,
                    InterestRating = 10,
                    IconClass = "devicons devicons-msql_server",
                    IsVisible = true,
                    Name = "Microsoft SQL Server",
                    UsageRating = 9
                };
                #endregion
                #region visual studio
                visual_studio = new Skill
                {
                    Description = "Microsoft Visual Studio is an integrated development environment (IDE) from Microsoft.",
                    ExperienceRating = 9,
                    InterestRating = 10,
                    IconClass = "devicons devicons-visualstudio",
                    IsVisible = true,
                    Name = "Microsoft Visual Studio",
                    UsageRating = 9
                };
                #endregion
                #region csharp
                csharp = new Skill
                {
                    Description = "C# is a multi-paradigm programming language encompassing strong typing, imperative, declarative, functional, generic, object-oriented (class-based), and component-oriented programming disciplines.",
                    ExperienceRating = 9,
                    InterestRating = 10,
                    IconClass = "mfizz mfizz-csharp",
                    IsVisible = true,
                    Name = "C#",
                    UsageRating = 9
                };
                #endregion
                #region .net framework
                dotnet = new Skill
                {
                    Description = ".NET Framework is a software framework developed by Microsoft that runs primarily on Microsoft Windows.",
                    ExperienceRating = 9,
                    InterestRating = 10,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = ".NET Framework",
                    UsageRating = 9
                };
                #endregion
                #region oracle
                oracle = new Skill
                {
                    Description = "Oracle Database (commonly referred to as Oracle RDBMS or simply as Oracle) is an object-relational database management system produced and marketed by Oracle Corporation.",
                    ExperienceRating = 2,
                    InterestRating = 5,
                    IconClass = "mfizz mfizz-oracle",
                    IsVisible = true,
                    Name = "Oracle",
                    UsageRating = 1
                };
                #endregion
                #region windows
                windows = new Skill
                {
                    Description = "Microsoft Windows (or simply Windows) is a metafamily of graphical operating systems developed, marketed, and sold by Microsoft.",
                    ExperienceRating = 9,
                    InterestRating = 9,
                    IconClass = "devicons devicons-windows",
                    IsVisible = true,
                    Name = "Microsoft Windows",
                    UsageRating = 9
                };
                #endregion
            }
            return context.SaveChanges();
        }

        private static int CreateSkillVersions(CvDbContext context)
        {
            if (!context.SkillVersions.Any())
            {
                #region php 4.3
                php_4_3 = new SkillVersion
                {
                    Name = "php 4.3",
                    SkillId = php.Id                      
                };
                #endregion
                #region mysql 4.0.6
                mysql_4_0_6 = new SkillVersion
                {
                    Name = "MySQL 4.0.6",
                    SkillId = mysql.Id
                };
                #endregion
                #region asp 3.0
                asp_3_0 = new SkillVersion
                {
                    Name = "ASP 3.0",
                    SkillId = asp.Id
                };
                #endregion
                #region asp.net 2.0
                asp_net_2_0 = new SkillVersion
                {
                    Name = "ASP.NET 2.0",
                    SkillId = asp_net.Id
                };
                #endregion
                #region sql server 2000
                sqlserver_2000 = new SkillVersion
                {
                    Name = "SQL Server 2000",
                    SkillId = sqlserver.Id
                };
                #endregion
                #region visual studio 2003
                visual_studio_2003 = new SkillVersion
                {
                    Name = "Visual Studio .NET 2003",
                    SkillId = visual_studio.Id
                };
                #endregion
                #region csharp 1.2
                csharp_1_2 = new SkillVersion
                {
                    Name = "C# 1.2",
                    SkillId = csharp.Id
                };
                #endregion
                #region .net framework 1.1
                dotnet_1_1 = new SkillVersion
                {
                    Name = ".NET Framework 1.1",
                    SkillId = dotnet.Id
                };
                #endregion
                #region oracle 8
                oracle_8 = new SkillVersion
                {
                    Name = "Oracle8",
                    SkillId = oracle.Id
                };
                #endregion
                #region windows xp
                windows_xp = new SkillVersion
                {
                    Name = "Windows XP",
                    SkillId = windows.Id
                };
                #endregion
                #region windows server 2003
                windows_server_2003 = new SkillVersion
                {
                    Name = "Windows Server 2003",
                    SkillId = windows.Id
                };
                #endregion
            }

            return context.SaveChanges();
        }

        private static int CreateExperiences(CvDbContext context)
        {

            if (!context.Experiences.Any())
            {
                #region T2S
                context.Experiences.Add(new Experience
                {
                    City = "Noisy-Le-Grand",
                    CompanyName = "T2S",
                    Country = "France",
                    EndDate = new DateTime(2005, 8, 31),
                    ImageUrl = "tomato-experience-icon.png",
                    RoleTitle = "Webmaster Developer",
                    WebsiteUrl = null,
                    Description = "Analysis and development of an E-commerce website for skateboarding equipment using Web technologies (PHP, MYSQL).",
                    StartDate = new DateTime(2003, 9, 1),
                    Skills = new List<ExperienceSkill>
                    {
                        new ExperienceSkill
                        {
                            SkillId = php.Id,
                            UsageRating = 10,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = php.Id, SkillVersionId = php_4_3.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = mysql.Id,
                            UsageRating = 10,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = mysql.Id, SkillVersionId = mysql_4_0_6.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = windows.Id,
                            UsageRating = 10,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = windows.Id, SkillVersionId = windows_xp.Id }
                            }
                        }
                        //easyPHP
                    }
                });
                #endregion
                #region Intellimind
                context.Experiences.Add(new Experience
                {
                    City = "Paris",
                    CompanyName = "Intellimind",
                    Country = "France",
                    EndDate = new DateTime(2006, 4, 30),
                    ImageUrl = "intellimind-experience-icon.png",
                    RoleTitle = "Developer",
                    WebsiteUrl = "http://www.intellimind.fr/",
                    Description = "Development of a financial software called “Credit Voyager” using Microsoft technologies (ASP.NET, ASP, C#), Web technologies and multi database (ORACLE, SQL SERVER). This software allows banks and companies to evaluate their customers credential risks.",
                    StartDate = new DateTime(2005, 10, 1),
                    Skills = new List<ExperienceSkill>
                    {
                        new ExperienceSkill
                        {
                            SkillId = asp.Id,
                            UsageRating = 9,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = asp.Id, SkillVersionId = asp_3_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = asp_net.Id,
                            UsageRating = 3,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_2_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = sqlserver.Id,
                            UsageRating = 6,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = sqlserver.Id, SkillVersionId = sqlserver_2000.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = visual_studio.Id,
                            UsageRating = 6,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_2003.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = csharp.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = csharp.Id, SkillVersionId = csharp_1_2.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = dotnet.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_1_1.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = oracle.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = oracle.Id, SkillVersionId = oracle_8.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = windows.Id,
                            UsageRating = 10,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = windows.Id, SkillVersionId = windows_xp.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = windows.Id,
                            UsageRating = 1,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = windows.Id, SkillVersionId = windows_server_2003.Id }
                            }
                        }
                        //IIS, TOAD, VSS
                    }
                });
                #endregion

                /*
                context.Experiences.Add(new Experience
                {
                    City = "London",
                    CompanyName = "University of London",
                    Country = "United Kingdom",
                    EndDate = new DateTime(2016, 4, 30),
                    ImageUrl = "uol-experience-icon.png",
                    RoleTitle = "Senior Developer",
                    WebsiteUrl = "http://www.london.ac.uk",
                    Description = "<p>Some description about the role goes here, do not make it too long as this is not something people might be very interested to read</p><ul><li>bazinga</li><li>kaouabounga</li><li>yata</li></ul>",
                    StartDate = new DateTime(2012, 4, 17),
                    Skills = new List<ExperienceSkill>
                    {
                        new ExperienceSkill { SkillId = 1, UsageRating = 3 },
                        new ExperienceSkill { SkillId = 2, UsageRating = 9 },
                        new ExperienceSkill { SkillId = 3, UsageRating = 2 }
                    }
                });
                context.Experiences.Add(new Experience
                {
                    City = "London",
                    CompanyName = "DOCDATA",
                    Country = "United Kingdom",
                    EndDate = new DateTime(2012, 3, 30),
                    ImageUrl = "docdata-experience-icon.png",
                    RoleTitle = "Senior Developer",
                    WebsiteUrl = "http://www.docdata.ac.uk",
                    Description = "<p>Some description about the role goes here, do not make it too long as this is not something people might be very interested to read</p><ul><li>bazinga</li><li>kaouabounga</li><li>yata</li></ul>",
                    StartDate = new DateTime(2011, 4, 1),
                    Skills = new List<ExperienceSkill>
                    {
                        new ExperienceSkill { SkillId = 1, UsageRating = 9 },
                        new ExperienceSkill { SkillId = 3, UsageRating = 7 }
                    }
                });
                context.Experiences.Add(new Experience
                {
                    City = "London",
                    CompanyName = "GroovyTrain",
                    Country = "United Kingdom",
                    EndDate = new DateTime(2011, 3, 20),
                    ImageUrl = "groovytrain-experience-icon.png",
                    RoleTitle = "Dotnet Developer",
                    WebsiteUrl = null,
                    Description = "<p>Some description about the role goes here, do not make it too long as this is not something people might be very interested to read</p><ul><li>bazinga</li><li>kaouabounga</li><li>yata</li></ul>",
                    StartDate = new DateTime(2010, 9, 20),
                    Skills = new List<ExperienceSkill>
                    {
                        new ExperienceSkill { SkillId = 2, UsageRating = 6 },
                        new ExperienceSkill { SkillId = 3, UsageRating = 8 }
                    }
                });
                */
            }

            return context.SaveChanges();
        }
    }
}
