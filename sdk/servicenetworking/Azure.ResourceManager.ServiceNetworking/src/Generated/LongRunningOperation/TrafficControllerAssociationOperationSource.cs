// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ServiceNetworking
{
    internal class TrafficControllerAssociationOperationSource : IOperationSource<TrafficControllerAssociationResource>
    {
        private readonly ArmClient _client;

        internal TrafficControllerAssociationOperationSource(ArmClient client)
        {
            _client = client;
        }

        TrafficControllerAssociationResource IOperationSource<TrafficControllerAssociationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = TrafficControllerAssociationData.DeserializeTrafficControllerAssociationData(document.RootElement);
            return new TrafficControllerAssociationResource(_client, data);
        }

        async ValueTask<TrafficControllerAssociationResource> IOperationSource<TrafficControllerAssociationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = TrafficControllerAssociationData.DeserializeTrafficControllerAssociationData(document.RootElement);
            return new TrafficControllerAssociationResource(_client, data);
        }
    }
}
