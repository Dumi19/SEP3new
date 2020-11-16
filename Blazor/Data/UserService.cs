using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Blazor.Models;

namespace Blazor.Data
{
    public class UserService : IUserService
    {
        private readonly HttpClient client;

        public UserService()
        {
            client = new HttpClient();
        }


        public async Task<User> ValidateUserAsync(string username, string password)
        {
            HttpResponseMessage response = await client.GetAsync($"https://localhost:5001/Users?username={username}&password={password}");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string userAsJson = await response.Content.ReadAsStringAsync();
                User resultUser = JsonSerializer.Deserialize<User>(userAsJson);
                return resultUser;
            } 
            throw new Exception("User not found");
        }
    }
}