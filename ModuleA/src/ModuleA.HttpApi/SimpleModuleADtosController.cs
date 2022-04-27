using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using SimpleDtos;

namespace ModuleA;

[RemoteService(Name = "ModuleA")]
[Area("modulea")]
[Route("api/simple-dto/module-a")]
public class SimpleModuleADtosController : ModuleAController, ISimpleModuleADtosAppService
{
    protected ISimpleModuleADtosAppService AppService;

    public SimpleModuleADtosController(ISimpleModuleADtosAppService appService)
    {
        AppService = appService;
    }

    [HttpGet]
    [Route("dto1")]
    public Task<Dto1> GetDto1Async()
    {
        return AppService.GetDto1Async();
    }

    [HttpGet]
    [Route("dto2")]
    public Task<Dto2> GetDto2Async()
    {
        return AppService.GetDto2Async();
    }
}