using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IbradnzMealBuilder.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data.Contract;
using IbradnzMealBuilder.Data.Implementation;
using IbradnzMealBuilder.Service.Contract;
using IbradnzMealBuilder.Service.Implementation;
using IbradnzMealBuilder.Utility;
using Microsoft.AspNetCore.Http.Features;
using Rotativa.AspNetCore;

namespace IbradnzMealBuilder
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            StaticConfig = configuration;
        }

        public IConfiguration Configuration { get; }
        public static IConfiguration StaticConfig { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddScoped<SignInManager<ApplicationUser>, SignInManager<ApplicationUser>>();
            services.AddScoped<UserManager<ApplicationUser>, UserManager<ApplicationUser>>();

            services.AddIdentity<ApplicationUser, ApplicationRole>(
                options => {
                    options.Stores.MaxLengthForKeys = 128;
                    options.User.RequireUniqueEmail = true;

                    //password validation
                    options.Password.RequireDigit = false;
                    options.Password.RequiredLength = 6;
                    options.Password.RequiredUniqueChars = 0;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnectionLocal")));

            //bool isProductionServer = bool.Parse(Configuration["General:IsProd"]);
            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(
            //        Configuration.GetConnectionString($"{(isProductionServer ? "DefaultConnection" : "DefaultConnectionLocal")}")));

            //services.AddDefaultIdentity<ApplicationUser>()    
            //    .AddDefaultUI(UIFramework.Bootstrap4)
            //    .AddEntityFrameworkStores<ApplicationDbContext>();


            services.AddScoped(serviceType: typeof(IUnitOfWork), implementationType: typeof(UnitOfWork));

            //repos
            services.AddScoped(serviceType: typeof(ICoreRepo<>), implementationType: typeof(CoreRepo<>));

            //services
            services.AddScoped(serviceType: typeof(ICustomerService), implementationType: typeof(CustomerService));
            services.AddScoped(serviceType: typeof(IMealTypeService), implementationType: typeof(MealTypeService));
            services.AddScoped(serviceType: typeof(IMealService), implementationType: typeof(MealService));
            services.AddScoped(serviceType: typeof(IMealBuilderService), implementationType: typeof(MealBuilderService));
            services.AddScoped(serviceType: typeof(ISubscriptionService), implementationType: typeof(SubscriptionService));
            services.AddScoped(serviceType: typeof(ITrainingVideoService), implementationType: typeof(TrainingVideoService));
            services.AddScoped(serviceType: typeof(IProfileImageService), implementationType: typeof(ProfileImageService));
            services.AddScoped(serviceType: typeof(ITechniqueVideoService), implementationType: typeof(TechniqueVideoService));
            services.AddScoped(serviceType: typeof(ILiveZoomService), implementationType: typeof(LiveZoomService));
            services.AddScoped(serviceType: typeof(ITrainingDayService), implementationType: typeof(TrainingDayService));
            services.AddScoped(serviceType: typeof(ICountryPhoneCodeService), implementationType: typeof(CountryPhoneCodeService));
            services.AddScoped(serviceType: typeof(IFaqService), implementationType: typeof(FaqService));
            services.AddScoped(serviceType: typeof(IProgramService), implementationType: typeof(ProgramService));
            services.AddScoped(serviceType: typeof(IMuscleGroupService), implementationType: typeof(MuscleGroupService));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.Configure<FormOptions>(x =>
            {
                x.ValueLengthLimit = int.MaxValue;
                x.MultipartBodyLengthLimit = int.MaxValue; // In case of multipart
            }); ;
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            services.AddMvcCore().AddDataAnnotations();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [Obsolete]
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            
            app.UseAuthentication();

           
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
            RotativaConfiguration.Setup(env);
        }
    }
}
