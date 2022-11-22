using Exercicio01.Domain.Core.Interfaces;
using Exercicio01.Domain.Validators;
using FluentValidation.Results;

namespace Exercicio01.Domain.Entity
{
    public class Professional : IEntity
    {
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public Guid Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public ValidationResult Validate => new ProfessionalValidator().Validate(this);
    }
}
