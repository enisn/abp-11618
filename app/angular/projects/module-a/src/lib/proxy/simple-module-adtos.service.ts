import type { Dto1, Dto2 } from './simple-dtos/models';
import { RestService } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class SimpleModuleADtosService {
  apiName = 'ModuleA';

  getDto1 = () =>
    this.restService.request<any, Dto1>({
      method: 'GET',
      url: '/api/simple-dto/module-a/dto1',
    },
    { apiName: this.apiName });

  getDto2 = () =>
    this.restService.request<any, Dto2>({
      method: 'GET',
      url: '/api/simple-dto/module-a/dto2',
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
