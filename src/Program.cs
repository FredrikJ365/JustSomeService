using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace src
{
    public static class Program
    {
        public static void Main()
        {
            CreateWebHostBuilder().Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder() =>
            WebHost.CreateDefaultBuilder().UseStartup<Startup>();
    }
}
