using Exercicio01.Domain.Entity;
using Exercicio01.Infra.Data.SqlServer.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Exercicio01.Infra.Data.SqlServer.Contexts
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProfessionalConfiguration());
        }

        public DbSet<Professional>? Professionals { get; set; }
    }
}
