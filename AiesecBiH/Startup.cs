using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.Authentication;
using AiesecBiH.EF;
using AiesecBiH.Filters;
using AiesecBiH.IServices;
using AiesecBiH.Model.Response;
using AiesecBiH.Services;
using AiesecBiH.Services.BaseServices;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace AiesecBiH
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(x =>
            {
                x.Filters.Add<ErrorFilters>();
            }).AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            ); ;
            //services.AddControllers();
            services.AddDbContext<AiesecContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("local")));
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IFunctionalFieldService, FunctionalFieldService>();
            services.AddScoped<ILocalCommitteeService, LocalCommitteeService>();
            services.AddScoped<IOfficeService, OfficeService>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IReportService, ReportService>();
            services.AddScoped<ISecurityService, SecurityService>();
            services.AddScoped<IMemberService, MemberService>();
            services.AddScoped<IReadService<Role,Model.Search.Role>, ReadService<Role,Database.Role, Model.Search.Role>>();
            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication",null);
            services.AddSwaggerGen(options =>
            {
                options.CustomSchemaIds(type => type.ToString());
                options.AddSecurityDefinition("BasicAuthentication", new OpenApiSecurityScheme()
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic"
                });
                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme()
                        {
                            Reference = new OpenApiReference(){Type = ReferenceType.SecurityScheme,Id="BasicAuthentication"}
                        },
                        new string[]{}
                    }
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(x =>
                x.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));

            app.UseHttpsRedirection();
            
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
