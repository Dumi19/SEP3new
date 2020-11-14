using System.Text.Json.Serialization;

namespace Blazor.Models
{
    public class User
    {
        [JsonPropertyName("username")]
        public string UserName { set; get; }
        [JsonPropertyName("password")]
        public string Password { set; get; }
    }
}