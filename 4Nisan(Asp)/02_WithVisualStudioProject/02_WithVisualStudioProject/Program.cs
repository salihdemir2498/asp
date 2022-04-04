using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_WithVisualStudioProject
{
    public class Program
    {
        //Asl�nda Asp.Net Core uygulamalar� bir console uygulamas�d�r.
        public static void Main(string[] args)
        {
            //Buras� uygulaman�n ba�lang�� noktas�d�r.
            //B�t�n hikaye burada ba�l�yor.
            //Asp.Net Core sunucuyu aya�a kald�r�yor.
            //Bu i�i geriye IHostBuilder t�r�nden bir de�er d�nd�r�ren
            //a�ag�daki CreateHostBuilder metodunu kullanarak yap�yor.
            CreateHostBuilder(args).Build().Run();
        }
        //Bir sunucu aya�a kald�r�l�rken �e�itli konfig�rasyonlara 

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //Sunucu Startup class�ndaki konfig�rasyonlar
                    //kullan�larak aya�a kald�r�l�yor.
                    webBuilder.UseStartup<Startup>();
                });
    }
}
