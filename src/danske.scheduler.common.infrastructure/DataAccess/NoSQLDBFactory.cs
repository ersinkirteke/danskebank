using System;

namespace danske.scheduler.common.infrastructure.dataaccess
{
    public class NoSQLDBFactory : INoSQLDBFactory
    {
        public INoSQLDB Create(string dbName)
        {
            throw new ArgumentException("dbName is invalid");
        }
    }
}
