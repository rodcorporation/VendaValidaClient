namespace VendaValidaClient
{
    public class Credential
    {
        public string BusinessId { get; internal set; }

        public string ApiKey { get; internal set; }

        public Credential(string businessId,
                          string apiKey)
        {
            BusinessId = businessId;
            ApiKey = apiKey;
        }
    }
}
