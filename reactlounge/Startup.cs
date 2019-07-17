using Autino.Lounge.Services.Concrete;
using Autino.Lounge.Services.Interfaces;
using AutinoConnect.Shared.Connectivity.Concrete;
using AutinoConnect.Shared.Connectivity.Interfaces;
using AutinoConnect.Utility.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using reactlounge.Services;

namespace reactlounge
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
            SetUpIoc(services);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });
        }

        public void SetUpIoc(IServiceCollection services)
        {
            services.AddScoped<IWebApiClientManager, JsonWebApiClientManager>();
            services.AddScoped<IConfigurationService, ConfigurationService>();
            services.AddScoped<IIdentityTokenService, IdentityTokenService>();
            services.Scan(scan =>
                scan.FromAssemblyOf<IBookingService>()
                    .AddClasses()
                    .AsMatchingInterface()
                    .WithScopedLifetime());
            services.Scan(scan =>
                scan.FromAssemblyOf<IModelToQueryStringService>()
                    .AddClasses()
                    .AsMatchingInterface()
                    .WithScopedLifetime());
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
