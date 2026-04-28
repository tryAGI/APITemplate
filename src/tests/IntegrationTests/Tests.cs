namespace APITemplate.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static APITemplateClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("APITEMPLATE_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("APITEMPLATE_API_KEY environment variable is not found.");

        var client = new APITemplateClient(apiKey);
        
        return client;
    }
}
