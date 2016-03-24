using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using CV.DataAccessLayer.Contexts;
using Microsoft.Data.Entity;
using CV.DataAccessLayer.Initializers;
using CV.DataAccessLayer.Repositories;
using CV.Core.Services;
using CV.Core.Mappings;
using AutoMapper;
using Microsoft.AspNet.Http;
using System.Data.SqlClient;
using CV.Api.Settings;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Cors;
using Newtonsoft.Json.Serialization;

namespace CV.Api
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            // Set up configuration sources.
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();

            if (env.IsDevelopment())
            {
                builder.AddUserSecrets();
            }

            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging();

            services.AddCors(options => 
            {
                options.AddPolicy("AllowCvWeb", 
                    x => x.WithOrigins(Configuration["Data:CorsAllowedOrigins:CvWeb"])
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                    );
            });

            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            });

            services.Configure<MvcOptions>(options =>
            {
                options.Filters.Add(new CorsAuthorizationFilterFactory("AllowCvWeb"));
            });

            services.AddEntityFramework().AddSqlServer()
                .AddDbContext<CvDbContext>(options =>
                    options.UseSqlServer(Configuration["Data:DefaultConnection:ConnectionString"]));

            services.AddTransient<IQualificationService, QualificationService>();
            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<IExperienceService, ExperienceService>();
            services.AddTransient<IProjectService, ProjectService>();
            services.AddTransient<ISkillService, SkillService>();
            services.AddTransient<IQualificationRepository, QualificationRepository>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IExperienceRepository, ExperienceRepository>();
            services.AddTransient<IProjectRepository, ProjectRepository>();
            services.AddTransient<ISkillRepository, SkillRepository>();

            var mapperConfig = new MapperConfiguration(config =>
            {
                config.AddProfile(new CvMapperProfile());
            });
            services.AddSingleton<IMapper>(sp => mapperConfig.CreateMapper());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                loggerFactory.MinimumLevel = LogLevel.Debug;
                loggerFactory.AddConsole(Configuration.GetSection("Logging"));
                loggerFactory.AddDebug(LogLevel.Debug);
            }
            else
            {
                loggerFactory.MinimumLevel = LogLevel.Information;
                loggerFactory.AddConsole(LogLevel.Information);
                loggerFactory.AddDebug(LogLevel.Information);
            }
            
            if (env.IsDevelopment())
            {
                using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                    .CreateScope())
                {
                    try
                    {
                        serviceScope.ServiceProvider.GetService<CvDbContext>().Database.Migrate();
                        serviceScope.ServiceProvider.GetService<CvDbContext>().EnsureSeedData();
                    }
                    catch(SqlException ex)
                    {
                        var logger = loggerFactory.CreateLogger("Catchall Migration");
                        logger.LogCritical((int)LoggingEvents.EfMigrations, ex.StackTrace);
                    }
                }
            }

            app.UseIISPlatformHandler();

            app.UseStaticFiles();

            app.UseCors("AllowCvWeb");

            app.UseMvc();
            
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
