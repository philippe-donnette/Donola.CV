﻿using CV.DataAccessLayer.Contexts;
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
            CreatePerson(context);
            CreateSkills(context);
            CreateSkillVersions(context);
            CreateExperiences(context);
            CreateProjects(context);
            CreateCards(context);
            CreateProjectImages(context);
            CreateQualifications(context);
            CreateTrainings(context);
        }

        #region Skills
        private static Skill actionscript { get; set; }
        private static Skill ado_net { get; set; }
        private static Skill agile { get; set; }
        private static Skill ajax { get; set; }
        private static Skill angular { get; set; }
        private static Skill angularjs { get; set; }
        private static Skill apache { get; set; }
        private static Skill asp { get; set; }
        private static Skill aspnet_webapi { get; set; }
        private static Skill asp_net { get; set; }
        private static Skill asp_net_ajax { get; set; }
        private static Skill aurelia { get; set; }
        private static Skill autofac { get; set; }
        private static Skill automapper { get; set; }
        private static Skill axosoft { get; set; }
        private static Skill azure { get; set; }
        private static Skill babel { get; set; }
        private static Skill bamboo { get; set; }
        private static Skill bash_shell { get; set; }
        private static Skill bitbucket { get; set; }
        private static Skill bootstrap { get; set; }
        private static Skill bower { get; set; }
        private static Skill centos { get; set; }
        private static Skill chai { get; set; }
        private static Skill ci { get; set; }
        private static Skill cims { get; set; }
        private static Skill commerce_server { get; set; }
        private static Skill console_app { get; set; }
        private static Skill couchbase { get; set; }
        private static Skill couchbasenetclient { get; set; }
        private static Skill cqrs { get; set; }
        private static Skill csharp { get; set; }
        private static Skill css { get; set; }
        private static Skill ddd { get; set; }
        private static Skill di { get; set; }
        private static Skill docker { get; set; }
        private static Skill dotnet { get; set; }
        private static Skill easyphp { get; set; }
        private static Skill elasticsearch { get; set; }
        private static Skill entity_framework { get; set; }
        private static Skill enzyme { get; set; }
        private static Skill event_sourcing { get; set; }
        private static Skill fedora_core { get; set; }
        private static Skill flash { get; set; }
        private static Skill git { get; set; }
        private static Skill github { get; set; }
        private static Skill gocd { get; set; }
        private static Skill gogs { get; set; }
        private static Skill google_api { get; set; }
        private static Skill grunt { get; set; }
        private static Skill gulp { get; set; }
        private static Skill haproxy { get; set; }
        private static Skill html { get; set; }
        private static Skill identityserver { get; set; }
        private static Skill iis { get; set; }
        private static Skill jasmine { get; set; }
        private static Skill javascript { get; set; }
        private static Skill jenkins { get; set; }
        private static Skill jquery { get; set; }
        private static Skill jquery_ui { get; set; }
        private static Skill json { get; set; }
        private static Skill jsx { get; set; }
        private static Skill karma { get; set; }
        private static Skill knockout { get; set; }
        private static Skill less { get; set; }
        private static Skill linq { get; set; }
        private static Skill linux { get; set; }
        private static Skill lync_sdk { get; set; }
        private static Skill mantis { get; set; }
        private static Skill marathon { get; set; }
        private static Skill mariadb { get; set; }
        private static Skill mediawiki { get; set; }
        private static Skill mesos { get; set; }
        private static Skill microservices { get; set; }
        private static Skill mocha { get; set; }
        private static Skill mongodb { get; set; }
        private static Skill mongodb_csharp { get; set; }
        private static Skill moq { get; set; }
        private static Skill mstest { get; set; }
        private static Skill mvc { get; set; }
        private static Skill mysql { get; set; }
        private static Skill mysql_workbench { get; set; }
        private static Skill nest { get; set; }
        private static Skill nexus { get; set; }
        private static Skill nginx { get; set; }
        private static Skill npm { get; set; }
        private static Skill nuget { get; set; }
        private static Skill nunit { get; set; }
        private static Skill oauth { get; set; }
        private static Skill oracle { get; set; }
        private static Skill photoshop { get; set; }
        private static Skill php { get; set; }
        private static Skill phpmyadmin { get; set; }
        private static Skill pivotal_tracker { get; set; }
        private static Skill postgresql { get; set; }
        private static Skill proget { get; set; }
        private static Skill python { get; set; }
        private static Skill ravendb { get; set; }
        private static Skill razor { get; set; }
        private static Skill react { get; set; }
        private static Skill redux { get; set; }
        private static Skill rest { get; set; }
        private static Skill rhel { get; set; }
        private static Skill rhino_mock { get; set; }
        private static Skill saml { get; set; }
        private static Skill sass { get; set; }
        private static Skill scrum { get; set; }
        private static Skill shibboleth { get; set; }
        private static Skill silverlight_sdk { get; set; }
        private static Skill silverlight_toolkit { get; set; }
        private static Skill sinon { get; set; }
        private static Skill sitefinity { get; set; }
        private static Skill soap { get; set; }
        private static Skill sql { get; set; }
        private static Skill sqlserver { get; set; }
        private static Skill ssl { get; set; }
        private static Skill ssms { get; set; }
        private static Skill structuremap { get; set; }
        private static Skill svn { get; set; }
        private static Skill telerik_mvc { get; set; }
        private static Skill tfs { get; set; }
        private static Skill toad { get; set; }
        private static Skill typescript { get; set; }
        private static Skill ubuntu { get; set; }
        private static Skill umbraco { get; set; }
        private static Skill unity { get; set; }
        private static Skill unit_testing { get; set; }
        private static Skill visual_studio { get; set; }
        private static Skill vss { get; set; }
        private static Skill wamp { get; set; }
        private static Skill wcf { get; set; }
        private static Skill webpack { get; set; }
        private static Skill web_service { get; set; }
        private static Skill windows { get; set; }
        private static Skill winform { get; set; }
        private static Skill winservice { get; set; }
        private static Skill wpf { get; set; }
        private static Skill xml { get; set; }
        private static Skill xsd { get; set; }
        private static Skill xslt { get; set; }
        private static Skill xunit { get; set; }
        private static Skill zookeeper { get; set; }
        #endregion

        #region SkillVersions
        private static SkillVersion actionscript_2_0 { get; set; }
        private static SkillVersion angularjs_1_3 { get; set; }
        private static SkillVersion angularjs_1_4 { get; set; }
        private static SkillVersion angular_2_4_0 { get; set; }
        private static SkillVersion angular_2_4_6 { get; set; }
        private static SkillVersion aspnet_webapi_1 { get; set; }
        private static SkillVersion aspnet_webapi_2 { get; set; }
        private static SkillVersion aspnet_webapi_core_1_0 { get; set; }
        private static SkillVersion aspnet_webapi_core_1_1 { get; set; }
        private static SkillVersion asp_3_0 { get; set; }
        private static SkillVersion asp_net_2_0 { get; set; }
        private static SkillVersion asp_net_3_0 { get; set; }
        private static SkillVersion asp_net_3_5 { get; set; }
        private static SkillVersion asp_net_4_0 { get; set; }
        private static SkillVersion asp_net_4_5 { get; set; }
        private static SkillVersion asp_net_4_5_1 { get; set; }
        private static SkillVersion asp_net_4_5_2 { get; set; }
        private static SkillVersion asp_net_4_6 { get; set; }
        private static SkillVersion asp_net_core_1_0 { get; set; }
        private static SkillVersion asp_net_core_1_1 { get; set; }
        private static SkillVersion aurelia_1_0 { get; set; }
        private static SkillVersion autofac_4_0 { get; set; }
        private static SkillVersion automapper_2_2_0 { get; set; }
        private static SkillVersion automapper_5_2_0 { get; set; }
        private static SkillVersion azure_webjobs { get; set; }
        private static SkillVersion azure_web_sites { get; set; }
        private static SkillVersion babel_6_24_1 { get; set; }
        private static SkillVersion bamboo_0_2_2_1 { get; set; }
        private static SkillVersion bootstrap_3 { get; set; }
        private static SkillVersion centos_7_2 { get; set; }
        private static SkillVersion chai_3_5_0 { get; set; }
        private static SkillVersion commerce_server_2009 { get; set; }
        private static SkillVersion couchbasenetclient_2_4_0 { get; set; }
        private static SkillVersion couchbase_community_4_1_0 { get; set; }
        private static SkillVersion couchbase_enterprise_4_0_0 { get; set; }
        private static SkillVersion couchbase_enterprise_4_5_0 { get; set; }
        private static SkillVersion csharp_1_2 { get; set; }
        private static SkillVersion csharp_2_0 { get; set; }
        private static SkillVersion csharp_3_0 { get; set; }
        private static SkillVersion csharp_4_0 { get; set; }
        private static SkillVersion csharp_5_0 { get; set; }
        private static SkillVersion csharp_6_0 { get; set; }
        private static SkillVersion csharp_7_0 { get; set; }
        private static SkillVersion css_2_0 { get; set; }
        private static SkillVersion css_2_1 { get; set; }
        private static SkillVersion css_3_0 { get; set; }
        private static SkillVersion docker_1_12_1 { get; set; }
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
        private static SkillVersion dotnet_core_1_0 { get; set; }
        private static SkillVersion dotnet_core_1_1 { get; set; }
        private static SkillVersion elasticsearch_1_7_0 { get; set; }
        private static SkillVersion elasticsearch_2_3_5 { get; set; }
        private static SkillVersion elasticsearch_2_4_3 { get; set; }
        private static SkillVersion entity_framework_4_1 { get; set; }
        private static SkillVersion entity_framework_5_0 { get; set; }
        private static SkillVersion entity_framework_6_0 { get; set; }
        private static SkillVersion entity_framework_core_1_0 { get; set; }
        private static SkillVersion entity_framework_core_1_1 { get; set; }
        private static SkillVersion enzyme_2_8_2 { get; set; }
        private static SkillVersion fedora_core_23 { get; set; }
        private static SkillVersion flash_2004 { get; set; }
        private static SkillVersion git_1_9_5 { get; set; }
        private static SkillVersion git_2_5_0 { get; set; }
        private static SkillVersion git_2_8_1 { get; set; }
        private static SkillVersion gocd_16_7_0 { get; set; }
        private static SkillVersion haproxy_1_5_8 { get; set; }
        private static SkillVersion html_4_0 { get; set; }
        private static SkillVersion html_5_0 { get; set; }
        private static SkillVersion identityserver_3 { get; set; }
        private static SkillVersion identityserver_4 { get; set; }
        private static SkillVersion iis_6_0 { get; set; }
        private static SkillVersion iis_7_0 { get; set; }
        private static SkillVersion iis_7_0_express { get; set; }
        private static SkillVersion iis_8_0 { get; set; }
        private static SkillVersion iis_8_0_express { get; set; }
        private static SkillVersion javascript_ecmascript_3 { get; set; }
        private static SkillVersion javascript_ecmascript_5 { get; set; }
        private static SkillVersion javascript_ecmascript_6 { get; set; }
        private static SkillVersion jenkins_1_6 { get; set; }
        private static SkillVersion jquery_1_10 { get; set; }
        private static SkillVersion jquery_1_11 { get; set; }
        private static SkillVersion jquery_1_3 { get; set; }
        private static SkillVersion jquery_1_4 { get; set; }
        private static SkillVersion jquery_1_5 { get; set; }
        private static SkillVersion jquery_1_7 { get; set; }
        private static SkillVersion jquery_1_8 { get; set; }
        private static SkillVersion jquery_1_9 { get; set; }
        private static SkillVersion jquery_2_0 { get; set; }
        private static SkillVersion jquery_2_1 { get; set; }
        private static SkillVersion jquery_ui_1_10 { get; set; }
        private static SkillVersion jquery_ui_1_11 { get; set; }
        private static SkillVersion jquery_ui_1_6 { get; set; }
        private static SkillVersion jquery_ui_1_7 { get; set; }
        private static SkillVersion jquery_ui_1_8 { get; set; }
        private static SkillVersion jquery_ui_1_9 { get; set; }
        private static SkillVersion knockout_2_2_1 { get; set; }
        private static SkillVersion lync_sdk_2013 { get; set; }
        private static SkillVersion marathon_1_1_2 { get; set; }
        private static SkillVersion mediawiki_1_22 { get; set; }
        private static SkillVersion mediawiki_1_26 { get; set; }
        private static SkillVersion mesos_1_0_1 { get; set; }
        private static SkillVersion mocha_3_3_0 { get; set; }
        private static SkillVersion mongodb_3_0 { get; set; }
        private static SkillVersion mongodb_csharp_2_1_1 { get; set; }
        private static SkillVersion mvc_2 { get; set; }
        private static SkillVersion mvc_3 { get; set; }
        private static SkillVersion mvc_4 { get; set; }
        private static SkillVersion mvc_5 { get; set; }
        private static SkillVersion mvc_core_1_0 { get; set; }
        private static SkillVersion mvc_core_1_1 { get; set; }
        private static SkillVersion mysql_4_0_6 { get; set; }
        private static SkillVersion mysql_4_1_4 { get; set; }
        private static SkillVersion mysql_5_0_96 { get; set; }
        private static SkillVersion mysql_5_1_22 { get; set; }
        private static SkillVersion mysql_5_1_73 { get; set; }
        private static SkillVersion mysql_workbench_5_2 { get; set; }
        private static SkillVersion mysql_workbench_6_3 { get; set; }
        private static SkillVersion nest_1_8_3 { get; set; }
        private static SkillVersion nest_2_5_1 { get; set; }
        private static SkillVersion nexus_3_0_1 { get; set; }
        private static SkillVersion nginx_1_13_1 { get; set; }
        private static SkillVersion nunit_2_6_2 { get; set; }
        private static SkillVersion oauth_2_0 { get; set; }
        private static SkillVersion oracle_8 { get; set; }
        private static SkillVersion photoshop_cs_2 { get; set; }
        private static SkillVersion photoshop_cs_3 { get; set; }
        private static SkillVersion photoshop_cs_6 { get; set; }
        private static SkillVersion photoshop_elements_14_0 { get; set; }
        private static SkillVersion photoshop_elements_7_0 { get; set; }
        private static SkillVersion photoshop_elements_9_0 { get; set; }
        private static SkillVersion php_4_3 { get; set; }
        private static SkillVersion php_4_4 { get; set; }
        private static SkillVersion postgresql_9_2_15 { get; set; }
        private static SkillVersion proget_3_4_6 { get; set; }
        private static SkillVersion proget_4_6_4 { get; set; }
        private static SkillVersion python_2_0 { get; set; }
        private static SkillVersion ravendb_3_0 { get; set; }
        private static SkillVersion react_15_4_2 { get; set; }
        private static SkillVersion redux_3_6_0 { get; set; }
        private static SkillVersion rhel_7 { get; set; }
        private static SkillVersion saml_2_0 { get; set; }
        private static SkillVersion shibboleth_2_0 { get; set; }
        private static SkillVersion silverlight_sdk_5 { get; set; }
        private static SkillVersion silverlight_toolkit_5 { get; set; }
        private static SkillVersion sitefinity_4_0 { get; set; }
        private static SkillVersion sqlserver_2000 { get; set; }
        private static SkillVersion sqlserver_2005 { get; set; }
        private static SkillVersion sqlserver_2008 { get; set; }
        private static SkillVersion sqlserver_2008_express { get; set; }
        private static SkillVersion sqlserver_2008_R2 { get; set; }
        private static SkillVersion sqlserver_2012 { get; set; }
        private static SkillVersion sqlserver_2012_express { get; set; }
        private static SkillVersion sqlserver_2014 { get; set; }
        private static SkillVersion sqlserver_2016 { get; set; }
        private static SkillVersion ssms_2005 { get; set; }
        private static SkillVersion ssms_2008 { get; set; }
        private static SkillVersion ssms_2012 { get; set; }
        private static SkillVersion ssms_2014 { get; set; }
        private static SkillVersion ssms_2016 { get; set; }
        private static SkillVersion ssms_enterprise_manager { get; set; }
        private static SkillVersion structuremap_2_6_3 { get; set; }
        private static SkillVersion structuremap_2_6_4_1 { get; set; }
        private static SkillVersion structuremap_3_0_2_0 { get; set; }
        private static SkillVersion svn_1_3 { get; set; }
        private static SkillVersion svn_1_6 { get; set; }
        private static SkillVersion svn_1_8 { get; set; }
        private static SkillVersion tfs_2005 { get; set; }
        private static SkillVersion tfs_2008 { get; set; }
        private static SkillVersion tfs_2013_express { get; set; }
        private static SkillVersion tfs_2015 { get; set; }
        private static SkillVersion toad_9_0 { get; set; }
        private static SkillVersion typescript_1_8 { get; set; }
        private static SkillVersion typescript_2_0 { get; set; }
        private static SkillVersion ubuntu_14_04 { get; set; }
        private static SkillVersion umbraco_4 { get; set; }
        private static SkillVersion umbraco_6 { get; set; }
        private static SkillVersion umbraco_7 { get; set; }
        private static SkillVersion unity_3_0 { get; set; }
        private static SkillVersion unity_3_5 { get; set; }
        private static SkillVersion visual_studio_2003_pro { get; set; }
        private static SkillVersion visual_studio_2005_pro { get; set; }
        private static SkillVersion visual_studio_2008_pro { get; set; }
        private static SkillVersion visual_studio_2010_express { get; set; }
        private static SkillVersion visual_studio_2010_pro { get; set; }
        private static SkillVersion visual_studio_2012_pro { get; set; }
        private static SkillVersion visual_studio_2013_pro { get; set; }
        private static SkillVersion visual_studio_2013_web_developer_express { get; set; }
        private static SkillVersion visual_studio_2015_community { get; set; }
        private static SkillVersion visual_studio_2015_pro { get; set; }
        private static SkillVersion visual_studio_code { get; set; }
        private static SkillVersion vss_6_0 { get; set; }
        private static SkillVersion webpack_2_0 { get; set; }
        private static SkillVersion webpack_2_4_1 { get; set; }
        private static SkillVersion windows_10 { get; set; }
        private static SkillVersion windows_7 { get; set; }
        private static SkillVersion windows_server_2003 { get; set; }
        private static SkillVersion windows_server_2008 { get; set; }
        private static SkillVersion windows_server_2008_R2 { get; set; }
        private static SkillVersion windows_server_2012_R2 { get; set; }
        private static SkillVersion windows_server_2016 { get; set; }
        private static SkillVersion windows_vista { get; set; }
        private static SkillVersion windows_xp { get; set; }
        private static SkillVersion xml_1_1 { get; set; }
        private static SkillVersion xslt_1_0 { get; set; }
        private static SkillVersion zookeeper_3_4_6 { get; set; }
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
        private static Experience travco { get; set; }
        #endregion

        #region Projects
        private static Project othodo { get; set; }
        private static Project louise13 { get; set; }
        private static Project cnlaps { get; set; }
        private static Project makabou { get; set; }
        private static Project pharmatoo { get; set; }
        private static Project toomanyplaces { get; set; }
        private static Project pubrush { get; set; }
        private static Project moi { get; set; }
        private static Project dpf { get; set; }
        private static Project babybook { get; set; }
        private static Project cv { get; set; }
        #endregion

        #region Cards
        private static Card location { get; set; }
        private static Card contact { get; set; }
        #endregion

        private static int CreateSkills(CvDbContext context)
        {
            if (!context.Skills.Any())
            {
                #region chai
                chai = new Skill
                {
                    Description = "Chai is a BDD / TDD assertion library for node and the browser that can be delightfully paired with any javascript testing framework.",
                    ExperienceRating = 3,
                    InterestRating = 5,
                    IconClass = "devicons devicons-javascript_shield",
                    IsVisible = true,
                    Name = "Chai",
                    UsageRating = 6
                };
                #endregion
                #region babel
                babel = new Skill
                {
                    Description = "Babel is a JavaScript compiler.",
                    ExperienceRating = 3,
                    InterestRating = 4,
                    IconClass = "devicons devicons-javascript_shield",
                    IsVisible = true,
                    Name = "Babel",
                    UsageRating = 4
                };
                #endregion
                #region mocha
                mocha = new Skill
                {
                    Description = "Mocha is a feature-rich JavaScript test framework running on Node.js and in the browser.",
                    ExperienceRating = 3,
                    InterestRating = 5,
                    IconClass = "devicons devicons-javascript_shield",
                    IsVisible = true,
                    Name = "Mocha",
                    UsageRating = 6
                };
                #endregion
                #region sinon
                sinon = new Skill
                {
                    Description = "Standalone test spies, stubs and mocks for JavaScript.",
                    ExperienceRating = 3,
                    InterestRating = 5,
                    IconClass = "devicons devicons-javascript_shield",
                    IsVisible = true,
                    Name = "Sinon.JS",
                    UsageRating = 5
                };
                #endregion
                #region enzyme
                enzyme = new Skill
                {
                    Description = "Enzyme is a JavaScript Testing utility for React that makes it easier to assert, manipulate, and traverse your React Components' output.",
                    ExperienceRating = 3,
                    InterestRating = 5,
                    IconClass = "devicons devicons-javascript_shield",
                    IsVisible = true,
                    Name = "Enzyme",
                    UsageRating = 5
                };
                #endregion
                #region redux
                redux = new Skill
                {
                    Description = "Redux is a predictable state container for JavaScript apps.",
                    ExperienceRating = 3,
                    InterestRating = 7,
                    IconClass = "devicons devicons-javascript_shield",
                    IsVisible = true,
                    Name = "Redux",
                    UsageRating = 7
                };
                #endregion
                #region nginx
                nginx = new Skill
                {
                    Description = "NGINX is a free, open-source, high-performance HTTP server and reverse proxy, as well as an IMAP/POP3 proxy server.",
                    ExperienceRating = 1,
                    InterestRating = 3,
                    IconClass = "devicon-nginx-plain",
                    IsVisible = true,
                    Name = "NGINX",
                    UsageRating = 1
                };
                #endregion
                #region grunt
                grunt = new Skill
                {
                    Description = "Grunt is a JavaScript task runner, a tool used to automatically perform frequently used tasks such as minification, compilation, unit testing, linting...",
                    ExperienceRating = 2,
                    InterestRating = 2,
                    IconClass = "devicon-grunt-line",
                    IsVisible = true,
                    Name = "Grunt",
                    UsageRating = 2
                };
                #endregion
                #region domain-driven design
                ddd = new Skill
                {
                    Description = "Domain-driven design (DDD) is an approach to software development for complex needs by connecting the implementation to an evolving model.",
                    ExperienceRating = 3,
                    InterestRating = 5,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Domain-driven design",
                    UsageRating = 5
                };
                #endregion
                #region event sourcing
                event_sourcing = new Skill
                {
                    Description = "Event Sourcing ensures that all changes to application state are stored as a sequence of events.",
                    ExperienceRating = 2,
                    InterestRating = 5,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Event Sourcing",
                    UsageRating = 3
                };
                #endregion
                #region cqrs
                cqrs = new Skill
                {
                    Description = "Command and Query Responsibility Segregation (CQRS) is a pattern that segregates the operations that read data (queries) from the operations that update data (commands) by using separate interfaces.",
                    ExperienceRating = 2,
                    InterestRating = 6,
                    IconClass = null,
                    IsVisible = true,
                    Name = "CQRS",
                    UsageRating = 3
                };
                #endregion
                #region jsx
                jsx = new Skill
                {
                    Description = "JSX is a statically-typed, object-oriented programming language designed to run on modern web browsers.",
                    ExperienceRating = 3,
                    InterestRating = 4,
                    IconClass = null,
                    IsVisible = true,
                    Name = "JSX",
                    UsageRating = 5
                };
                #endregion
                #region identityserver
                identityserver = new Skill
                {
                    Description = "OpenID Connect and OAuth 2.0 Framework for ASP.NET 4.x/Katana and ASP.NET Core",
                    ExperienceRating = 2,
                    InterestRating = 7,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "IdentityServer",
                    UsageRating = 3
                };
                #endregion
                #region autofac
                autofac = new Skill
                {
                    Description = "Autofac is an Inversion of Control container for .NET Core, ASP.NET Core, .NET 4.5.1+, Universal Windows apps, and more.",
                    ExperienceRating = 4,
                    InterestRating = 7,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "Autofac",
                    UsageRating = 4
                };
                #endregion
                #region nest
                nest = new Skill
                {
                    Description = "NEST is the official high-level .NET client of Elasticsearch. It aims to be a solid, strongly typed client with a very concise API.",
                    ExperienceRating = 5,
                    InterestRating = 9,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "NEST",
                    UsageRating = 6
                };
                #endregion
                #region couchbasenetclient
                couchbasenetclient = new Skill
                {
                    Description = "The Couchbase authored new and improved client for .NET based languages.",
                    ExperienceRating = 4,
                    InterestRating = 8,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "CouchbaseNetClient",
                    UsageRating = 5
                };
                #endregion
                #region angular
                angular = new Skill
                {
                    Description = "Angular is a development platform for building mobile and desktop web applications.",
                    ExperienceRating = 1,
                    InterestRating = 10,
                    IconClass = "devicons devicons-angular",
                    IsVisible = true,
                    Name = "Angular",
                    UsageRating = 3
                };
                #endregion
                #region typescript
                typescript = new Skill
                {
                    Description = "TypeScript is a strict superset of JavaScript, and adds optional static typing and class-based object-oriented programming to the language.",
                    ExperienceRating = 2,
                    InterestRating = 10,
                    IconClass = null,
                    IsVisible = true,
                    Name = "TypeScript",
                    UsageRating = 3
                };
                #endregion
                #region microservices
                microservices = new Skill
                {
                    Description = "Microservices is a specialisation of an implementation approach for service-oriented architectures (SOA) used to build flexible, independently deployable software systems.",
                    ExperienceRating = 5,
                    InterestRating = 10,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Microservices",
                    UsageRating = 5
                };
                #endregion
                #region webpack
                webpack = new Skill
                {
                    Description = "webpack is a module bundler. Its main purpose is to bundle JavaScript files for usage in a browser, yet it is also capable of transforming, bundling, or packaging...",
                    ExperienceRating = 1,
                    InterestRating = 8,
                    IconClass = "devicons devicons-javascript_shield",
                    IsVisible = true,
                    Name = "webpack",
                    UsageRating = 2
                };
                #endregion
                #region react
                react = new Skill
                {
                    Description = "React is an open-source JavaScript framework for building user interfaces.",
                    ExperienceRating = 3,
                    InterestRating = 7,
                    IconClass = "devicon-react-original",
                    IsVisible = true,
                    Name = "React",
                    UsageRating = 7
                };
                #endregion
                #region Aurelia
                aurelia = new Skill
                {
                    Description = "Aurelia is a JavaScript client framework for mobile, desktop and web leveraging simple conventions and empowering creativity.",
                    ExperienceRating = 5,
                    InterestRating = 6,
                    IconClass = "devicons devicons-javascript_shield",
                    IsVisible = true,
                    Name = "aurelia",
                    UsageRating = 5
                };
                #endregion
                #region Mesos
                mesos = new Skill
                {
                    Description = "Apache Mesos abstracts CPU, memory, storage, and other compute resources away from machines (physical or virtual), enabling fault-tolerant and elastic distributed systems to easily be built and run effectively.",
                    ExperienceRating = 4,
                    InterestRating = 7,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Mesos",
                    UsageRating = 6
                };
                #endregion
                #region Marathon
                marathon = new Skill
                {
                    Description = "Marathon is a production-grade container orchestration platform for Mesosphere’s Datacenter Operating System (DC/OS) and Apache Mesos.",
                    ExperienceRating = 4,
                    InterestRating = 7,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Marathon",
                    UsageRating = 6
                };
                #endregion
                #region GoCD
                gocd = new Skill
                {
                    Description = "Open source continuous delivery server to model and visualize complex workflows with ease.",
                    ExperienceRating = 6,
                    InterestRating = 8,
                    IconClass = null,
                    IsVisible = true,
                    Name = "GoCD",
                    UsageRating = 6
                };
                #endregion
                #region Zookeeper
                zookeeper = new Skill
                {
                    Description = "ZooKeeper is a centralized service for maintaining configuration information, naming, providing distributed synchronization, and providing group services.",
                    ExperienceRating = 2,
                    InterestRating = 5,
                    IconClass = "devicon-apache-line",
                    IsVisible = true,
                    Name = "Zookeeper",
                    UsageRating = 3
                };
                #endregion
                #region proget
                proget = new Skill
                {
                    Description = "ProGet is a software repository manager, designed to allow users to host and manage personal or enterprise-wide package management feeds.",
                    ExperienceRating = 5,
                    InterestRating = 7,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Proget",
                    UsageRating = 7
                };
                #endregion
                #region bamboo
                bamboo = new Skill
                {
                    Description = "Bamboo is a web daemon that automatically configures HAProxy for web services deployed on Apache Mesos and Marathon.",
                    ExperienceRating = 3,
                    InterestRating = 6,
                    IconClass = "devicons devicons-go",
                    IsVisible = true,
                    Name = "Bamboo",
                    UsageRating = 5
                };
                #endregion
                #region haproxy
                haproxy = new Skill
                {
                    Description = "HAProxy is a free, very fast and reliable solution offering high availability, load balancing, and proxying for TCP and HTTP-based applications.",
                    ExperienceRating = 1,
                    InterestRating = 6,
                    IconClass = null,
                    IsVisible = true,
                    Name = "HAProxy",
                    UsageRating = 3
                };
                #endregion
                #region postgresql
                postgresql = new Skill
                {
                    Description = "PostgreSQL is a powerful, open source object-relational database system.",
                    ExperienceRating = 1,
                    InterestRating = 6,
                    IconClass = "mfizz mfizz-postgres",
                    IsVisible = true,
                    Name = "PostgreSQL",
                    UsageRating = 4
                };
                #endregion
                #region Ubuntu
                ubuntu = new Skill
                {
                    Description = "Ubuntu is a Debian-based Linux operating system.",
                    ExperienceRating = 3,
                    InterestRating = 7,
                    IconClass = "devicon-ubuntu-plain",
                    IsVisible = true,
                    Name = "Ubuntu",
                    UsageRating = 3
                };
                #endregion
                #region Gogs
                gogs = new Skill
                {
                    Description = "Gogs is a painless self-hosted Git service.",
                    ExperienceRating = 1,
                    InterestRating = 5,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Gogs",
                    UsageRating = 5
                };
                #endregion
                #region Nexus Repository OSS
                nexus = new Skill
                {
                    Description = "Repository manager with FREE support for popular formats.",
                    ExperienceRating = 1,
                    InterestRating = 5,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Nexus Repository OSS",
                    UsageRating = 3
                };
                #endregion
                #region CentOS
                centos = new Skill
                {
                    Description = "CentOS (from Community Enterprise Operating System) is a Linux distribution that attempts to provide a free, enterprise-class, community-supported computing platform functionally compatible with its upstream source, Red Hat Enterprise Linux (RHEL).",
                    ExperienceRating = 2,
                    InterestRating = 7,
                    IconClass = "icon-centos",
                    IsVisible = true,
                    Name = "CentOS",
                    UsageRating = 5
                };
                #endregion
                #region Couchbase
                couchbase = new Skill
                {
                    Description = "Couchbase is an open-source, distributed (shared-nothing architecture) multi-model NoSQL document-oriented database software package that is optimized for interactive applications.",
                    ExperienceRating = 4,
                    InterestRating = 8,
                    IconClass = "icon-database",
                    IsVisible = true,
                    Name = "Couchbase",
                    UsageRating = 5
                };
                #endregion
                #region Elasticsearch
                elasticsearch = new Skill
                {
                    Description = "Elasticsearch is a distributed, RESTful search and analytics engine.",
                    ExperienceRating = 4,
                    InterestRating = 10,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Elasticsearch",
                    UsageRating = 5
                };
                #endregion
                #region Docker
                docker = new Skill
                {
                    Description = "Docker is the world’s leading software container platform.",
                    ExperienceRating = 4,
                    InterestRating = 10,
                    IconClass = "devicon-docker-plain",
                    IsVisible = true,
                    Name = "Docker",
                    UsageRating = 4
                };
                #endregion
                #region Microsoft Azure
                azure = new Skill
                {
                    Description = "Microsoft Azure is a cloud computing platform and infrastructure created by Microsoft for building, deploying, and managing applications and services through a global network of Microsoft-managed datacenters.",
                    ExperienceRating = 2,
                    InterestRating = 10,
                    IconClass = "devicons devicons-windows",
                    IsVisible = true,
                    Name = "Microsoft Azure",
                    UsageRating = 2
                };
                #endregion
                #region Less
                less = new Skill
                {
                    Description = "Less (sometimes stylized as LESS) is a dynamic style sheet language that can be compiled into Cascading Style Sheets (CSS) and run on the client side or server side.",
                    ExperienceRating = 2,
                    InterestRating = 7,
                    IconClass = "devicons devicons-less",
                    IsVisible = true,
                    Name = "Less",
                    UsageRating = 3
                };
                #endregion
                #region wamp server
                wamp = new Skill
                {
                    Description = "WampServer refers to a software stack for the Microsoft Windows operating system, created by Romain Bourdon and consisting of the Apache web server, OpenSSL for SSL support, MySQL database and PHP programming language.",
                    ExperienceRating = 1,
                    InterestRating = 1,
                    IconClass = null,
                    IsVisible = true,
                    Name = "WampServer",
                    UsageRating = 1
                };
                #endregion
                #region xunit
                xunit = new Skill
                {
                    Description = "xUnit.net is an open source unit testing tool for the .NET framework, written by the original author of NUnit.",
                    ExperienceRating = 3,
                    InterestRating = 9,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "xUnit.net",
                    UsageRating = 4
                };
                #endregion
                #region bower
                bower = new Skill
                {
                    Description = "Bower is a package management system for client-side programming on the World Wide Web.",
                    ExperienceRating = 4,
                    InterestRating = 5,
                    IconClass = "devicons devicons-bower",
                    IsVisible = true,
                    Name = "Bower",
                    UsageRating = 5
                };
                #endregion
                #region npm
                npm = new Skill
                {
                    Description = "npm runs through the command line and manages dependencies for an application. It also allows users to install Node.js applications that are available on the npm registry.",
                    ExperienceRating = 5,
                    InterestRating = 8,
                    IconClass = "devicons devicons-npm",
                    IsVisible = true,
                    Name = "npm",
                    UsageRating = 7
                };
                #endregion
                #region sass
                sass = new Skill
                {
                    Description = "Sass (Syntactically Awesome Stylesheets) is a style sheet language initially designed by Hampton Catlin and developed by Natalie Weizenbaum.",
                    ExperienceRating = 1,
                    InterestRating = 5,
                    IconClass = "devicons devicons-sass",
                    IsVisible = true,
                    Name = "Sass",
                    UsageRating = 1
                };
                #endregion
                #region gulp
                gulp = new Skill
                {
                    Description = "gulp is a toolkit that helps you automate painful or time-consuming tasks in your development workflow.",
                    ExperienceRating = 1,
                    InterestRating = 6,
                    IconClass = "devicons devicons-gulp",
                    IsVisible = true,
                    Name = "Gulp",
                    UsageRating = 3
                };
                #endregion
                #region karma
                karma = new Skill
                {
                    Description = "Test Runner for JavaScript",
                    ExperienceRating = 1,
                    InterestRating = 7,
                    IconClass = "devicons devicons-javascript_shield",
                    IsVisible = true,
                    Name = "Karma",
                    UsageRating = 4
                };
                #endregion
                #region jasmine
                jasmine = new Skill
                {
                    Description = "Jasmine is an open source testing framework for JavaScript. It aims to run on any JavaScript-enabled platform, to not intrude on the application nor the IDE, and to have easy-to-read syntax.",
                    ExperienceRating = 1,
                    InterestRating = 7,
                    IconClass = "devicons devicons-javascript_shield",
                    IsVisible = true,
                    Name = "Jasmine",
                    UsageRating = 4
                };
                #endregion
                #region RavenDB
                ravendb = new Skill
                {
                    Description = "2nd generation document database, JSON format with replication and sharding.",
                    ExperienceRating = 1,
                    InterestRating = 7,
                    IconClass = null,
                    IsVisible = true,
                    Name = "RavenDB",
                    UsageRating = 2
                };
                #endregion
                #region MongoDB
                mongodb = new Skill
                {
                    Description = "MongoDB (from humongous) is a cross-platform document-oriented database. Classified as a NoSQL database, MongoDB eschews the traditional table-based relational database structure in favor of JSON-like documents with dynamic schemas (MongoDB calls the format BSON), making the integration of data in certain types of applications easier and faster.",
                    ExperienceRating = 1,
                    InterestRating = 6,
                    IconClass = "devicons devicons-mongodb",
                    IsVisible = true,
                    Name = "MongoDB",
                    UsageRating = 2
                };
                #endregion
                #region MongoDB c# Driver
                mongodb_csharp = new Skill
                {
                    Description = "The official MongoDB .NET Driver provides asynchronous interaction with MongoDB. Powering the drivers is a Core library and a BSON library.",
                    ExperienceRating = 1,
                    InterestRating = 6,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "MongoDB .NET Driver",
                    UsageRating = 2
                };
                #endregion
                #region oauth
                oauth = new Skill
                {
                    Description = "OAuth is an open standard for authorization, commonly used as a way for Internet users to log into third party websites using their Microsoft, Google, Facebook, Twitter, One Network etc. accounts without exposing their password.",
                    ExperienceRating = 1,
                    InterestRating = 7,
                    IconClass = null,
                    IsVisible = true,
                    Name = "OAuth",
                    UsageRating = 3
                };
                #endregion
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
                    InterestRating = 7,
                    IconClass = "devicons devicons-msql_server",
                    IsVisible = true,
                    Name = "Microsoft SQL Server",
                    UsageRating = 7
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
                    IconClass = "devicons devicons-dotnet",
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
                    IconClass = "devicon-oracle-original",
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
                    IconClass = "devicon-apache-plain",
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
                    InterestRating = 7,
                    IconClass = "icon-html",
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
                    InterestRating = 5,
                    IconClass = "icon-css",
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
                    IconClass = "devicon-photoshop-line",
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
                    IconClass = "devicons devicons-windows",
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
                    IconClass = "devicons devicons-windows",
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
                    IconClass = "icon-mssql",
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
                    UsageRating = 8
                };
                #endregion
                #region xml
                xml = new Skill
                {
                    Description = "Extensible Markup Language (XML) is a markup language that defines a set of rules for encoding documents in a format which is both human-readable and machine-readable.",
                    ExperienceRating = 5,
                    InterestRating = 4,
                    IconClass = null,
                    IsVisible = true,
                    Name = "XML",
                    UsageRating = 4
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
                    IconClass = "devicon-apache-line",
                    IsVisible = true,
                    Name = "SVN",
                    UsageRating = 5
                };
                #endregion
                #region windows forms
                winform = new Skill
                {
                    Description = "Windows Forms (WinForms) is a graphical (GUI) class library included as a part of Microsoft .NET Framework, providing a platform to write rich client applications for desktop, laptop, and tablet PCs.",
                    ExperienceRating = 4,
                    InterestRating = 6,
                    IconClass = "devicons devicons-dotnet",
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
                    InterestRating = 7,
                    IconClass = null,
                    IsVisible = true,
                    Name = "SQL",
                    UsageRating = 7
                };
                #endregion
                #region ADO.NET
                ado_net = new Skill
                {
                    Description = "ADO.NET is a set of computer software components that programmers can use to access data and data services from the database. It is a part of the base class library that is included with the Microsoft .NET Framework.",
                    ExperienceRating = 7,
                    InterestRating = 5,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "ADO.NET",
                    UsageRating = 5
                };
                #endregion
                #region AJAX
                ajax = new Skill
                {
                    Description = "Ajax short for asynchronous JavaScript and XML, is a set of web development techniques using many web technologies on the client-side to create asynchronous Web applications.",
                    ExperienceRating = 8,
                    InterestRating = 10,
                    IconClass = "devicons devicons-javascript_shield",
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
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "ASP.NET AJAX",
                    UsageRating = 4
                };
                #endregion
                #region web service
                web_service = new Skill
                {
                    Description = "A Web service is a service offered by an electronic device to another electronic device, communicating with each other via the World wide web.",
                    ExperienceRating = 6,
                    InterestRating = 4,
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
                    InterestRating = 6,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "Console application",
                    UsageRating = 6
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
                    ExperienceRating = 4,
                    InterestRating = 7,
                    IconClass = "devicons devicons-visualstudio",
                    IsVisible = true,
                    Name = "TFS",
                    UsageRating = 5
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
                    IconClass = "devicons devicons-windows",
                    IsVisible = true,
                    Name = "Microsoft Commerce Server",
                    UsageRating = 1
                };
                #endregion
                #region Scrum
                scrum = new Skill
                {
                    Description = "Scrum is an iterative and incremental agile software development framework for managing product development.",
                    ExperienceRating = 4,
                    InterestRating = 9,
                    IconClass = "devicons devicons-scrum",
                    IsVisible = true,
                    Name = "Scrum",
                    UsageRating = 3
                };
                #endregion
                #region Agile
                agile = new Skill
                {
                    Description = "Agile software development is a set of principles for software development in which requirements and solutions evolve through collaboration between self-organizing, cross-functional teams.",
                    ExperienceRating = 4,
                    InterestRating = 9,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Agile",
                    UsageRating = 3
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
                    ExperienceRating = 7,
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
                    IconClass = "devicons devicons-dotnet",
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
                    IconClass = "devicons devicons-dotnet",
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
                    UsageRating = 8
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
                    InterestRating = 5,
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
                    ExperienceRating = 5,
                    InterestRating = 10,
                    IconClass = "devicons devicons-angular",
                    IsVisible = true,
                    Name = "AngularJS",
                    UsageRating = 8
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
                    IconClass = null,
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
                    IconClass = "devicon-redhat-plain",
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
                    IconClass = "icon-fedora",
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
                #region Entity Framework
                entity_framework = new Skill
                {
                    Description = "Entity Framework (EF) is an open source[1] object-relational mapping (ORM) framework for ADO.NET, was a part of .NET Framework, but from Entity framework version 6 it is separated from .NET framework.",
                    ExperienceRating = 5,
                    InterestRating = 10,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "Entity Framework",
                    UsageRating = 8
                };
                #endregion
                #region Unity
                unity = new Skill
                {
                    Description = "Unity is a lightweight, extensible dependency injection container with support for instance and type interception.",
                    ExperienceRating = 4,
                    InterestRating = 8,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "Unity",
                    UsageRating = 8
                };
                #endregion
                #region moq
                moq = new Skill
                {
                    Description = "Moq (pronounced \"Mock-you\" or just \"Mock\") is a mocking library for .NET developed from scratch to take full advantage of .NET 3.5 (i.e. Linq expression trees) and C# 3.0 features (i.e. lambda expressions) that make it the most productive, type-safe and refactoring-friendly mocking library available.",
                    ExperienceRating = 4,
                    InterestRating = 9,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "Moq",
                    UsageRating = 7
                };
                #endregion
                #region Rhino Mock
                rhino_mock = new Skill
                {
                    Description = "Rhino Mocks is a dynamic mock object framework for the .Net platform. Its purpose is to ease testing by allowing the developer to create mock implementations of custom objects and verify the interactions using unit testing.",
                    ExperienceRating = 2,
                    InterestRating = 7,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "Rhino Mocks",
                    UsageRating = 2
                };
                #endregion
                #region Automapper
                automapper = new Skill
                {
                    Description = "A convention-based object-object mapper.",
                    ExperienceRating = 5,
                    InterestRating = 8,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "AutoMapper",
                    UsageRating = 7
                };
                #endregion
                #region Unit Testing
                unit_testing = new Skill
                {
                    Description = "Unit testing is a software testing method by which individual units of source code, sets of one or more computer program modules together with associated control data, usage procedures, and operating procedures, are tested to determine whether they are fit for use.",
                    ExperienceRating = 4,
                    InterestRating = 10,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Unit Testing",
                    UsageRating = 6
                };
                #endregion
                #region linq
                linq = new Skill
                {
                    Description = "Language Integrated Query (LINQ, pronounced \"link\") is a Microsoft .NET Framework component that adds native data querying capabilities to .NET languages.",
                    ExperienceRating = 7,
                    InterestRating = 8,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "LINQ",
                    UsageRating = 9
                };
                #endregion
                #region umbraco
                umbraco = new Skill
                {
                    Description = "Umbraco is an open source content management system (CMS) platform for publishing content on the World Wide Web and intranets.",
                    ExperienceRating = 2,
                    InterestRating = 3,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "Umbraco",
                    UsageRating = 1
                };
                #endregion
                #region MediaWiki
                mediawiki = new Skill
                {
                    Description = "MediaWiki is a free and open-source wiki application. It was originally developed by the Wikimedia Foundation and runs on many websites, including Wikipedia, Wiktionary and Wikimedia Commons.",
                    ExperienceRating = 2,
                    InterestRating = 1,
                    IconClass = null,
                    IsVisible = true,
                    Name = "MediaWiki",
                    UsageRating = 1
                };
                #endregion
                #region Silverlight SDK
                silverlight_sdk = new Skill
                {
                    Description = "The Microsoft Silverlight SDK provides libraries and tools for developing Silverlight applications.",
                    ExperienceRating = 2,
                    InterestRating = 1,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "Silverlight SDK",
                    UsageRating = 1
                };
                #endregion
                #region Silverlight ToolKit
                silverlight_toolkit = new Skill
                {
                    Description = "The Microsoft Silverlight Toolkit provides the developer community with new components, functionality, and an efficient way to help shape product development.",
                    ExperienceRating = 2,
                    InterestRating = 1,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "Silverlight Toolkit",
                    UsageRating = 1
                };
                #endregion
                #region bootstrap
                bootstrap = new Skill
                {
                    Description = "Bootstrap is a free and open-source front-end library for creating websites and web applications. It contains HTML- and CSS-based design templates for typography, forms, buttons, navigation and other interface components, as well as optional JavaScript extensions.",
                    ExperienceRating = 5,
                    InterestRating = 7,
                    IconClass = "devicons devicons-bootstrap",
                    IsVisible = true,
                    Name = "Bootstrap",
                    UsageRating = 9
                };
                #endregion
                #region wcf
                wcf = new Skill
                {
                    Description = "The Windows Communication Foundation (or WCF), previously known as \"Indigo\", is a runtime and a set of APIs in the .NET Framework for building connected, service-oriented applications.",
                    ExperienceRating = 2,
                    InterestRating = 6,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "WCF",
                    UsageRating = 2
                };
                #endregion
                #region wpf
                wpf = new Skill
                {
                    Description = "Windows Presentation Foundation (or WPF) is a graphical subsystem for rendering user interfaces in Windows-based applications by Microsoft. WPF, previously known as \"Avalon\", was initially released as part of .NET Framework 3.0.",
                    ExperienceRating = 2,
                    InterestRating = 3,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "WPF",
                    UsageRating = 1
                };
                #endregion
                #region nunit
                nunit = new Skill
                {
                    Description = "NUnit is an open source unit testing framework for Microsoft .NET.",
                    ExperienceRating = 2,
                    InterestRating = 6,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "NUnit",
                    UsageRating = 1
                };
                #endregion
                #region Visual Studio Unit Testing Framework
                mstest = new Skill
                {
                    Description = "The Visual Studio Unit Testing Framework describes Microsoft's suite of unit testing tools as integrated into some versions of Visual Studio 2005 and later.",
                    ExperienceRating = 2,
                    InterestRating = 6,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "Visual Studio Unit Testing Framework",
                    UsageRating = 1
                };
                #endregion
                #region Linux
                linux = new Skill
                {
                    Description = "Linux is a Unix-like and mostly POSIX-compliant computer operating system (OS) assembled under the model of free and open-source software development and distribution.",
                    ExperienceRating = 4,
                    InterestRating = 7,
                    IconClass = "devicons devicons-linux",
                    IsVisible = true,
                    Name = "Linux",
                    UsageRating = 5
                };
                #endregion
                #region ASP.NET Web API
                aspnet_webapi = new Skill
                {
                    Description = "ASP.NET Web API is a framework that makes it easy to build HTTP services that reach a broad range of clients, including browsers and mobile devices. ASP.NET Web API is an ideal platform for building RESTful applications on the .NET Framework.",
                    ExperienceRating = 5,
                    InterestRating = 10,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "ASP.NET Web API",
                    UsageRating = 8
                };
                #endregion
                #region Python 
                python = new Skill
                {
                    Description = "Python is a widely used high-level, general-purpose, interpreted, dynamic programming language.",
                    ExperienceRating = 3,
                    InterestRating = 4,
                    IconClass = "devicons devicons-python",
                    IsVisible = true,
                    Name = "Python",
                    UsageRating = 3
                };
                #endregion
                #region Bash
                bash_shell = new Skill
                {
                    Description = "Python is a widely used high-level, general-purpose, interpreted, dynamic programming language.",
                    ExperienceRating = 3,
                    InterestRating = 5,
                    IconClass = "icon-shell",
                    IsVisible = true,
                    Name = "Bash",
                    UsageRating = 5
                };
                #endregion
                #region Mantis Bug Tracker
                mantis = new Skill
                {
                    Description = "Mantis Bug Tracker is a free and open source, web-based bug tracking system released under the terms of the GNU General Public License version 2.",
                    ExperienceRating = 3,
                    InterestRating = 1,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Mantis Bug Tracker",
                    UsageRating = 2
                };
                #endregion
                #region Windows Service
                winservice = new Skill
                {
                    Description = "In Windows NT operating systems, a Windows service is a computer program that operates in the background.",
                    ExperienceRating = 4,
                    InterestRating = 6,
                    IconClass = "devicons devicons-windows",
                    IsVisible = true,
                    Name = "Windows service",
                    UsageRating = 2
                };
                #endregion
                #region MariaDB
                mariadb = new Skill
                {
                    Description = "MariaDB is a community-developed fork of the MySQL relational database management system intended to remain free under the GNU GPL.",
                    ExperienceRating = 1,
                    InterestRating = 5,
                    IconClass = "icon-mariadb",
                    IsVisible = true,
                    Name = "MariaDB",
                    UsageRating = 1
                };
                #endregion
                #region Github
                github = new Skill
                {
                    Description = "GitHub is a web-based Git repository hosting service. It offers all of the distributed revision control and source code management (SCM) functionality of Git as well as adding its own features.",
                    ExperienceRating = 3,
                    InterestRating = 8,
                    IconClass = "devicons devicons-github",
                    IsVisible = true,
                    Name = "GitHub",
                    UsageRating = 5
                };
                #endregion
                #region git
                git = new Skill
                {
                    Description = "Git is a widely used source code management system for software development.",
                    ExperienceRating = 5,
                    InterestRating = 8,
                    IconClass = "devicons devicons-git",
                    IsVisible = true,
                    Name = "Git",
                    UsageRating = 6
                };
                #endregion
                #region Bitbucket
                bitbucket = new Skill
                {
                    Description = "Bitbucket is a web-based hosting service for projects that use either the Mercurial (since launch) or Git (since October 2011) revision control systems.",
                    ExperienceRating = 2,
                    InterestRating = 8,
                    IconClass = "devicons devicons-bitbucket",
                    IsVisible = true,
                    Name = "Bitbucket",
                    UsageRating = 4
                };
                #endregion
                #region NuGet
                nuget = new Skill
                {
                    Description = "NuGet is a free and open-source package manager designed for the Microsoft development platform (formerly known as NuPack).",
                    ExperienceRating = 8,
                    InterestRating = 7,
                    IconClass = "devicons devicons-dotnet",
                    IsVisible = true,
                    Name = "NuGet",
                    UsageRating = 9
                };
                #endregion
                #region rest
                rest = new Skill
                {
                    Description = "In computing, representational state transfer (REST) is the software architectural style of the World Wide Web.",
                    ExperienceRating = 5,
                    InterestRating = 8,
                    IconClass = null,
                    IsVisible = true,
                    Name = "REST",
                    UsageRating = 8
                };
                #endregion
                #region JSON
                json = new Skill
                {
                    Description = "JSON (JavaScript Object Notation) is an open-standard format that uses human-readable text to transmit data objects consisting of attribute–value pairs.",
                    ExperienceRating = 8,
                    InterestRating = 8,
                    IconClass = "devicons devicons-javascript_shield",
                    IsVisible = true,
                    Name = "JSON",
                    UsageRating = 9
                };
                #endregion
                #region Continuous Integration
                ci = new Skill
                {
                    Description = "Continuous integration (CI) is the practice, in software engineering, of merging all developer working copies to a shared mainline several times a day.",
                    ExperienceRating = 5,
                    InterestRating = 10,
                    IconClass = null,
                    IsVisible = true,
                    Name = "Continuous integration",
                    UsageRating = 7
                };
                #endregion

                context.Skills.Add(chai);
                context.Skills.Add(babel);
                context.Skills.Add(mocha);
                context.Skills.Add(sinon);
                context.Skills.Add(enzyme);
                context.Skills.Add(redux);
                context.Skills.Add(nginx);
                context.Skills.Add(jsx);
                context.Skills.Add(grunt);
                context.Skills.Add(ddd);
                context.Skills.Add(event_sourcing);
                context.Skills.Add(cqrs);
                context.Skills.Add(identityserver);
                context.Skills.Add(autofac);
                context.Skills.Add(nest);
                context.Skills.Add(couchbasenetclient);
                context.Skills.Add(angular);
                context.Skills.Add(typescript);
                context.Skills.Add(microservices);
                context.Skills.Add(webpack);
                context.Skills.Add(react);
                context.Skills.Add(typescript);
                context.Skills.Add(aurelia);
                context.Skills.Add(mesos);
                context.Skills.Add(marathon);
                context.Skills.Add(gocd);
                context.Skills.Add(zookeeper);
                context.Skills.Add(proget);
                context.Skills.Add(bamboo);
                context.Skills.Add(haproxy);
                context.Skills.Add(postgresql);
                context.Skills.Add(ubuntu);
                context.Skills.Add(gogs);
                context.Skills.Add(nexus);
                context.Skills.Add(centos);
                context.Skills.Add(couchbase);
                context.Skills.Add(elasticsearch);
                context.Skills.Add(docker);
                context.Skills.Add(sass);
                context.Skills.Add(less);
                context.Skills.Add(bower);
                context.Skills.Add(npm);
                context.Skills.Add(gulp);
                context.Skills.Add(karma);
                context.Skills.Add(jasmine);
                context.Skills.Add(oauth);
                context.Skills.Add(mantis);
                context.Skills.Add(winservice);
                context.Skills.Add(aspnet_webapi);
                context.Skills.Add(python);
                context.Skills.Add(bash_shell);
                context.Skills.Add(nunit);
                context.Skills.Add(mstest);
                context.Skills.Add(linux);
                context.Skills.Add(wcf);
                context.Skills.Add(wpf);
                context.Skills.Add(bootstrap);
                context.Skills.Add(silverlight_sdk);
                context.Skills.Add(silverlight_toolkit);
                context.Skills.Add(mediawiki);
                context.Skills.Add(umbraco);
                context.Skills.Add(linq);
                context.Skills.Add(unit_testing);
                context.Skills.Add(automapper);
                context.Skills.Add(rhino_mock);
                context.Skills.Add(unity);
                context.Skills.Add(moq);
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
                context.Skills.Add(entity_framework);
                context.Skills.Add(mariadb);
                context.Skills.Add(github);
                context.Skills.Add(bitbucket);
                context.Skills.Add(git);
                context.Skills.Add(nuget);
                context.Skills.Add(rest);
                context.Skills.Add(json);
                context.Skills.Add(ci);
                context.Skills.Add(ravendb);
                context.Skills.Add(mongodb);
                context.Skills.Add(mongodb_csharp);
                context.Skills.Add(xunit);
                context.Skills.Add(wamp);
                context.Skills.Add(azure);
            }
            return context.SaveChanges();
        }

        private static int CreateSkillVersions(CvDbContext context)
        {
            if (!context.SkillVersions.Any())
            {
                #region chai 3.5.0
                chai_3_5_0 = new SkillVersion
                {
                    Name = "3.5.0",
                    SkillId = chai.Id
                };
                #endregion
                #region mocha 3.3.0
                mocha_3_3_0 = new SkillVersion
                {
                    Name = "3.3.0",
                    SkillId = mocha.Id
                };
                #endregion
                #region babel 6.24.1
                babel_6_24_1 = new SkillVersion
                {
                    Name = "6.24.1",
                    SkillId = babel.Id
                };
                #endregion
                #region enzyme 2.8.2
                enzyme_2_8_2 = new SkillVersion
                {
                    Name = "2.8.2",
                    SkillId = enzyme.Id
                };
                #endregion
                #region redux 3.6.0
                redux_3_6_0 = new SkillVersion
                {
                    Name = "3.6.0",
                    SkillId = redux.Id
                };
                #endregion
                #region nginx 1.13.1
                nginx_1_13_1 = new SkillVersion
                {
                    Name = "1.13.1",
                    SkillId = nginx.Id
                };
                #endregion
                #region IdentityServer4
                identityserver_4 = new SkillVersion
                {
                    Name = "IdentityServer4",
                    SkillId = identityserver.Id
                };
                #endregion
                #region IdentityServer3
                identityserver_3 = new SkillVersion
                {
                    Name = "IdentityServer3",
                    SkillId = identityserver.Id
                };
                #endregion
                #region autofac 4.0
                autofac_4_0 = new SkillVersion
                {
                    Name = "4.0",
                    SkillId = autofac.Id
                };
                #endregion
                #region nest 2.5.1
                nest_2_5_1 = new SkillVersion
                {
                    Name = "2.5.1",
                    SkillId = nest.Id
                };
                #endregion
                #region nest 1.8.3
                nest_1_8_3 = new SkillVersion
                {
                    Name = "1.8.3",
                    SkillId = nest.Id
                };
                #endregion
                #region couchbasenetclient 2.4.0
                couchbasenetclient_2_4_0 = new SkillVersion
                {
                    Name = "2.4.0",
                    SkillId = couchbasenetclient.Id
                };
                #endregion
                #region angular 2.4.0
                angular_2_4_0 = new SkillVersion
                {
                    Name = "2.4.0",
                    SkillId = angular.Id
                };
                #endregion
                #region angular 2.4.6
                angular_2_4_6 = new SkillVersion
                {
                    Name = "2.4.6",
                    SkillId = angular.Id
                };
                #endregion
                #region typescript 1.8
                typescript_1_8 = new SkillVersion
                {
                    Name = "1.8",
                    SkillId = typescript.Id
                };
                #endregion
                #region typescript 2.0
                typescript_2_0 = new SkillVersion
                {
                    Name = "2.0",
                    SkillId = typescript.Id
                };
                #endregion
                #region webpack 2.0
                webpack_2_0 = new SkillVersion
                {
                    Name = "2.0",
                    SkillId = webpack.Id
                };
                #endregion
                #region webpack 2.4.1
                webpack_2_4_1 = new SkillVersion
                {
                    Name = "2.4.1",
                    SkillId = webpack.Id
                };
                #endregion
                #region react 15.4.2
                react_15_4_2 = new SkillVersion
                {
                    Name = "15.4.2",
                    SkillId = react.Id
                };
                #endregion
                #region aurelia 1.0
                aurelia_1_0 = new SkillVersion
                {
                    Name = "1.0",
                    SkillId = aurelia.Id
                };
                #endregion
                #region mesos 1.0.1
                mesos_1_0_1 = new SkillVersion
                {
                    Name = "1.0.1",
                    SkillId = mesos.Id
                };
                #endregion
                #region marathon 1.1.2
                marathon_1_1_2 = new SkillVersion
                {
                    Name = "1.1.2",
                    SkillId = marathon.Id
                };
                #endregion
                #region gocd 16.7.0
                gocd_16_7_0 = new SkillVersion
                {
                    Name = "16.7.0",
                    SkillId = gocd.Id
                };
                #endregion
                #region zookeeper 3.4.6
                zookeeper_3_4_6 = new SkillVersion
                {
                    Name = "3.4.6",
                    SkillId = zookeeper.Id
                };
                #endregion
                #region proget 3.4.6
                proget_3_4_6 = new SkillVersion
                {
                    Name = "3.4.6",
                    SkillId = proget.Id
                };
                #endregion
                #region proget 4.6.4
                proget_4_6_4 = new SkillVersion
                {
                    Name = "4.6.4",
                    SkillId = proget.Id
                };
                #endregion
                #region bamboo 0.0.21
                bamboo_0_2_2_1 = new SkillVersion
                {
                    Name = "0.2.21",
                    SkillId = bamboo.Id
                };
                #endregion
                #region haproxy 1.5.8
                haproxy_1_5_8 = new SkillVersion
                {
                    Name = "1.5.8",
                    SkillId = haproxy.Id
                };
                #endregion
                #region postgresql 9.2.15
                postgresql_9_2_15 = new SkillVersion
                {
                    Name = "9.2.15",
                    SkillId = postgresql.Id
                };
                #endregion
                #region ubuntu 14..04
                ubuntu_14_04 = new SkillVersion
                {
                    Name = "14.04",
                    SkillId = ubuntu.Id
                };
                #endregion
                #region nexus repository oss 3.0.1
                nexus_3_0_1 = new SkillVersion
                {
                    Name = "3.0.1",
                    SkillId = nexus.Id
                };
                #endregion
                #region centos 7.2
                centos_7_2 = new SkillVersion
                {
                    Name = "7.2",
                    SkillId = centos.Id
                };
                #endregion
                #region couchbase enterprise 4.5.0
                couchbase_enterprise_4_5_0 = new SkillVersion
                {
                    Name = "Enterprise 4.5.0",
                    SkillId = couchbase.Id
                };
                #endregion
                #region couchbase enterprise 4.0.0
                couchbase_enterprise_4_0_0 = new SkillVersion
                {
                    Name = "Enterprise 4.0.0",
                    SkillId = couchbase.Id
                };
                #endregion
                #region couchbase community 4.1.0
                couchbase_community_4_1_0 = new SkillVersion
                {
                    Name = "Community 4.1.0",
                    SkillId = couchbase.Id
                };
                #endregion
                #region elasticsearch 1.7.0
                elasticsearch_1_7_0 = new SkillVersion
                {
                    Name = "1.7.0",
                    SkillId = elasticsearch.Id
                };
                #endregion
                #region elasticsearch 2.3.5
                elasticsearch_2_3_5 = new SkillVersion
                {
                    Name = "2.3.5",
                    SkillId = elasticsearch.Id
                };
                #endregion
                #region elasticsearch 2.4.3
                elasticsearch_2_4_3 = new SkillVersion
                {
                    Name = "2.4.3",
                    SkillId = elasticsearch.Id
                };
                #endregion
                #region docker 1.12.1
                docker_1_12_1 = new SkillVersion
                {
                    Name = "1.12.1",
                    SkillId = docker.Id
                };
                #endregion
                #region Azure WebJobs
                azure_webjobs = new SkillVersion
                {
                    Name = "Azure WebJobs",
                    SkillId = azure.Id
                };
                #endregion
                #region Azure WebSites
                azure_web_sites = new SkillVersion
                {
                    Name = "Azure Web Sites",
                    SkillId = azure.Id
                };
                #endregion
                #region MongoDB .NET Driver 2.1.1
                mongodb_csharp_2_1_1 = new SkillVersion
                {
                    Name = "MongoDB .NET Driver 2.1.1",
                    SkillId = mongodb_csharp.Id
                };
                #endregion
                #region MongoDB 3.0
                mongodb_3_0 = new SkillVersion
                {
                    Name = "MongoDB 3.0",
                    SkillId = mongodb.Id
                };
                #endregion
                #region RavenDB 3.0
                ravendb_3_0 = new SkillVersion
                {
                    Name = "RavenDB 3.0",
                    SkillId = ravendb.Id
                };
                #endregion
                #region oauth 2.0
                oauth_2_0 = new SkillVersion
                {
                    Name = "OAuth 2.0",
                    SkillId = oauth.Id
                };
                #endregion
                #region php 4.3
                php_4_3 = new SkillVersion
                {
                    Name = "php 4.3",
                    SkillId = php.Id                      
                };
                #endregion
                #region php 4.4
                php_4_4 = new SkillVersion
                {
                    Name = "php 4.4",
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
                #region mysql 4.1.4
                mysql_4_1_4 = new SkillVersion
                {
                    Name = "MySQL 4.1.4",
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
                #region mysql 5.1.22
                mysql_5_1_22 = new SkillVersion
                {
                    Name = "MySQL 5.1.22",
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
                #region asp.net core 1.0
                asp_net_core_1_0 = new SkillVersion
                {
                    Name = "ASP.NET Core 1.0",
                    SkillId = asp_net.Id
                };
                #endregion
                #region asp.net core 1.1
                asp_net_core_1_1 = new SkillVersion
                {
                    Name = "ASP.NET Core 1.1",
                    SkillId = asp_net.Id
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
                #region sql server 2014
                sqlserver_2014 = new SkillVersion
                {
                    Name = "SQL Server 2014",
                    SkillId = sqlserver.Id
                };
                #endregion
                #region sql server 2016
                sqlserver_2016 = new SkillVersion
                {
                    Name = "SQL Server 2016",
                    SkillId = sqlserver.Id
                };
                #endregion
                #region sql server express 2008
                sqlserver_2008_express = new SkillVersion
                {
                    Name = "SQL Server Express 2008",
                    SkillId = sqlserver.Id
                };
                #endregion
                #region sql server express 2012
                sqlserver_2012_express = new SkillVersion
                {
                    Name = "SQL Server Express 2012",
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
                #region visual studio 2010 Express
                visual_studio_2010_express = new SkillVersion
                {
                    Name = "Visual Studio 2010 Express",
                    SkillId = visual_studio.Id
                };
                #endregion
                #region visual web developer express 2013
                visual_studio_2013_web_developer_express = new SkillVersion
                {
                    Name = "Visual Web Developer Express 2013",
                    SkillId = visual_studio.Id
                };
                #endregion
                #region visual studio 2015 Community
                visual_studio_2015_community = new SkillVersion
                {
                    Name = "Visual Studio Community 2015",
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
                #region csharp 6.0
                csharp_6_0 = new SkillVersion
                {
                    Name = "C# 6.0",
                    SkillId = csharp.Id
                };
                #endregion
                #region csharp 7.0
                csharp_7_0 = new SkillVersion
                {
                    Name = "C# 7.0",
                    SkillId = csharp.Id
                };
                #endregion
                #region .net framework core 1.0
                dotnet_core_1_0 = new SkillVersion
                {
                    Name = ".NET Core 1.0",
                    SkillId = dotnet.Id
                };
                #endregion
                #region .net framework core 1.1
                dotnet_core_1_1 = new SkillVersion
                {
                    Name = ".NET Core 1.1",
                    SkillId = dotnet.Id
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
                #region windows 10
                windows_10 = new SkillVersion
                {
                    Name = "Windows 10",
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
                #region windows server 2016
                windows_server_2016 = new SkillVersion
                {
                    Name = "Windows Server 2016",
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
                #region photoshop elements 9.0
                photoshop_elements_9_0 = new SkillVersion
                {
                    Name = "Adobe Photoshop Elements 9.0",
                    SkillId = photoshop.Id
                };
                #endregion
                #region photoshop elements 14.0
                photoshop_elements_14_0 = new SkillVersion
                {
                    Name = "Adobe Photoshop Elements 14.0",
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
                #region photoshop cs3
                photoshop_cs_3 = new SkillVersion
                {
                    Name = "Adobe Photoshop CS3",
                    SkillId = photoshop.Id
                };
                #endregion
                #region photoshop cs6
                photoshop_cs_6 = new SkillVersion
                {
                    Name = "Adobe Photoshop CS6",
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
                #region iis 7.0
                iis_7_0 = new SkillVersion
                {
                    Name = "IIS 7.0",
                    SkillId = iis.Id
                };
                #endregion
                #region iis 8.0
                iis_8_0 = new SkillVersion
                {
                    Name = "IIS 8.0",
                    SkillId = iis.Id
                };
                #endregion
                #region iis express 7.0
                iis_7_0_express = new SkillVersion
                {
                    Name = "IIS Express 7.0",
                    SkillId = iis.Id
                };
                #endregion
                #region iis express 8.0
                iis_8_0_express = new SkillVersion
                {
                    Name = "IIS Express 8.0",
                    SkillId = iis.Id
                };
                #endregion
                #region vss 6.0
                vss_6_0 = new SkillVersion
                {
                    Name = "Microsoft Visual SourceSafe 6.0",
                    SkillId = vss.Id
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
                #region sql server management studio 2016
                ssms_2016 = new SkillVersion
                {
                    Name = "SSMS 2016",
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
                #region javascript ecmascript 6
                javascript_ecmascript_6 = new SkillVersion
                {
                    Name = "ECMAScript 6",
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
                #region svn 1.6
                svn_1_6 = new SkillVersion
                {
                    Name = "SVN 1.6",
                    SkillId = svn.Id
                };
                #endregion
                #region svn 1.8
                svn_1_8 = new SkillVersion
                {
                    Name = "SVN 1.8",
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
                #region tfs 2013 express
                tfs_2013_express = new SkillVersion
                {
                    Name = "TFS 2013 Express",
                    SkillId = tfs.Id
                };
                #endregion
                #region tfs 2015
                tfs_2015 = new SkillVersion
                {
                    Name = "TFS 2015",
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
                #region jQuery 1.3
                jquery_1_3 = new SkillVersion
                {
                    Name = "jQuery 1.3",
                    SkillId = jquery.Id
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
                #region jQuery 1.7
                jquery_1_7 = new SkillVersion
                {
                    Name = "jQuery 1.7",
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
                #region ASP.NET MVC Core 1.0
                mvc_core_1_0 = new SkillVersion
                {
                    Name = "MVC Core 1.0",
                    SkillId = mvc.Id
                };
                #endregion
                #region ASP.NET MVC Core 1.1
                mvc_core_1_1 = new SkillVersion
                {
                    Name = "MVC Core 1.1",
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
                #region StructureMap 3.0.2.0
                structuremap_3_0_2_0 = new SkillVersion
                {
                    Name = "StructureMap 3.0.2.0",
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
                #region AngularJS 1.3
                angularjs_1_3 = new SkillVersion
                {
                    Name = "AngularJS 1.3",
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
                #region Entity Framework Core 1.0
                entity_framework_core_1_0 = new SkillVersion
                {
                    Name = "EF Core 1.0",
                    SkillId = entity_framework.Id
                };
                #endregion
                #region Entity Framework Core 1.1
                entity_framework_core_1_1 = new SkillVersion
                {
                    Name = "EF Core 1.1",
                    SkillId = entity_framework.Id
                };
                #endregion
                #region Entity Framework 4.1
                entity_framework_4_1 = new SkillVersion
                {
                    Name = "EF 4.1",
                    SkillId = entity_framework.Id
                };
                #endregion
                #region Entity Framework 5.0
                entity_framework_5_0 = new SkillVersion
                {
                    Name = "EF 5.0",
                    SkillId = entity_framework.Id
                };
                #endregion
                #region Entity Framework 6_0
                entity_framework_6_0 = new SkillVersion
                {
                    Name = "EF 6.0",
                    SkillId = entity_framework.Id
                };
                #endregion
                #region AutoMapper 2.2.0
                automapper_2_2_0 = new SkillVersion
                {
                    Name = "AutoMapper 2.2.0",
                    SkillId = automapper.Id
                };
                #endregion
                #region AutoMapper 5.2.0
                automapper_5_2_0 = new SkillVersion
                {
                    Name = "AutoMapper 5.2.0",
                    SkillId = automapper.Id
                };
                #endregion
                #region Unity 3.0
                unity_3_0 = new SkillVersion
                {
                    Name = "Unity 3.0",
                    SkillId = unity.Id
                };
                #endregion
                #region Unity 3.5
                unity_3_5 = new SkillVersion
                {
                    Name = "Unity 3.5",
                    SkillId = unity.Id
                };
                #endregion
                #region Umbraco 4
                umbraco_4 = new SkillVersion
                {
                    Name = "Umbraco 4",
                    SkillId = umbraco.Id
                };
                #endregion
                #region Umbraco 6
                umbraco_6 = new SkillVersion
                {
                    Name = "Umbraco 6",
                    SkillId = umbraco.Id
                };
                #endregion
                #region Umbraco 7
                umbraco_7 = new SkillVersion
                {
                    Name = "Umbraco 7",
                    SkillId = umbraco.Id
                };
                #endregion
                #region MediaWiki 1.26
                mediawiki_1_26 = new SkillVersion
                {
                    Name = "MediaWiki 1.26",
                    SkillId = mediawiki.Id
                };
                #endregion
                #region MediaWiki 1.22
                mediawiki_1_22 = new SkillVersion
                {
                    Name = "MediaWiki 1.22",
                    SkillId = mediawiki.Id
                };
                #endregion
                #region Silverlight SDK 5
                silverlight_sdk_5 = new SkillVersion
                {
                    Name = "Silverlight SDK 5",
                    SkillId = silverlight_sdk.Id
                };
                #endregion
                #region Silverlight Toolkit 5
                silverlight_toolkit_5 = new SkillVersion
                {
                    Name = "Silverlight Toolkit 5",
                    SkillId = silverlight_toolkit.Id
                };
                #endregion
                #region bootstrap 3
                bootstrap_3 = new SkillVersion
                {
                    Name = "Bootstrap 3",
                    SkillId = bootstrap.Id
                };
                #endregion
                #region nunit 2.6.2
                nunit_2_6_2 = new SkillVersion
                {
                    Name = "NUnit 2.6.2",
                    SkillId = nunit.Id
                };
                #endregion
                #region ASP.NET Web API 1
                aspnet_webapi_1 = new SkillVersion
                {
                    Name = "ASP.NET Web API 1",
                    SkillId = aspnet_webapi.Id
                };
                #endregion
                #region ASP.NET Web API 2
                aspnet_webapi_2 = new SkillVersion
                {
                    Name = "ASP.NET Web API 2",
                    SkillId = aspnet_webapi.Id
                };
                #endregion
                #region ASP.NET Web API Core 1.0
                aspnet_webapi_core_1_0 = new SkillVersion
                {
                    Name = "ASP.NET Web API Core 1.0",
                    SkillId = aspnet_webapi.Id
                };
                #endregion
                #region ASP.NET Web API Core 1.1
                aspnet_webapi_core_1_1 = new SkillVersion
                {
                    Name = "ASP.NET Web API Core 1.1",
                    SkillId = aspnet_webapi.Id
                };
                #endregion
                #region Python 2.0
                python_2_0 = new SkillVersion
                {
                    Name = "Python 2.0",
                    SkillId = python.Id
                };
                #endregion
                #region Git 2.5.0
                git_2_5_0 = new SkillVersion
                {
                    Name = "Git 2.5.0",
                    SkillId = git.Id
                };
                #endregion
                #region Git 1.9.5
                git_1_9_5 = new SkillVersion
                {
                    Name = "Git 1.9.5",
                    SkillId = git.Id
                };
                #endregion
                #region Git 2.8.1
                git_2_8_1 = new SkillVersion
                {
                    Name = "Git 2.8.1",
                    SkillId = git.Id
                };
                #endregion

                context.SkillVersions.Add(chai_3_5_0);
                context.SkillVersions.Add(mocha_3_3_0);
                context.SkillVersions.Add(babel_6_24_1);
                context.SkillVersions.Add(enzyme_2_8_2);
                context.SkillVersions.Add(redux_3_6_0);
                context.SkillVersions.Add(nginx_1_13_1);
                context.SkillVersions.Add(identityserver_3);
                context.SkillVersions.Add(identityserver_4);
                context.SkillVersions.Add(autofac_4_0);
                context.SkillVersions.Add(nest_1_8_3);
                context.SkillVersions.Add(nest_2_5_1);
                context.SkillVersions.Add(couchbasenetclient_2_4_0);
                context.SkillVersions.Add(angular_2_4_0);
                context.SkillVersions.Add(angular_2_4_6);
                context.SkillVersions.Add(typescript_1_8);
                context.SkillVersions.Add(typescript_2_0);
                context.SkillVersions.Add(webpack_2_0);
                context.SkillVersions.Add(webpack_2_4_1);
                context.SkillVersions.Add(react_15_4_2);
                context.SkillVersions.Add(aurelia_1_0);
                context.SkillVersions.Add(mesos_1_0_1);
                context.SkillVersions.Add(marathon_1_1_2);
                context.SkillVersions.Add(gocd_16_7_0);
                context.SkillVersions.Add(zookeeper_3_4_6);
                context.SkillVersions.Add(proget_3_4_6);
                context.SkillVersions.Add(proget_4_6_4);
                context.SkillVersions.Add(bamboo_0_2_2_1);
                context.SkillVersions.Add(haproxy_1_5_8);
                context.SkillVersions.Add(postgresql_9_2_15);
                context.SkillVersions.Add(ubuntu_14_04);
                context.SkillVersions.Add(nexus_3_0_1);
                context.SkillVersions.Add(centos_7_2);
                context.SkillVersions.Add(couchbase_enterprise_4_5_0);
                context.SkillVersions.Add(couchbase_enterprise_4_0_0);
                context.SkillVersions.Add(couchbase_community_4_1_0);
                context.SkillVersions.Add(elasticsearch_1_7_0);
                context.SkillVersions.Add(elasticsearch_2_3_5);
                context.SkillVersions.Add(elasticsearch_2_4_3);
                context.SkillVersions.Add(docker_1_12_1);
                context.SkillVersions.Add(azure_webjobs);
                context.SkillVersions.Add(azure_web_sites);
                context.SkillVersions.Add(mongodb_3_0);
                context.SkillVersions.Add(mongodb_csharp_2_1_1);
                context.SkillVersions.Add(ravendb_3_0);
                context.SkillVersions.Add(aspnet_webapi_core_1_0);
                context.SkillVersions.Add(aspnet_webapi_core_1_1);
                context.SkillVersions.Add(aspnet_webapi_2);
                context.SkillVersions.Add(aspnet_webapi_1);
                context.SkillVersions.Add(python_2_0);
                context.SkillVersions.Add(bootstrap_3);
                context.SkillVersions.Add(nunit_2_6_2);
                context.SkillVersions.Add(svn_1_6);
                context.SkillVersions.Add(svn_1_8);
                context.SkillVersions.Add(silverlight_sdk_5);
                context.SkillVersions.Add(silverlight_toolkit_5);
                context.SkillVersions.Add(mediawiki_1_26);
                context.SkillVersions.Add(mediawiki_1_22);
                context.SkillVersions.Add(umbraco_4);
                context.SkillVersions.Add(umbraco_6);
                context.SkillVersions.Add(umbraco_7);
                context.SkillVersions.Add(automapper_2_2_0);
                context.SkillVersions.Add(automapper_5_2_0);
                context.SkillVersions.Add(unity_3_0);
                context.SkillVersions.Add(unity_3_5);
                context.SkillVersions.Add(entity_framework_core_1_0);
                context.SkillVersions.Add(entity_framework_core_1_1);
                context.SkillVersions.Add(entity_framework_4_1);
                context.SkillVersions.Add(entity_framework_5_0);
                context.SkillVersions.Add(entity_framework_6_0);
                context.SkillVersions.Add(php_4_3);
                context.SkillVersions.Add(php_4_4);
                context.SkillVersions.Add(mysql_4_0_6);
                context.SkillVersions.Add(mysql_4_1_4);
                context.SkillVersions.Add(mysql_5_0_96);
                context.SkillVersions.Add(mysql_5_1_22);
                context.SkillVersions.Add(mysql_5_1_73);
                context.SkillVersions.Add(asp_3_0);
                context.SkillVersions.Add(asp_net_2_0);
                context.SkillVersions.Add(asp_net_core_1_0);
                context.SkillVersions.Add(asp_net_core_1_1);
                context.SkillVersions.Add(sqlserver_2000);
                context.SkillVersions.Add(visual_studio_2003_pro);
                context.SkillVersions.Add(visual_studio_2005_pro);
                context.SkillVersions.Add(visual_studio_2008_pro);
                context.SkillVersions.Add(visual_studio_2010_pro);
                context.SkillVersions.Add(visual_studio_2012_pro);
                context.SkillVersions.Add(visual_studio_2013_pro);
                context.SkillVersions.Add(visual_studio_2015_pro);
                context.SkillVersions.Add(visual_studio_2010_express);
                context.SkillVersions.Add(visual_studio_2013_web_developer_express);
                context.SkillVersions.Add(visual_studio_2015_community);
                context.SkillVersions.Add(csharp_1_2);
                context.SkillVersions.Add(csharp_2_0);
                context.SkillVersions.Add(csharp_3_0);
                context.SkillVersions.Add(csharp_4_0);
                context.SkillVersions.Add(csharp_5_0);
                context.SkillVersions.Add(csharp_6_0);
                context.SkillVersions.Add(csharp_7_0);
                context.SkillVersions.Add(dotnet_core_1_0);
                context.SkillVersions.Add(dotnet_core_1_1);
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
                context.SkillVersions.Add(windows_10);
                context.SkillVersions.Add(windows_server_2003);
                context.SkillVersions.Add(windows_server_2008);
                context.SkillVersions.Add(windows_server_2008_R2);
                context.SkillVersions.Add(windows_server_2012_R2);
                context.SkillVersions.Add(windows_server_2016);
                context.SkillVersions.Add(html_4_0);
                context.SkillVersions.Add(html_5_0);
                context.SkillVersions.Add(css_2_0);
                context.SkillVersions.Add(css_2_1);
                context.SkillVersions.Add(css_3_0);
                context.SkillVersions.Add(flash_2004);
                context.SkillVersions.Add(actionscript_2_0);
                context.SkillVersions.Add(iis_6_0);
                context.SkillVersions.Add(iis_7_0);
                context.SkillVersions.Add(iis_8_0);
                context.SkillVersions.Add(iis_7_0_express);
                context.SkillVersions.Add(iis_8_0_express);
                context.SkillVersions.Add(vss_6_0);
                context.SkillVersions.Add(toad_9_0);
                context.SkillVersions.Add(ssms_enterprise_manager);
                context.SkillVersions.Add(ssms_2005);
                context.SkillVersions.Add(ssms_2008);
                context.SkillVersions.Add(ssms_2012);
                context.SkillVersions.Add(ssms_2014);
                context.SkillVersions.Add(ssms_2016);
                context.SkillVersions.Add(xslt_1_0);
                context.SkillVersions.Add(javascript_ecmascript_3);
                context.SkillVersions.Add(javascript_ecmascript_5);
                context.SkillVersions.Add(javascript_ecmascript_6);
                context.SkillVersions.Add(xml_1_1);
                context.SkillVersions.Add(asp_net_3_0);
                context.SkillVersions.Add(sqlserver_2005);
                context.SkillVersions.Add(sqlserver_2008);
                context.SkillVersions.Add(sqlserver_2008_express);
                context.SkillVersions.Add(sqlserver_2012_express);
                context.SkillVersions.Add(sqlserver_2008_R2);
                context.SkillVersions.Add(sqlserver_2012);
                context.SkillVersions.Add(sqlserver_2014);
                context.SkillVersions.Add(sqlserver_2016);
                context.SkillVersions.Add(svn_1_3);
                context.SkillVersions.Add(photoshop_elements_7_0);
                context.SkillVersions.Add(photoshop_elements_9_0);
                context.SkillVersions.Add(photoshop_elements_14_0);
                context.SkillVersions.Add(photoshop_cs_2);
                context.SkillVersions.Add(photoshop_cs_3);
                context.SkillVersions.Add(photoshop_cs_6);
                context.SkillVersions.Add(asp_net_3_5);
                context.SkillVersions.Add(asp_net_4_0);
                context.SkillVersions.Add(asp_net_4_5);
                context.SkillVersions.Add(asp_net_4_5_1);
                context.SkillVersions.Add(asp_net_4_5_2);
                context.SkillVersions.Add(asp_net_4_6);
                context.SkillVersions.Add(tfs_2005);
                context.SkillVersions.Add(tfs_2008);
                context.SkillVersions.Add(tfs_2013_express);
                context.SkillVersions.Add(tfs_2015);
                context.SkillVersions.Add(commerce_server_2009);
                context.SkillVersions.Add(jquery_1_3);
                context.SkillVersions.Add(jquery_1_4);
                context.SkillVersions.Add(jquery_1_5);
                context.SkillVersions.Add(jquery_1_7);
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
                context.SkillVersions.Add(mvc_core_1_0);
                context.SkillVersions.Add(mvc_core_1_1);
                context.SkillVersions.Add(structuremap_2_6_3);
                context.SkillVersions.Add(structuremap_2_6_4_1);
                context.SkillVersions.Add(structuremap_3_0_2_0);
                context.SkillVersions.Add(sitefinity_4_0);
                context.SkillVersions.Add(mysql_workbench_5_2);
                context.SkillVersions.Add(mysql_workbench_6_3);
                context.SkillVersions.Add(shibboleth_2_0);
                context.SkillVersions.Add(saml_2_0);
                context.SkillVersions.Add(jenkins_1_6);
                context.SkillVersions.Add(knockout_2_2_1);
                context.SkillVersions.Add(angularjs_1_3);
                context.SkillVersions.Add(angularjs_1_4);
                context.SkillVersions.Add(rhel_7);
                context.SkillVersions.Add(fedora_core_23);
                context.SkillVersions.Add(lync_sdk_2013);
                context.SkillVersions.Add(visual_studio_code);
                context.SkillVersions.Add(git_1_9_5);
                context.SkillVersions.Add(git_2_5_0);
                context.SkillVersions.Add(git_2_8_1);
                context.SkillVersions.Add(oauth_2_0);
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
                    Description = @"<p>As part of a sandwich course at HEIG MLV school in France I was working at T2S, a skateshop, to develop and launch their E-commerce website. The website went on to become the main revenue stream for the business and eventually replaced the retail outlet.</p>
                                    <p>
                                    The website was built using php and MySQL. Functionalities of the website included:
                                    <ul>
                                    <li>Shopping cart</li>
                                    <li>Stock import from the retail outlet software directly to the website</li>
                                    <li>Online payment</li>
                                    </ul>
                                    </p>",
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
                        },
                        new ExperienceSkill
                        {
                            SkillId = linux.Id,
                            UsageRating = 1
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
                    Description = "<p>Working within a team of 12 people, I was involved in the development of a 'Credit Voyager' product. The key feature of this product is the possibility to manage credit distribution with full control of risk analysis.</p>"
                        + "<p>This web based solution was mainly built using Microsoft technologies (ASP, ASP.NET, c#) and was developped to work either on ORACLE and MSSQL database.</p>"
                        + "<p>Responsibilities included:</p>"
                        + "<ul>"
                        + "<li>Maintenance and Bug fixing</li>"
                        + "<li>Building a database migration tool to migrate a full MSSQL database to an ORACLE database</li>"
                        + "<li>Integration of a third party service (BIL) to obtain financial information for the purposes of carrying out credit checks</li>"
                        + "</ul>"
                        + "<p>Clients included:</p>"
                        + "<ul class='list-inline dn-experience-client'>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_iveco.png' alt='IVECO Finance France' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_total.png' alt='Total' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_sfr.png' alt='SFR' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_neopost.png' alt='neopost FRANCE' /></li>"
                        + "</ul>",
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
                        },
                        new ExperienceSkill
                        {
                            SkillId = mantis.Id,
                            UsageRating = 3
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
                    Description = "<p>Project lead and lead developer using Microsoft technologies (ASP.NET, ASP, C#, SQL SERVER) and other Web technologies to deliver large web community platforms.</p>"
                        + "<p>Responsibilities included:</p>"
                        + "<ul>"
                        + "<li>Migration of existing applications from ASP to ASP.NET</li>"
                        + "<li>Development of various web community modules (blog, forum, photo album, video, shared link) with extensive social networking functionalities (profile, rating, messaging, connections...)</li>"
                        + "<li>Recruitment, training and management of a team of 5 developers based in India</li>"
                        + "<li>Supporting staff with transition to new technologies</li> "
                        + "<li>Integrating moderation solutions for clients with pre-existing platforms</li>"
                        + "</ul>"
                        + "<p>Clients included:</p>"
                        + "<ul class='list-inline dn-experience-client'>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_fhm.png' alt='FHM' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_samsung.png' alt='Samsung Mobile France' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_femmeactuelle.png' alt='Femme Actuelle' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_letudiant.png' alt='Letudiant' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_sport24.png' alt='Sport24' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_canalj.png' alt='Canal J' /></li>"
                        + "</ul>",
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
                        },
                        new ExperienceSkill
                        {
                            SkillId = xml.Id,
                            UsageRating = 2,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = xml.Id, SkillVersionId = xml_1_1.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = web_service.Id,
                            UsageRating = 3
                        },
                        new ExperienceSkill
                        {
                            SkillId = google_api.Id,
                            UsageRating = 4
                        },
                        new ExperienceSkill
                        {
                            SkillId = winform.Id,
                            UsageRating = 1
                        },
                        new ExperienceSkill
                        {
                            SkillId = console_app.Id,
                            UsageRating = 3
                        },
                        new ExperienceSkill
                        {
                            SkillId = sql.Id,
                            UsageRating = 8
                        },
                        new ExperienceSkill
                        {
                            SkillId = ado_net.Id,
                            UsageRating = 8
                        },
                        new ExperienceSkill
                        {
                            SkillId = soap.Id,
                            UsageRating = 1
                        }
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
                    Description = "<p>Working within a small team of 3 developers using Microsoft technologies (ASP.NET, ASP, C#, SQL SERVER) and other Web technologies to deliver stock images e - commerce platforms and tooling for post photo shoot sessions.</p>"
                        + "<p>Responsibilities included:</p>"
                        + "<ul>"
                        + "<li>Maintenance and bug fixing</li>"
                        + "<li>Development of a tool for post photo shoot sessions to assist client in their photo selection process</li>"
                        + "<li>Implementation of an online print room feature to buy prints/canvas with 3D visualisation and price matrix</li>"
                        + "<li>Documenting the stock images e-commerce platform solution</li> "
                        + "<li>Styling and setup of stock images platform for new clients</li>"
                        + "</ul>"
                        + "<p>Clients included:</p>"
                        + "<ul class='list-inline dn-experience-client'>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_constructionphotography.png' alt='Construction Photography' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_murphy.png' alt='Murphy' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_essex.png' alt='Essex County Council' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_railphotolibrary.png' alt='Rail Photo Library' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_cephas.png' alt='Cephas' /></li>"
                        + "</ul>",
                    StartDate = new DateTime(2008, 5, 1),
                    Skills = new List<ExperienceSkill>
                    {
                        new ExperienceSkill
                        {
                            SkillId = asp_net.Id,
                            UsageRating = 9,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_3_5.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = asp_net_ajax.Id,
                            UsageRating = 3
                        },
                        new ExperienceSkill
                        {
                            SkillId = ajax.Id,
                            UsageRating = 3
                        },
                        new ExperienceSkill
                        {
                            SkillId = csharp.Id,
                            UsageRating = 9,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = csharp.Id, SkillVersionId = csharp_3_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = sqlserver.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = sqlserver.Id, SkillVersionId = sqlserver_2005.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = tfs.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = tfs.Id, SkillVersionId = tfs_2005.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = ssms.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = ssms.Id, SkillVersionId = ssms_2005.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = visual_studio.Id,
                            UsageRating = 9,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_2008_pro.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = dotnet.Id,
                            UsageRating = 9,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_3_5.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = windows.Id,
                            UsageRating = 6,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = windows.Id, SkillVersionId = windows_vista.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = javascript.Id,
                            UsageRating = 4,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_3.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = html.Id,
                            UsageRating = 8,
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
                                new ExperienceSkillVersion { SkillId = css.Id, SkillVersionId = css_2_1.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = sql.Id,
                            UsageRating = 8
                        },
                        new ExperienceSkill
                        {
                            SkillId = xsd.Id,
                            UsageRating = 8
                        },
                        new ExperienceSkill
                        {
                            SkillId = iis.Id,
                            UsageRating = 2,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = iis.Id, SkillVersionId = iis_7_0.Id }
                            }
                        }
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
                    Description = "<p>Employed within a recruitment agency, I was working a 6 month contract with a digital agency Itelios to develop and maintain e - commerce web solutions for 10 different brands using mainly Microsoft technologies (ASP.NET, C#, COMMERCE SERVER).</p>"
                        + "<p>Responsibilities included:</p>"
                        + "<ul>"
                        + "<li>Maintenance and bug fixing</li>"
                        + "<li>Implementing URL Rewriting on the solution</li>"
                        + "<li>Developement of a functionality to redeem points and benefits with a loyalty card (program)</li>"
                        + "<li>Documenting any new features developped</li> "
                        + "<li>Brief exposure to scrum practices</li>"
                        + "</ul>"
                        + "<p>Clients included:</p>"
                        + "<ul class='list-inline dn-experience-client'>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_celio.png' alt='celio' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_letanneur.png' alt='le tanneur' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_kookai.png' alt='Kookai' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_lcdp.png' alt='La Compagnie des petits' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_hom.png' alt='HOM' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_newman.png' alt='Newman' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_figaret.png' alt='Alain Figaret' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_aigle.png' alt='AIGLE' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_soco.png' alt='SOCO' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_ripcurl.png' alt='RIP CURL' /></li>"
                        + "</ul>",
                    StartDate = new DateTime(2010, 2, 1),
                    Skills = new List<ExperienceSkill>
                    {
                        new ExperienceSkill
                        {
                            SkillId = asp_net_ajax.Id,
                            UsageRating = 3
                        },
                        new ExperienceSkill
                        {
                            SkillId = ajax.Id,
                            UsageRating = 4
                        },
                        new ExperienceSkill
                        {
                            SkillId = asp_net.Id,
                            UsageRating = 9,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_3_5.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = csharp.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = csharp.Id, SkillVersionId = csharp_3_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = commerce_server.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = commerce_server.Id, SkillVersionId = commerce_server_2009.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = tfs.Id,
                            UsageRating = 6,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = tfs.Id, SkillVersionId = tfs_2008.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = visual_studio.Id,
                            UsageRating = 9,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_2008_pro.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = dotnet.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_3_5.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = windows.Id,
                            UsageRating = 6,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = windows.Id, SkillVersionId = windows_7.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = javascript.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_3.Id },
                                new ExperienceSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_5.Id }
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
                            UsageRating = 3,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = css.Id, SkillVersionId = css_2_1.Id },
                                new ExperienceSkillVersion { SkillId = css.Id, SkillVersionId = css_3_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = scrum.Id,
                            UsageRating = 2
                        },
                        new ExperienceSkill
                        {
                            SkillId = jquery.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = jquery.Id, SkillVersionId = jquery_1_4.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = jquery_ui.Id,
                            UsageRating = 3,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = jquery_ui.Id, SkillVersionId = jquery_ui_1_7.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = agile.Id,
                            UsageRating = 2
                        },
                        new ExperienceSkill
                        {
                            SkillId = mantis.Id,
                            UsageRating = 5
                        },
                        new ExperienceSkill
                        {
                            SkillId = iis.Id,
                            UsageRating = 2,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = iis.Id, SkillVersionId = iis_7_0.Id }
                            }
                        }
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
                    Description = "<p>Development of a windows service task scheduler to integrate and synchronise data between an e-commerce platform and a distribution retail management system using dotnet technologies.</p>"
                        + "<p>Responsibilities included:</p>"
                        + "<ul>"
                        + "<li>Automating update of products data and stock on the e-commerce platform directly from the product management system</li>"
                        + "<li>Automating order fulfillment process</li>"
                        + "<li>Ensure sync between the e-commerce platform and the distribution retail management system</li>"
                        + "<li>Documenting the solution</li> "
                        + "</ul>"
                        + "<p>Clients included:</p>"
                        + "<ul class='list-inline dn-experience-client'>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_east.png' alt='East Clothing' /></li>"
                        + "</ul>",
                    StartDate = new DateTime(2010, 9, 1),
                    Skills = new List<ExperienceSkill>
                    {
                        new ExperienceSkill
                        {
                            SkillId = csharp.Id,
                            UsageRating = 9,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = csharp.Id, SkillVersionId = csharp_4_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = cims.Id,
                            UsageRating = 8
                        },
                        new ExperienceSkill
                        {
                            SkillId = web_service.Id,
                            UsageRating = 3
                        },
                        new ExperienceSkill
                        {
                            SkillId = visual_studio.Id,
                            UsageRating = 9,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_2010_pro.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = dotnet.Id,
                            UsageRating = 9,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_4_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = windows.Id,
                            UsageRating = 4,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = windows.Id, SkillVersionId = windows_7.Id },
                                new ExperienceSkillVersion { SkillId = windows.Id, SkillVersionId = windows_server_2008_R2.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = winform.Id,
                            UsageRating = 5
                        },
                        new ExperienceSkill
                        {
                            SkillId = console_app.Id,
                            UsageRating = 7
                        },
                        new ExperienceSkill
                        {
                            SkillId = linq.Id,
                            UsageRating = 7
                        },
                        new ExperienceSkill
                        {
                            SkillId = winservice.Id,
                            UsageRating = 8
                        }
                    }
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
                    Description = "<p>Working in a small team of 4 in the development and maintenance of several e-commerce solutions using mainly Microsoft technologies(ASP.NET, ASP.NET MVC 2.0, C#, SQL SERVER) and other web technologies.</p>"
                        + "<p>Responsibilities included:</p>"
                        + "<ul>"
                        + "<li>Maintenance and bug fixing</li>"
                        + "<li>Rebuild of the back end interface using the MVC Telerik controls</li>"
                        + "<li>Implementation of a store locator solution</li>"
                        + "<li>Integration of new features on the e-commerce platform such as multi-currency and multi-lingual functionalities</li>"
                        + "</ul>"
                        + "<p>Clients included:</p>"
                        + "<ul class='list-inline dn-experience-client'>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_pearlspopcorn.png' alt='Pearls and Popcorn' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_anatomic.png' alt='Anatomic Shoes' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_loake.png' alt='Loake' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_lulu.png' alt='Lulu Guinness' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_tbw.png' alt='The Barcode Warehouse' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_scalabio.png' alt='Scala Bio Fir' /></li>"
                        + "</ul>",
                    StartDate = new DateTime(2011, 4, 1),
                    Skills = new List<ExperienceSkill>
                    {
                        new ExperienceSkill
                        {
                            SkillId = jquery.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = jquery.Id, SkillVersionId = jquery_1_5.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = google_api.Id,
                            UsageRating = 2
                        },
                        new ExperienceSkill
                        {
                            SkillId = javascript.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_3.Id },
                                new ExperienceSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_5.Id }
                            }
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
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = css.Id, SkillVersionId = css_2_1.Id },
                                new ExperienceSkillVersion { SkillId = css.Id, SkillVersionId = css_3_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = iis.Id,
                            UsageRating = 3,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = iis.Id, SkillVersionId = iis_7_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = windows.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = windows.Id, SkillVersionId = windows_7.Id },
                                new ExperienceSkillVersion { SkillId = windows.Id, SkillVersionId = windows_server_2003.Id },
                                new ExperienceSkillVersion { SkillId = windows.Id, SkillVersionId = windows_server_2008_R2.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = svn.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = svn.Id, SkillVersionId = svn_1_6.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = csharp.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = csharp.Id, SkillVersionId = csharp_2_0.Id },
                                new ExperienceSkillVersion { SkillId = csharp.Id, SkillVersionId = csharp_3_0.Id },
                                new ExperienceSkillVersion { SkillId = csharp.Id, SkillVersionId = csharp_4_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = asp_net.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_2_0.Id },
                                new ExperienceSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_3_0.Id },
                                new ExperienceSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_3_5.Id },
                                new ExperienceSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_4_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = mvc.Id,
                            UsageRating = 3,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = mvc.Id, SkillVersionId = mvc_2.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = dotnet.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_2_0.Id },
                                new ExperienceSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_3_0.Id },
                                new ExperienceSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_3_5.Id },
                                new ExperienceSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_4_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = sqlserver.Id,
                            UsageRating = 6,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = sqlserver.Id, SkillVersionId = sqlserver_2005.Id },
                                new ExperienceSkillVersion { SkillId = sqlserver.Id, SkillVersionId = sqlserver_2008.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = ssms.Id,
                            UsageRating = 6,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = ssms.Id, SkillVersionId = ssms_2008.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = sql.Id,
                            UsageRating = 7
                        },
                        new ExperienceSkill
                        {
                            SkillId = di.Id,
                            UsageRating = 6
                        },
                        new ExperienceSkill
                        {
                            SkillId = structuremap.Id,
                            UsageRating = 6,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = structuremap.Id, SkillVersionId = structuremap_2_6_3.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = ado_net.Id,
                            UsageRating = 7
                        },
                        new ExperienceSkill
                        {
                            SkillId = telerik_mvc.Id,
                            UsageRating = 5
                        },
                        new ExperienceSkill
                        {
                            SkillId = sitefinity.Id,
                            UsageRating = 4,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = sitefinity.Id, SkillVersionId = sitefinity_4_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = razor.Id,
                            UsageRating = 8
                        },
                        new ExperienceSkill
                        {
                            SkillId = visual_studio.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_2010_pro.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = ajax.Id,
                            UsageRating = 5
                        },
                        new ExperienceSkill
                        {
                            SkillId = jquery_ui.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = jquery_ui.Id, SkillVersionId = jquery_ui_1_8.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = linq.Id,
                            UsageRating = 6
                        }
                    }
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
                    Description = "<p>Working at the University of London, for the career services department called The Careers Group providing and maintaining solutions for students in their early careers.</p>"
                        + "<p>Responsibilities included:</p>"
                        + "<ul>"
                        + "<li>Bug fixing and maintenance of existing system</li>"
                        + "<li>Support for mid-level and junior developers</li>"
                        + "<li>Developer lead in the implementation of a call centre application</li>"
                        + "<li>Development of a Careers Management system including a CRM and a placement management module</li> "
                        + "<li>Implementation of a continuous integration and test automation solution for Moodle</li>"
                        + "<li>Doumentation Writing</li>"
                        + "<li>Client support</li>"
                        + "</ul>"
                        + "<p>Clients included:</p>"
                        + "<ul class='list-inline dn-experience-client'>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_lmu.png' alt='London Metropolitan University' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_bbk.png' alt='Birkbeck' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_goldsmiths.png' alt='Goldsmiths' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_kcl.png' alt='Kings College London' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_kingston.png' alt='Kingston University' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_qmul.png' alt='Queen Mary University of London' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_rhul.png' alt='Royal Holloway' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_soas.png' alt='SOAS' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_stmarys.png' alt='St Marys University' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_ucl.png' alt='University College London' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_greenwich.png' alt='University of Greenwich' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_roehampton.png' alt='University of Roehampton' /></li>"
                        + "<li><img class='img-responsive' src='./images/experience/clients/logo_westminster.png' alt='University of Westminster' /></li>"
                        + "</ul>",
                    StartDate = new DateTime(2012, 4, 1),
                    Skills = new List<ExperienceSkill>
                    {
                        new ExperienceSkill
                        {
                            SkillId = winform.Id,
                            UsageRating = 2
                        },
                        new ExperienceSkill
                        {
                            SkillId = console_app.Id,
                            UsageRating = 4
                        },
                        new ExperienceSkill
                        {
                            SkillId = google_api.Id,
                            UsageRating = 4
                        },
                        new ExperienceSkill
                        {
                            SkillId = web_service.Id,
                            UsageRating = 5
                        },
                        new ExperienceSkill
                        {
                            SkillId = sql.Id,
                            UsageRating = 7
                        },
                        new ExperienceSkill
                        {
                            SkillId = sqlserver.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = sqlserver.Id, SkillVersionId = sqlserver_2005.Id },
                                new ExperienceSkillVersion { SkillId = sqlserver.Id, SkillVersionId = sqlserver_2008_R2.Id },
                                new ExperienceSkillVersion { SkillId = sqlserver.Id, SkillVersionId = sqlserver_2012.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = ssms.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = ssms.Id, SkillVersionId = ssms_2008.Id },
                                new ExperienceSkillVersion { SkillId = ssms.Id, SkillVersionId = ssms_2012.Id },
                                new ExperienceSkillVersion { SkillId = ssms.Id, SkillVersionId = ssms_2014.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = mysql.Id,
                            UsageRating = 2,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = mysql.Id, SkillVersionId = mysql_5_0_96.Id },
                                new ExperienceSkillVersion { SkillId = mysql.Id, SkillVersionId = mysql_5_1_73.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = mysql_workbench.Id,
                            UsageRating = 2,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = mysql_workbench.Id, SkillVersionId = mysql_workbench_5_2.Id },
                                new ExperienceSkillVersion { SkillId = mysql_workbench.Id, SkillVersionId = mysql_workbench_6_3.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = shibboleth.Id,
                            UsageRating = 3,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = shibboleth.Id, SkillVersionId = shibboleth_2_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = saml.Id,
                            UsageRating = 2,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = saml.Id, SkillVersionId = saml_2_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = xml.Id,
                            UsageRating = 2,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = xml.Id, SkillVersionId = xml_1_1.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = jenkins.Id,
                            UsageRating = 4,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = jenkins.Id, SkillVersionId = jenkins_1_6.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = visual_studio.Id,
                            UsageRating = 9,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_2008_pro.Id },
                                new ExperienceSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_2010_pro.Id },
                                new ExperienceSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_2012_pro.Id },
                                new ExperienceSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_2013_pro.Id },
                                new ExperienceSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_2015_pro.Id },
                                new ExperienceSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_code.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = javascript.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_3.Id },
                                new ExperienceSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_5.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = jquery.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = jquery.Id, SkillVersionId = jquery_1_8.Id },
                                new ExperienceSkillVersion { SkillId = jquery.Id, SkillVersionId = jquery_1_9.Id },
                                new ExperienceSkillVersion { SkillId = jquery.Id, SkillVersionId = jquery_1_10.Id },
                                new ExperienceSkillVersion { SkillId = jquery.Id, SkillVersionId = jquery_1_11.Id },
                                new ExperienceSkillVersion { SkillId = jquery.Id, SkillVersionId = jquery_2_0.Id },
                                new ExperienceSkillVersion { SkillId = jquery.Id, SkillVersionId = jquery_2_1.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = knockout.Id,
                            UsageRating = 1,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = knockout.Id, SkillVersionId = knockout_2_2_1.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = angularjs.Id,
                            UsageRating = 2,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = angularjs.Id, SkillVersionId = angularjs_1_4.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = lync_sdk.Id,
                            UsageRating = 4,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = lync_sdk.Id, SkillVersionId = lync_sdk_2013.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = dotnet.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_2_0.Id },
                                new ExperienceSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_3_0.Id },
                                new ExperienceSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_3_5.Id },
                                new ExperienceSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_4_0.Id },
                                new ExperienceSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_4_5.Id },
                                new ExperienceSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_4_5_1.Id },
                                new ExperienceSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_4_5_2.Id },
                                new ExperienceSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_4_6.Id },
                                new ExperienceSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_4_6_1.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = asp_net.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_2_0.Id },
                                new ExperienceSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_3_0.Id },
                                new ExperienceSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_3_5.Id },
                                new ExperienceSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_4_0.Id },
                                new ExperienceSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_4_5.Id },
                                new ExperienceSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_4_5_1.Id },
                                new ExperienceSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_4_5_2.Id },
                                new ExperienceSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_4_6.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = mvc.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = mvc.Id, SkillVersionId = mvc_3.Id },
                                new ExperienceSkillVersion { SkillId = mvc.Id, SkillVersionId = mvc_4.Id },
                                new ExperienceSkillVersion { SkillId = mvc.Id, SkillVersionId = mvc_5.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = csharp.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = csharp.Id, SkillVersionId = csharp_2_0.Id },
                                new ExperienceSkillVersion { SkillId = csharp.Id, SkillVersionId = csharp_3_0.Id },
                                new ExperienceSkillVersion { SkillId = csharp.Id, SkillVersionId = csharp_4_0.Id },
                                new ExperienceSkillVersion { SkillId = csharp.Id, SkillVersionId = csharp_5_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = ssl.Id,
                            UsageRating = 3
                        },
                        new ExperienceSkill
                        {
                            SkillId = windows.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = windows.Id, SkillVersionId = windows_7.Id },
                                new ExperienceSkillVersion { SkillId = windows.Id, SkillVersionId = windows_server_2003.Id },
                                new ExperienceSkillVersion { SkillId = windows.Id, SkillVersionId = windows_server_2008_R2.Id },
                                new ExperienceSkillVersion { SkillId = windows.Id, SkillVersionId = windows_server_2012_R2.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = rhel.Id,
                            UsageRating = 2,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = rhel.Id, SkillVersionId = rhel_7.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = fedora_core.Id,
                            UsageRating = 3,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = fedora_core.Id, SkillVersionId = fedora_core_23.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = pivotal_tracker.Id,
                            UsageRating = 5
                        },
                        new ExperienceSkill
                        {
                            SkillId = scrum.Id,
                            UsageRating = 4
                        },
                        new ExperienceSkill
                        {
                            SkillId = axosoft.Id,
                            UsageRating = 3
                        },
                        new ExperienceSkill
                        {
                            SkillId = structuremap.Id,
                            UsageRating = 4,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = structuremap.Id, SkillVersionId = structuremap_2_6_4_1.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = entity_framework.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = entity_framework.Id, SkillVersionId = entity_framework_4_1.Id },
                                new ExperienceSkillVersion { SkillId = entity_framework.Id, SkillVersionId = entity_framework_5_0.Id },
                                new ExperienceSkillVersion { SkillId = entity_framework.Id, SkillVersionId = entity_framework_6_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = unity.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = unity.Id, SkillVersionId = unity_3_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = moq.Id,
                            UsageRating = 1
                        },
                        new ExperienceSkill
                        {
                            SkillId = rhino_mock.Id,
                            UsageRating = 1
                        },
                        new ExperienceSkill
                        {
                            SkillId = automapper.Id,
                            UsageRating = 4,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = automapper.Id, SkillVersionId = automapper_2_2_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = di.Id,
                            UsageRating = 7
                        },
                        new ExperienceSkill
                        {
                            SkillId = unit_testing.Id,
                            UsageRating = 1
                        },
                        new ExperienceSkill
                        {
                            SkillId = linq.Id,
                            UsageRating = 8
                        },
                        new ExperienceSkill
                        {
                            SkillId = ado_net.Id,
                            UsageRating = 6
                        },
                        new ExperienceSkill
                        {
                            SkillId = umbraco.Id,
                            UsageRating = 3,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = umbraco.Id, SkillVersionId = umbraco_4.Id },
                                new ExperienceSkillVersion { SkillId = umbraco.Id, SkillVersionId = umbraco_6.Id },
                                new ExperienceSkillVersion { SkillId = umbraco.Id, SkillVersionId = umbraco_7.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = mediawiki.Id,
                            UsageRating = 1,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = mediawiki.Id, SkillVersionId = mediawiki_1_22.Id },
                                new ExperienceSkillVersion { SkillId = mediawiki.Id, SkillVersionId = mediawiki_1_26.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = silverlight_sdk.Id,
                            UsageRating = 2,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = silverlight_sdk.Id, SkillVersionId = silverlight_sdk_5.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = silverlight_toolkit.Id,
                            UsageRating = 2,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = silverlight_toolkit.Id, SkillVersionId = silverlight_toolkit_5.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = html.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = html.Id, SkillVersionId = html_4_0.Id },
                                new ExperienceSkillVersion { SkillId = html.Id, SkillVersionId = html_5_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = css.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = css.Id, SkillVersionId = css_2_1.Id },
                                new ExperienceSkillVersion { SkillId = css.Id, SkillVersionId = css_3_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = bootstrap.Id,
                            UsageRating = 6,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = bootstrap.Id, SkillVersionId = bootstrap_3.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = wcf.Id,
                            UsageRating = 2
                        },
                        new ExperienceSkill
                        {
                            SkillId = wpf.Id,
                            UsageRating = 1
                        },
                        new ExperienceSkill
                        {
                            SkillId = nunit.Id,
                            UsageRating = 1,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = nunit.Id, SkillVersionId = nunit_2_6_2.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = ajax.Id,
                            UsageRating = 8
                        },
                        new ExperienceSkill
                        {
                            SkillId = asp_net_ajax.Id,
                            UsageRating = 3
                        },
                        new ExperienceSkill
                        {
                            SkillId = razor.Id,
                            UsageRating = 6
                        },
                        new ExperienceSkill
                        {
                            SkillId = svn.Id,
                            UsageRating = 6,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = svn.Id, SkillVersionId = svn_1_3.Id },
                                new ExperienceSkillVersion { SkillId = svn.Id, SkillVersionId = svn_1_8.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = mstest.Id,
                            UsageRating = 2
                        },
                        new ExperienceSkill
                        {
                            SkillId = linux.Id,
                            UsageRating = 2
                        },
                        new ExperienceSkill
                        {
                            SkillId = agile.Id,
                            UsageRating = 4
                        },
                        new ExperienceSkill
                        {
                            SkillId = soap.Id,
                            UsageRating = 2
                        },
                        new ExperienceSkill
                        {
                            SkillId = aspnet_webapi.Id,
                            UsageRating = 1,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = aspnet_webapi.Id, SkillVersionId = aspnet_webapi_1.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = bash_shell.Id,
                            UsageRating = 2
                        },
                        new ExperienceSkill
                        {
                            SkillId = python.Id,
                            UsageRating = 2,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = python.Id, SkillVersionId = python_2_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = jquery_ui.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = jquery_ui.Id, SkillVersionId = jquery_ui_1_6.Id },
                                new ExperienceSkillVersion { SkillId = jquery_ui.Id, SkillVersionId = jquery_ui_1_7.Id },
                                new ExperienceSkillVersion { SkillId = jquery_ui.Id, SkillVersionId = jquery_ui_1_8.Id },
                                new ExperienceSkillVersion { SkillId = jquery_ui.Id, SkillVersionId = jquery_ui_1_9.Id },
                                new ExperienceSkillVersion { SkillId = jquery_ui.Id, SkillVersionId = jquery_ui_1_10.Id },
                                new ExperienceSkillVersion { SkillId = jquery_ui.Id, SkillVersionId = jquery_ui_1_11.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = winservice.Id,
                            UsageRating = 2
                        },
                        new ExperienceSkill
                        {
                            SkillId = apache.Id,
                            UsageRating = 1
                        },
                        new ExperienceSkill
                        {
                            SkillId = github.Id,
                            UsageRating = 3
                        },
                        new ExperienceSkill
                        {
                            SkillId = git.Id,
                            UsageRating = 3,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = git.Id, SkillVersionId = git_2_5_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = bitbucket.Id,
                            UsageRating = 2
                        },
                        new ExperienceSkill
                        {
                            SkillId = mariadb.Id,
                            UsageRating = 1
                        },
                        new ExperienceSkill
                        {
                            SkillId = iis.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = iis.Id, SkillVersionId = iis_7_0.Id },
                                new ExperienceSkillVersion { SkillId = iis.Id, SkillVersionId = iis_8_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = nuget.Id,
                            UsageRating = 6
                        },
                        new ExperienceSkill
                        {
                            SkillId = rest.Id,
                            UsageRating = 1
                        },
                        new ExperienceSkill
                        {
                            SkillId = json.Id,
                            UsageRating = 8
                        },
                        new ExperienceSkill
                        {
                            SkillId = ci.Id,
                            UsageRating = 2
                        },
                        new ExperienceSkill
                        {
                            SkillId = photoshop.Id,
                            UsageRating = 3,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = photoshop.Id, SkillVersionId = photoshop_cs_6.Id }
                            }
                        }
                    }
                };
                #endregion
                #region Travco
                travco = new Experience
                {
                    City = "London",
                    CompanyName = "Travco",
                    Country = "United Kingdom",
                    EndDate = null,
                    ImageUrl = "travco-experience-icon.png",
                    RoleTitle = "Senior Developer",
                    WebsiteUrl = "http://travco.co.uk",
                    Description = "<p>Working in a team of 5 developers o rewrite an online hotel booking system offering a selection of thousands of international hotels. The system provides a complete solution from data entry, rates, pricing, search and booking based o a microservice archtecture using the latest technologies.</p>"
                        + "<p>Responsibilities include:</p>"
                        + "<ul>"
                        + "<li>Full stack development of the solution</li>"
                        + "<li>Writing unit tests</li>"
                        + "<li>Building and maintaining a full distributed software infrastructure solution with automated continuous integration and continuous delivery</li>"
                        + "<li>Technical support and supervision of junior developers</li> "
                        + "<li>Maintaining and documenting system specifications</li>"
                        + "<li>Working in an agile environment using scrum</li>"
                        + "<li>Contributing towards architectural and technical solutions in team discussions</li>"
                        + "</ul>",
                    StartDate = new DateTime(2016, 7, 1),
                    Skills = new List<ExperienceSkill>
                    {
                        new ExperienceSkill
                        {
                            SkillId = linux.Id,
                            UsageRating = 5
                        },
                        new ExperienceSkill
                        {
                            SkillId = console_app.Id,
                            UsageRating = 1
                        },
                        new ExperienceSkill
                        {
                            SkillId = sql.Id,
                            UsageRating = 1
                        },
                        new ExperienceSkill
                        {
                            SkillId = oauth.Id,
                            UsageRating = 1,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = oauth.Id, SkillVersionId = oauth_2_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = sqlserver.Id,
                            UsageRating = 1,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = sqlserver.Id, SkillVersionId = sqlserver_2016.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = ssms.Id,
                            UsageRating = 1,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = ssms.Id, SkillVersionId = ssms_2016.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = docker.Id,
                            UsageRating = 6,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = docker.Id, SkillVersionId = docker_1_12_1.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = couchbase.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = couchbase.Id, SkillVersionId = couchbase_enterprise_4_0_0.Id },
                                new ExperienceSkillVersion { SkillId = couchbase.Id, SkillVersionId = couchbase_enterprise_4_5_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = elasticsearch.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = elasticsearch.Id, SkillVersionId = elasticsearch_1_7_0.Id },
                                new ExperienceSkillVersion { SkillId = elasticsearch.Id, SkillVersionId = elasticsearch_2_4_3.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = angularjs.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = angularjs.Id, SkillVersionId = angularjs_1_3.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = aurelia.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = aurelia.Id, SkillVersionId = aurelia_1_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = couchbasenetclient.Id,
                            UsageRating = 3,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = couchbasenetclient.Id, SkillVersionId = couchbasenetclient_2_4_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = visual_studio.Id,
                            UsageRating = 10,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_2015_pro.Id },
                                new ExperienceSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_code.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = javascript.Id,
                            UsageRating = 9,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_3.Id },
                                new ExperienceSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_5.Id },
                                new ExperienceSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_6.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = jquery.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = jquery.Id, SkillVersionId = jquery_2_1.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = nest.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = nest.Id, SkillVersionId = nest_1_8_3.Id },
                                new ExperienceSkillVersion { SkillId = nest.Id, SkillVersionId = nest_2_5_1.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = angular.Id,
                            UsageRating = 1,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = angular.Id, SkillVersionId = angular_2_4_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = gocd.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = gocd.Id, SkillVersionId = gocd_16_7_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = dotnet.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_4_5_2.Id },
                                new ExperienceSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_core_1_1.Id },
                                new ExperienceSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_core_1_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = asp_net.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_core_1_1.Id },
                                new ExperienceSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_core_1_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = mvc.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = mvc.Id, SkillVersionId = mvc_core_1_1.Id },
                                new ExperienceSkillVersion { SkillId = mvc.Id, SkillVersionId = mvc_core_1_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = csharp.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = csharp.Id, SkillVersionId = csharp_4_0.Id },
                                new ExperienceSkillVersion { SkillId = csharp.Id, SkillVersionId = csharp_5_0.Id },
                                new ExperienceSkillVersion { SkillId = csharp.Id, SkillVersionId = csharp_6_0.Id },
                                new ExperienceSkillVersion { SkillId = csharp.Id, SkillVersionId = csharp_7_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = windows.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = windows.Id, SkillVersionId = windows_10.Id },
                                new ExperienceSkillVersion { SkillId = windows.Id, SkillVersionId = windows_server_2016.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = ubuntu.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = ubuntu.Id, SkillVersionId = ubuntu_14_04.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = proget.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = proget.Id, SkillVersionId = proget_3_4_6.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = scrum.Id,
                            UsageRating = 7
                        },
                        new ExperienceSkill
                        {
                            SkillId = autofac.Id,
                            UsageRating = 6,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = autofac.Id, SkillVersionId = autofac_4_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = entity_framework.Id,
                            UsageRating = 1,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = entity_framework.Id, SkillVersionId = entity_framework_core_1_0.Id },
                                new ExperienceSkillVersion { SkillId = entity_framework.Id, SkillVersionId = entity_framework_core_1_1.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = identityserver.Id,
                            UsageRating = 3,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = identityserver.Id, SkillVersionId = identityserver_4.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = moq.Id,
                            UsageRating = 5
                        },
                        new ExperienceSkill
                        {
                            SkillId = automapper.Id,
                            UsageRating = 6,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = automapper.Id, SkillVersionId = automapper_5_2_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = di.Id,
                            UsageRating = 7
                        },
                        new ExperienceSkill
                        {
                            SkillId = microservices.Id,
                            UsageRating = 9
                        },
                        new ExperienceSkill
                        {
                            SkillId = unit_testing.Id,
                            UsageRating = 7
                        },
                        new ExperienceSkill
                        {
                            SkillId = linq.Id,
                            UsageRating = 8
                        },
                        new ExperienceSkill
                        {
                            SkillId = ado_net.Id,
                            UsageRating = 1
                        },
                        new ExperienceSkill
                        {
                            SkillId = mesos.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = mesos.Id, SkillVersionId = mesos_1_0_1.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = webpack.Id,
                            UsageRating = 1,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = webpack.Id, SkillVersionId = webpack_2_0.Id },
                                new ExperienceSkillVersion { SkillId = webpack.Id, SkillVersionId = webpack_2_4_1.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = react.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = react.Id, SkillVersionId = react_15_4_2.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = typescript.Id,
                            UsageRating = 1,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = typescript.Id, SkillVersionId = typescript_1_8.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = marathon.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = marathon.Id, SkillVersionId = marathon_1_1_2.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = zookeeper.Id,
                            UsageRating = 3,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = zookeeper.Id, SkillVersionId = zookeeper_3_4_6.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = bamboo.Id,
                            UsageRating = 2,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = bamboo.Id, SkillVersionId = bamboo_0_2_2_1.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = html.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = html.Id, SkillVersionId = html_4_0.Id },
                                new ExperienceSkillVersion { SkillId = html.Id, SkillVersionId = html_5_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = css.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = css.Id, SkillVersionId = css_3_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = bootstrap.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = bootstrap.Id, SkillVersionId = bootstrap_3.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = xunit.Id,
                            UsageRating = 5
                        },
                        new ExperienceSkill
                        {
                            SkillId = ajax.Id,
                            UsageRating = 8
                        },
                        new ExperienceSkill
                        {
                            SkillId = razor.Id,
                            UsageRating = 1
                        },
                        new ExperienceSkill
                        {
                            SkillId = tfs.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = tfs.Id, SkillVersionId = tfs_2015.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = aspnet_webapi.Id,
                            UsageRating = 8,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = aspnet_webapi.Id, SkillVersionId = aspnet_webapi_core_1_0.Id },
                                new ExperienceSkillVersion { SkillId = aspnet_webapi.Id, SkillVersionId = aspnet_webapi_core_1_1.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = bash_shell.Id,
                            UsageRating = 4
                        },
                        new ExperienceSkill
                        {
                            SkillId = jquery_ui.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = jquery_ui.Id, SkillVersionId = jquery_ui_1_11.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = git.Id,
                            UsageRating = 5,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = git.Id, SkillVersionId = git_2_5_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = nuget.Id,
                            UsageRating = 7
                        },
                        new ExperienceSkill
                        {
                            SkillId = rest.Id,
                            UsageRating = 8
                        },
                        new ExperienceSkill
                        {
                            SkillId = json.Id,
                            UsageRating = 8
                        },
                        new ExperienceSkill
                        {
                            SkillId = ci.Id,
                            UsageRating = 8
                        },
                        new ExperienceSkill
                        {
                            SkillId = haproxy.Id,
                            UsageRating = 2,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = haproxy.Id, SkillVersionId = haproxy_1_5_8.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = babel.Id,
                            UsageRating = 2,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = babel.Id, SkillVersionId = babel_6_24_1.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = mocha.Id,
                            UsageRating = 6,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = mocha.Id, SkillVersionId = mocha_3_3_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = chai.Id,
                            UsageRating = 6,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = chai.Id, SkillVersionId = chai_3_5_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = enzyme.Id,
                            UsageRating = 6,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = enzyme.Id, SkillVersionId = enzyme_2_8_2.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = sinon.Id,
                            UsageRating = 6
                        },
                        new ExperienceSkill
                        {
                            SkillId = redux.Id,
                            UsageRating = 7,
                            Versions = new List<ExperienceSkillVersion>
                            {
                                new ExperienceSkillVersion { SkillId = redux.Id, SkillVersionId = redux_3_6_0.Id }
                            }
                        },
                        new ExperienceSkill
                        {
                            SkillId = grunt.Id,
                            UsageRating = 3
                        },
                        new ExperienceSkill
                        {
                            SkillId = ddd.Id,
                            UsageRating = 5
                        },
                        new ExperienceSkill
                        {
                            SkillId = event_sourcing.Id,
                            UsageRating = 4
                        },
                        new ExperienceSkill
                        {
                            SkillId = cqrs.Id,
                            UsageRating = 5
                        }
                    }
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
                context.Experiences.Add(travco);
            }

            return context.SaveChanges();
            
        }

        private static int CreateProjects(CvDbContext context)
        {
            if (!context.Projects.Any())
            {
                #region Othodo
                othodo = new Project
                {
                    Description = "<p>Helping in the development of a car rental booking website as a first training using PHP and MySQL.</p>"
                        + "<ul>"
                        + "<li>Fixing booking system</li>"
                        + "<li>CSS Styling</li>"
                        + "</ul>",
                    Name = "Othodo",
                    PrimaryImage = "no-main.png",
                    StartDate = new DateTime(2003, 06, 1),
                    Skills = new List<ProjectSkill>
                    {
                        new ProjectSkill
                        {
                            SkillId = php.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = php.Id, SkillVersionId = php_4_3.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = mysql.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = mysql.Id, SkillVersionId = mysql_4_0_6.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = easyphp.Id,
                            UsageRating = 3
                        },
                        new ProjectSkill
                        {
                            SkillId = phpmyadmin.Id,
                            UsageRating = 4
                        },
                        new ProjectSkill
                        {
                            SkillId = apache.Id,
                            UsageRating = 2
                        },
                        new ProjectSkill
                        {
                            SkillId = css.Id,
                            UsageRating = 4,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = css.Id, SkillVersionId = css_2_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = html.Id,
                            UsageRating = 7,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = html.Id, SkillVersionId = html_4_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = windows.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = windows.Id, SkillVersionId = windows_xp.Id }
                            }
                        }
                    }
                };
                #endregion
                #region Louise13
                louise13 = new Project
                {
                    Description = "<p>Helping a web designer friend in a school project to deliver a website promoting art galleries for a street art association the Louise-Weiss street (a notable place of contemporary art).</p>"
                        + "<ul>"
                        + "<li>Implementing dynamic content into a Flash ActionScript application</li>"
                        + "<li>Development of a back-end interface for management of dynamic content</li>"
                        + "</ul>",
                    Name = "Louise13",
                    PrimaryImage = "no-main.png",
                    StartDate = new DateTime(2004, 04, 1),
                    Skills = new List<ProjectSkill>
                    {
                        new ProjectSkill
                        {
                            SkillId = php.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = php.Id, SkillVersionId = php_4_3.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = mysql.Id,
                            UsageRating = 6,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = mysql.Id, SkillVersionId = mysql_4_1_4.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = easyphp.Id,
                            UsageRating = 3
                        },
                        new ProjectSkill
                        {
                            SkillId = phpmyadmin.Id,
                            UsageRating = 5
                        },
                        new ProjectSkill
                        {
                            SkillId = apache.Id,
                            UsageRating = 2
                        },
                        new ProjectSkill
                        {
                            SkillId = css.Id,
                            UsageRating = 1,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = css.Id, SkillVersionId = css_2_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = html.Id,
                            UsageRating = 1,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = html.Id, SkillVersionId = html_4_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = windows.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = windows.Id, SkillVersionId = windows_xp.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = flash.Id,
                            UsageRating = 7,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = flash.Id, SkillVersionId = flash_2004.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = actionscript.Id,
                            UsageRating = 7,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = actionscript.Id, SkillVersionId = actionscript_2_0.Id }
                            }
                        }
                    }
                };
                #endregion
                #region CNLAPS
                cnlaps = new Project
                {
                    Description = "<p>Assisting a web designer friend to deliver a web application for a french association CNLAPS.</p>"
                        + "<ul>"
                        + "<li>Document upload</li>"
                        + "<li>Document sharing</li>"
                        + "<li>User roles and permissions</li>"
                        + "</ul>",
                    Name = "CNLAPS",
                    PrimaryImage = "cnlaps-main.png",
                    StartDate = new DateTime(2005, 04, 1),
                    Skills = new List<ProjectSkill>
                    {
                        new ProjectSkill
                        {
                            SkillId = php.Id,
                            UsageRating = 9,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = php.Id, SkillVersionId = php_4_3.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = mysql.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = mysql.Id, SkillVersionId = mysql_4_1_4.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = easyphp.Id,
                            UsageRating = 3
                        },
                        new ProjectSkill
                        {
                            SkillId = phpmyadmin.Id,
                            UsageRating = 7
                        },
                        new ProjectSkill
                        {
                            SkillId = apache.Id,
                            UsageRating = 2
                        },
                        new ProjectSkill
                        {
                            SkillId = css.Id,
                            UsageRating = 1,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = css.Id, SkillVersionId = css_2_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = html.Id,
                            UsageRating = 1,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = html.Id, SkillVersionId = html_4_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = windows.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = windows.Id, SkillVersionId = windows_xp.Id }
                            }
                        }
                    }
                };
                #endregion
                #region Makabou
                makabou = new Project
                {
                    Description = "<p>Helping a friend building an online classifieds ads website for the african community we developped Makabou website.</p>"
                        + "<ul>"
                        + "<li>File upload</li>"
                        + "<li>User registration</li>"
                        + "<li>Private message</li>"
                        + "<li>Moderation system</li>"
                        + "<li>Search Filter</li>"
                        + "<li>Ads classified by categories, sub-categories and locations</li>"
                        + "</ul>",
                    Name = "Makabou",
                    PrimaryImage = "makabou-main.gif",
                    StartDate = new DateTime(2008, 8, 1),
                    Skills = new List<ProjectSkill>
                    {
                        new ProjectSkill
                        {
                            SkillId = php.Id,
                            UsageRating = 9,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = php.Id, SkillVersionId = php_4_4.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = mysql.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = mysql.Id, SkillVersionId = mysql_5_1_22.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = easyphp.Id,
                            UsageRating = 3
                        },
                        new ProjectSkill
                        {
                            SkillId = phpmyadmin.Id,
                            UsageRating = 8
                        },
                        new ProjectSkill
                        {
                            SkillId = apache.Id,
                            UsageRating = 2
                        },
                        new ProjectSkill
                        {
                            SkillId = css.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = css.Id, SkillVersionId = css_2_1.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = html.Id,
                            UsageRating = 9,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = html.Id, SkillVersionId = html_4_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = windows.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = windows.Id, SkillVersionId = windows_vista.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = javascript.Id,
                            UsageRating = 2,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_3.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = photoshop.Id,
                            UsageRating = 4,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = photoshop.Id, SkillVersionId = photoshop_cs_3.Id }
                            }
                        }
                    }
                };
                #endregion
                #region Pharmatoo
                pharmatoo = new Project
                {
                    Description = "<p>Helping a friend building Pharmatoo, a website community for pharmacist.</p>"
                        + "<ul>"
                        + "<li>User and business registration</li>"
                        + "<li>Pharmacy and medicine drug listings</li>"
                        + "<li>Moderation System</li>"
                        + "</ul>",
                    Name = "Pharmatoo",
                    PrimaryImage = "pharmatoo-main.jpg",
                    StartDate = new DateTime(2009, 4, 1),
                    Skills = new List<ProjectSkill>
                    {
                        new ProjectSkill
                        {
                            SkillId = php.Id,
                            UsageRating = 9,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = php.Id, SkillVersionId = php_4_4.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = mysql.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = mysql.Id, SkillVersionId = mysql_5_1_22.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = easyphp.Id,
                            UsageRating = 3
                        },
                        new ProjectSkill
                        {
                            SkillId = phpmyadmin.Id,
                            UsageRating = 8
                        },
                        new ProjectSkill
                        {
                            SkillId = apache.Id,
                            UsageRating = 2
                        },
                        new ProjectSkill
                        {
                            SkillId = css.Id,
                            UsageRating = 6,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = css.Id, SkillVersionId = css_2_1.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = html.Id,
                            UsageRating = 9,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = html.Id, SkillVersionId = html_4_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = windows.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = windows.Id, SkillVersionId = windows_vista.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = javascript.Id,
                            UsageRating = 2,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_3.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = photoshop.Id,
                            UsageRating = 4,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = photoshop.Id, SkillVersionId = photoshop_cs_3.Id }
                            }
                        }
                    }
                };
                #endregion
                #region toomanyplaces
                toomanyplaces = new Project
                {
                    Description = "<p>Development of a website with listings of bars and pubs for watching live sports on TV.</p>"
                        + "<ul>"
                        + "<li>Business registration</li>"
                        + "<li>Listing of registered places (bars and pubs)</li>"
                        + "<li>Listing of live sport events on TV</li>"
                        + "<li>Search by event, location and map</li>"
                        + "<li>Online payment using paypal</li>"
                        + "</ul>",
                    Name = "toomanyplaces",
                    PrimaryImage = "tmp-main.png",
                    StartDate = new DateTime(2009, 8, 1),
                    Skills = new List<ProjectSkill>
                    {
                        new ProjectSkill
                        {
                            SkillId = php.Id,
                            UsageRating = 9,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = php.Id, SkillVersionId = php_4_4.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = mysql.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = mysql.Id, SkillVersionId = mysql_5_1_22.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = easyphp.Id,
                            UsageRating = 3
                        },
                        new ProjectSkill
                        {
                            SkillId = phpmyadmin.Id,
                            UsageRating = 8
                        },
                        new ProjectSkill
                        {
                            SkillId = apache.Id,
                            UsageRating = 2
                        },
                        new ProjectSkill
                        {
                            SkillId = css.Id,
                            UsageRating = 7,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = css.Id, SkillVersionId = css_2_1.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = html.Id,
                            UsageRating = 9,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = html.Id, SkillVersionId = html_4_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = windows.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = windows.Id, SkillVersionId = windows_xp.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = javascript.Id,
                            UsageRating = 3,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_3.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = photoshop.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = photoshop.Id, SkillVersionId = photoshop_cs_3.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = google_api.Id,
                            UsageRating = 3
                        },
                        new ProjectSkill
                        {
                            SkillId = jquery.Id,
                            UsageRating = 2,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = jquery.Id, SkillVersionId = jquery_1_3.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = jquery_ui.Id,
                            UsageRating = 2,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = jquery_ui.Id, SkillVersionId = jquery_ui_1_7.Id }
                            }
                        }
                    }
                };
                #endregion
                #region pubrush
                pubrush = new Project
                {
                    Description = "<p>Development of a website with listings of events (pub quiz, music...) and meal deal in bars, pubs and restaurants.</p>"
                        + "<ul>"
                        + "<li>Business registration</li>"
                        + "<li>Listing of registered places (bars, pubs and restaurants)</li>"
                        + "<li>Listing of events and meal deal offers</li>"
                        + "<li>Search by event, location and map</li>"
                        + "</ul>",
                    Name = "Pubrush",
                    PrimaryImage = "pubrush-main.jpg",
                    StartDate = new DateTime(2012, 4, 1),
                    Skills = new List<ProjectSkill>
                    {
                        new ProjectSkill
                        {
                            SkillId = asp_net.Id,
                            UsageRating = 9,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_4_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = csharp.Id,
                            UsageRating = 9,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = csharp.Id, SkillVersionId = csharp_4_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = google_api.Id,
                            UsageRating = 4
                        },
                        new ProjectSkill
                        {
                            SkillId = sqlserver.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = sqlserver.Id, SkillVersionId = sqlserver_2008_express.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = ssms.Id,
                            UsageRating = 7,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = ssms.Id, SkillVersionId = ssms_2008.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = sql.Id,
                            UsageRating = 8
                        },
                        new ProjectSkill
                        {
                            SkillId = ajax.Id,
                            UsageRating = 3
                        },
                        new ProjectSkill
                        {
                            SkillId = asp_net_ajax.Id,
                            UsageRating = 3
                        },
                        new ProjectSkill
                        {
                            SkillId = jquery_ui.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = jquery_ui.Id, SkillVersionId = jquery_ui_1_8.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = jquery.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = jquery.Id, SkillVersionId = jquery_1_7.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = javascript.Id,
                            UsageRating = 4,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_3.Id },
                                new ProjectSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_5.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = css.Id,
                            UsageRating = 7,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = css.Id, SkillVersionId = css_2_1.Id },
                                new ProjectSkillVersion { SkillId = css.Id, SkillVersionId = css_3_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = html.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = html.Id, SkillVersionId = html_4_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = photoshop.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = photoshop.Id, SkillVersionId = photoshop_elements_9_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = visual_studio.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_2010_express.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = dotnet.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_4_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = iis.Id,
                            UsageRating = 3,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = iis.Id, SkillVersionId = iis_7_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = ado_net.Id,
                            UsageRating = 9
                        },
                        new ProjectSkill
                        {
                            SkillId = windows.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = iis.Id, SkillVersionId = windows_xp.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = razor.Id,
                            UsageRating = 7
                        }
                    }
                };
                #endregion
                #region moi
                moi = new Project
                {
                    Description = "<p>Version 1.0 of family photos and videos album website.</p>"
                        + "<ul>"
                        + "<li>User permissions and roles</li>"
                        + "<li>Photo and video upload</li>"
                        + "<li>Media processing and conversion</li>"
                        + "<li>Back-end admin</li>"
                        + "<li>LDAP authentication</li>"
                        + "<li>Email notifications</li>"
                        + "</ul>",
                    Name = "MOI",
                    PrimaryImage = "moi-main.png",
                    StartDate = new DateTime(2014, 3, 1),
                    Skills = new List<ProjectSkill>
                    {
                        new ProjectSkill
                        {
                            SkillId = iis.Id,
                            UsageRating = 3,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = iis.Id, SkillVersionId = iis_7_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = csharp.Id,
                            UsageRating = 9,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = csharp.Id, SkillVersionId = csharp_4_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = console_app.Id,
                            UsageRating = 4
                        },
                        new ProjectSkill
                        {
                            SkillId = sqlserver.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = sqlserver.Id, SkillVersionId = sqlserver_2012_express.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = ssms.Id,
                            UsageRating = 7,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = ssms.Id, SkillVersionId = ssms_2012.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = di.Id,
                            UsageRating = 6
                        },
                        new ProjectSkill
                        {
                            SkillId = ajax.Id,
                            UsageRating = 5
                        },
                        new ProjectSkill
                        {
                            SkillId = razor.Id,
                            UsageRating = 5
                        },
                        new ProjectSkill
                        {
                            SkillId = jquery_ui.Id,
                            UsageRating = 6,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = jquery_ui.Id, SkillVersionId = jquery_ui_1_11.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = jquery.Id,
                            UsageRating = 7,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = jquery.Id, SkillVersionId = jquery_1_10.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = javascript.Id,
                            UsageRating = 3,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_3.Id },
                                new ProjectSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_5.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = css.Id,
                            UsageRating = 7,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = css.Id, SkillVersionId = css_2_1.Id },
                                new ProjectSkillVersion { SkillId = css.Id, SkillVersionId = css_3_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = html.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = html.Id, SkillVersionId = html_4_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = visual_studio.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_2013_web_developer_express.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = dotnet.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_4_5.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = windows.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = iis.Id, SkillVersionId = windows_7.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = mvc.Id,
                            UsageRating = 7,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = mvc.Id, SkillVersionId = mvc_5.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = asp_net.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = entity_framework.Id, SkillVersionId = entity_framework_6_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = structuremap.Id,
                            UsageRating = 6,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = structuremap.Id, SkillVersionId = structuremap_3_0_2_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = svn.Id,
                            UsageRating = 6,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = svn.Id, SkillVersionId = svn_1_8.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = nuget.Id,
                            UsageRating = 4
                        }
                    }
                };
                #endregion
                #region deptford park football
                dpf = new Project
                {
                    Description = "<p>Football web community to organise and manage games in deptford park.</p>"
                        + "<ul>"
                        + "<li>User registration</li>"
                        + "<li>Email notifications</li>"
                        + "<li>User roles</li>"
                        + "<li>Responsive design</li>"
                        + "<li>Facebook and Google authentication</li>"
                        + "</ul>",
                    Name = "Deptford Park Football",
                    PrimaryImage = "dpf-main.png",
                    StartDate = new DateTime(2015, 5, 1),
                    Skills = new List<ProjectSkill>
                    {
                        new ProjectSkill
                        {
                            SkillId = identityserver.Id,
                            UsageRating = 2,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = identityserver.Id, SkillVersionId = identityserver_3.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = iis.Id,
                            UsageRating = 3,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = iis.Id, SkillVersionId = iis_7_0_express.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = csharp.Id,
                            UsageRating = 9,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = csharp.Id, SkillVersionId = csharp_5_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = console_app.Id,
                            UsageRating = 4
                        },
                        new ProjectSkill
                        {
                            SkillId = sqlserver.Id,
                            UsageRating = 6,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = sqlserver.Id, SkillVersionId = sqlserver_2012_express.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = ssms.Id,
                            UsageRating = 6,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = ssms.Id, SkillVersionId = ssms_2012.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = di.Id,
                            UsageRating = 7
                        },
                        new ProjectSkill
                        {
                            SkillId = ajax.Id,
                            UsageRating = 8
                        },
                        new ProjectSkill
                        {
                            SkillId = rest.Id,
                            UsageRating = 7
                        },
                        new ProjectSkill
                        {
                            SkillId = jquery_ui.Id,
                            UsageRating = 3,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = jquery_ui.Id, SkillVersionId = jquery_ui_1_11.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = jquery.Id,
                            UsageRating = 3,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = jquery.Id, SkillVersionId = jquery_2_1.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = javascript.Id,
                            UsageRating = 3,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_3.Id },
                                new ProjectSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_5.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = css.Id,
                            UsageRating = 7,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = css.Id, SkillVersionId = css_2_1.Id },
                                new ProjectSkillVersion { SkillId = css.Id, SkillVersionId = css_3_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = html.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = html.Id, SkillVersionId = html_4_0.Id },
                                new ProjectSkillVersion { SkillId = html.Id, SkillVersionId = html_5_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = visual_studio.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_2013_web_developer_express.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = dotnet.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_4_5.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = windows.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = windows.Id, SkillVersionId = windows_7.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = oauth.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = oauth.Id, SkillVersionId = oauth_2_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = asp_net.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_4_5.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = unity.Id,
                            UsageRating = 7,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = unity.Id, SkillVersionId = unity_3_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = tfs.Id,
                            UsageRating = 4,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = tfs.Id, SkillVersionId = tfs_2013_express.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = aspnet_webapi.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = aspnet_webapi.Id, SkillVersionId = aspnet_webapi_2.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = json.Id,
                            UsageRating = 8
                        },
                        new ProjectSkill
                        {
                            SkillId = google_api.Id,
                            UsageRating = 1
                        },
                        new ProjectSkill
                        {
                            SkillId = bootstrap.Id,
                            UsageRating = 7,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = bootstrap.Id, SkillVersionId = bootstrap_3.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = angularjs.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = angularjs.Id, SkillVersionId = angularjs_1_4.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = entity_framework.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = entity_framework.Id, SkillVersionId = entity_framework_6_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = azure.Id,
                            UsageRating = 4,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = azure.Id, SkillVersionId = azure_web_sites.Id },
                                new ProjectSkillVersion { SkillId = azure.Id, SkillVersionId = azure_webjobs.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = nuget.Id,
                            UsageRating = 4
                        }
                    }
                };
                #endregion
                #region babybook
                babybook = new Project
                {
                    Description = "<p>Version 2.0 of family photos and videos album website with faceted search and tagging.</p>"
                        + "<ul>"
                        + "<li>User permissions and roles</li>"
                        + "<li>Photo and video upload</li>"
                        + "<li>Media processing and conversion</li>"
                        + "<li>Back-end admin</li>"
                        + "<li>Faceted search</li>"
                        + "<li>Responsive design</li>"
                        + "<li>Facebook and Google authentication</li>"
                        + "</ul>",
                    Name = "Family Donola",
                    PrimaryImage = "babybook-main.png",
                    StartDate = new DateTime(2015, 12, 1),
                    Skills = new List<ProjectSkill>
                    {
                        new ProjectSkill
                        {
                            SkillId = identityserver.Id,
                            UsageRating = 2,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = identityserver.Id, SkillVersionId = identityserver_3.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = ravendb.Id,
                            UsageRating = 4,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = ravendb.Id, SkillVersionId = ravendb_3_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = csharp.Id,
                            UsageRating = 9,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = csharp.Id, SkillVersionId = csharp_5_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = winservice.Id,
                            UsageRating = 5
                        },
                        new ProjectSkill
                        {
                            SkillId = sqlserver.Id,
                            UsageRating = 6,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = sqlserver.Id, SkillVersionId = sqlserver_2012_express.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = ssms.Id,
                            UsageRating = 6,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = ssms.Id, SkillVersionId = ssms_2012.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = di.Id,
                            UsageRating = 7
                        },
                        new ProjectSkill
                        {
                            SkillId = ajax.Id,
                            UsageRating = 8
                        },
                        new ProjectSkill
                        {
                            SkillId = rest.Id,
                            UsageRating = 7
                        },
                        new ProjectSkill
                        {
                            SkillId = mongodb.Id,
                            UsageRating = 4,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = mongodb.Id, SkillVersionId = mongodb_3_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = jquery.Id,
                            UsageRating = 3,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = jquery.Id, SkillVersionId = jquery_2_1.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = javascript.Id,
                            UsageRating = 3,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_3.Id },
                                new ProjectSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_5.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = css.Id,
                            UsageRating = 7,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = css.Id, SkillVersionId = css_2_1.Id },
                                new ProjectSkillVersion { SkillId = css.Id, SkillVersionId = css_3_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = html.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = html.Id, SkillVersionId = html_4_0.Id },
                                new ProjectSkillVersion { SkillId = html.Id, SkillVersionId = html_5_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = visual_studio.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_2013_web_developer_express.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = dotnet.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_4_5_2.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = windows.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = windows.Id, SkillVersionId = windows_7.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = oauth.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = oauth.Id, SkillVersionId = oauth_2_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = asp_net.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_4_5_2.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = unity.Id,
                            UsageRating = 7,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = unity.Id, SkillVersionId = unity_3_5.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = tfs.Id,
                            UsageRating = 4,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = tfs.Id, SkillVersionId = tfs_2013_express.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = aspnet_webapi.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = aspnet_webapi.Id, SkillVersionId = aspnet_webapi_2.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = json.Id,
                            UsageRating = 8
                        },
                        new ProjectSkill
                        {
                            SkillId = bower.Id,
                            UsageRating = 3
                        },
                        new ProjectSkill
                        {
                            SkillId = bootstrap.Id,
                            UsageRating = 7,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = bootstrap.Id, SkillVersionId = bootstrap_3.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = angularjs.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = angularjs.Id, SkillVersionId = angularjs_1_4.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = entity_framework.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = entity_framework.Id, SkillVersionId = entity_framework_6_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = iis.Id,
                            UsageRating = 6,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = iis.Id, SkillVersionId = iis_8_0_express.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = npm.Id,
                            UsageRating = 3
                        },
                        new ProjectSkill
                        {
                            SkillId = pivotal_tracker.Id,
                            UsageRating = 8
                        },
                        new ProjectSkill
                        {
                            SkillId = mongodb_csharp.Id,
                            UsageRating = 6,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = mongodb_csharp.Id, SkillVersionId = mongodb_csharp_2_1_1.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = sass.Id,
                            UsageRating = 2
                        },
                        new ProjectSkill
                        {
                            SkillId = nuget.Id,
                            UsageRating = 4
                        },
                        new ProjectSkill
                        {
                            SkillId = jenkins.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = jenkins.Id, SkillVersionId = jenkins_1_6.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = ci.Id,
                            UsageRating = 5
                        },
                        new ProjectSkill
                        {
                            SkillId = gulp.Id,
                            UsageRating = 5
                        },
                        new ProjectSkill
                        {
                            SkillId = unit_testing.Id,
                            UsageRating = 1
                        },
                        new ProjectSkill
                        {
                            SkillId = karma.Id,
                            UsageRating = 1
                        },
                        new ProjectSkill
                        {
                            SkillId = jasmine.Id,
                            UsageRating = 1
                        }
                    }
                };
                #endregion
                #region cv
                cv = new Project
                {
                    Description = "<p>Website CV with details of my skills, qualifications, experience and personal projects.</p>"
                        + "<ul>"
                        + "<li>Responsive design</li>"
                        + "<li>dotnet core REST api</li>"
                        + "<li>One front-end version written in AngularJS</li>"
                        + "<li>One front-end version written in React</li>"
                        + "<li>Running on docker</li>"
                        + "<li>Continuous integration/delivery using GoCD, mesos and marathon</li>"
                        + "<li>Running xUnit, Karma and Mocha unit tests</li>"
                        + "</ul>",
                    Name = "CV",
                    PrimaryImage = "cv-main.png",
                    StartDate = new DateTime(2016, 5, 1),
                    Skills = new List<ProjectSkill>
                    {
                        new ProjectSkill
                        {
                            SkillId = photoshop.Id,
                            UsageRating = 2,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = photoshop.Id, SkillVersionId = photoshop_elements_14_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = csharp.Id,
                            UsageRating = 6,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = csharp.Id, SkillVersionId = csharp_6_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = github.Id,
                            UsageRating = 4
                        },
                        new ProjectSkill
                        {
                            SkillId = sqlserver.Id,
                            UsageRating = 6,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = sqlserver.Id, SkillVersionId = sqlserver_2012_express.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = ssms.Id,
                            UsageRating = 6,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = ssms.Id, SkillVersionId = ssms_2012.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = centos.Id,
                            UsageRating = 2,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = centos.Id, SkillVersionId = centos_7_2.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = postgresql.Id,
                            UsageRating = 6,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = postgresql.Id, SkillVersionId = postgresql_9_2_15.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = docker.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = docker.Id, SkillVersionId = docker_1_12_1.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = gocd.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = gocd.Id, SkillVersionId = gocd_16_7_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = di.Id,
                            UsageRating = 7
                        },
                        new ProjectSkill
                        {
                            SkillId = linux.Id,
                            UsageRating = 2
                        },
                        new ProjectSkill
                        {
                            SkillId = ajax.Id,
                            UsageRating = 8
                        },
                        new ProjectSkill
                        {
                            SkillId = rest.Id,
                            UsageRating = 7
                        },
                        new ProjectSkill
                        {
                            SkillId = git.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = git.Id, SkillVersionId = git_1_9_5.Id },
                                new ProjectSkillVersion { SkillId = git.Id, SkillVersionId = git_2_8_1.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = wamp.Id,
                            UsageRating = 2
                        },
                        new ProjectSkill
                        {
                            SkillId = javascript.Id,
                            UsageRating = 9,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_3.Id },
                                new ProjectSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_5.Id },
                                new ProjectSkillVersion { SkillId = javascript.Id, SkillVersionId = javascript_ecmascript_6.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = css.Id,
                            UsageRating = 7,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = css.Id, SkillVersionId = css_2_1.Id },
                                new ProjectSkillVersion { SkillId = css.Id, SkillVersionId = css_3_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = html.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = html.Id, SkillVersionId = html_4_0.Id },
                                new ProjectSkillVersion { SkillId = html.Id, SkillVersionId = html_5_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = visual_studio.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_2015_community.Id },
                                new ProjectSkillVersion { SkillId = visual_studio.Id, SkillVersionId = visual_studio_code.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = dotnet.Id,
                            UsageRating = 7,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = dotnet.Id, SkillVersionId = dotnet_core_1_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = windows.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = windows.Id, SkillVersionId = windows_7.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = xunit.Id,
                            UsageRating = 6
                        },
                        new ProjectSkill
                        {
                            SkillId = asp_net.Id,
                            UsageRating = 6,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = asp_net.Id, SkillVersionId = asp_net_core_1_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = tfs.Id,
                            UsageRating = 4,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = tfs.Id, SkillVersionId = tfs_2013_express.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = aspnet_webapi.Id,
                            UsageRating = 6,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = aspnet_webapi.Id, SkillVersionId = aspnet_webapi_core_1_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = json.Id,
                            UsageRating = 8
                        },
                        new ProjectSkill
                        {
                            SkillId = bower.Id,
                            UsageRating = 3
                        },
                        new ProjectSkill
                        {
                            SkillId = bootstrap.Id,
                            UsageRating = 7,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = bootstrap.Id, SkillVersionId = bootstrap_3.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = angularjs.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = angularjs.Id, SkillVersionId = angularjs_1_4.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = entity_framework.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = entity_framework.Id, SkillVersionId = entity_framework_core_1_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = npm.Id,
                            UsageRating = 3
                        },
                        new ProjectSkill
                        {
                            SkillId = less.Id,
                            UsageRating = 5
                        },
                        new ProjectSkill
                        {
                            SkillId = gulp.Id,
                            UsageRating = 5
                        },
                        new ProjectSkill
                        {
                            SkillId = unit_testing.Id,
                            UsageRating = 6
                        },
                        new ProjectSkill
                        {
                            SkillId = karma.Id,
                            UsageRating = 6
                        },
                        new ProjectSkill
                        {
                            SkillId = jasmine.Id,
                            UsageRating = 6
                        },
                        new ProjectSkill
                        {
                            SkillId = jquery.Id,
                            UsageRating = 1,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = jquery.Id, SkillVersionId = jquery_2_1.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = react.Id,
                            UsageRating = 8,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = react.Id, SkillVersionId = react_15_4_2.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = chai.Id,
                            UsageRating = 5,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = chai.Id, SkillVersionId = chai_3_5_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = mocha.Id,
                            UsageRating = 6,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = mocha.Id, SkillVersionId = mocha_3_3_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = enzyme.Id,
                            UsageRating = 6,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = enzyme.Id, SkillVersionId = enzyme_2_8_2.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = babel.Id,
                            UsageRating = 2,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = babel.Id, SkillVersionId = babel_6_24_1.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = sinon.Id,
                            UsageRating = 5
                        },
                        new ProjectSkill
                        {
                            SkillId = webpack.Id,
                            UsageRating = 3,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = webpack.Id, SkillVersionId = webpack_2_4_1.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = redux.Id,
                            UsageRating = 7,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = redux.Id, SkillVersionId = redux_3_6_0.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = marathon.Id,
                            UsageRating = 3,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = marathon.Id, SkillVersionId = marathon_1_1_2.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = mesos.Id,
                            UsageRating = 2,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = mesos.Id, SkillVersionId = mesos_1_0_1.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = zookeeper.Id,
                            UsageRating = 1,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = zookeeper.Id, SkillVersionId = zookeeper_3_4_6.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = bamboo.Id,
                            UsageRating = 2,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = bamboo.Id, SkillVersionId = bamboo_0_2_2_1.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = nginx.Id,
                            UsageRating = 2,
                            Versions = new List<ProjectSkillVersion>
                            {
                                new ProjectSkillVersion { SkillId = nginx.Id, SkillVersionId = nginx_1_13_1.Id }
                            }
                        },
                        new ProjectSkill
                        {
                            SkillId = jsx.Id,
                            UsageRating = 6
                        }
                    }
                };
                #endregion
                context.Projects.Add(othodo);
                context.Projects.Add(louise13);
                context.Projects.Add(cnlaps);
                context.Projects.Add(makabou);
                context.Projects.Add(pharmatoo);
                context.Projects.Add(toomanyplaces);
                context.Projects.Add(pubrush);
                context.Projects.Add(moi);
                context.Projects.Add(dpf);
                context.Projects.Add(babybook);
                context.Projects.Add(cv);
            }

            return context.SaveChanges();

        }

        private static int CreateCards(CvDbContext context)
        {
            if (!context.Cards.Any())
            {
                #region Location
                location = new Card
                {
                    ImageBackUrl = null,
                    Rotate = "y",
                    TextBack = "<br /><i class=\"fa fa-3x fa-map-marker\"></i><br />London SE8<br />United Kingdom",
                    Caption = "Location",
                    CaptionIconClass = "fa fa-map-marker",
                    TextFront = null,
                    ImageFrontUrl = "maps-location.png",
                };
                #endregion
                #region Contact
                contact = new Card
                {
                    ImageBackUrl = null,
                    Rotate = "y",
                    TextBack = "<br /><i class=\"fa fa-3x fa-envelope\"></i><br />philippe.donnette@gmail.com",
                    Caption = "Contact",
                    CaptionIconClass = "fa fa-envelope",
                    TextFront = null,
                    ImageFrontUrl = "contact.png",
                };
                #endregion

                context.Cards.Add(location);
                context.Cards.Add(contact);
            }

            return context.SaveChanges();

        }

        private static int CreateProjectImages(CvDbContext context)
        {
            if (!context.ProjectImages.Any())
            {

                #region babybook
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Filtered list of photos",
                    ImageUrl = "babybook-1.png",
                    ProjectId = babybook.Id,
                    Title = "Desktop View - Photo List"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Upload screen to add photos and videos",
                    ImageUrl = "babybook-2.png",
                    ProjectId = babybook.Id,
                    Title = "Desktop View - Upload"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Upload screen to add photos and videos",
                    ImageUrl = "babybook-3.png",
                    ProjectId = babybook.Id,
                    Title = "Mobile View - Upload"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "List of photos for publishing",
                    ImageUrl = "babybook-4.png",
                    ProjectId = babybook.Id,
                    Title = "Mobile View - Publish Screen"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Detail view of a photo with tagging funcionality",
                    ImageUrl = "babybook-5.png",
                    ProjectId = babybook.Id,
                    Title = "Mobile View - Admin Photo Detail"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Advanced search with facets",
                    ImageUrl = "babybook-6.png",
                    ProjectId = babybook.Id,
                    Title = "Desktop View - Faceted Search"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Detail view of a photo with tagging funcionality",
                    ImageUrl = "babybook-7.png",
                    ProjectId = babybook.Id,
                    Title = "Desktop View - Admin Photo Detail"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Login screen with social login capabilities with Facebook and Google",
                    ImageUrl = "babybook-8.png",
                    ProjectId = babybook.Id,
                    Title = "Mobile View - Login Screen"
                });
                #endregion
                #region deptford park football
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Login screen with social login capabilities with Facebook and Google",
                    ImageUrl = "dpf-1.png",
                    ProjectId = dpf.Id,
                    Title = "Desktop View - Login Screen"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Admin screen to post a new game",
                    ImageUrl = "dpf-2.png",
                    ProjectId = dpf.Id,
                    Title = "Desktop View - Add Game"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Screen of a posted game with all details",
                    ImageUrl = "dpf-3.png",
                    ProjectId = dpf.Id,
                    Title = "Mobile View - Game Details"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Screen of a posted game with all details and attendance",
                    ImageUrl = "dpf-4.png",
                    ProjectId = dpf.Id,
                    Title = "Desktop View - Game Details"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Screen of a posted game with attendance details",
                    ImageUrl = "dpf-5.png",
                    ProjectId = dpf.Id,
                    Title = "Mobile View - Attendance Details"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Screen of an email notification to join a newly added game",
                    ImageUrl = "dpf-6.png",
                    ProjectId = dpf.Id,
                    Title = "Desktop View - Email Notification"
                });
                #endregion
                #region makabou
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Screen showing list of adverts for a category",
                    ImageUrl = "makabou-1.png",
                    ProjectId = makabou.Id,
                    Title = "Desktop View - Advert List"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Screen to post a new advert",
                    ImageUrl = "makabou-2.png",
                    ProjectId = makabou.Id,
                    Title = "Desktop View - Post Advert"
                });
                #endregion
                #region moi
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "List of photos and videos for the selected age category",
                    ImageUrl = "moi-1.png",
                    ProjectId = moi.Id,
                    Title = "Desktop View - Media List"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Zoom view of a photo",
                    ImageUrl = "moi-2.png",
                    ProjectId = moi.Id,
                    Title = "Desktop View - Zoom View"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Upload screen to post new photos and videos",
                    ImageUrl = "moi-3.png",
                    ProjectId = moi.Id,
                    Title = "Desktop View - Upload"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "User account screen details with editable fields and list of permissions",
                    ImageUrl = "moi-4.png",
                    ProjectId = moi.Id,
                    Title = "Desktop View - User Account"
                });
                #endregion
                #region pharmatoo
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Home page with recently added pharmacies and pharmacist suppliers",
                    ImageUrl = "pharmatoo-1.png",
                    ProjectId = pharmatoo.Id,
                    Title = "Desktop View - Home Page"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Screen of a pharmacy with all details",
                    ImageUrl = "pharmatoo-2.png",
                    ProjectId = pharmatoo.Id,
                    Title = "Desktop View - Pharmacy Details"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Page listing of all medicine drugs available in pharmatoo registered stores with search and filter by keywords and/or category",
                    ImageUrl = "pharmatoo-3.png",
                    ProjectId = pharmatoo.Id,
                    Title = "Desktop View - Medicine Drugs List"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Registration form to subscribe and promote a pharmacy on pharmatoo website",
                    ImageUrl = "pharmatoo-4.png",
                    ProjectId = pharmatoo.Id,
                    Title = "Desktop View - Registration Form"
                });
                #endregion
                #region toomanyplaces
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Marketing business card to promote toomanyplaces websites",
                    ImageUrl = "tmp-1.png",
                    ProjectId = toomanyplaces.Id,
                    Title = "Marketing Business Card"
                });
                #endregion
                #region cv
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Homepage",
                    ImageUrl = "cv-1.png",
                    ProjectId = cv.Id,
                    Title = "Desktop View - Homepage"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "List of all skills",
                    ImageUrl = "cv-2.png",
                    ProjectId = cv.Id,
                    Title = "Desktop View - Skills Page"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Details of a skills with rating from the skills page",
                    ImageUrl = "cv-3.png",
                    ProjectId = cv.Id,
                    Title = "Desktop View - Skills Details"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "List of all qualifications and trainings",
                    ImageUrl = "cv-4.png",
                    ProjectId = cv.Id,
                    Title = "Desktop View - Qualifications Page"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Detail view of a job experience",
                    ImageUrl = "cv-5.png",
                    ProjectId = cv.Id,
                    Title = "Desktop View - Job Experience Page"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "List of all projects",
                    ImageUrl = "cv-6.png",
                    ProjectId = cv.Id,
                    Title = "Desktop View - Projects Page"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Detail view of a project",
                    ImageUrl = "cv-7.png",
                    ProjectId = cv.Id,
                    Title = "Desktop View - Project Details Page"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Zoom popup of a screenshot from project details page",
                    ImageUrl = "cv-8.png",
                    ProjectId = cv.Id,
                    Title = "Desktop View - Zoom Popup"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Homepage",
                    ImageUrl = "cv-9.png",
                    ProjectId = cv.Id,
                    Title = "Mobile View - Homepage"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "List of all skills",
                    ImageUrl = "cv-10.png",
                    ProjectId = cv.Id,
                    Title = "Mobile View - Skills Page"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Details of a skills with rating from the skills page",
                    ImageUrl = "cv-11.png",
                    ProjectId = cv.Id,
                    Title = "Mobile View - Skills Details"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "List of all qualifications and trainings",
                    ImageUrl = "cv-12.png",
                    ProjectId = cv.Id,
                    Title = "Mobile View - Qualifications Page"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Detail view of a job experience",
                    ImageUrl = "cv-13.png",
                    ProjectId = cv.Id,
                    Title = "Mobile View - Job Experience Page"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "List of all projects",
                    ImageUrl = "cv-14.png",
                    ProjectId = cv.Id,
                    Title = "Mobile View - Projects Page"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Detail view of a project",
                    ImageUrl = "cv-15.png",
                    ProjectId = cv.Id,
                    Title = "Mobile View - Project Details Page"
                });
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Zoom popup of a screenshot from project details page",
                    ImageUrl = "cv-16.png",
                    ProjectId = cv.Id,
                    Title = "Mobile View - Zoom Popup"
                });
                #endregion
            }

            return context.SaveChanges();
        }

        private static int CreateQualifications(CvDbContext context)
        {
            if (!context.Qualifications.Any())
            {
                context.Qualifications.Add(new Qualification
                {
                    SchoolName = "Martin Luther King",
                    StartDate = new DateTime(1998, 9, 1),
                    EndDate = new DateTime(2001, 7, 31),
                    ImageUrl = null,
                    City = "Bussy-Saint-Georges",
                    Country = "France",
                    Subject = "General Scientific Baccalaureate",
                    Description = "<p>Baccalaureate is France's national secondary-school diploma, much like the British A-level.</p><p>During my second and third year, I chose to study the scientific stream and to specialised in engineering.</p>",
                    WebsiteUrl = null,
                    DegreeFile = "bac.pdf"
                });
                context.Qualifications.Add(new Qualification
                {
                    SchoolName = "University Paris-Est Marne-la-Vallée",
                    StartDate = new DateTime(1998, 9, 1),
                    EndDate = new DateTime(2001, 7, 31),
                    ImageUrl = "mlv-uni.png",
                    City = "Champs-sur-Marne",
                    Country = "France",
                    Subject = "DEUG MIAS",
                    Description = "<p>The Diplôme d'études universitaires générales (French for General Academic Studies Degree), abbreviated DEUG, was a French national degree.</p><p>I chose to specialised in mathematics and computer science but did not fully completed my cursus.</p>",
                    WebsiteUrl = "http://www.u-pem.fr/",
                    DegreeFile = null
                });
                context.Qualifications.Add(new Qualification
                {
                    SchoolName = "H.E.I.G",
                    StartDate = new DateTime(2003, 9, 1),
                    EndDate = new DateTime(2005, 7, 31),
                    ImageUrl = "heig.png",
                    City = "Lognes",
                    Country = "France",
                    Subject = "Brevet de Technicien Supérieur (BTS)",
                    Description = "<p>The Brevet de Technicien Supérieur (BTS) technician certificate is a national diploma of higher education in France.</p><p>I decided to specialised in software applications and complete my formation in a sandwich course working a minimum of 3 days a week for T2S during two years.</p>",
                    WebsiteUrl = null,
                    DegreeFile = "bts.pdf"
                });

            }

            return context.SaveChanges();
        }

        private static int CreateTrainings(CvDbContext context)
        {
            if (!context.Trainings.Any())
            {
                context.Trainings.Add(new Training
                {
                    CertificateFile = "scrum.pdf",
                    Description = "3-day course that teaches how to create great software using the Scrum framework.",
                    ImageUrl = "scrum.png",
                    Provider = "Scrum.org",
                    Subject = "Professional Scrum Developer I (PSD I)",
                    WebsiteUrl = "http://www.scrum.org"
                });
                context.Trainings.Add(new Training
                {
                    CertificateFile = null,
                    Description = "Two days course centre around the installation and configuration of a Shibboleth 2 service provider and identity provider.",
                    ImageUrl = "jisc.png",
                    Provider = "Jisc",
                    Subject = "Implementing a Shibboleth identity provider and service provider",
                    WebsiteUrl = "http://www.jisc.ac.uk"
                });
            }

            return context.SaveChanges();
        }

        private static int CreatePerson(CvDbContext context)
        {
            if (!context.Persons.Any())
            {
                context.Persons.Add(new Person
                {
                    AboutCaption = "Full Stack Developer",
                    AboutImage = "user.png",
                    AboutMotto = "10 Years of Experience in Software Development",
                    AboutText = "<p>Passionate about coding with over 10 years of experience, I am a full-stack developer specialised in Microsoft technologies and front-end technologies such as ASP.NET MVC, .NET Core, C#, SQL SERVER, Angular, JavaScript...</p>"
                        + "<p>"
                        + "I have a great understanding of the full development lifecycle from planning to deployment of a solution and I am also experienced with a broad range of technologies and developement practices (NoSQL, Source Control, Continous Integration/Delivery, Agile, Scrum, Microservices, TDD...) and have a great understanding of the full development lifecycle from planning to deployment of a solution."
                        + "</p>"
                        + "<p>"
                        + "After nine years living in London, I am looking to relocate to Jyvaskyla, Finland with my family. We anticipate that the move can be completed between September 2017 and January 2018."
                        + "</p>"
                        + "<p>"
                        + "In terms of professional development, I am looking for a role where I can further enhance my skills whilst building quality software with robust architecture. I have a strong interest in working with the latest technologies and wish to be part of an agile team with high standard software development practices."
                        + "</p>"
                        + "<p>"
                        + "Please do get in touch if you would like to discuss in further detail. I look forward to hearing from you."
                        + "</p>",
                    Firstname = "Philippe",
                    GitHubUrl = "https://github.com/philippe-donnette",
                    HomeImage = "wordcloud-1.png",
                    Lastname = "Donnette",
                    LinkedinUrl = "https://www.linkedin.com/in/philippe-donnette-2bb80b4",
                    Occupation = "Full Stack Developer",
                    OccupationMotto = "10 Years of Experience in Software Development",
                    PrimaryImage = "user.png"
                });
            }

            return context.SaveChanges();
        }
    }
}
