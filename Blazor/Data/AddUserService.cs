using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Blazor.Models;

namespace Blazor.Data
{
    public class AddUserService : IAddUserService
    {
        private string uri = "https://localhost:5001";
        private readonly HttpClient client;

        public AddUserService()
        {
            client = new HttpClient();
        }


        public async Task<List<User>> GetUserAsync()
        {
            Task<string> stringAsync = client.GetStringAsync(uri+"/Users");
            string message = await stringAsync;
            List<User> result = JsonSerializer.Deserialize<List<User>>(message);
            return result;
        }
    }
}