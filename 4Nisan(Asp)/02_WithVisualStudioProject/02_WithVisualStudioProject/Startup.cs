using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_WithVisualStudioProject
{
    public class Startup
    {
      
        public void ConfigureServices(IServiceCollection services)
        {
            //Bu uygulamada kullanýlacak olan serrvislerin belirlendiði metod.
            //Servive demek belli bir takým iþleri yapmak için kodlarýn içinde bulunduðu yapýlardýr.
            //Modül, kütüphane gibi düþünebilirsiniz.
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Bu metot uygulamada kullanýlacak olan ara katmanlarýn belirtildiði metotdur.
            //Ara katman MiddleWare adýylada bilinir.
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //Bu MiddleWare routing iþlemini devreye alýr.
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
