
namespace danske.scheduler.common.infrastructure.dataaccess
{
    public interface INoSQLDBFactory
    {
        INoSQLDB Create(string dbName);
    }
}
