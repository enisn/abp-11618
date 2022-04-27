using System.Threading.Tasks;
using SimpleDtos;
using System;

namespace ModuleB;

public class SimpleDtoModuleBAppService : ModuleBAppService, ISimpleDtoModuleBAppService
{
    public Task<Dto3> GetDto3Async()
    {
        throw new NotImplementedException();
    }
}