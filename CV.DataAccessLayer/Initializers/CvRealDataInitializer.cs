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
            CreateSkills(context);
            CreateSkillVersions(context);
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
        private static Skill easyphp { get; set; }
        private static Skill phpmyadmin { get; set; }
        private static Skill apache { get; set; }
        private static Skill html { get; set; }
        private static Skill css { get; set; }
        private static Skill flash { get; set; }
        private static Skill actionscript { get; set; }
        private static Skill photoshop { get; set; }
        private static Skill iis { get; set; }
        private static Skill vss { get; set; }
        private static Skill toad { get; set; }
        private static Skill ssms { get; set; }
        private static Skill javascript { get; set; }
        private static Skill xml { get; set; }
        private static Skill xslt { get; set; }
        private static Skill svn { get; set; }
        #endregion

        #region SkillVersions
        private static SkillVersion php_4_3 { get; set; }
        private static SkillVersion mysql_4_0_6 { get; set; }
        private static SkillVersion asp_3_0 { get; set; }
        private static SkillVersion asp_net_2_0 { get; set; }
        private static SkillVersion asp_net_3_0 { get; set; }
        private static SkillVersion sqlserver_2000 { get; set; }
        private static SkillVersion sqlserver_2005 { get; set; }
        private static SkillVersion visual_studio_2003 { get; set; }
        private static SkillVersion visual_studio_2005 { get; set; }
        private static SkillVersion csharp_1_2 { get; set; }
        private static SkillVersion csharp_2_0 { get; set; }
        private static SkillVersion dotnet_1_1 { get; set; }
        private static SkillVersion dotnet_2_0 { get; set; }
        private static SkillVersion oracle_8 { get; set; }
        private static SkillVersion windows_xp { get; set; }
        private static SkillVersion windows_vista { get; set; }
        private static SkillVersion windows_server_2003 { get; set; }
        private static SkillVersion html_4_0 { get; set; }
        private static SkillVersion css_2_0 { get; set; }
        private static SkillVersion flash_2004 { get; set; }
        private static SkillVersion actionscript_2_0 { get; set; }
        private static SkillVersion photoshop_elements_7_0 { get; set; }
        private static SkillVersion photoshop_cs_2 { get; set; }
        private static SkillVersion iis_6_0 { get; set; }
        private static SkillVersion vss_6_0 { get; set; }
        private static SkillVersion toad_9_0 { get; set; }
        private static SkillVersion ssms_enterprise_manager { get; set; }
        private static SkillVersion javascript_ecmascript_3 { get; set; }
        private static SkillVersion xslt_1_0 { get; set; }
        private static SkillVersion xml_1_1 { get; set; }
        private static SkillVersion svn_1_3 { get; set; }
        #endregion

        #region Experiences
        private static Experience tomato { get; set; }
        private static Experience intellimind { get; set; }
        private static Experience concileo { get; set; }
        private static Experience dataarchive { get; set; }
        private static Experience hrteam { get; set; }
        private static Experience groovytrain { get; set; }
        private static Experience docdata { get; set; }
        private static Experience uol { get; set; }
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
                    IconClass = null,//"devicons devicons-code",
                    IsVisible = true,
                    Name = "ASP",
                    UsageRating = 1
                };
                #endregion
                #region asp.net
                asp_net = new Skill
                {
                    Description = "ASP.NET is a server-side web application framework designed for web development to produce dynamic web pages. It was developed by Microsoft to allow programmers to build dynamic web sites, web applications and web services.",
                    ExperienceRating = 9,
                    InterestRating = 10,
                    IconClass = "devicons devicons-dotnet",
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
                #region easyphp
                easyphp = new Skill
                {
                    Description = "EasyPHP was the first package WAMP to emerge (1999).",
                    ExperienceRating = 2,
                    InterestRating = 1,
                    IconClass = null,
                    IsVisible = true,
                    Name = "EasyPHP",
                    UsageRating = 1
                };
                #endregion
                #region phpmyadmin
                phpmyadmin = new Skill
                {
                    Description = "phpMyAdmin is a free and open source tool written in PHP intended to handle the administration of MySQL or MariaDB with the use of a web browser.",
                    ExperienceRating = 3,
                    InterestRating = 1,
                    IconClass = null,
                    IsVisible = true,
                    Name = "phpMyAdmin",
                    UsageRating = 3
                };
                #endregion
                #region apache
                apache = new Skill
                {
                    Description = "The Apache HTTP Server, colloquially called Apache, is the world's most used web server software.",
                    ExperienceRating = 4,
                    InterestRating = 5,
                    IconClass = "mfizz mfizz-apache",
                    IsVisible = true,
                    Name = "Apache",
                    UsageRating = 3
                };
                #endregion
                #region html
                html = new Skill
                {
                    Description = "HyperText Markup Language, commonly referred to as HTML, is the standard markup language used to create web pages.",
                    ExperienceRating = 9,
                    InterestRating = 10,
                    IconClass = "mfizz mfizz-html",
                    IsVisible = true,
                    Name = "HTML",
                    UsageRating = 10
                };
                #endregion
                #region css
                css = new Skill
                {
                    Description = "Cascading Style Sheets (CSS) is a style sheet language used for describing the presentation of a document written in a markup language.",
                    ExperienceRating = 7,
                    InterestRating = 6,
                    IconClass = "mfizz mfizz-css",
                    IsVisible = true,
                    Name = "CSS",
                    UsageRating = 10
                };
                #endregion
                #region flash
                flash = new Skill
                {
                    Description = "Adobe Flash (formerly called Macromedia Flash and Shockwave Flash) is a multimedia and software platform used for creating vector graphics, animation, browser games, rich Internet applications, desktop applications, mobile applications and mobile games.",
                    ExperienceRating = 1,
                    InterestRating = 1,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Macromedia Flash MX",
                    UsageRating = 2
                };
                #endregion
                #region actionscript
                actionscript = new Skill
                {
                    Description = "ActionScript is an object-oriented programming language originally developed by Macromedia Inc. (since merged into Adobe Systems).",
                    ExperienceRating = 1,
                    InterestRating = 1,
                    IconClass = null,
                    IsVisible = true,
                    Name = "ActionScript",
                    UsageRating = 2
                };
                #endregion
                #region photoshop
                photoshop = new Skill
                {
                    Description = "Adobe Photoshop is a raster graphics editor developed and published by Adobe Systems for Windows and OS X.",
                    ExperienceRating = 4,
                    InterestRating = 2,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Adobe Photoshop",
                    UsageRating = 3
                };
                #endregion
                #region iis
                iis = new Skill
                {
                    Description = "Internet Information Services (IIS, formerly Internet Information Server) is an extensible web server created by Microsoft for use with Windows NT family.",
                    ExperienceRating = 7,
                    InterestRating = 7,
                    IconClass = null,
                    IsVisible = true,
                    Name = "IIS",
                    UsageRating = 6
                };
                #endregion
                #region vss
                vss = new Skill
                {
                    Description = "Microsoft Visual SourceSafe (VSS) is a discontinued source control program, oriented towards small software development projects.",
                    ExperienceRating = 3,
                    InterestRating = 1,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Microsoft Visual SourceSafe",
                    UsageRating = 2
                };
                #endregion
                #region toad
                toad = new Skill
                {
                    Description = "Toad is application software from Dell Software that database developers, database administrators and data analysts use to manage both relational and non-relational databases using SQL.",
                    ExperienceRating = 2,
                    InterestRating = 1,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Toad",
                    UsageRating = 2
                };
                #endregion
                #region sql server management studio
                ssms = new Skill
                {
                    Description = "SQL Server Management Studio (SSMS) is a software application first launched with the Microsoft SQL Server 2005 that is used for configuring, managing, and administering all components within Microsoft SQL Server.",
                    ExperienceRating = 7,
                    InterestRating = 7,
                    IconClass = null,
                    IsVisible = true,
                    Name = "SQL Server Management Studio",
                    UsageRating = 7
                };
                #endregion
                #region javascript
                javascript = new Skill
                {
                    Description = "JavaScript is a high-level, dynamic, untyped, and interpreted programming language.",
                    ExperienceRating = 7,
                    InterestRating = 10,
                    IconClass = null,
                    IsVisible = true,
                    Name = "JavaScript",
                    UsageRating = 7
                };
                #endregion
                #region xml
                xml = new Skill
                {
                    Description = "Extensible Markup Language (XML) is a markup language that defines a set of rules for encoding documents in a format which is both human-readable and machine-readable.",
                    ExperienceRating = 5,
                    InterestRating = 5,
                    IconClass = "devicons devicons-javascript",
                    IsVisible = true,
                    Name = "XML",
                    UsageRating = 5
                };
                #endregion
                #region xslt
                xslt = new Skill
                {
                    Description = "XSLT (Extensible Stylesheet Language Transformations) is a language for transforming XML documents into other XML documents, or other formats such as HTML for web pages, plain text or into XSL Formatting Objects, which may subsequently be converted to other formats, such as PDF, PostScript and PNG.",
                    ExperienceRating = 2,
                    InterestRating = 1,
                    IconClass = null,
                    IsVisible = true,
                    Name = "XSLT",
                    UsageRating = 2
                };
                #endregion
                #region svn
                svn = new Skill
                {
                    Description = "Apache Subversion (often abbreviated SVN, after the command name svn) is a software versioning and revision control system distributed as free software under the Apache License.",
                    ExperienceRating = 7,
                    InterestRating = 2,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Apache Subversion",
                    UsageRating = 7
                };
                #endregion

                context.Skills.Add(php);
                context.Skills.Add(mysql);
                context.Skills.Add(asp);
                context.Skills.Add(asp_net);
                context.Skills.Add(sqlserver);
                context.Skills.Add(visual_studio);
                context.Skills.Add(csharp);
                context.Skills.Add(dotnet);
                context.Skills.Add(oracle);
                context.Skills.Add(windows);
                context.Skills.Add(easyphp);
                context.Skills.Add(phpmyadmin);
                context.Skills.Add(apache);
                context.Skills.Add(html);
                context.Skills.Add(css);
                context.Skills.Add(flash);
                context.Skills.Add(actionscript);
                context.Skills.Add(photoshop);
                context.Skills.Add(iis);
                context.Skills.Add(vss);
                context.Skills.Add(toad);
                context.Skills.Add(ssms);
                context.Skills.Add(xslt);
                context.Skills.Add(xml);
                context.Skills.Add(javascript);
                context.Skills.Add(svn);
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
                #region visual studio 2005
                visual_studio_2005 = new SkillVersion
                {
                    Name = "Visual Studio 2005",
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
                #region csharp 2.0
                csharp_2_0 = new SkillVersion
                {
                    Name = "C# 2.0",
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
                #region .net framework 2.0
                dotnet_2_0 = new SkillVersion
                {
                    Name = ".NET Framework 2.0",
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
                #region windows vista
                windows_vista = new SkillVersion
                {
                    Name = "Windows Vista",
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
                #region html 4.0
                html_4_0 = new SkillVersion
                {
                    Name = "HTML 4.0",
                    SkillId = html.Id
                };
                #endregion
                #region css 2.0
                css_2_0 = new SkillVersion
                {
                    Name = "CSS 2.0",
                    SkillId = css.Id
                };
                #endregion
                #region flash 2004
                flash_2004 = new SkillVersion
                {
                    Name = "Macromedia Flash MX 2004",
                    SkillId = flash.Id
                };
                #endregion
                #region actionscript 2.0
                actionscript_2_0 = new SkillVersion
                {
                    Name = "ActionScript 2.0",
                    SkillId = actionscript.Id
                };
                #endregion
                #region photoshop elements 7.0
                photoshop_elements_7_0 = new SkillVersion
                {
                    Name = "Adobe Photoshop Elements 7.0",
                    SkillId = photoshop.Id
                };
                #endregion
                #region photoshop cs2
                photoshop_cs_2 = new SkillVersion
                {
                    Name = "Adobe Photoshop CS2",
                    SkillId = photoshop.Id
                };
                #endregion
                #region iis 6.0
                iis_6_0 = new SkillVersion
                {
                    Name = "IIS 6.0",
                    SkillId = iis.Id
                };
                #endregion
                #region vss 6.0
                vss_6_0 = new SkillVersion
                {
                    Name = "Microsoft Visual SourceSafe 6.0",
                    SkillId = iis.Id
                };
                #endregion
                #region toad 9.0
                toad_9_0 = new SkillVersion
                {
                    Name = "Toad 9.0",
                    SkillId = toad.Id
                };
                #endregion
                #region sql server management studio enterprise manager
                ssms_enterprise_manager = new SkillVersion
                {
                    Name = "Enterprise Manager",
                    SkillId = ssms_enterprise_manager.Id
                };
                #endregion
                #region xml 1.1
                xml_1_1 = new SkillVersion
                {
                    Name = "XML 1.1",
                    SkillId = xml.Id
                };
                #endregion
                #region xslt 1.0
                xslt_1_0 = new SkillVersion
                {
                    Name = "XSLT 1.0",
                    SkillId = xslt.Id
                };
                #endregion
                #region javascript ecmascript 3
                javascript_ecmascript_3 = new SkillVersion
                {
                    Name = "ECMAScript 3",
                    SkillId = javascript.Id
                };
                #endregion
                #region asp.net 3.0
                asp_net_3_0 = new SkillVersion
                {
                    Name = "ASP.NET 3.0",
                    SkillId = asp_net.Id
                };
                #endregion
                #region sql server 2005
                sqlserver_2005 = new SkillVersion
                {
                    Name = "SQL Server 2005",
                    SkillId = sqlserver.Id
                };
                #endregion
                #region svn 1.3
                svn_1_3 = new SkillVersion
                {
                    Name = "SVN 1.3",
                    SkillId = svn.Id
                };
                #endregion

                context.SkillVersions.Add(php_4_3);
                context.SkillVersions.Add(mysql_4_0_6);
                context.SkillVersions.Add(asp_3_0);
                context.SkillVersions.Add(asp_net_2_0);
                context.SkillVersions.Add(sqlserver_2000);
                context.SkillVersions.Add(visual_studio_2003);
                context.SkillVersions.Add(visual_studio_2005);
                context.SkillVersions.Add(csharp_1_2);
                context.SkillVersions.Add(csharp_2_0);
                context.SkillVersions.Add(dotnet_1_1);
                context.SkillVersions.Add(dotnet_2_0);
                context.SkillVersions.Add(oracle_8);
                context.SkillVersions.Add(windows_xp);
                context.SkillVersions.Add(windows_vista);
                context.SkillVersions.Add(windows_server_2003);
                context.SkillVersions.Add(html_4_0);
                context.SkillVersions.Add(css_2_0);
                context.SkillVersions.Add(flash_2004);
                context.SkillVersions.Add(actionscript_2_0);
                context.SkillVersions.Add(photoshop_elements_7_0);
                context.SkillVersions.Add(iis_6_0);
                context.SkillVersions.Add(vss_6_0);
                context.SkillVersions.Add(toad_9_0);
                context.SkillVersions.Add(ssms_enterprise_manager);
                context.SkillVersions.Add(xslt_1_0);
                context.SkillVersions.Add(javascript_ecmascript_3);
                context.SkillVersions.Add(xml_1_1);
                context.SkillVersions.Add(asp_net_3_0);
                context.SkillVersions.Add(sqlserver_2005);
                context.SkillVersions.Add(svn_1_3);
                context.SkillVersions.Add(photoshop_cs_2);
            }

            return context.SaveChanges();
        }

        private static int CreateExperiences(CvDbContext context)
        {

            if (!context.Experiences.Any())
            {
                #region T2S
                tomato = new Experience
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
                        },
                        new ExperienceSkill
                        {
                            SkillId = easyphp.Id,
                            UsageRating = 10
                        },
                        new ExperienceSkill
                        {
                            SkillId = phpmyadmin.Id,
                            UsageRating = 7
                        },
                        new ExperienceSkill
                        {
                            SkillId = apache.Id,
                            UsageRating = 10
                        },
                        new ExperienceSkill
                        {
                            SkillId = html.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = html.Id, SkillVersionId = html_4_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = css.Id,
                            UsageRating = 6,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = css.Id, SkillVersionId = css_2_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = flash.Id,
                            UsageRating = 3,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = flash.Id, SkillVersionId = flash_2004.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = actionscript.Id,
                            UsageRating = 2,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = actionscript.Id, SkillVersionId = actionscript_2_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = photoshop.Id,
                            UsageRating = 4,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = photoshop.Id, SkillVersionId = photoshop_elements_7_0.Id }
                            }
                        }
                    }
                };
                #endregion
                #region Intellimind
                intellimind = new Experience
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
                            UsageRating = 6,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = windows.Id, SkillVersionId = windows_xp.Id },
                                new ExperienceSkillVersion { SkillId = windows.Id, SkillVersionId = windows_server_2003.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = html.Id,
                            UsageRating = 6,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = html.Id, SkillVersionId = html_4_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = css.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = css.Id, SkillVersionId = css_2_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = iis.Id,
                            UsageRating = 3,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = iis.Id, SkillVersionId = iis_6_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = vss.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = vss.Id, SkillVersionId = vss_6_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = toad.Id,
                            UsageRating = 4,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = toad.Id, SkillVersionId = toad_9_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = ssms.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = ssms.Id, SkillVersionId = ssms_enterprise_manager.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = javascript.Id,
                            UsageRating = 2,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_3.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = xslt.Id,
                            UsageRating = 3,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = xslt.Id, SkillVersionId = xslt_1_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = xml.Id,
                            UsageRating = 3,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = xml.Id, SkillVersionId = xml_1_1.Id }
                            }
                        }
                    }
                };
                #endregion
                #region Concileo
                concileo = new Experience
                {
                    City = "Paris",
                    CompanyName = "Concileo",
                    Country = "France",
                    EndDate = new DateTime(2007, 12, 31),
                    ImageUrl = "concileo-experience-icon.png",
                    RoleTitle = "Project manager and developer",
                    WebsiteUrl = "http://www.concileo.com",
                    Description = "Analysis and development of web community platforms (blog, forum, photo, video, social networking application) using Microsoft technologies (ASP.NET, ASP, C#, SQL SERVER) and Web technologies.",
                    StartDate = new DateTime(2006, 5, 1),
                    Skills = new List<ExperienceSkill>
                    {
                        new ExperienceSkill
                        {
                            SkillId = asp.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = asp.Id, SkillVersionId = asp_3_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = asp_net.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_3_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = sqlserver.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = sqlserver.Id, SkillVersionId = sqlserver_2000.Id },
                                new ExperienceSkillVersion { SkillId = sqlserver.Id, SkillVersionId = sqlserver_2005.Id }

                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = visual_studio.Id,
                            UsageRating = 9,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_2005.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = csharp.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = csharp.Id, SkillVersionId = csharp_2_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = dotnet.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_2_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = windows.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = windows.Id, SkillVersionId = windows_xp.Id },
                                new ExperienceSkillVersion { SkillId = windows.Id, SkillVersionId = windows_server_2003.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = html.Id,
                            UsageRating = 6,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = html.Id, SkillVersionId = html_4_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = css.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = css.Id, SkillVersionId = css_2_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = iis.Id,
                            UsageRating = 3,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = iis.Id, SkillVersionId = iis_6_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = ssms.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = ssms.Id, SkillVersionId = ssms_enterprise_manager.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = svn.Id,
                            UsageRating = 9,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = svn.Id, SkillVersionId = svn_1_3.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = photoshop.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = photoshop.Id, SkillVersionId = photoshop_cs_2.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = javascript.Id,
                            UsageRating = 6,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_3.Id }
                            }
                        }
                        //ASP.NET AJAX, AJAX, XML, Web Service, Google API,  
                    }
                };
                #endregion
                #region The Data Archive
                dataarchive = new Experience
                {
                    City = "London",
                    CompanyName = "The Data Archive",
                    Country = "United Kingdom",
                    EndDate = new DateTime(2009, 4, 30),
                    ImageUrl = "tda-experience-icon.png",
                    RoleTitle = "Developer",
                    WebsiteUrl = "http://www.thedataarchive.com",
                    Description = "Analysis and development of image libraries web solutions including e-commerce and online download using Microsoft technologies (ASP.NET, ASP, C#, SQL SERVER) and Web technologies.",
                    StartDate = new DateTime(2008, 5, 1),
                    Skills = new List<ExperienceSkill>
                    {
                        
                    }
                };
                #endregion
                #region HR TEAM
                hrteam = new Experience
                {
                    City = "Paris",
                    CompanyName = "H.R team",
                    Country = "France",
                    EndDate = new DateTime(2010, 8, 31),
                    ImageUrl = "hrteam-experience-icon.png",
                    RoleTitle = "Developer",
                    WebsiteUrl = "http://www.hr-team.net/",
                    Description = "6 months contract with ITELIOS to develop and maintain e-commerce web solutions using Microsoft technologies (ASP.NET, ASP, C#, SQL SERVER, COMMERCE SERVER) and Web technologies.",
                    StartDate = new DateTime(2010, 2, 1),
                    Skills = new List<ExperienceSkill>
                    {

                    }
                };
                #endregion
                #region Groovy Train
                groovytrain = new Experience
                {
                    City = "London",
                    CompanyName = "Groovy Train",
                    Country = "United Kingdom",
                    EndDate = new DateTime(2011, 3, 31),
                    ImageUrl = "groovytrain-experience-icon.png",
                    RoleTitle = "Developer",
                    WebsiteUrl = null,
                    Description = "Analysis and development of an application to integrate data between an e-commerce platform and a data warehouse (DOTNET, C#, SQL SERVER, ORACLE).",
                    StartDate = new DateTime(2010, 9, 1),
                    Skills = new List<ExperienceSkill>
                    {

                    }
                };
                #endregion

                context.Experiences.Add(tomato);
                context.Experiences.Add(intellimind);
                context.Experiences.Add(concileo);
                context.Experiences.Add(dataarchive);
                context.Experiences.Add(hrteam);
                context.Experiences.Add(groovytrain);

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
