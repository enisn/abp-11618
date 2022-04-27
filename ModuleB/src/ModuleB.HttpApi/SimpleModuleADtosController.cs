using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using SimpleDtos;

namespace ModuleB;

[RemoteService(Name = "ModuleB")]
[Area("moduleb")]
[Route("api/simple-dto/module-b")]
public class SimpleModuleBDtosController : ModuleBController, ISimpleDtoModuleBAppService
{
    protected ISimpleDtoModuleBAppService AppService;

    public SimpleModuleBDtosController(ISimpleDtoModuleBAppService appService)
    {
        AppService = appService;
    }

    [HttpGet]
    [Route("dto3")]
    public Task<Dto3> GetDto3Async()
    {
        return AppService.GetDto3Async();
    }
}