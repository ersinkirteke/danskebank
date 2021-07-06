using FluentValidation;
using FluentValidation.AspNetCore;
using danske.scheduler.common.domain.models;
using danske.scheduler.producer.api.extensions;
using danske.scheduler.producer.api.validators;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using danske.scheduler.common.infrastructure.context;
using Microsoft.EntityFrameworkCore;
using danske.scheduler.api.services;
using danske.scheduler.common.infrastructure;
using danske.scheduler.common.infrastructure.repositories;
using danske.scheduler.common.domain.entities;
using AutoMapper;
using System;
using danske.scheduler.producer.api.profiles;

namespace danske.scheduler.producer.api
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
            services.AddMvc().AddFluentValidation();
            services.AddDbContext<DanskeContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DBConnection"))
            );
            services.AddAutoMapper(typeof(CompanyProfile), typeof(NotificationProfile));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IScheduleService, ScheduleService>();
            services.AddTransient<IValidator<NotificationDto>, NotificationValidator>();
            services.AddTransient<IValidator<CompanyDto>, CompanyValidator>();
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "danske.scheduler.producer.api", Version = "v1" });
            });
            services.ConfigureCors();
        }

        private void profileAssembly1(IMapperConfigurationExpression obj)
        {
            throw new NotImplementedException();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, DanskeContext danskeContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "danske.scheduler.producer.api v1"));
            }

            danskeContext.Database.EnsureCreated();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.ConfigureCustomExceptionMiddleware();
        }
    }
}
