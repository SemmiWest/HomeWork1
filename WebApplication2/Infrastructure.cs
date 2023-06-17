using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace WebApplication2
{
    public static class Infrastructure
    {
        public static IServiceCollection RegisterDataBase(this IServiceCollection services)
        {// запасная строка "host=localhost; port=5432; dbname=postgres; user=postgres; password=74epenaf;"
            var dbConnectionString = "User ID=postgres; Password=74epenaf; Host=localhost; Port=5432; Database=AnimalbDb;";
             services.AddDbContext<AppDbContext>((serviceProvider, options)=>
             {
                 var currentAssemblyName = typeof(AppDbContext).Assembly.FullName;
                 options.UseNpgsql(
                     dbConnectionString, b => b.MigrationsAssembly(currentAssemblyName));
             });
            return services;
        }
    }
}
