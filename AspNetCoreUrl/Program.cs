using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AspNetCoreUrl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    // 使用UseUrls设置监听的端口和协议
                    //webBuilder.UseUrls("http://localhost:7003", "https://localhost:7013");
                    //webBuilder.UseKestrel(kestrelServerOptions =>
                    //{
                    //    kestrelServerOptions.ListenLocalhost(7004);
                    //    kestrelServerOptions.ListenLocalhost(7014, listenOptions => listenOptions.UseHttps());
                    //});
                });
    }
}
