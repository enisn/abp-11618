using System.Threading.Tasks;
using SimpleDtos;
using Volo.Abp.Application.Services;

namespace ModuleB;

public interface ISimpleDtoModuleBAppService : IApplicationService
{
    Task<Dto3> GetDto3Async();
}