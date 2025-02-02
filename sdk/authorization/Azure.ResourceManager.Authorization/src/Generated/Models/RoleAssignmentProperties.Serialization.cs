// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class RoleAssignmentProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("roleDefinitionId");
            writer.WriteStringValue(RoleDefinitionId);
            writer.WritePropertyName("principalId");
            writer.WriteStringValue(PrincipalId);
            writer.WriteEndObject();
        }
    }
}
