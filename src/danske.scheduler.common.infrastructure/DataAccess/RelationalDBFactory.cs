using System;

namespace danske.scheduler.common.infrastructure.dataaccess
{
    public class RelationalDBFactory : IRelationalDBFactory
    {
        public IRelationalDB Create(string dbName)
        {
            throw new ArgumentException("dbName is invalid");
        }
    }
}
