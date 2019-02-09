using System;
using Chimerical.Conversions.Db;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace Chimerical.Conversions.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = NLogBuilder.ConfigureNLog("NLog.config").GetCurrentClassLogger();
            try
            {
                logger.Debug("Run DB migrations");
                using (var context = new ConversionsContext())
                {
                    context.Database.Migrate();
                }

                logger.Debug("Initialize server");
                GetWebHostBuilder(args).Build().Run();
            }
            catch (Exception e)
            {
                logger.Error(e, "Stopped program because of exception");
                throw;
            }
            finally
            {
                NLog.LogManager.Shutdown();
            }

            
        }

        private static IWebHostBuilder GetWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureLogging(logging =>
                {
                    logging.SetMinimumLevel(LogLevel.Trace);
                })
                .UseNLog();
    }
}
