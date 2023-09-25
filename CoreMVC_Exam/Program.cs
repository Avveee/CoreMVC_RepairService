using CoreMVC_Exam.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using CoreMVC_Exam.Services;

namespace CoreMVC_Exam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'ApplicationDBContextConnection' not found.");

            builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(
                    option =>
                    {
                        option.Password.RequireDigit = false;
                        option.Password.RequiredLength = 6;
                        option.Password.RequireNonAlphanumeric = false;
                        option.Password.RequireUppercase = false;
                        option.Password.RequireLowercase = false;
                    }
                ).AddEntityFrameworkStores<ApplicationContext>()
            .AddDefaultTokenProviders();



            builder.Services.AddTransient<IEmailSender, EmailSender>();

            // указание адреса страниц login, logout, accessdenied для сайта, нужно для правильной работы [Authorize]
            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
                options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
            });

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("ClaimPolicy", policy =>
                {
                    policy.RequireClaim("Position", "Admin");
                    policy.RequireRole("Admin");
                });
            });

            builder.Services.AddRazorPages();

            builder.Services.AddMvc().AddRazorPagesOptions(options =>
            {
                options.Conventions.AuthorizeAreaFolder("Identity", "/Account/Manage");
                options.Conventions.AuthorizeAreaPage("Identity", "/Account/Logout");
            });

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseStatusCodePages(async context =>
            {
                var response = context.HttpContext.Response;

                if (response.StatusCode == (int)HttpStatusCode.Unauthorized ||
                    response.StatusCode == (int)HttpStatusCode.Forbidden)
                    response.Redirect("/Authentication");
            });

            app.MapRazorPages();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}