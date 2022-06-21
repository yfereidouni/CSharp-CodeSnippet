using Duende.IdentityServer.Models;

namespace iIdentity.S24E19.IdentityServer;

public static class Config
{
    public static IEnumerable<ApiScope> ApiScopes =>
        new List<ApiScope>
        {
            new ApiScope("api1","First API")
        };

    public static IEnumerable<Client> Clients =>
        new List<Client>
        {
            new Client
            {
                ClientId="client",
                ClientSecrets ={new Secret("secret".Sha256())},
                AllowedScopes = {"api1"},
                AllowedGrantTypes = GrantTypes.ClientCredentials
            }
        };
}
