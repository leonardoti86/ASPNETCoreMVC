using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Site01.Database;

namespace Site01
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //usar o MVC
            services.AddMvc();

            //usar o EF
            services.AddDbContext<DatabaseContext>(options => {
                //Providers - bibliotecas de conexões de banco dos fabricantes. SqlServer, MySql, etc
                options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=site01;Integrated Security=true;");
            });

            //usar controle de sessão
            services.AddDistributedMemoryCache();
            services.AddSession();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSession();

            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute();

            // qdo adiciono o comando acima "app.UseMvcWithDefaultRoute();" esse app.run não será executado 
            /*
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
            */
        }
    }
}
