using Microsoft.EntityFrameworkCore;
using MyBlog.Data;
using MyBlog.Data.Models.Articles;
using MyBlog.Data.Models.Comments;
using MyBlog.Data.Models.Roles;
using MyBlog.Data.Models.Tags;
using MyBlog.Data.Models.Users;
using MyBlog.Data.Repositories;
using MyBlog.Data.Repositories.Interfaces;

namespace MyBlog.App
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<BlogDbContext>(option => option.UseSqlServer(connectionString), ServiceLifetime.Singleton);

            builder.Services.AddSingleton<IRepository<Article>, ArticleRepository>();
            builder.Services.AddSingleton<IRepository<Comment>, CommentRepository>();
            builder.Services.AddSingleton<IRepository<Tag>, TagRepository>();
            builder.Services.AddSingleton<IRepository<User>, UserRepository>();

            builder.Services.AddIdentity<User, Role>(cfg =>
            {
                cfg.Password.RequiredLength = 8;
                cfg.Password.RequireNonAlphanumeric = false;
                cfg.Password.RequireUppercase = false;
                cfg.Password.RequireLowercase = false;
                cfg.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<BlogDbContext>();

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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}