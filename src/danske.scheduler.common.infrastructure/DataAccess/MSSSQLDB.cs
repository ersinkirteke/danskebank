using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danske.scheduler.common.infrastructure.dataaccess
{
    public class MSSSQLDB : IMSSSQLDB
    {
        private readonly IConfiguration _configuration;

        public MSSSQLDB(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnection()
        {
            return _configuration.GetConnectionString("DBConnection");
        }
    }
}
