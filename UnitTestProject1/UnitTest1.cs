using System;
using System.Linq;
using GrainInterfaces1;
using Xunit;

namespace UnitTestProject1
{
    public class UnitTest1 : Orleans.TestingHost.TestingSiloHost
    {
        [Fact]
        public async void TestMethod1()
        {
            const long id = 0;

            var grain = GrainFactory.GetGrain<IGrain1>(id);

            // This will create and call a Hello grain with specified 'id' in one of the test silos.
            var reply = await grain.SayHello();

        }
    }
}
