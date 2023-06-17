using Microsoft.EntityFrameworkCore;
using System;

namespace Tes3.Tes3.Infrastructure
{
    public static class InfrasturctureExtention
    {
        public static IServiceCollection RegisterDataBase(this IServiceCollection services)
        {
            var dbConnectionString = "User ID=postgres; Password=74epenaf; Host=localhost; Port=5432; Database=myDataBase;";
            services.AddDbContext<ApplicationContext>((ServiceProvider, options) =>
            {
                var currentAssemblyName = typeof(ApplicationContext).Assembly.FullName;
                options.UseNpgsql(
                    dbConnectionString,
                    b => b.MigrationsAssembly(currentAssemblyName));
            });
            return services;
        }

    }
}
