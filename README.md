[![](https://img.shields.io/nuget/v/soenneker.plaid.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.plaid.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.plaid.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.plaid.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.plaid.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.plaid.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.plaid.httpclients/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.plaid.httpclients/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Plaid.HttpClients

Provides a cached `HttpClient` with the credentials and environment URL required by Plaid's API.

## Installation

```bash
dotnet add package Soenneker.Plaid.HttpClients
```

## Configuration

```json
{
  "Plaid": {
    "ClientId": "your-client-id",
    "Secret": "your-secret",
    "ClientBaseUrl": "https://sandbox.plaid.com"
  }
}
```

Use `https://sandbox.plaid.com`, `https://development.plaid.com`, or `https://production.plaid.com` for the matching Plaid environment. `Plaid:ApiKey` remains a compatibility fallback for `Plaid:Secret`.

## Usage

```csharp
using Soenneker.Plaid.HttpClients.Abstract;
using Soenneker.Plaid.HttpClients.Registrars;

services.AddPlaidOpenApiHttpClientAsSingleton();

IPlaidOpenApiHttpClient plaid = serviceProvider
    .GetRequiredService<IPlaidOpenApiHttpClient>();

HttpClient client = await plaid.Get(cancellationToken);
```

The client sends `PLAID-CLIENT-ID` and `PLAID-SECRET` on each request. The provider owns the cached client and removes it when disposed; scoped provider instances use separate cache entries.
