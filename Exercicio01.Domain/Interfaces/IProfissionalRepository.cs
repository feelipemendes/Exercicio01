using Exercicio01.Domain.Core.Interfaces;
using Exercicio01.Domain.Entity;

namespace Exercicio01.Domain.Interfaces
{
    public interface IProfissionalRepository : IRepository<Professional, Guid>
    {
        Professional GetByCpf(string cpf);
        Professional GetByTelefone(string telefone);
        Professional GetByEmail(string email);
    }
}
