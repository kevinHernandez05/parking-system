using PS.Service;
using PS.Service.Helpers;
using PS.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS.API.Installers
{
    public class DataInstallers : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            //Registering DBContext
            services.AddDbContext<ApplicationDbContext>(opt => 
                opt.UseSqlServer(configuration.GetConnectionString("DatabaseConnection")));

            //DI
            services.AddTransient<IWeatherForecastService, WeatherForecastService>();
            services.AddTransient<IUserService, UserService>();

            //JWT Setting
            services.Configure<AppSettings>(configuration.GetSection("AppSettings"));


            // automapper

        }
    }
}
