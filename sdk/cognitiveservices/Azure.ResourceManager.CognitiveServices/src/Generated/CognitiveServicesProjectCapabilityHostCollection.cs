// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.CognitiveServices
{
    /// <summary>
    /// A class representing a collection of <see cref="CognitiveServicesProjectCapabilityHostResource"/> and their operations.
    /// Each <see cref="CognitiveServicesProjectCapabilityHostResource"/> in the collection will belong to the same instance of <see cref="CognitiveServicesProjectResource"/>.
    /// To get a <see cref="CognitiveServicesProjectCapabilityHostCollection"/> instance call the GetCognitiveServicesProjectCapabilityHosts method from an instance of <see cref="CognitiveServicesProjectResource"/>.
    /// </summary>
    public partial class CognitiveServicesProjectCapabilityHostCollection : ArmCollection
    {
        private readonly ClientDiagnostics _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics;
        private readonly ProjectCapabilityHostsRestOperations _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CognitiveServicesProjectCapabilityHostCollection"/> class for mocking. </summary>
        protected CognitiveServicesProjectCapabilityHostCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CognitiveServicesProjectCapabilityHostCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CognitiveServicesProjectCapabilityHostCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", CognitiveServicesProjectCapabilityHostResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CognitiveServicesProjectCapabilityHostResource.ResourceType, out string cognitiveServicesProjectCapabilityHostProjectCapabilityHostsApiVersion);
            _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient = new ProjectCapabilityHostsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cognitiveServicesProjectCapabilityHostProjectCapabilityHostsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CognitiveServicesProjectResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CognitiveServicesProjectResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update project capabilityHost.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/projects/{projectName}/capabilityHosts/{capabilityHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectCapabilityHosts_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CognitiveServicesProjectCapabilityHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="capabilityHostName"> The name of the capability host associated with the Cognitive Services Resource. </param>
        /// <param name="data"> CapabilityHost definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilityHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityHostName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CognitiveServicesProjectCapabilityHostResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string capabilityHostName, CognitiveServicesCapabilityHostData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilityHostName, nameof(capabilityHostName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics.CreateScope("CognitiveServicesProjectCapabilityHostCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, capabilityHostName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CognitiveServicesArmOperation<CognitiveServicesProjectCapabilityHostResource>(new CognitiveServicesProjectCapabilityHostOperationSource(Client), _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics, Pipeline, _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, capabilityHostName, data).Request, response, OperationFinalStateVia.OriginalUri);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update project capabilityHost.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/projects/{projectName}/capabilityHosts/{capabilityHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectCapabilityHosts_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CognitiveServicesProjectCapabilityHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="capabilityHostName"> The name of the capability host associated with the Cognitive Services Resource. </param>
        /// <param name="data"> CapabilityHost definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilityHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityHostName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CognitiveServicesProjectCapabilityHostResource> CreateOrUpdate(WaitUntil waitUntil, string capabilityHostName, CognitiveServicesCapabilityHostData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilityHostName, nameof(capabilityHostName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics.CreateScope("CognitiveServicesProjectCapabilityHostCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, capabilityHostName, data, cancellationToken);
                var operation = new CognitiveServicesArmOperation<CognitiveServicesProjectCapabilityHostResource>(new CognitiveServicesProjectCapabilityHostOperationSource(Client), _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics, Pipeline, _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, capabilityHostName, data).Request, response, OperationFinalStateVia.OriginalUri);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get project capabilityHost.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/projects/{projectName}/capabilityHosts/{capabilityHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectCapabilityHosts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CognitiveServicesProjectCapabilityHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilityHostName"> The name of the capability host associated with the Cognitive Services Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilityHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityHostName"/> is null. </exception>
        public virtual async Task<Response<CognitiveServicesProjectCapabilityHostResource>> GetAsync(string capabilityHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilityHostName, nameof(capabilityHostName));

            using var scope = _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics.CreateScope("CognitiveServicesProjectCapabilityHostCollection.Get");
            scope.Start();
            try
            {
                var response = await _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, capabilityHostName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CognitiveServicesProjectCapabilityHostResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get project capabilityHost.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/projects/{projectName}/capabilityHosts/{capabilityHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectCapabilityHosts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CognitiveServicesProjectCapabilityHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilityHostName"> The name of the capability host associated with the Cognitive Services Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilityHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityHostName"/> is null. </exception>
        public virtual Response<CognitiveServicesProjectCapabilityHostResource> Get(string capabilityHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilityHostName, nameof(capabilityHostName));

            using var scope = _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics.CreateScope("CognitiveServicesProjectCapabilityHostCollection.Get");
            scope.Start();
            try
            {
                var response = _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, capabilityHostName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CognitiveServicesProjectCapabilityHostResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/projects/{projectName}/capabilityHosts/{capabilityHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectCapabilityHosts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CognitiveServicesProjectCapabilityHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilityHostName"> The name of the capability host associated with the Cognitive Services Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilityHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityHostName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string capabilityHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilityHostName, nameof(capabilityHostName));

            using var scope = _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics.CreateScope("CognitiveServicesProjectCapabilityHostCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, capabilityHostName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/projects/{projectName}/capabilityHosts/{capabilityHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectCapabilityHosts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CognitiveServicesProjectCapabilityHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilityHostName"> The name of the capability host associated with the Cognitive Services Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilityHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityHostName"/> is null. </exception>
        public virtual Response<bool> Exists(string capabilityHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilityHostName, nameof(capabilityHostName));

            using var scope = _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics.CreateScope("CognitiveServicesProjectCapabilityHostCollection.Exists");
            scope.Start();
            try
            {
                var response = _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, capabilityHostName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/projects/{projectName}/capabilityHosts/{capabilityHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectCapabilityHosts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CognitiveServicesProjectCapabilityHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilityHostName"> The name of the capability host associated with the Cognitive Services Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilityHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityHostName"/> is null. </exception>
        public virtual async Task<NullableResponse<CognitiveServicesProjectCapabilityHostResource>> GetIfExistsAsync(string capabilityHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilityHostName, nameof(capabilityHostName));

            using var scope = _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics.CreateScope("CognitiveServicesProjectCapabilityHostCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, capabilityHostName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CognitiveServicesProjectCapabilityHostResource>(response.GetRawResponse());
                return Response.FromValue(new CognitiveServicesProjectCapabilityHostResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/projects/{projectName}/capabilityHosts/{capabilityHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectCapabilityHosts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CognitiveServicesProjectCapabilityHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilityHostName"> The name of the capability host associated with the Cognitive Services Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilityHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityHostName"/> is null. </exception>
        public virtual NullableResponse<CognitiveServicesProjectCapabilityHostResource> GetIfExists(string capabilityHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilityHostName, nameof(capabilityHostName));

            using var scope = _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics.CreateScope("CognitiveServicesProjectCapabilityHostCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, capabilityHostName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CognitiveServicesProjectCapabilityHostResource>(response.GetRawResponse());
                return Response.FromValue(new CognitiveServicesProjectCapabilityHostResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
