
using System.Threading.Tasks;
using SimpleDtos;

namespace ModuleA;

public class SimpleDtosAppService : ModuleAAppService, ISimpleDtosAppService
{
    public Task<Dto1> GetDto1Async()
    {
        throw new System.NotImplementedException();
    }

    public Task<Dto2> GetDto2Async()
    {
        throw new System.NotImplementedException();
    }
}