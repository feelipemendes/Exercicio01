using Microsoft.EntityFrameworkCore.Design;

namespace Exercicio01.Infra.Data.SqlServer.Contexts
{
    public class SqlServerContextFactory : IDesignTimeDbContextFactory<SqlServerContext>
    {
        public SqlServerContext CreateDbContext(string[] args)
        {
            return null;
        }
    }
}
