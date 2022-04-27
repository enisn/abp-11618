using System;
using System.Threading.Tasks;
using SimpleDtos;
using Volo.Abp.Application.Services;

namespace ModuleA
{
	public interface ISimpleDtosAppService : IApplicationService
	{
		Task<Dto1> GetDto1Async();

		Task<Dto2> GetDto2Async();
	}
}

