using Chimerical.Conversions.Db;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace Chimerical.Conversions.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new ConversionsContext())
            {
                context.Database.Migrate();
            }

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
