namespace danske.scheduler.common.infrastructure.dataaccess
{
    public class DBFactory : IDBFactory
    {
        public INoSQLDB CreateNoSQLDB(string dbName)
        {
            NoSQLDBFactory factory = new NoSQLDBFactory();

            return factory.Create(dbName);
        }

        public IRelationalDB CreateRelationalDB(string dbName)
        {
            RelationalDBFactory factory = new RelationalDBFactory();

            return factory.Create(dbName);
        }
    }
}
