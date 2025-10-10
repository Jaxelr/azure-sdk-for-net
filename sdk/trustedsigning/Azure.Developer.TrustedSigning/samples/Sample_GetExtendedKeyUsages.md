# # Azure.Developer.TrustedSigning samples - Get client extended key usages

To use these samples, you'll first need to set up resources. See [getting started](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/trustedsigning/Azure.Developer.TrustedSigning/README.md#getting-started) for details.

## Get customer extended key usages

The extended key usages are a piece of data used to describe the purpose of a certificate. This sample demonstrates how to get the available client extended key usages from a certificate profile.

```C# Snippet:Azure_Developer_TrustedSigning_GetExtendedKeyUsages
CertificateProfile certificateProfileClient = new TrustedSigningClient(region, credential).GetCertificateProfileClient();

List<string> ekus = new();

foreach (BinaryData item in certificateProfileClient.GetExtendedKeyUsages(accountName, profileName, null))
{
    JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
    string eku = result.GetProperty("eku").ToString();

    ekus.Add(eku);
}
```
