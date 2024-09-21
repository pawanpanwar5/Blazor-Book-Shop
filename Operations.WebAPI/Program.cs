
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Operations.WebAPI.Data;
using Operations.WebAPI.Utility;

namespace Operations.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<ApplicationDbContext>
                (options =>options.UseSqlServer
                    (builder.Configuration.GetConnectionString("DefaultConnection")
                    )
                );

            builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // one way to read object inside object in appsetting.json file ...below
            //var schoolSettings = new SchoolSettings();
            //builder.Configuration.GetSection("SchoolSettings").Bind(schoolSettings);
            //builder.Services.AddSingleton(schoolSettings);

            //another way for above process
            builder.Services.Configure<SchoolSettings>
                (builder.Configuration.GetSection("SchoolSettings"));


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
