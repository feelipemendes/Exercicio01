namespace Exercicio01.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();

        #region Repositorios

        public IProfissionalRepository ProfissionalRepository { get; }

        #endregion
    }
}
