using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using TravelAssist.Business.Business;
using TravelAssist.Core.Business_Interface;
using TravelAssist.Core.Repository_Interface;
using TravelAssist.Core.UnitOfWork_Inferface;
using TravelAssist.Data._Context;
using TravelAssist.Data._UnitOfWork;
using TravelAssist.Data.Repository;

namespace TravelAssist.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TravelDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddMvc()  //.SetCompatibilityVersion (CompatibilityVersion.Version_2_1)
                .AddJsonOptions(opt => opt
                    .SerializerSettings
                    .ReferenceLoopHandling = ReferenceLoopHandling.Ignore); // data get korar somoy lopping ignore korbe.


            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserBusiness, UserBusiness>();
            services.AddTransient<ISpotRepository, SpotRepository>();
            services.AddTransient<ISpotBusiness, SpotBusiness>();
            services.AddTransient<IFeedBackRepository, FeedBackRepository>();
            services.AddTransient<IFeedBackBusiness, FeedBackBusiness>();
            services.AddTransient<DbContext, TravelDbContext>();
        
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
