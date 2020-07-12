using CQRSAndMediatr.Domain.Handlers.QueryHandlers;
using CQRSAndMediatr.Domain.Interfaces.ICommandHandlers;
using CQRSAndMediatr.Domain.Interfaces.IQueryHandlers;
using CQRSAndMediatr.Infra.Data.Interfaces;
using CQRSAndMediatr.Infra.Data.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CQRSAndMediatr.Services.Api.Configurations
{
    public static class DependencyInjectionSetup
    {
        public static void AddDependencyInjectionSetup(this IServiceCollection services)
        {
            //// Infra - Data
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped(typeof(ICoursetRepository), typeof(CourseRepository));

            //// Mediatr
            services.AddMediatR(typeof(ICreateNewCourseCommandHandler).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(IGetCourseByIdQueryHandler).GetTypeInfo().Assembly);

        }
    }
}
