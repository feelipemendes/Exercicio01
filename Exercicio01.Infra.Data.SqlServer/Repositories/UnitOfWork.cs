using Exercicio01.Domain.Interfaces;
using Exercicio01.Infra.Data.SqlServer.Contexts;
using Microsoft.EntityFrameworkCore.Storage;

namespace Exercicio01.Infra.Data.SqlServer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SqlServerContext _sqlServerContext;
        private IDbContextTransaction _dbContextTransaction;

        public UnitOfWork(SqlServerContext sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }

        public IProfissionalRepository ProfissionalRepository => new ProfessionalRepository(_sqlServerContext);

        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void CommitTransaction()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void RollbackTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
