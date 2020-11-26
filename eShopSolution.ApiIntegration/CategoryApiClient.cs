﻿using eShopSolution.ApiIntegration;
using eShopSolution.ViewModel.Catalog.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eShopSolution.ApiIntegration
{
    public class CategoryApiClient : BaseApiClient, ICategoryApiClient
    {
        public CategoryApiClient(IHttpClientFactory httpClientFactory,
                  IHttpContextAccessor httpContextAccessor,
                   IConfiguration configuration)
           : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<List<CategoryVM>> GetAll(string languageId)
        {
            return await GetListAsync<CategoryVM>("/api/categories?languageId=" + languageId);
        }

        public async Task<CategoryVM> GetById(string languageId, int id)
        {
            return await GetAsync<CategoryVM>($"/api/categories/{id}/{languageId}");
        }
    }
}
