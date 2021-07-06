using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace danske.scheduler.producer.test
{
    public class SchedulerControllerTest
    {
        public SchedulerControllerTest()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false)
                .Build();
        }

        [Fact]
        public async Task Create_Schedule_Succeded()
        {
            //arrange
            //act
            //assert
        }
    }
}
