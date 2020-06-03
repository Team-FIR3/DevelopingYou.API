using DevelopingYou.API.Data;
using DevelopingYou.API.Data.DatabaseRepositories;
using DevelopingYou.API.Data.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DevelopingYou.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // TODO:
            // Insert DBContext here and setup default connection string in appsettings.json
            services.AddDbContext<DiscoveringYouDBContext>(options =>
            {
                string connectionString = Configuration
                    .GetConnectionString("DefaultConnection");
                options.UseSqlServer(connectionString);
            });

            // TODO:
            // Insert dependency injection here

            services.AddTransient<IGoalRepository, DatabaseGoalRepository>();
            services.AddTransient<IInstanceRepository, DatabaseInstanceRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
