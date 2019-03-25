using System.Net.Http;
using Chimerical.Conversions.Api.Services;
using Chimerical.Conversions.Dal.Dals.Auth;
using Chimerical.Conversions.Dal.Dals.Conversions;
using Chimerical.Conversions.Dal.Dals.Lists;
using Chimerical.Conversions.Db;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;
using SimpleInjector.Integration.AspNetCore.Mvc;
using SimpleInjector.Lifestyles;

namespace Chimerical.Conversions.Api
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddEnvironmentVariables()
                .AddJsonFile("appsettings.json")
                .Build();
        }

        private IConfiguration Configuration { get; }
        private Container _container = new Container();

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddEntityFrameworkSqlServer().AddDbContext<ConversionsContext>();

            IntegrateSimpleInjector(services);
        }

        private void IntegrateSimpleInjector(IServiceCollection services)
        {
            _container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            services.AddSingleton(Configuration);
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IControllerActivator>(new SimpleInjectorControllerActivator(_container));

            services.EnableSimpleInjectorCrossWiring(_container);
            services.UseSimpleInjectorAspNetRequestScoping(_container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            InitializeContainer(app);
            _container.Verify();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors(builder => builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .WithOrigins(Configuration["AllowedHosts"]));

            //            app.UseHttpsRedirection();
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });
            app.UseMvc();
        }

        private void InitializeContainer(IApplicationBuilder app)
        {
            _container.RegisterMvcControllers(app);

            _container.Register(() => new HttpClient(), Lifestyle.Singleton);

            #region DALs
            _container.Register<IIdentityProviderDal, IdentityProviderDal>();

            _container.Register<IUnitDal, UnitDal>();
            _container.Register<IUnitTypeDal, UnitTypeDal>();
            _container.Register<IConversionDal, ConversionDal>();

            _container.Register<IConverterListDal, ConverterListDal>();
            _container.Register<IConverterDal, ConverterDal>();
            _container.Register<IConverterIoDal, ConverterIoDal>();
            #endregion

            #region Services
            _container.Register<IConversionsService, ConversionsService>();
            _container.Register<IListsService, ListsService>();
            
            _container.Register<IIdentityProviderDiscoveryService, IdentityProviderDiscoveryService>(Lifestyle.Singleton);
            _container.Register<IAuthService, AuthService>();
            #endregion

            _container.AutoCrossWireAspNetComponents(app);
        }
    }
}
