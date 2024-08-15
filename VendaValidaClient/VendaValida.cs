using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using VendaValidaClient.Models;

namespace VendaValidaClient
{
    public sealed class VendaValida
    {
        private readonly Credential _credential;
        private readonly IEnvironment _environment;
        private readonly HttpClient _httpClient;

        public string BusinessId => _credential.BusinessId;

        public VendaValida(Credential credential,
                        IEnvironment environment)
        {
            _credential = credential;
            _environment = environment;

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_environment.GetUrl()),
            };
        }

        public ApiResponse<RegistrarAtualizacaoResponse> RegistrarAtualizacao(RegistrarAtualizacaoRequest request)
        {
            var content = new StringContent(JsonConvert.SerializeObject(request));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var client = new HttpClient
            {
                BaseAddress = new Uri(_environment.GetUrl()),
            };

            client.DefaultRequestHeaders.Add("api-key", _credential.ApiKey);

            var response = client.PostAsync($"/api/v1/customer", content).Result;

            if (!response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                    throw new Exception(JsonConvert.DeserializeObject<ErrorResponse>(response.Content.ReadAsStringAsync().Result).Message);

                return new ApiResponse<RegistrarAtualizacaoResponse>(JsonConvert.DeserializeObject<MessageResponse>(response.Content.ReadAsStringAsync().Result));
            }

            return new ApiResponse<RegistrarAtualizacaoResponse>(JsonConvert.DeserializeObject<RegistrarAtualizacaoResponse>(response.Content.ReadAsStringAsync().Result));
        }
    }
}
