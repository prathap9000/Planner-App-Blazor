﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AKSoftware.WebApi;
using AKSoftware.WebApi.Client;
using PlannerApp.Shared.Models;

namespace PlannerApp.Shared.Services
{
    public class AuthenticationService
    {
        private readonly string _baseUrl;
        ServiceClient client = new ServiceClient();
        public AuthenticationService(string url)
        {
            _baseUrl = url;
        }
        public async Task<UserManagerResponse> RegisterAsync(RegisterRequest request)
        {
            var response = await client.PostAsync<UserManagerResponse>($"{_baseUrl}/api/auth/register", request);
            return response.Result;
        }
        public async Task<UserManagerResponse> LoginAsync(LoginRequest request)
        {
            var response = await client.PostAsync<UserManagerResponse>($"{_baseUrl}/api/auth/login", request);
            return response.Result;
        }
    }
}
