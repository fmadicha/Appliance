namespace Appliance.Repository.IRepository
{
    public interface IUnitOfWork:IDisposable
    {
        IProductRepository Products { get; }
        IOrderRepository Orders { get; }

        int Complete();
    }
}
