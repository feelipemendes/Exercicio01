using Exercicio01.Domain.Entity;
using Exercicio01.Domain.Interfaces;
using Exercicio01.Infra.Data.SqlServer.Contexts;

namespace Exercicio01.Infra.Data.SqlServer.Repositories
{
    public class ProfessionalRepository : BaseRepository<Professional, Guid>, IProfissionalRepository
    {
        private readonly SqlServerContext _sqlServerContext;

        public ProfessionalRepository(SqlServerContext sqlServerContext)
            : base(sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }

        public Task CreateAsync(Professional entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Professional entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<List<Professional>> GetAllAsync(int page, int limit)
        {
            throw new NotImplementedException();
        }

        public Professional GetByCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public Professional GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<Professional> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Professional GetByTelefone(string telefone)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Professional entity)
        {
            throw new NotImplementedException();
        }
    }
}
