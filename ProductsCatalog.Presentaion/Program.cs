using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using ProductsCatalog.Application.Services.Category;
using ProductsCatalog.Application.Services.Product;
using ProductsCatalog.Application.Services.Product_Image;
using ProductsCatalog.Application.Services.Products_Logs;
using ProductsCatalog.Domain;
using ProductsCatalog.Infrastructure;
using ProductsCatalog.Infrastructure.Data.Context;
using ProductsCatalog.Infrastructure.Data.Repositories;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace ProductsCatalog.Presentaion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services
                .AddDbContext<ApplicationDBContext>(options => options
                .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));

            #region Registering Repositories / Services

            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
            builder.Services.AddScoped<IProductUpdateLogsRepository, ProductupdateLogsRepository>();
            builder.Services.AddScoped<IProductImageRepository, ProductImageRepository>();

            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<IProductLogsService, ProductLogsService>();
            builder.Services.AddScoped<IProductImgeService, ProductImgeService>();

            #endregion

            #region To Configure Authentication

            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                // Configure other options as needed
            })
            .AddEntityFrameworkStores<ApplicationDBContext>()
            .AddDefaultTokenProviders();

            builder.Services.AddSession();

            #endregion

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("MyAppOnly", policy =>
                {
                    policy.WithOrigins("http://localhost:5242/")
                          .AllowCredentials()
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
            });

            var app = builder.Build();

            app.UseCors("MyAppOnly");

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseSession();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
