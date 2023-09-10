using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DataContext>(options => {
                    options.UseSqlite(config.GetConnectionString("DefaultConnection"));    
                });
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddCors();
            services.AddScoped<ITokenService, TokenService>();  
            services.AddScoped<IUserRepository, UserRepository>();  
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
                              
           return services;
        }
    }
}