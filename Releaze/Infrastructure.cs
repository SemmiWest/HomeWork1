using Microsoft.EntityFrameworkCore;
using Releaze.Entityes;

namespace Releaze
{
    public static class Infrastructure
    {
        public static IServiceCollection RegisterDataBase(this IServiceCollection services) 
        {
            var dbCOnnectionString = $"host=localhost; port=5432; dbname=postgres ;user=postgres ;password=74epenaf ;sslmode=prefer ;connect_timeout=10";
            services.AddDbContext<AppDbContext>((serviceProvaider, options) =>
            {
                var currentAssemblyName = typeof(AppDbContext).Assembly.FullName;
                options.UseNpgsql(
                    dbCOnnectionString,
                    b => b.MigrationsAssembly(currentAssemblyName)
                    );
            });
            return services;
        }
    }
}
