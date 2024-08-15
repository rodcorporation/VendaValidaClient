using Newtonsoft.Json;
using VendaValidaClient.Models;

namespace VendaValidaClient
{
    public class ApiResponse<T> where T : class
    {
        public T Response { get; private set; }
        public MessageResponse Error { get; private set; }
        public bool IsSuccess => Error == null;

        public ApiResponse(string response)
        {
            Response = JsonConvert.DeserializeObject<T>(response);
        }

        public ApiResponse(T response)
        {
            Response = response;
        }

        public ApiResponse(MessageResponse error)
        {
            Error = error;
        }
    }
}
