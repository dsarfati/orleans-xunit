using System.Threading.Tasks;
using GrainInterfaces1;
using Orleans;

namespace Grains1
{
    /// <summary>
    /// Grain implementation class Grain1.
    /// </summary>
    public class Grain1 : Grain, IGrain1
    {
        public Task<string> SayHello()
        {
            return Task.FromResult("Hello World!");
        }
    }
}
