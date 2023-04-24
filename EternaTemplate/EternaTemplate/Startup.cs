using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EternaTemplate.Data_Access;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EternaTemplate
{
	public class Startup
	{
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();
			services.AddDbContext<DataContext>(setting =>
			{
				setting.UseSqlServer(@"Server=DESKTOP-497OP8B\SQLEXPRESS;Database=Eterna;Trusted_Connection=true");

			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseRouting();
			app.UseStaticFiles();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute("default",
					"{controller=home}/{action=index}");
				endpoints.MapControllerRoute("forabout",
					"about-us",
					defaults: new { controller = "home", action = "about" });
				endpoints.MapControllerRoute("forcontact",
					"contact-us",
					defaults: new { controller = "home", action = "contact" }
					);
			});
		}
	}
}
