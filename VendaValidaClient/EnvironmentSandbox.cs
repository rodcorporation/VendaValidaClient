namespace VendaValidaClient
{
    public class EnvironmentSandbox : IEnvironment
    {
        public string GetUrl() => "https://vv-unified-customer-api-stage-16580ef186c3.herokuapp.com";
    }
}
