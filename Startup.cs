using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVC_Basics.Models;

namespace MVC_Basics
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICrabRepository, MochCrabRepository>();
            services.AddScoped<ICategoryRepository, MochCategoryRepository>();

            services.AddControllersWithViews();
            services.AddHttpContextAccessor();
            services.AddSession();

            //services.AddMvc();
            // services.addScoped<IxxxRepository, MockDatabaseRepository>
            // once per request
            // Add singelton en enda. 
            // AddTransitory 

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSession();
            // app.UseStatusCodePages();
            // app.UseHttpsRedirection(); från http till https
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                name: "crab",
                pattern: "crab",
                defaults: new { Controller = "Crab", Action = "Crab" });

                endpoints.MapControllerRoute(
                name: "FeverCheck",
                pattern: "FeverCheck",
                defaults: new { Controller = "Doctor", Action = "CheckPerson" });

                endpoints.MapControllerRoute(
                name: "Game",
                pattern: "Game",
                defaults: new { Controller = "Game", Action = "Index" });


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{Controller=Home}/{action=Index}/{id?}"
                    );



            });
        }
    }
}
