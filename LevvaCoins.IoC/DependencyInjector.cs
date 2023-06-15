using LevvaCoins.Data;
using LevvaCoins.Data.Repositories;
using LevvaCoins.Domain.Interfaces;
using LevvaCoins.Logic.Interfaces;
using LevvaCoins.Logic.MapperProfiles;
using LevvaCoins.Logic.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevvaCoins.IoC
{
    public static class DependencyInjector
    {

        public static void AddNewbiesService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Context>(options => options.UseSqlite(configuration.GetConnectionString("Default"), b => b.MigrationsAssembly(typeof(Context).Assembly.FullName)));
            services.AddAutoMapper(typeof(DefaultMapper));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();


            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddScoped<ILoginService, LoginService>();


            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }
            ).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.Default.GetBytes(configuration.GetSection("Secret").Value)),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            services.AddCors(opt =>
            {
                opt.AddPolicy("AllowAnyOrigin", x =>
                {
                    x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });
        }

    }
}
