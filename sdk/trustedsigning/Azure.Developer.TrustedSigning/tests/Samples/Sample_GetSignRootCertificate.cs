// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Developer.TrustedSigning.Tests.Samples
{
    public partial class Sample_GetSignRootCertificate : SamplesBase<TrustedSigningClientTestEnvironment>
    {
        [Test]
        public void GetSignRootCertificate()
        {
            var endpoint = new Uri(TestEnvironment.Endpoint);
            string accountName = TestEnvironment.AccountName;
            string profileName = TestEnvironment.ProfileName;
            var credential = new DefaultAzureCredential();

            #region Snippet:Azure_Developer_TrustedSigning_GetSignRootCertificate
            var certificateProfileClient = new TrustedSigningClient(endpoint, credential).GetCertificateProfileClient();

            Response<BinaryData> response = certificateProfileClient.GetSignRootCertificate(accountName, profileName);

            byte[] rootCertificate = response.Value.ToArray();
            #endregion Snippet:Azure_Developer_TrustedSigning_GetSignRootCertificate
        }
    }
}
