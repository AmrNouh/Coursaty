using CourseDemo.EF;
using CourseDemo.EF.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CoursesDemo
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
            services.AddControllersWithViews();
            services.AddDbContext<ApplicationDbContext>(context =>
            context.UseSqlServer(Configuration.GetConnectionString("CoursesDb"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
                ));

            var entryAssembly = Assembly.GetEntryAssembly();
            var referencedAssemblies = entryAssembly.GetReferencedAssemblies().Select(Assembly.Load);
            var assemblies = new List<Assembly> { entryAssembly }.Concat(referencedAssemblies).ToArray();
            var specificAssemblies = assemblies.Where(assemblies => assemblies.FullName.StartsWith("CourseDemo.EF")).ToArray();

            services.Scan(scan => scan
            .FromAssemblies(specificAssemblies)
            .AddClasses()
            .AsImplementedInterfaces()
            .WithScopedLifetime()
            );

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Course}/{action=Index}/{id?}");
            });
        }
    }
}
