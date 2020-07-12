using CQRSAndMediatr.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSAndMediatr.Services.Api.Configurations
{
    public static class DatabaseSetup
    {
        public static void AddDatabaseSetup(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CqrsMediatrDBContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        }
    }
}
