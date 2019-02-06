using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using BasicCRUD_Operation_DesignPattern.BLL.Contracts;
using BasicCRUD_Operation_DesignPattern.BLL.Manager;
using BasicCRUD_Operation_DesignPattern.DbContext.ApplicationDbCOntext;
using BasicCRUD_Operation_DesignPattern.Repositories.Contracts;
using BasicCRUD_Operation_DesignPattern.Repositories.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http;

namespace BasicCRUD_Operation_DesignPattern.AppConfiguration
{
    public static class AppConfiguration
    {


        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

         
                services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ApplicationDbContext"),
               
                b=>b.MigrationsAssembly("BasicCRUD_Operation_DesignPattern.DbContext")));


            services.AddTransient<IDepartmentRepository,DepartmentRepository>();
            services.AddTransient<IDepartmentManager, DepartmentManager>();
            services.AddTransient<IStudentInfoRepository, StudentInfoRepository>();
            services.AddTransient<IStudentInfoManager, StudentInfoManager>();



            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
        }
    }
}
