// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Expiration of the role eligibility schedule. </summary>
    public partial class RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration
    {
        /// <summary> Initializes a new instance of RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration. </summary>
        public RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration()
        {
        }

        /// <summary> Initializes a new instance of RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration. </summary>
        /// <param name="roleEligibilityExpirationType"> Type of the role eligibility schedule expiration. </param>
        /// <param name="endOn"> End DateTime of the role eligibility schedule. </param>
        /// <param name="duration"> Duration of the role eligibility schedule in TimeSpan. </param>
        internal RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration(RoleEligibilityScheduleType? roleEligibilityExpirationType, DateTimeOffset? endOn, TimeSpan? duration)
        {
            RoleEligibilityExpirationType = roleEligibilityExpirationType;
            EndOn = endOn;
            Duration = duration;
        }

        /// <summary> Type of the role eligibility schedule expiration. </summary>
        public RoleEligibilityScheduleType? RoleEligibilityExpirationType { get; set; }
        /// <summary> End DateTime of the role eligibility schedule. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> Duration of the role eligibility schedule in TimeSpan. </summary>
        public TimeSpan? Duration { get; set; }
    }
}
