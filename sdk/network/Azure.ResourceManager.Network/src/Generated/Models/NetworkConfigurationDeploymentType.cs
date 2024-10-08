// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Configuration Deployment Type. </summary>
    public readonly partial struct NetworkConfigurationDeploymentType : IEquatable<NetworkConfigurationDeploymentType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkConfigurationDeploymentType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkConfigurationDeploymentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SecurityAdminValue = "SecurityAdmin";
        private const string ConnectivityValue = "Connectivity";
        private const string SecurityUserValue = "SecurityUser";
        private const string RoutingValue = "Routing";

        /// <summary> SecurityAdmin. </summary>
        public static NetworkConfigurationDeploymentType SecurityAdmin { get; } = new NetworkConfigurationDeploymentType(SecurityAdminValue);
        /// <summary> Connectivity. </summary>
        public static NetworkConfigurationDeploymentType Connectivity { get; } = new NetworkConfigurationDeploymentType(ConnectivityValue);
        /// <summary> SecurityUser. </summary>
        public static NetworkConfigurationDeploymentType SecurityUser { get; } = new NetworkConfigurationDeploymentType(SecurityUserValue);
        /// <summary> Routing. </summary>
        public static NetworkConfigurationDeploymentType Routing { get; } = new NetworkConfigurationDeploymentType(RoutingValue);
        /// <summary> Determines if two <see cref="NetworkConfigurationDeploymentType"/> values are the same. </summary>
        public static bool operator ==(NetworkConfigurationDeploymentType left, NetworkConfigurationDeploymentType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkConfigurationDeploymentType"/> values are not the same. </summary>
        public static bool operator !=(NetworkConfigurationDeploymentType left, NetworkConfigurationDeploymentType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NetworkConfigurationDeploymentType"/>. </summary>
        public static implicit operator NetworkConfigurationDeploymentType(string value) => new NetworkConfigurationDeploymentType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkConfigurationDeploymentType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkConfigurationDeploymentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
