using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_Mvc_01
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Bu servisi ekleyerek uygulamam�z�n mvc mimarisini kullanaca��n� belirtmi� olduk.
            //Dolay�s�yla art�k bu uygulamaya gelen bir request kar��lanabilir haldedir.
            //Kar��layacak olan �ey, Controller'd�r.Tabi ki sonu� olarak html yaratmas�n� 
            //istedi�imiz i�in de Viewlarla �al��aca��m�z� da belirtmi� olduk.
            //*Model ise bir SERVICE de�il
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //Gelen requestlar�n rotas� bu middleware sayesinde belirlenecektir.
            app.UseRouting();
            //Bu middleware en �nemlilerinden birirdir.
            //endpoints, gelen requestin var�� noktas� diye d���n�lebilir.
            //Yani yap�lan requestin adresi.
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                //abc.com
                //abc.com/urunler
                //abc.com/urunler/getir
                //abc.com/urunler/getir/5
            });
        }
    }
}
