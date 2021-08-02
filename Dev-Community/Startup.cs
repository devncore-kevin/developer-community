using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Dev_Community.Data;

namespace Dev_Community
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();

            services.AddTransient<IBoardService, BoardService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
        
                //public void ConfigureServices(IServiceCollection services)
        //{
        //    var serverVersion = new MariaDbServerVersion(new Version(10, 0, 16));

        //    services.AddDbContext<EtoosContext>(options =>
        //          options.UseLazyLoadingProxies()
        //          .UseMySql(Configuration.GetConnectionString("etoos"), serverVersion)); 

        //    services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
        //            .AddRoles<NewUserRole>()
        //            .AddEntityFrameworkStores<EtoosContext>();  

        //    services.Configure<IdentityOptions>(options =>
        //    {
        //        //previous code removed for clarity reasons
        //        options.Lockout.AllowedForNewUsers = true;
        //        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(550);
        //        options.Lockout.MaxFailedAccessAttempts = 5;
        //    });


        //    services.AddCors(options =>
        //    {              
        //        options.AddDefaultPolicy(builder =>
        //        {
        //            builder
        //                .WithOrigins(new string[]
        //                {
        //                    "https://34.64.71.30",
        //                    "https://centervr.storage.googleapis.com"
        //                });
        //        });
        //    });

        //    //services.AddDefaultIdentity<UserInfo>(options => options.SignIn.RequireConfirmedAccount = true)
        //    //    .AddEntityFrameworkStores<EtoosContext>();

        //    services.AddAuthentication()
        //            .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme);

        //    services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<User>>();

        //    services.AddSyncfusionBlazor();
        //    services.AddRazorPages();
        //    services.AddServerSideBlazor();

        //    services.AddTransient<IFileUploadService, GoogleUploadService>();
        //    services.AddSingleton<DragAndDropService>();

        //    //DBService
        //    AddTransient(services);
        //    //로그
        //    SerilogConfig(services);            
        //}

        //public void AddTransient(IServiceCollection services)
        //{
        //    services.AddTransient<ISvcCdService, SvcCdService>();
        //    services.AddTransient<ILectureService, LectureService>();
        //    services.AddTransient<IExamService, ExamService>();
        //    services.AddTransient<IStadiumService, StadiumService>();
        //    services.AddTransient<IExamResultService, ExamResultService>();
        //    services.AddTransient<IRoomService, RoomService>();
        //    services.AddTransient<IPlaceService, PlaceService>();
        //    services.AddTransient<IRoomTemplateService, RoomTemplateService>();
        //    services.AddTransient<IQtalkService, QtalkService>();
        //    services.AddTransient<IPlaceRoomService, PlaceRoomService>();
        //    services.AddTransient<IUserFileService, UserFileDBService>();
        //    services.AddTransient<ICategoryService, CategoryService>();
        //    services.AddTransient<IRoomReservationService, RoomReservationService>();
        //    services.AddTransient<IUserInfoService, UserInfoService>();
        //    services.AddTransient<IRoomDetailService, RoomDetailService>();
        //    services.AddTransient<IRoomQuestionService, RoomQuestionService>();
        //    services.AddTransient<IQtalkNoticeService, QtalkNoticeService>();
        //}
        
        
            //public interface IDBService<T>
    //{
    //    Task<T> Get(string ID);
    //    Task<T> Add(T item);
    //    Task<T> Remove(T item);
    //    Task<T> Update(T item);        
    //    Task<List<T>> GetAll();
    //}

    //public class DBServiceClass
    //{
    //    protected readonly EtoosContext context;
    //    protected DBServiceClass(EtoosContext _context)
    //    {
    //        context = _context;
    //   }      
    //}
    }
}
