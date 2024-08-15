using Newtonsoft.Json;

namespace VendaValidaClient.Models
{
    public class MessageResponse
    {
        [JsonProperty("valid")]
        public bool Valid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
