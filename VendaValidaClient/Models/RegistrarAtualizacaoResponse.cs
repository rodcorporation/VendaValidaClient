using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VendaValidaClient.Models
{
    public class RegistrarAtualizacaoResponse
    {
        [JsonProperty("valid")]
        public bool Valid { get; set; }
        
        [JsonProperty("invalidUsers")] 
        public IList<int> InvalidUsers { get; set; }        
    }
}
