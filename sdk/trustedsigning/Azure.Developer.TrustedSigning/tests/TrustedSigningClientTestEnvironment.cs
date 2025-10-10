// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.Developer.TrustedSigning.Tests
{
    public class TrustedSigningClientTestEnvironment : TestEnvironment
    {
        public string Endpoint => GetRecordedVariable("TrustedSigning_ENDPOINT");
        public string AccountName => GetRecordedVariable("TrustedSigning_ACCOUNT_NAME");
        public string ProfileName => GetRecordedVariable("TrustedSigning_PROFILE_NAME");
    }
}
