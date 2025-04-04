// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Properties for a certificate stored in a Key Vault. </summary>
    public partial class ContainerAppCertificateKeyVaultProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppCertificateKeyVaultProperties"/>. </summary>
        public ContainerAppCertificateKeyVaultProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppCertificateKeyVaultProperties"/>. </summary>
        /// <param name="identity"> Resource ID of a managed identity to authenticate with Azure Key Vault, or System to use a system-assigned identity. </param>
        /// <param name="keyVaultUri"> URL pointing to the Azure Key Vault secret that holds the certificate. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppCertificateKeyVaultProperties(string identity, Uri keyVaultUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Identity = identity;
            KeyVaultUri = keyVaultUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource ID of a managed identity to authenticate with Azure Key Vault, or System to use a system-assigned identity. </summary>
        [WirePath("identity")]
        public string Identity { get; set; }
        /// <summary> URL pointing to the Azure Key Vault secret that holds the certificate. </summary>
        [WirePath("keyVaultUrl")]
        public Uri KeyVaultUri { get; set; }
    }
}
