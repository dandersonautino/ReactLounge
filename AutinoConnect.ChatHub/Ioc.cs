using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutinoConnect.Data.CarVue.Models.Models;
using AutinoConnect.DataAccess.Concrete;
using AutinoConnect.DataAccess.Interfaces;
using AutinoConnect.Hub.Services.Interface;
using AutinoConnect.Utility.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AutinoConnect.ChatHub
{
    public class Ioc
    {
        public void Configure(IServiceCollection services, IConfiguration configuration)
        {


            string connectionString = configuration["Settings:DbContextConnectionString"];

            services.AddDbContext<ACCarVueContext>(options => options.UseSqlServer(connectionString));

            services.AddScoped<IUnitOfWork<ACCarVueContext>, UnitOfWork<ACCarVueContext>>();
            services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));

            services.Scan(scan =>
                scan.FromAssemblyOf<IChatAuthService>()
                    .AddClasses()
                    .AsMatchingInterface()
                    
                    .WithScopedLifetime());

            services.Scan(scan =>
                scan.FromAssemblyOf<IModelToQueryStringService>()
                    .AddClasses()
                    .AsMatchingInterface()   
                    .WithScopedLifetime());

        }
    }
}
