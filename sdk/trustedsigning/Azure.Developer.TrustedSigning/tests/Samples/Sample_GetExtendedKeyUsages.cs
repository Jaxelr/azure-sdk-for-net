// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Developer.TrustedSigning.Tests.Samples
{
    public partial class Sample_GetExtendedKeyUsages : SamplesBase<TrustedSigningClientTestEnvironment>
    {
        [Test]
        public void GetExtendedKeyUsages()
        {
            var endpoint = new Uri(TestEnvironment.Endpoint);
            string accountName = TestEnvironment.AccountName;
            string profileName = TestEnvironment.ProfileName;
            var credential = new DefaultAzureCredential();

            #region Snippet:Azure_Developer_TrustedSigning_GetExtendedKeyUsages
            var certificateProfileClient = new TrustedSigningClient(endpoint, credential).GetCertificateProfileClient();

            List<string> ekus = new();

            foreach (BinaryData item in certificateProfileClient.GetExtendedKeyUsages(accountName, profileName, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                string eku = result.GetProperty("eku").ToString();

                ekus.Add(eku);
            }
            #endregion Snippet:Azure_Developer_TrustedSigning_GetExtendedKeyUsages
        }
    }
}
