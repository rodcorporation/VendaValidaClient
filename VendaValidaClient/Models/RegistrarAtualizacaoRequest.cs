using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VendaValidaClient.Models
{
    public class RegistrarAtualizacaoRequest
    {
        [JsonProperty("businessId")]
        public string BusinessId { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; } = "db_history";

        [JsonProperty("users")]
        public IList<RegistrarAtualizacaoClienteRequest> Users { get; set; }

        public RegistrarAtualizacaoRequest()
        {
            Users = new List<RegistrarAtualizacaoClienteRequest>();
        }

        public class RegistrarAtualizacaoClienteRequest
        {
            [JsonProperty("birthdayDate")]
            public string BirthdayDate { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("customerDocument")]
            public string CustomerDocument { get; set; }

            [JsonProperty("phone")]
            public string Phone { get; set; }

            [JsonProperty("email")]
            public string Email { get; set; }

            [JsonProperty("order")]
            public RegistrarAtualizacaoPedidoRequest Order { get; set; }
        }

        public class RegistrarAtualizacaoPedidoRequest
        {
            [JsonProperty("Id")]
            public string Id { get; set; }

            [JsonProperty("createdAt")]
            public DateTime CreatedAt { get; set; }

            [JsonProperty("amount")]
            public float Amount { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("paymentMethod")]
            public string PaymentMethod { get; set; }

            [JsonProperty("link")]
            public string Link { get; set; }

            [JsonProperty("code")]
            public string Code { get; set; }

            [JsonProperty("products")]
            public IList<RegistrarAtualizacaoProdutoRequest> Products { get; set; }

            public RegistrarAtualizacaoPedidoRequest()
            {
                Products = new List<RegistrarAtualizacaoProdutoRequest>();
            }
        }

        public class RegistrarAtualizacaoProdutoRequest
        {
            [JsonProperty("sku")]
            public string Sku { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("quantity")]
            public int Quantity { get; set; }

            [JsonProperty("amount")]
            public float Amount { get; set; }

            [JsonProperty("image")]
            public string ImageUrl { get; set; }

            [JsonProperty("category")]
            public string Category { get; set; }
        }
    }
}
