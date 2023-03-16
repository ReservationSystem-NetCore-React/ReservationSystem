using Application;
using Infrastructure;
using Infrastructure.Identity.Contexts;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<IdentityContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddApplication();
            builder.Services.AddInfrastructure();
            builder.Services.AddPersistence();
            
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", policy =>
                {
                    //todo change for production. In next build
                    policy.AllowAnyMethod().AllowAnyHeader().WithOrigins("*");
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
                app.UseSwagger();
                app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseCors("CorsPolicy");

            app.MapControllers();

            app.Run();
        }
    }
}