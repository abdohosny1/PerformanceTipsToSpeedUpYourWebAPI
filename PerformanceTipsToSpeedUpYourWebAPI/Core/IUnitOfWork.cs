


namespace MyPerformanceTipsToSpeedUpYourWebAPI.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Employee> Employees { get; }

        int Complete();
    }
}
