using Newtonsoft.Json;

namespace VendaValidaClient.Models
{
    public class ErrorResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
