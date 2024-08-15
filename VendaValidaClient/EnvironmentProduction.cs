namespace VendaValidaClient
{
    public class EnvironmentProduction : IEnvironment
    {
        public string GetUrl() => "https://customer-api.vendavalida.com.br";
    }
}
