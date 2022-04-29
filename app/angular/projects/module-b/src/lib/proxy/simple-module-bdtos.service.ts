import type { Dto3 } from './simple-dtos/models';
import { RestService } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class SimpleModuleBDtosService {
  apiName = 'ModuleB';

  getDto3 = () =>
    this.restService.request<any, Dto3>({
      method: 'GET',
      url: '/api/simple-dto/module-b/dto3',
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
