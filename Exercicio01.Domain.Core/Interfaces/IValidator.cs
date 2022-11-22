using FluentValidation.Results;

namespace Exercicio01.Domain.Core.Interfaces
{
    public interface IValidator
    {
        ValidationResult Validate { get; }
    }
}
