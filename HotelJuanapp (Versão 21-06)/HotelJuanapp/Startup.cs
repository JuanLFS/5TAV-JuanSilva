using AutoMapper;
using HotelJuanApp.Aplication;
using HotelJuanApp.Application.Interface;
using HotelJuanApp.Application.ViewModel;
using HotelJuanApp.Domain.Entity;
using HotelJuanApp.Domain.Interfaces.Service;
using HotelJuanApp.Domain.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelJuanapp
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
            DependenceInjectionConf(Configuration, services);

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HotelJuanapp", Version = "v1" });
            });

            var configuration = new MapperConfiguration (cfg =>
            {
                cfg.CreateMap<Quarto, QuartoViewModel>();
                cfg.CreateMap<QuartoViewModel, Quarto>();
            }
            );

            var mapper = configuration.CreateMapper();
            services.AddSingleton(mapper);
        }

        //injeção de dependência
        private static void DependenceInjectionConf(IConfiguration configuration, IServiceCollection services)
        {
            services.AddScoped(typeof(IReservaService), typeof(ReservaService));
            services.AddScoped(typeof(IReservaAppService), typeof(ReservaAppService));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HotelJuanapp v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
