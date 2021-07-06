namespace danske.scheduler.common.infrastructure.dataaccess
{
    public interface IDBFactory
    {
        INoSQLDB CreateNoSQLDB(string dbName);
        IRelationalDB CreateRelationalDB(string dbName);
    }
}
