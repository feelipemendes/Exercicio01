using Exercicio01.Domain.Interfaces;
using Exercicio01.Infra.Data.SqlServer.Contexts;
using Exercicio01.Infra.Data.SqlServer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Exercicio01.Services.Api.Configuration
{
    public class RepositoryConfig
    {
        public static void AddRepositoryConfig(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

            var connectionString = builder.Configuration.GetConnectionString("BDExercicio01");

            builder.Services.AddDbContext<SqlServerContext>
                (options => options.UseSqlServer(connectionString));
        }
    }
}
