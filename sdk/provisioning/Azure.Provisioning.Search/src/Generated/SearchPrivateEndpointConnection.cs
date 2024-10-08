// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Search;

/// <summary>
/// SearchPrivateEndpointConnection.
/// </summary>
public partial class SearchPrivateEndpointConnection : Resource
{
    /// <summary>
    /// The name of the private endpoint connection to the Azure AI Search
    /// service with the specified resource group.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Describes the properties of an existing private endpoint connection to
    /// the Azure AI Search service.
    /// </summary>
    public BicepValue<SearchServicePrivateEndpointConnectionProperties> Properties { get => _properties; set => _properties.Assign(value); }
    private readonly BicepValue<SearchServicePrivateEndpointConnectionProperties> _properties;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent SearchService.
    /// </summary>
    public SearchService? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<SearchService> _parent;

    /// <summary>
    /// Creates a new SearchPrivateEndpointConnection.
    /// </summary>
    /// <param name="resourceName">Name of the SearchPrivateEndpointConnection.</param>
    /// <param name="resourceVersion">Version of the SearchPrivateEndpointConnection.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public SearchPrivateEndpointConnection(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Search/searchServices/privateEndpointConnections", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _properties = BicepValue<SearchServicePrivateEndpointConnectionProperties>.DefineProperty(this, "Properties", ["properties"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<SearchService>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing SearchPrivateEndpointConnection.
    /// </summary>
    /// <param name="resourceName">Name of the SearchPrivateEndpointConnection.</param>
    /// <param name="resourceVersion">Version of the SearchPrivateEndpointConnection.</param>
    /// <returns>The existing SearchPrivateEndpointConnection resource.</returns>
    public static SearchPrivateEndpointConnection FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
