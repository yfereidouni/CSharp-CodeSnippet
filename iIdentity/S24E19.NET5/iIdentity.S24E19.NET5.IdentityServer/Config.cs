using Duende.IdentityServer;
using Duende.IdentityServer.Models;
using System.Collections.Generic;

namespace iIdentity.S24E19.NET5.IdentityServer
{
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

                    RedirectUris = {"https://localhost:5001/sign-in-oidc"},
                    PostLogoutRedirectUris = { "https://localhost:5001/signout-callback-oidc"},

                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "api1"
                    }
                }
            };
    }
}
