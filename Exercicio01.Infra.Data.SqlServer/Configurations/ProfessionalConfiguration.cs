using Exercicio01.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exercicio01.Infra.Data.SqlServer.Configurations
{
    public class ProfessionalConfiguration : IEntityTypeConfiguration<Professional>
    {
        public void Configure(EntityTypeBuilder<Professional> builder)
        {
            builder.HasIndex(c => c.Cpf).IsUnique();
            builder.HasIndex(c => c.Telefone).IsUnique();
            builder.HasIndex(c => c.Email).IsUnique();
        }
    }
}
