// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Developer.TrustedSigning.Tests.Samples
{
    public partial class Sample_Sign : SamplesBase<TrustedSigningClientTestEnvironment>
    {
        [Test]
        public void Sign()
        {
            var endpoint = new Uri(TestEnvironment.Endpoint);
            string accountName = TestEnvironment.AccountName;
            string profileName = TestEnvironment.ProfileName;
            var credential = new DefaultAzureCredential();

            const string signatureAlgorithm = "RS256";

            byte[] digest = new byte[32];
            var random = new Random();
            random.NextBytes(digest);

            #region Snippet:Azure_Developer_TrustedSigning_SigningBytes
            var certificateProfileClient = new TrustedSigningClient(endpoint, credential).GetCertificateProfileClient();

            using RequestContent content = RequestContent.Create(new
            {
                signatureAlgorithm,
                digest,
            });

            Operation<BinaryData> operation = certificateProfileClient.Sign(WaitUntil.Completed, accountName, profileName, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            #endregion Snippet:Azure_Developer_TrustedSigning_SigningBytes
        }
    }
}
