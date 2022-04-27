using System;
using System.Threading.Tasks;
using SimpleDtos;

namespace ModuleA
{
	public interface ISimpleDtosAppService
	{
		Task<Dto1> GetDto1Async();

		Task<Dto2> GetDto2Async();
	}
}

