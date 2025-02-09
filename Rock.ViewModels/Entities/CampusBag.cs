//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//

using System;
using System.Linq;

using Rock.ViewModels.Utility;

namespace Rock.ViewModels.Entities
{
    /// <summary>
    /// Campus View Model
    /// </summary>
    public partial class CampusBag : EntityBagBase
    {
        /// <summary>
        /// Gets or sets the campus status value identifier.
        /// </summary>
        /// <value>
        /// The campus status value identifier.
        /// </value>
        public int? CampusStatusValueId { get; set; }

        /// <summary>
        /// Gets or sets the campus type value identifier.
        /// </summary>
        /// <value>
        /// The campus type value identifier.
        /// </value>
        public int? CampusTypeValueId { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the is active.
        /// </summary>
        /// <value>
        /// The is active.
        /// </value>
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if the Campus is a part of the Rock system/framework. This property is required.
        /// </summary>
        /// <value>
        /// A System.Boolean that is true if this Block is part of the Rock core system/framework, otherwise is false.
        /// </value>
        public bool IsSystem { get; set; }

        /// <summary>
        /// Gets or sets the Id of the Rock.Model.Person that is the leader of the campus.
        /// </summary>
        /// <value>
        /// A System.Int32 that represents the Id of the person who leads the campus.
        /// </value>
        public int? LeaderPersonAliasId { get; set; }

        /// <summary>
        /// Gets or sets the Id of the Rock.Model.Location that is associated with this campus. 
        /// </summary>
        /// <value>
        /// A System.Int32 that represents the Id of the (physical) location of the campus. If none exists, this value is null.
        /// </value>
        public int? LocationId { get; set; }

        /// <summary>
        /// Gets or sets the name of the Campus. This property is required.
        /// </summary>
        /// <value>
        /// A System.String that represents the Campus name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        /// <value>
        /// The order.
        /// </value>
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the campus.
        /// </summary>
        /// <value>
        /// A System.String that represents the campus phone number.
        /// </value>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the service times (Stored as a delimited list)
        /// </summary>
        /// <value>
        /// The service times.
        /// </value>
        public string ServiceTimes { get; set; }

        /// <summary>
        /// Gets or sets an optional short code identifier for the campus.
        /// </summary>
        /// <value>
        /// A System.String value that represents a short code identifier for a campus. If the campus does not have a ShortCode
        /// this value is null.
        /// </value>
        public string ShortCode { get; set; }

        /// <summary>
        /// Gets or sets the team group identifier.
        /// </summary>
        /// <value>
        /// The team group identifier.
        /// </value>
        public int? TeamGroupId { get; set; }

        /// <summary>
        /// Gets or sets the time zone identifier (System.TimeZoneInfo.Id)
        /// If this is not set, the Campus time zone will be the default Rock time zone (Rock.RockDateTime.OrgTimeZoneInfo )
        /// </summary>
        /// <value>
        /// The time zone identifier. 
        /// NOTE: System.TimeZoneInfo.Id can be any length, but documentation recommends that it 32 chars or less, so we'll limit it to 50
        /// </value>
        public string TimeZoneId { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the created date time.
        /// </summary>
        /// <value>
        /// The created date time.
        /// </value>
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the modified date time.
        /// </summary>
        /// <value>
        /// The modified date time.
        /// </value>
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the created by person alias identifier.
        /// </summary>
        /// <value>
        /// The created by person alias identifier.
        /// </value>
        public int? CreatedByPersonAliasId { get; set; }

        /// <summary>
        /// Gets or sets the modified by person alias identifier.
        /// </summary>
        /// <value>
        /// The modified by person alias identifier.
        /// </value>
        public int? ModifiedByPersonAliasId { get; set; }

    }
}
