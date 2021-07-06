
namespace danske.scheduler.common.infrastructure.dataaccess
{
    public interface IRelationalDBFactory
    {
        IRelationalDB Create(string dbName);
    }
}
