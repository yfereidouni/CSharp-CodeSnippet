using Duende.IdentityServer;
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
            ,new Client
            {
                ClientId = "mvc",
                ClientSecrets = {new Secret ("secret".Sha256()) },

                AllowedGrantTypes= GrantTypes.Code,

                RedirectUris = {"https://localhost:5002/signin-oidc"},
                PostLogoutRedirectUris = { "https://localhost:5002/signout-callback-oidc"},

                AllowedScopes = new List<string>
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    "api1"
                }
            }
        };

    public static IEnumerable<IdentityResource> IdentityResources =>
    new List<IdentityResource>
    {
        new IdentityResources.OpenId(),
        new IdentityResources.Profile(),
    };
}
