using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
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

using IoTCafeApi.Service.User;
using IoTCafeApi.Service.Cooperative;
using IoTCafeApi.Service.Farm;
using IoTCafeApi.Service.Menu;
using IoTCafeApi.Service.Plot;
using IoTCafeApi.Service.PlotCycle;
using IoTCafeApi.Service.Rol;
using IoTCafeApi.Service.Stage;
using IoTCafeApi.Service.Station;
using IoTCafeApi.Service.Variety;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace IoTCafeApi
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
            //Habilitacion del Cors
            services.AddCors(options => options.AddPolicy("All", policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));


            //Configuracion del Token Jwt

            var key = Encoding.ASCII.GetBytes(Configuration.GetValue<string>("SecretKey"));

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            //Inyeccion de dependencias
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<ICooperativeServices, CooperativeServices>();
            services.AddScoped<IFarmServices, FarmService>();
            services.AddScoped<IMenuServices, MenuServices>();
            services.AddScoped<IPlotServices, PlotServices>();
            services.AddScoped<IPlotCycleServices, PlotCycleServices>();
            services.AddScoped<IRolServices, RolServices>();
            services.AddScoped<IStageServices, StageServices>();
            services.AddScoped<IStationServices, StationServices>();
            services.AddScoped<IVarietyServices, VarietyServices>();


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "IoTCafeApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseAuthentication();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "IoTCafeApi v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
