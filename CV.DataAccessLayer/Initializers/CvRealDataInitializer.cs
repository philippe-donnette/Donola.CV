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
        private static Skill winform { get; set; }
        private static Skill ado_net { get; set; }
        private static Skill sql { get; set; }
        private static Skill asp_net_ajax { get; set; }
        private static Skill ajax { get; set; }
        private static Skill web_service { get; set; }
        private static Skill google_api { get; set; }
        private static Skill console_app { get; set; }
        private static Skill soap { get; set; }
        private static Skill tfs { get; set; }
        private static Skill xsd { get; set; }
        private static Skill commerce_server { get; set; }
        private static Skill scrum { get; set; }
        private static Skill jquery { get; set; }
        private static Skill jquery_ui { get; set; }
        private static Skill agile { get; set; }
        private static Skill cims { get; set; }
        private static Skill di { get; set; }
        private static Skill razor { get; set; }
        private static Skill telerik_mvc { get; set; }
        private static Skill mvc { get; set; }
        private static Skill sitefinity { get; set; }
        private static Skill structuremap { get; set; }
        private static Skill mysql_workbench { get; set; }
        private static Skill shibboleth { get; set; }
        private static Skill saml { get; set; }
        private static Skill jenkins { get; set; }
        private static Skill knockout { get; set; }
        private static Skill angularjs { get; set; }
        private static Skill lync_sdk { get; set; }
        private static Skill rhel { get; set; }
        private static Skill fedora_core { get; set; }
        private static Skill pivotal_tracker { get; set; }
        private static Skill axosoft { get; set; }
        private static Skill ssl { get; set; }
        #endregion

        #region SkillVersions
        private static SkillVersion php_4_3 { get; set; }
        private static SkillVersion mysql_4_0_6 { get; set; }
        private static SkillVersion mysql_5_0_96 { get; set; }
        private static SkillVersion mysql_5_1_73 { get; set; }
        private static SkillVersion asp_3_0 { get; set; }
        private static SkillVersion asp_net_2_0 { get; set; }
        private static SkillVersion asp_net_3_0 { get; set; }
        private static SkillVersion asp_net_3_5 { get; set; }
        private static SkillVersion asp_net_4_0 { get; set; }
        private static SkillVersion asp_net_4_5 { get; set; }
        private static SkillVersion asp_net_4_5_1 { get; set; }
        private static SkillVersion asp_net_4_5_2 { get; set; }
        private static SkillVersion asp_net_4_6 { get; set; }
        private static SkillVersion sqlserver_2000 { get; set; }
        private static SkillVersion sqlserver_2005 { get; set; }
        private static SkillVersion sqlserver_2008 { get; set; }
        private static SkillVersion sqlserver_2008_R2 { get; set; }
        private static SkillVersion sqlserver_2012 { get; set; }
        private static SkillVersion visual_studio_2003_pro { get; set; }
        private static SkillVersion visual_studio_2005_pro { get; set; }
        private static SkillVersion visual_studio_2008_pro { get; set; }
        private static SkillVersion visual_studio_2010_pro { get; set; }
        private static SkillVersion visual_studio_2012_pro { get; set; }
        private static SkillVersion visual_studio_2013_pro { get; set; }
        private static SkillVersion visual_studio_2015_pro { get; set; }
        private static SkillVersion visual_studio_code { get; set; }
        private static SkillVersion csharp_1_2 { get; set; }
        private static SkillVersion csharp_2_0 { get; set; }
        private static SkillVersion csharp_3_0 { get; set; }
        private static SkillVersion csharp_4_0 { get; set; }
        private static SkillVersion csharp_5_0 { get; set; }
        private static SkillVersion dotnet_1_1 { get; set; }
        private static SkillVersion dotnet_2_0 { get; set; }
        private static SkillVersion dotnet_3_0 { get; set; }
        private static SkillVersion dotnet_3_5 { get; set; }
        private static SkillVersion dotnet_4_0 { get; set; }
        private static SkillVersion dotnet_4_5 { get; set; }
        private static SkillVersion dotnet_4_5_1 { get; set; }
        private static SkillVersion dotnet_4_5_2 { get; set; }
        private static SkillVersion dotnet_4_6 { get; set; }
        private static SkillVersion dotnet_4_6_1 { get; set; }
        private static SkillVersion oracle_8 { get; set; }
        private static SkillVersion windows_xp { get; set; }
        private static SkillVersion windows_vista { get; set; }
        private static SkillVersion windows_7 { get; set; }
        private static SkillVersion windows_server_2003 { get; set; }
        private static SkillVersion windows_server_2008 { get; set; }
        private static SkillVersion windows_server_2008_R2 { get; set; }
        private static SkillVersion windows_server_2012_R2 { get; set; }
        private static SkillVersion html_4_0 { get; set; }
        private static SkillVersion html_5_0 { get; set; }
        private static SkillVersion css_2_0 { get; set; }
        private static SkillVersion css_2_1 { get; set; }
        private static SkillVersion css_3_0 { get; set; }
        private static SkillVersion flash_2004 { get; set; }
        private static SkillVersion actionscript_2_0 { get; set; }
        private static SkillVersion photoshop_elements_7_0 { get; set; }
        private static SkillVersion photoshop_cs_2 { get; set; }
        private static SkillVersion iis_6_0 { get; set; }
        private static SkillVersion vss_6_0 { get; set; }
        private static SkillVersion toad_9_0 { get; set; }
        private static SkillVersion ssms_enterprise_manager { get; set; }
        private static SkillVersion ssms_2005 { get; set; }
        private static SkillVersion ssms_2008 { get; set; }
        private static SkillVersion ssms_2012 { get; set; }
        private static SkillVersion ssms_2014 { get; set; }
        private static SkillVersion javascript_ecmascript_3 { get; set; }
        private static SkillVersion javascript_ecmascript_5 { get; set; }
        private static SkillVersion xslt_1_0 { get; set; }
        private static SkillVersion xml_1_1 { get; set; }
        private static SkillVersion svn_1_3 { get; set; }
        private static SkillVersion tfs_2005 { get; set; }
        private static SkillVersion tfs_2008 { get; set; }
        private static SkillVersion commerce_server_2009 { get; set; }
        private static SkillVersion jquery_1_4 { get; set; }
        private static SkillVersion jquery_1_5 { get; set; }
        private static SkillVersion jquery_1_8 { get; set; }
        private static SkillVersion jquery_1_9 { get; set; }
        private static SkillVersion jquery_1_10 { get; set; }
        private static SkillVersion jquery_1_11 { get; set; }
        private static SkillVersion jquery_2_0 { get; set; }
        private static SkillVersion jquery_2_1 { get; set; }
        private static SkillVersion jquery_ui_1_6 { get; set; }
        private static SkillVersion jquery_ui_1_7 { get; set; }
        private static SkillVersion jquery_ui_1_8 { get; set; }
        private static SkillVersion jquery_ui_1_9 { get; set; }
        private static SkillVersion jquery_ui_1_10 { get; set; }
        private static SkillVersion jquery_ui_1_11 { get; set; }
        private static SkillVersion mvc_2 { get; set; }
        private static SkillVersion mvc_3 { get; set; }
        private static SkillVersion mvc_4 { get; set; }
        private static SkillVersion mvc_5 { get; set; }
        private static SkillVersion structuremap_2_6_4_1 { get; set; }
        private static SkillVersion structuremap_2_6_3 { get; set; }
        private static SkillVersion sitefinity_4_0 { get; set; }
        private static SkillVersion mysql_workbench_5_2 { get; set; }
        private static SkillVersion mysql_workbench_6_3 { get; set; }
        private static SkillVersion shibboleth_2_0 { get; set; }
        private static SkillVersion saml_2_0 { get; set; }
        private static SkillVersion jenkins_1_6 { get; set; }
        private static SkillVersion knockout_2_2_1 { get; set; }
        private static SkillVersion angularjs_1_4 { get; set; }
        private static SkillVersion lync_sdk_2013 { get; set; }
        private static SkillVersion rhel_7 { get; set; }
        private static SkillVersion fedora_core_23 { get; set; }
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
                    IconClass = "devicons devicons-javascript_shield",
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
                #region windows forms
                winform = new Skill
                {
                    Description = "Windows Forms (WinForms) is a graphical (GUI) class library included as a part of Microsoft .NET Framework, providing a platform to write rich client applications for desktop, laptop, and tablet PCs.",
                    ExperienceRating = 4,
                    InterestRating = 6,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Windows Forms",
                    UsageRating = 3
                };
                #endregion
                #region sql
                sql = new Skill
                {
                    Description = "SQL (Structured Query Language) is a special-purpose programming language designed for managing data held in a relational database management system (RDBMS), or for stream processing in a relational data stream management system (RDSMS).",
                    ExperienceRating = 8,
                    InterestRating = 8,
                    IconClass = null,
                    IsVisible = true,
                    Name = "SQL",
                    UsageRating = 8
                };
                #endregion
                #region ADO.NET
                ado_net = new Skill
                {
                    Description = "ADO.NET is a set of computer software components that programmers can use to access data and data services from the database. It is a part of the base class library that is included with the Microsoft .NET Framework.",
                    ExperienceRating = 7,
                    InterestRating = 5,
                    IconClass = null,
                    IsVisible = true,
                    Name = "ADO.NET",
                    UsageRating = 7
                };
                #endregion
                #region AJAX
                ajax = new Skill
                {
                    Description = "Ajax short for asynchronous JavaScript and XML, is a set of web development techniques using many web technologies on the client-side to create asynchronous Web applications.",
                    ExperienceRating = 8,
                    InterestRating = 10,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Ajax",
                    UsageRating = 8
                };
                #endregion
                #region aspnet ajax
                asp_net_ajax = new Skill
                {
                    Description = "ASP.NET AJAX is a set of extensions to ASP.NET developed by Microsoft for implementing Ajax functionality.",
                    ExperienceRating = 5,
                    InterestRating = 4,
                    IconClass = null,
                    IsVisible = true,
                    Name = "ASP.NET AJAX",
                    UsageRating = 5
                };
                #endregion
                #region web service
                web_service = new Skill
                {
                    Description = "A Web service is a service offered by an electronic device to another electronic device, communicating with each other via the World wide web.",
                    ExperienceRating = 6,
                    InterestRating = 5,
                    IconClass = "fa fa-globe",
                    IsVisible = true,
                    Name = "Web Service",
                    UsageRating = 2
                };
                #endregion
                #region google api
                google_api = new Skill
                {
                    Description = "Google APIs is a set of application programming interfaces (APIs) developed by Google which allow communication with Google Services and their integration to other services.",
                    ExperienceRating = 5,
                    InterestRating = 8,
                    IconClass = "fa fa-google",
                    IsVisible = true,
                    Name = "Google APIs",
                    UsageRating = 4
                };
                #endregion
                #region console application
                console_app = new Skill
                {
                    Description = "A console application is a computer program designed to be used via a text-only computer interface, such as a text terminal, the command line interface of some operating systems (Unix, DOS, etc.) or the text-based interface included with most Graphical User Interface (GUI) operating systems, such as the Win32 console in Microsoft Windows, the Terminal in Mac OS X, and xterm in Unix.",
                    ExperienceRating = 7,
                    InterestRating = 7,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Console application",
                    UsageRating = 7
                };
                #endregion
                #region soap
                soap = new Skill
                {
                    Description = "SOAP, originally an acronym for Simple Object Access Protocol, is a protocol specification for exchanging structured information in the implementation of web services in computer networks.",
                    ExperienceRating = 4,
                    InterestRating = 3,
                    IconClass = null,
                    IsVisible = true,
                    Name = "SOAP",
                    UsageRating = 3
                };
                #endregion
                #region TFS
                tfs = new Skill
                {
                    Description = "Team Foundation Server (commonly abbreviated to TFS) is a Microsoft product that provides source code management (either via Team Foundation Version Control or Git), reporting, requirements management, project management (for both agile software development and waterfall teams), automated builds, lab management, testing and release management capabilities.",
                    ExperienceRating = 2,
                    InterestRating = 7,
                    IconClass = "devicons devicons-visualstudio",
                    IsVisible = true,
                    Name = "TFS",
                    UsageRating = 3
                };
                #endregion
                #region XSD
                xsd = new Skill
                {
                    Description = "A typed DataSet is a class that derives from a DataSet. As such, it inherits all the methods, events, and properties of a DataSet. Additionally, a typed DataSet provides strongly typed methods, events, and properties. This means you can access tables and columns by name, instead of using collection-based methods.",
                    ExperienceRating = 3,
                    InterestRating = 2,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Strongly Typed DataSet",
                    UsageRating = 1
                };
                #endregion
                #region Commerce Server
                commerce_server = new Skill
                {
                    Description = "Microsoft Commerce Server is a Microsoft product for building e-commerce systems using Microsoft .NET technology.",
                    ExperienceRating = 3,
                    InterestRating = 2,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Microsoft Commerce Server",
                    UsageRating = 1
                };
                #endregion
                #region Scrum
                scrum = new Skill
                {
                    Description = "Scrum is an iterative and incremental agile software development framework for managing product development.",
                    ExperienceRating = 3,
                    InterestRating = 9,
                    IconClass = "devicons devicons-scrum",
                    IsVisible = true,
                    Name = "Scrum",
                    UsageRating = 2
                };
                #endregion
                #region Agile
                agile = new Skill
                {
                    Description = "Agile software development is a set of principles for software development in which requirements and solutions evolve through collaboration between self-organizing, cross-functional teams.",
                    ExperienceRating = 3,
                    InterestRating = 9,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Agile",
                    UsageRating = 2
                };
                #endregion
                #region jQuery
                jquery = new Skill
                {
                    Description = "jQuery is a cross-platform JavaScript library designed to simplify the client-side scripting of HTML.",
                    ExperienceRating = 8,
                    InterestRating = 8,
                    IconClass = "devicons devicons-jquery",
                    IsVisible = true,
                    Name = "jQuery",
                    UsageRating = 8
                };
                #endregion
                #region jQuery UI
                jquery_ui = new Skill
                {
                    Description = "jQuery UI is a collection of GUI widgets, animated visual effects, and themes implemented with jQuery (a JavaScript library), Cascading Style Sheets, and HTML.",
                    ExperienceRating = 8,
                    InterestRating = 8,
                    IconClass = "devicons devicons-jquery_ui",
                    IsVisible = true,
                    Name = "jQuery UI",
                    UsageRating = 8
                };
                #endregion
                #region CIMS
                cims = new Skill
                {
                    Description = "CIMS is a specialist multi-channel business system developed exclusively to meet the special demands of the fashion & lifestyle sector.",
                    ExperienceRating = 2,
                    InterestRating = 1,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Prologic - CIMS Software",
                    UsageRating = 1
                };
                #endregion
                #region Dependency Injection
                di = new Skill
                {
                    Description = "In software engineering, dependency injection is a software design pattern that implements inversion of control for resolving dependencies.",
                    ExperienceRating = 5,
                    InterestRating = 10,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Dependency Injection",
                    UsageRating = 8
                };
                #endregion
                #region Telerik MVC controls
                telerik_mvc = new Skill
                {
                    Description = "ASP.NET MVC controls for navigation and layout, data management and visualization, editing, interactivity and more.",
                    ExperienceRating = 2,
                    InterestRating = 6,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Telerik MVC Controls",
                    UsageRating = 1
                };
                #endregion
                #region ASP.NET razor
                razor = new Skill
                {
                    Description = "Razor is an ASP.NET programming syntax used to create dynamic web pages with the C# or Visual Basic .NET programming languages.",
                    ExperienceRating = 8,
                    InterestRating = 6,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "ASP.NET Razor",
                    UsageRating = 7
                };
                #endregion
                #region StructureMap
                structuremap = new Skill
                {
                    Description = "StructureMap is the oldest, continuously used IoC/DI container for .Net dating back to its first public release and production usage all the way back in June 2004 on .Net 1.1.",
                    ExperienceRating = 3,
                    InterestRating = 8,
                    IconClass = null,
                    IsVisible = true,
                    Name = "StructureMap",
                    UsageRating = 6
                };
                #endregion
                #region Sitefinity
                sitefinity = new Skill
                {
                    Description = "A web content management system (CMS), used to create and manage websites accessed via desktop or mobile devices.",
                    ExperienceRating = 2,
                    InterestRating = 3,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Telerik Sitefinity",
                    UsageRating = 1
                };
                #endregion
                #region ASP.NET MVC
                mvc = new Skill
                {
                    Description = "The ASP.NET MVC is a web application framework developed by Microsoft, which implements the model–view–controller (MVC) pattern.",
                    ExperienceRating = 8,
                    InterestRating = 10,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "ASP.NET MVC",
                    UsageRating = 7
                };
                #endregion
                #region MySQL Workbench
                mysql_workbench = new Skill
                {
                    Description = "MySQL Workbench is a visual database design tool that integrates SQL development, administration, database design, creation and maintenance into a single integrated development environment for the MySQL database system.",
                    ExperienceRating = 2,
                    InterestRating = 2,
                    IconClass = "devicons devicons-mysql",
                    IsVisible = true,
                    Name = "MySQL Workbench",
                    UsageRating = 3
                };
                #endregion
                #region Shibboleth
                shibboleth = new Skill
                {
                    Description = "Shibboleth is a single sign-on (log-in) system for computer networks and the Internet. It allows people to sign in using just one identity to various systems run by federations of different organizations or institutions.",
                    ExperienceRating = 2,
                    InterestRating = 2,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Shibboleth (Internet2)",
                    UsageRating = 1
                };
                #endregion
                #region saml
                saml = new Skill
                {
                    Description = "Security Assertion Markup Language (SAML, pronounced sam-el[1]) is an XML-based, open-standard data format for exchanging authentication and authorization data between parties, in particular, between an identity provider and a service provider.",
                    ExperienceRating = 2,
                    InterestRating = 3,
                    IconClass = null,
                    IsVisible = true,
                    Name = "SAML",
                    UsageRating = 1
                };
                #endregion
                #region jenkins
                jenkins = new Skill
                {
                    Description = "Jenkins is an open source continuous integration tool written in Java.",
                    ExperienceRating = 3,
                    InterestRating = 9,
                    IconClass = "devicons devicons-jenkins",
                    IsVisible = true,
                    Name = "Jenkins",
                    UsageRating = 4
                };
                #endregion
                #region Knockout
                knockout = new Skill
                {
                    Description = "Knockout is a standalone JavaScript implementation of the Model-View-ViewModel pattern with templates.",
                    ExperienceRating = 1,
                    InterestRating = 7,
                    IconClass = "devicons devicons-javascript_shield",
                    IsVisible = true,
                    Name = "Knockout",
                    UsageRating = 1
                };
                #endregion
                #region AngularJS
                angularjs = new Skill
                {
                    Description = "AngularJS (commonly referred to as \"Angular\" or \"Angular.js\") is an open-source web application framework mainly maintained by Google and by a community of individuals and corporations to address many of the challenges encountered in developing single-page applications.",
                    ExperienceRating = 2,
                    InterestRating = 10,
                    IconClass = "devicons devicons-angular",
                    IsVisible = true,
                    Name = "AngularJS",
                    UsageRating = 7
                };
                #endregion
                #region Lync SDK
                lync_sdk = new Skill
                {
                    Description = "Microsoft Lync SDK is the client-side API set that enables the integration and extension of Lync experiences.",
                    ExperienceRating = 2,
                    InterestRating = 3,
                    IconClass = "fa fa-skype",
                    IsVisible = true,
                    Name = "Microsoft Lync SDK",
                    UsageRating = 4
                };
                #endregion
                #region SSL
                ssl = new Skill
                {
                    Description = "Transport Layer Security (TLS) and its predecessor, Secure Sockets Layer (SSL), both of which are frequently referred to as 'SSL', are cryptographic protocols that provide communications security over a computer network.",
                    ExperienceRating = 4,
                    InterestRating = 5,
                    IconClass = "fa fa-skype",
                    IsVisible = true,
                    Name = "SSL",
                    UsageRating = 4
                };
                #endregion
                #region RHEL
                rhel = new Skill
                {
                    Description = "Red Hat Enterprise Linux (RHEL) is a Linux distribution developed by Red Hat and targeted toward the commercial market.",
                    ExperienceRating = 2,
                    InterestRating = 6,
                    IconClass = "mfizz mfizz-redhat",
                    IsVisible = true,
                    Name = "RHEL",
                    UsageRating = 2
                };
                #endregion
                #region Fedora Core
                fedora_core = new Skill
                {
                    Description = "Fedora (formerly Fedora Core) is an operating system based on the Linux kernel, developed by the community-supported Fedora Project and sponsored by Red Hat.",
                    ExperienceRating = 2,
                    InterestRating = 6,
                    IconClass = "mfizz mfizz-fedora",
                    IsVisible = true,
                    Name = "Fedora Core",
                    UsageRating = 5
                };
                #endregion
                #region Pivotal Tracker
                pivotal_tracker = new Skill
                {
                    Description = "Pivotal Tracker is Pivotal Labs' software as a service product for agile project management and collaboration.",
                    ExperienceRating = 2,
                    InterestRating = 6,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Pivotal Tracker",
                    UsageRating = 6
                };
                #endregion
                #region Axosoft
                axosoft = new Skill
                {
                    Description = "Axosoft (formerly OnTime) is a proprietary project management and bug tracking system, available as hosted or on-premises software.",
                    ExperienceRating = 2,
                    InterestRating = 1,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Axosoft",
                    UsageRating = 4
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
                context.Skills.Add(winform);
                context.Skills.Add(sql);
                context.Skills.Add(ado_net);
                context.Skills.Add(ajax);
                context.Skills.Add(asp_net_ajax);
                context.Skills.Add(web_service);
                context.Skills.Add(google_api);
                context.Skills.Add(console_app);
                context.Skills.Add(soap);
                context.Skills.Add(tfs);
                context.Skills.Add(xsd);
                context.Skills.Add(commerce_server);
                context.Skills.Add(scrum);
                context.Skills.Add(agile);
                context.Skills.Add(jquery);
                context.Skills.Add(jquery_ui);
                context.Skills.Add(cims);
                context.Skills.Add(telerik_mvc);
                context.Skills.Add(razor);
                context.Skills.Add(di);
                context.Skills.Add(mvc);
                context.Skills.Add(sitefinity);
                context.Skills.Add(structuremap);
                context.Skills.Add(mysql_workbench);
                context.Skills.Add(shibboleth);
                context.Skills.Add(saml);
                context.Skills.Add(jenkins);
                context.Skills.Add(lync_sdk);
                context.Skills.Add(ssl);
                context.Skills.Add(rhel);
                context.Skills.Add(fedora_core);
                context.Skills.Add(pivotal_tracker);
                context.Skills.Add(axosoft);
                context.Skills.Add(knockout);
                context.Skills.Add(angularjs);

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
                #region mysql 5.0.96
                mysql_5_0_96 = new SkillVersion
                {
                    Name = "MySQL 5.0.96",
                    SkillId = mysql.Id
                };
                #endregion
                #region mysql 5.1.73
                mysql_5_1_73 = new SkillVersion
                {
                    Name = "MySQL 5.1.73",
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
                #region asp.net 3.0
                asp_net_3_0 = new SkillVersion
                {
                    Name = "ASP.NET 3.0",
                    SkillId = asp_net.Id
                };
                #endregion
                #region asp.net 3.5
                asp_net_3_5 = new SkillVersion
                {
                    Name = "ASP.NET 3.5",
                    SkillId = asp_net.Id
                };
                #endregion
                #region asp.net 4.0
                asp_net_4_0 = new SkillVersion
                {
                    Name = "ASP.NET 4.0",
                    SkillId = asp_net.Id
                };
                #endregion
                #region asp.net 4.5
                asp_net_4_5 = new SkillVersion
                {
                    Name = "ASP.NET 4.5",
                    SkillId = asp_net.Id
                };
                #endregion
                #region asp.net 4.5.1
                asp_net_4_5_1 = new SkillVersion
                {
                    Name = "ASP.NET 4.5.1",
                    SkillId = asp_net.Id
                };
                #endregion
                #region asp.net 4.5.2
                asp_net_4_5_2 = new SkillVersion
                {
                    Name = "ASP.NET 4.5.2",
                    SkillId = asp_net.Id
                };
                #endregion
                #region asp.net 4.6
                asp_net_4_6 = new SkillVersion
                {
                    Name = "ASP.NET 4.6",
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
                #region sql server 2005
                sqlserver_2005 = new SkillVersion
                {
                    Name = "SQL Server 2005",
                    SkillId = sqlserver.Id
                };
                #endregion
                #region sql server 2008
                sqlserver_2008 = new SkillVersion
                {
                    Name = "SQL Server 2008",
                    SkillId = sqlserver.Id
                };
                #endregion
                #region sql server 2008 R2
                sqlserver_2008_R2 = new SkillVersion
                {
                    Name = "SQL Server 2008 R2",
                    SkillId = sqlserver.Id
                };
                #endregion
                #region sql server 2012
                sqlserver_2012 = new SkillVersion
                {
                    Name = "SQL Server 2012",
                    SkillId = sqlserver.Id
                };
                #endregion
                #region visual studio 2003 Professional
                visual_studio_2003_pro = new SkillVersion
                {
                    Name = "Visual Studio .NET 2003 Professional",
                    SkillId = visual_studio.Id
                };
                #endregion
                #region visual studio 2005 Professional
                visual_studio_2005_pro = new SkillVersion
                {
                    Name = "Visual Studio 2005 Professional",
                    SkillId = visual_studio.Id
                };
                #endregion
                #region visual studio 2008 Professional
                visual_studio_2008_pro = new SkillVersion
                {
                    Name = "Visual Studio 2008 Professional",
                    SkillId = visual_studio.Id
                };
                #endregion
                #region visual studio 2010 Professional
                visual_studio_2010_pro = new SkillVersion
                {
                    Name = "Visual Studio 2010 Professional",
                    SkillId = visual_studio.Id
                };
                #endregion
                #region visual studio 2012 Professional
                visual_studio_2012_pro = new SkillVersion
                {
                    Name = "Visual Studio 2012 Professional",
                    SkillId = visual_studio.Id
                };
                #endregion
                #region visual studio 2013 Professional
                visual_studio_2013_pro = new SkillVersion
                {
                    Name = "Visual Studio 2013 Professional",
                    SkillId = visual_studio.Id
                };
                #endregion
                #region visual studio 2015 Professional
                visual_studio_2015_pro = new SkillVersion
                {
                    Name = "Visual Studio 2015 Professional",
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
                #region csharp 3.0
                csharp_3_0 = new SkillVersion
                {
                    Name = "C# 3.0",
                    SkillId = csharp.Id
                };
                #endregion
                #region csharp 4.0
                csharp_4_0 = new SkillVersion
                {
                    Name = "C# 4.0",
                    SkillId = csharp.Id
                };
                #endregion
                #region csharp 5.0
                csharp_5_0 = new SkillVersion
                {
                    Name = "C# 5.0",
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
                #region .net framework 3.0
                dotnet_3_0 = new SkillVersion
                {
                    Name = ".NET Framework 3.0",
                    SkillId = dotnet.Id
                };
                #endregion
                #region .net framework 3.5
                dotnet_3_5 = new SkillVersion
                {
                    Name = ".NET Framework 3.5",
                    SkillId = dotnet.Id
                };
                #endregion
                #region .net framework 4.0
                dotnet_4_0 = new SkillVersion
                {
                    Name = ".NET Framework 4.0",
                    SkillId = dotnet.Id
                };
                #endregion
                #region .net framework 4.5
                dotnet_4_5 = new SkillVersion
                {
                    Name = ".NET Framework 4.5",
                    SkillId = dotnet.Id
                };
                #endregion
                #region .net framework 4.5.1
                dotnet_4_5_1 = new SkillVersion
                {
                    Name = ".NET Framework 4.5.1",
                    SkillId = dotnet.Id
                };
                #endregion
                #region .net framework 4.5.2
                dotnet_4_5_2 = new SkillVersion
                {
                    Name = ".NET Framework 4.5.2",
                    SkillId = dotnet.Id
                };
                #endregion
                #region .net framework 4.6
                dotnet_4_6 = new SkillVersion
                {
                    Name = ".NET Framework 4.6",
                    SkillId = dotnet.Id
                };
                #endregion
                #region .net framework 4.6.1
                dotnet_4_6_1 = new SkillVersion
                {
                    Name = ".NET Framework 4.6.1",
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
                #region windows 7
                windows_7 = new SkillVersion
                {
                    Name = "Windows 7",
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
                #region windows server 2008
                windows_server_2008 = new SkillVersion
                {
                    Name = "Windows Server 2008",
                    SkillId = windows.Id
                };
                #endregion
                #region windows server 2008 R2
                windows_server_2008_R2 = new SkillVersion
                {
                    Name = "Windows Server 2008 R2",
                    SkillId = windows.Id
                };
                #endregion
                #region windows server 2012 R2
                windows_server_2012_R2 = new SkillVersion
                {
                    Name = "Windows Server 2012 R2",
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
                #region html5
                html_5_0 = new SkillVersion
                {
                    Name = "HTML5",
                    SkillId = html.Id
                };
                #endregion
                #region css 2
                css_2_0 = new SkillVersion
                {
                    Name = "CSS 2",
                    SkillId = css.Id
                };
                #endregion
                #region css 2.1
                css_2_1 = new SkillVersion
                {
                    Name = "CSS 2.1",
                    SkillId = css.Id
                };
                #endregion
                #region css 3
                css_3_0 = new SkillVersion
                {
                    Name = "CSS 3",
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
                    SkillId = ssms.Id
                };
                #endregion
                #region sql server management studio 2005
                ssms_2005 = new SkillVersion
                {
                    Name = "SSMS 2005",
                    SkillId = ssms.Id
                };
                #endregion
                #region sql server management studio 2008
                ssms_2008 = new SkillVersion
                {
                    Name = "SSMS 2008",
                    SkillId = ssms.Id
                };
                #endregion
                #region sql server management studio 2012
                ssms_2012 = new SkillVersion
                {
                    Name = "SSMS 2012",
                    SkillId = ssms.Id
                };
                #endregion
                #region sql server management studio 2014
                ssms_2014= new SkillVersion
                {
                    Name = "SSMS 2014",
                    SkillId = ssms.Id
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
                #region javascript ecmascript 5
                javascript_ecmascript_5 = new SkillVersion
                {
                    Name = "ECMAScript 5",
                    SkillId = javascript.Id
                };
                #endregion
                #region svn 1.3
                svn_1_3 = new SkillVersion
                {
                    Name = "SVN 1.3",
                    SkillId = svn.Id
                };
                #endregion
                #region tfs 2005
                tfs_2005 = new SkillVersion
                {
                    Name = "TFS 2005",
                    SkillId = tfs.Id
                };
                #endregion
                #region tfs 2008
                tfs_2008 = new SkillVersion
                {
                    Name = "TFS 2008",
                    SkillId = tfs.Id
                };
                #endregion
                #region Commerce Server 2009
                commerce_server_2009 = new SkillVersion
                {
                    Name = "Commerce Server 2009",
                    SkillId = commerce_server.Id
                };
                #endregion
                #region jQuery 1.4
                jquery_1_4 = new SkillVersion
                {
                    Name = "jQuery 1.4",
                    SkillId = jquery.Id
                };
                #endregion
                #region jQuery 1.5
                jquery_1_5 = new SkillVersion
                {
                    Name = "jQuery 1.5",
                    SkillId = jquery.Id
                };
                #endregion
                #region jQuery 1.8
                jquery_1_8 = new SkillVersion
                {
                    Name = "jQuery 1.8",
                    SkillId = jquery.Id
                };
                #endregion
                #region jQuery 1.9
                jquery_1_9 = new SkillVersion
                {
                    Name = "jQuery 1.9",
                    SkillId = jquery.Id
                };
                #endregion
                #region jQuery 2.0
                jquery_2_0 = new SkillVersion
                {
                    Name = "jQuery 2.0",
                    SkillId = jquery.Id
                };
                #endregion
                #region jQuery 2.1
                jquery_2_1 = new SkillVersion
                {
                    Name = "jQuery 2.1",
                    SkillId = jquery.Id
                };
                #endregion
                #region jQuery 1.10
                jquery_1_10 = new SkillVersion
                {
                    Name = "jQuery 1.10",
                    SkillId = jquery.Id
                };
                #endregion
                #region jQuery 1.11
                jquery_1_11 = new SkillVersion
                {
                    Name = "jQuery 1.11",
                    SkillId = jquery.Id
                };
                #endregion
                #region jQuery UI 1.6
                jquery_ui_1_6 = new SkillVersion
                {
                    Name = "jQuery UI 1.6",
                    SkillId = jquery_ui.Id
                };
                #endregion
                #region jQuery UI 1.7
                jquery_ui_1_7 = new SkillVersion
                {
                    Name = "jQuery UI 1.7",
                    SkillId = jquery_ui.Id
                };
                #endregion
                #region jQuery UI 1.8
                jquery_ui_1_8 = new SkillVersion
                {
                    Name = "jQuery UI 1.8",
                    SkillId = jquery_ui.Id
                };
                #endregion
                #region jQuery UI 1.9
                jquery_ui_1_9 = new SkillVersion
                {
                    Name = "jQuery UI 1.9",
                    SkillId = jquery_ui.Id
                };
                #endregion
                #region jQuery UI 1.10
                jquery_ui_1_10 = new SkillVersion
                {
                    Name = "jQuery UI 1.10",
                    SkillId = jquery_ui.Id
                };
                #endregion
                #region jQuery UI 1.11
                jquery_ui_1_11 = new SkillVersion
                {
                    Name = "jQuery UI 1.11",
                    SkillId = jquery_ui.Id
                };
                #endregion
                #region ASP.NET MVC 2
                mvc_2 = new SkillVersion
                {
                    Name = "MVC 2",
                    SkillId = mvc.Id
                };
                #endregion
                #region ASP.NET MVC 3
                mvc_3 = new SkillVersion
                {
                    Name = "MVC 3",
                    SkillId = mvc.Id
                };
                #endregion
                #region ASP.NET MVC 4
                mvc_4 = new SkillVersion
                {
                    Name = "MVC 4",
                    SkillId = mvc.Id
                };
                #endregion
                #region ASP.NET MVC 5
                mvc_5 = new SkillVersion
                {
                    Name = "MVC 5",
                    SkillId = mvc.Id
                };
                #endregion
                #region StructureMap 2.6.3
                structuremap_2_6_3 = new SkillVersion
                {
                    Name = "StructureMap 2.6.3",
                    SkillId = structuremap.Id
                };
                #endregion
                #region StructureMap 2.6.4.1
                structuremap_2_6_4_1= new SkillVersion
                {
                    Name = "StructureMap 2.6.4.1",
                    SkillId = structuremap.Id
                };
                #endregion
                #region Sitefinity 4.0
                sitefinity_4_0 = new SkillVersion
                {
                    Name = "Sitefinity 4.0",
                    SkillId = sitefinity.Id
                };
                #endregion
                #region MySQL Workbench 5.2
                mysql_workbench_5_2 = new SkillVersion
                {
                    Name = "MySQL Workbench 5.2",
                    SkillId = mysql_workbench.Id
                };
                #endregion
                #region MySQL Workbench 6.3
                mysql_workbench_6_3 = new SkillVersion
                {
                    Name = "MySQL Workbench 6.3",
                    SkillId = mysql_workbench.Id
                };
                #endregion
                #region Shibboleth 2.0
                shibboleth_2_0 = new SkillVersion
                {
                    Name = "Shibboleth 2.0",
                    SkillId = shibboleth.Id
                };
                #endregion
                #region SAML 2.0
                saml_2_0 = new SkillVersion
                {
                    Name = "SAML 2.0",
                    SkillId = saml.Id
                };
                #endregion
                #region Jenkins 1.6
                jenkins_1_6 = new SkillVersion
                {
                    Name = "Jenkins 1.6",
                    SkillId = jenkins.Id
                };
                #endregion
                #region Visual Studio Code
                visual_studio_code = new SkillVersion
                {
                    Name = "Visual Studio Code",
                    SkillId = visual_studio.Id
                };
                #endregion
                #region Knockout 2.2.1
                knockout_2_2_1 = new SkillVersion
                {
                    Name = "Knockout 2.2.1",
                    SkillId = knockout.Id
                };
                #endregion
                #region AngularJS 1.4
                angularjs_1_4 = new SkillVersion
                {
                    Name = "AngularJS 1.4",
                    SkillId = angularjs.Id
                };
                #endregion
                #region RHEL7
                rhel_7 = new SkillVersion
                {
                    Name = "RHEL 7",
                    SkillId = rhel.Id
                };
                #endregion
                #region Fedora Core 23
                fedora_core_23 = new SkillVersion
                {
                    Name = "Fedora Core 23",
                    SkillId = fedora_core.Id
                };
                #endregion
                #region Lync SDK 2013
                lync_sdk_2013 = new SkillVersion
                {
                    Name = "Lync SDK 2013",
                    SkillId = lync_sdk.Id
                };
                #endregion

                context.SkillVersions.Add(php_4_3);
                context.SkillVersions.Add(mysql_4_0_6);
                context.SkillVersions.Add(mysql_5_0_96);
                context.SkillVersions.Add(mysql_5_1_73);
                context.SkillVersions.Add(asp_3_0);
                context.SkillVersions.Add(asp_net_2_0);
                context.SkillVersions.Add(sqlserver_2000);
                context.SkillVersions.Add(visual_studio_2003_pro);
                context.SkillVersions.Add(visual_studio_2005_pro);
                context.SkillVersions.Add(visual_studio_2008_pro);
                context.SkillVersions.Add(visual_studio_2010_pro);
                context.SkillVersions.Add(visual_studio_2012_pro);
                context.SkillVersions.Add(visual_studio_2013_pro);
                context.SkillVersions.Add(visual_studio_2015_pro);
                context.SkillVersions.Add(csharp_1_2);
                context.SkillVersions.Add(csharp_2_0);
                context.SkillVersions.Add(csharp_3_0);
                context.SkillVersions.Add(csharp_4_0);
                context.SkillVersions.Add(csharp_5_0);
                context.SkillVersions.Add(dotnet_1_1);
                context.SkillVersions.Add(dotnet_2_0);
                context.SkillVersions.Add(dotnet_3_0);
                context.SkillVersions.Add(dotnet_3_5);
                context.SkillVersions.Add(dotnet_4_0);
                context.SkillVersions.Add(dotnet_4_5);
                context.SkillVersions.Add(dotnet_4_5_1);
                context.SkillVersions.Add(dotnet_4_5_2);
                context.SkillVersions.Add(dotnet_4_6);
                context.SkillVersions.Add(dotnet_4_6_1);
                context.SkillVersions.Add(oracle_8);
                context.SkillVersions.Add(windows_xp);
                context.SkillVersions.Add(windows_vista);
                context.SkillVersions.Add(windows_7);
                context.SkillVersions.Add(windows_server_2003);
                context.SkillVersions.Add(windows_server_2008);
                context.SkillVersions.Add(windows_server_2008_R2);
                context.SkillVersions.Add(windows_server_2012_R2);
                context.SkillVersions.Add(html_4_0);
                context.SkillVersions.Add(html_5_0);
                context.SkillVersions.Add(css_2_0);
                context.SkillVersions.Add(css_2_1);
                context.SkillVersions.Add(css_3_0);
                context.SkillVersions.Add(flash_2004);
                context.SkillVersions.Add(actionscript_2_0);
                context.SkillVersions.Add(photoshop_elements_7_0);
                context.SkillVersions.Add(iis_6_0);
                context.SkillVersions.Add(vss_6_0);
                context.SkillVersions.Add(toad_9_0);
                context.SkillVersions.Add(ssms_enterprise_manager);
                context.SkillVersions.Add(ssms_2005);
                context.SkillVersions.Add(ssms_2008);
                context.SkillVersions.Add(ssms_2012);
                context.SkillVersions.Add(ssms_2014);
                context.SkillVersions.Add(xslt_1_0);
                context.SkillVersions.Add(javascript_ecmascript_3);
                context.SkillVersions.Add(javascript_ecmascript_5);
                context.SkillVersions.Add(xml_1_1);
                context.SkillVersions.Add(asp_net_3_0);
                context.SkillVersions.Add(sqlserver_2005);
                context.SkillVersions.Add(sqlserver_2008);
                context.SkillVersions.Add(sqlserver_2008_R2);
                context.SkillVersions.Add(sqlserver_2012);
                context.SkillVersions.Add(svn_1_3);
                context.SkillVersions.Add(photoshop_cs_2);
                context.SkillVersions.Add(asp_net_3_5);
                context.SkillVersions.Add(asp_net_4_0);
                context.SkillVersions.Add(asp_net_4_5);
                context.SkillVersions.Add(asp_net_4_5_1);
                context.SkillVersions.Add(asp_net_4_5_2);
                context.SkillVersions.Add(asp_net_4_6);
                context.SkillVersions.Add(tfs_2005);
                context.SkillVersions.Add(tfs_2008);
                context.SkillVersions.Add(commerce_server_2009);
                context.SkillVersions.Add(jquery_1_4);
                context.SkillVersions.Add(jquery_1_5);
                context.SkillVersions.Add(jquery_1_8);
                context.SkillVersions.Add(jquery_1_9);
                context.SkillVersions.Add(jquery_1_10);
                context.SkillVersions.Add(jquery_1_11);
                context.SkillVersions.Add(jquery_2_0);
                context.SkillVersions.Add(jquery_2_1);
                context.SkillVersions.Add(jquery_ui_1_6);
                context.SkillVersions.Add(jquery_ui_1_7);
                context.SkillVersions.Add(jquery_ui_1_8);
                context.SkillVersions.Add(jquery_ui_1_9);
                context.SkillVersions.Add(jquery_ui_1_10);
                context.SkillVersions.Add(jquery_ui_1_11);
                context.SkillVersions.Add(mvc_2);
                context.SkillVersions.Add(mvc_3);
                context.SkillVersions.Add(mvc_4);
                context.SkillVersions.Add(mvc_5);
                context.SkillVersions.Add(structuremap_2_6_3);
                context.SkillVersions.Add(structuremap_2_6_4_1);
                context.SkillVersions.Add(sitefinity_4_0);
                context.SkillVersions.Add(mysql_workbench_5_2);
                context.SkillVersions.Add(mysql_workbench_6_3);
                context.SkillVersions.Add(shibboleth_2_0);
                context.SkillVersions.Add(saml_2_0);
                context.SkillVersions.Add(jenkins_1_6);
                context.SkillVersions.Add(knockout_2_2_1);
                context.SkillVersions.Add(angularjs_1_4);
                context.SkillVersions.Add(rhel_7);
                context.SkillVersions.Add(fedora_core_23);
                context.SkillVersions.Add(lync_sdk_2013);
                context.SkillVersions.Add(visual_studio_code);
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
                                new ExperienceSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_2003_pro.Id }
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
                        },
                        new ExperienceSkill
                        {
                            SkillId = winform.Id,
                            UsageRating = 5
                        },
                        new ExperienceSkill
                        {
                            SkillId = ado_net.Id,
                            UsageRating = 6
                        },
                        new ExperienceSkill
                        {
                            SkillId = sql.Id,
                            UsageRating = 7
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
                                new ExperienceSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_2005_pro.Id }
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
                        },
                        new ExperienceSkill
                        {
                            SkillId = asp_net_ajax.Id,
                            UsageRating = 4
                        },
                        new ExperienceSkill
                        {
                            SkillId = ajax.Id,
                            UsageRating = 4
                        }
                        //XML, Web Service, Google API, windows form, windows console application, tsql, ado.net 
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
                    //ASP.NET AJAX, AJAX, asp.net, c#, sqlserver, svn, ssms, visual studio, dotnet, windows, javascript, html, css, tsql, typed dataset (xsd)
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
                    //ASP.NET AJAX, AJAX, asp.net, c#, commerce server, tfs (vss?), visual studio, dotnet, windows, javascript, html, css
                    //scrum
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
                    //c#, prologic cims, (oracle), web service, visual studio, dotnet, windows, windows form, windows console application
                };
                #endregion
                #region docdata
                docdata = new Experience
                {
                    City = "London",
                    CompanyName = "docdata",
                    Country = "United Kingdom",
                    EndDate = new DateTime(2012, 3, 31),
                    ImageUrl = "docdata-experience-icon.png",
                    RoleTitle = "Developer",
                    WebsiteUrl = "http://docdata.co.uk",
                    Description = "Analysis and development of new functionalities in an e-commerce platform and maintenance on existing clients’ ecommerce websites (ASP.NET, ASP.NET MVC 2.0, C#, SQL SERVER).",
                    StartDate = new DateTime(2011, 4, 1),
                    Skills = new List<ExperienceSkill>
                    {

                    }
                    //JQuery, Google API, javascript, html, css, windows, windows server, svn, c#, asp.net, mvc, dotnet, sql server, ssms, tsql
                    //dependency injection, structure map, ado.net, telerik mvc controls, telerik sitefinity
                };
                #endregion
                #region University of London
                uol = new Experience
                {
                    City = "London",
                    CompanyName = "University of London",
                    Country = "United Kingdom",
                    EndDate = new DateTime(2016, 4, 30),
                    ImageUrl = "uol-experience-icon.png",
                    RoleTitle = "Senior Developer",
                    WebsiteUrl = "http://docdata.co.uk",
                    Description = "Project lead and developer of new services. Support and maintenance on existing services (ASP.NET, ASP.NET MVC 4.0, C#, SQL SERVER, JQUERY, Bootstrap).",
                    StartDate = new DateTime(2012, 4, 1),
                    Skills = new List<ExperienceSkill>
                    {

                    }
                    //windows form, windows console application, google api, web services
                    //tsql, sql server, ssms, mysql, mysql workbench
                    //shibboleth, saml, xml, jenkins, visual studio, visual studio code
                    //javascript, jquery, knockout, angularjs, lync
                    //dotnet, asp.net, mvc, c#, ssl, windows, windows server, rhel7, fedora core 23
                    //pivotal tracker, scrum, axosoft, structure map, entity framework,
                    //unity, moq, rhino mock, automapper, dependency injection, unit testing
                    //linq, agile, ado.net
                    //umbraco, wordpress, mediawiki, silverlight, html5, html, css, bootstrap, wcf, wpf
                };
                #endregion

                context.Experiences.Add(tomato);
                context.Experiences.Add(intellimind);
                context.Experiences.Add(concileo);
                context.Experiences.Add(dataarchive);
                context.Experiences.Add(hrteam);
                context.Experiences.Add(groovytrain);
                context.Experiences.Add(docdata);
                context.Experiences.Add(uol);
            }

            return context.SaveChanges();
        }
    }
}
