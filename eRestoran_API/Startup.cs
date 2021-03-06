using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eRestoran_API.Database;
using eRestoran_API.Filters;
using eRestoran_API.Security;
using eRestoran_API.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace eRestoran_API
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
           

            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);


            services.AddAutoMapper();
            services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "eRestoran API", Version = "v1" });

                c.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
                        },
                        new string[]{}
                    }
                });
            });

            services.AddScoped<IZaposlenikService, ZaposlenikService>();
            services.AddScoped<IUlogaService, UlogaService>();
            services.AddScoped<IKlijentService, KlijentService>();
            services.AddScoped<INabavkaService, NabavkaService>();
            services.AddScoped<INabavkaPiceService, NabavkaPiceService>();
            services.AddScoped<IPiceService, PiceService>();
            services.AddScoped<INabavkaNamirnicaService, NabavkaNamirnicaService>();
            services.AddScoped<INamirnicaService, NamirnicaService>();
            services.AddScoped<IRezervacijaService, RezervacijaService>();
            services.AddScoped<INarudzbaService, NarudzbaService>();
            services.AddScoped<IVrstaJelaService, VrstaJelaService>();
            services.AddScoped<IJeloService, JeloService>();
            services.AddScoped<INarudzbaJeloService, NarudzbaJeloService>();
            services.AddScoped<IOcjenaService, OcjenaService>();

            //var connection = @"Server=.;Database=IB140235;Trusted_Connection=True;";

            services.AddDbContext<IB140235Context>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseAuthentication();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });


            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
