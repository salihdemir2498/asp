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
        //Aslýnda Asp.Net Core uygulamalarý bir console uygulamasýdýr.
        public static void Main(string[] args)
        {
            //Burasý uygulamanýn baþlangýç noktasýdýr.
            //Bütün hikaye burada baþlýyor.
            //Asp.Net Core sunucuyu ayaða kaldýrýyor.
            //Bu iþi geriye IHostBuilder türünden bir deðer döndürüren
            //aþagýdaki CreateHostBuilder metodunu kullanarak yapýyor.
            CreateHostBuilder(args).Build().Run();
        }
        //Bir sunucu ayaða kaldýrýlýrken çeþitli konfigürasyonlara 

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //Sunucu Startup classýndaki konfigürasyonlar
                    //kullanýlarak ayaða kaldýrýlýyor.
                    webBuilder.UseStartup<Startup>();
                });
    }
}
