using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using BasicCRUD_Operation_DesignPattern.DbContext.ApplicationDbCOntext;
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

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ApplicationDbContext")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }
    }
}
