using System.Net.Mime;
using System;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Api.Domain.Entities;
using Api.Data.Implementations;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Api.Domain.Repository;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplamentation>();

            serviceCollection.AddDbContext<MyContext>(
                options => options.UseSqlServer("Server=DSK-PRODA0284\\SQLEXPRESS2017;User Id=sa;Pwd=mudar@123;Database=course")
            );

            // serviceCollection.AddDbContext<MyContext>(
            // options => options.UseMySql("Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=mudar@123")
            // );
        }
    }
}
