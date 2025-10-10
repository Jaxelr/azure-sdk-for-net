// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Developer.TrustedSigning.Tests.Samples
{
    public partial class DeveloperTrustedSigningSample : SamplesBase<TrustedSigningClientTestEnvironment>
    {
        [Test]
        public void CreateClients(Uri endpoint)
        {
            #region Snippet:Azure_Developer_TrustedSigning_CreateCertificateProfileClient

            var credential = new DefaultAzureCredential();
            var certificateProfileClient = new TrustedSigningClient(endpoint, credential).GetCertificateProfileClient();

            #endregion Snippet:Azure_Developer_TrustedSigning_CreateCertificateProfileClient
        }
    }
}
