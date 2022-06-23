﻿using IdentityModel.Client;


Console.WriteLine("Press Enter to continue...");
Console.ReadLine();
var client = new HttpClient();
var disco = await client.GetDiscoveryDocumentAsync("https://localhost:7166/");

if (disco.IsError)
{
    Console.WriteLine(disco.Error);
    return;
}

var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
{
    Address = disco.TokenEndpoint,
    ClientId = "client",
    ClientSecret = "secret",
    Scope = "api1"
});

if (tokenResponse.IsError)
{
    Console.WriteLine(tokenResponse.Error);
    return;
}

Console.WriteLine(tokenResponse.Json);
Console.ReadLine();


///Call API
var apiClient = new HttpClient();
apiClient.SetBearerToken(tokenResponse.AccessToken);
var response = await apiClient.GetAsync("https://localhost:7166/");
if (!response.IsSuccessStatusCode)
{
    Console.WriteLine(response.StatusCode);
}
