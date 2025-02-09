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
    /// InteractionComponent View Model
    /// </summary>
    public partial class InteractionComponentBag : EntityBagBase
    {
        /// <summary>
        /// Gets or sets the channel custom 1.
        /// </summary>
        /// <value>
        /// The channel custom 1.
        /// </value>
        public string ChannelCustom1 { get; set; }

        /// <summary>
        /// Gets or sets the channel custom 2.
        /// </summary>
        /// <value>
        /// The channel custom 2.
        /// </value>
        public string ChannelCustom2 { get; set; }

        /// <summary>
        /// Gets or sets the channel custom indexed 1.
        /// </summary>
        /// <value>
        /// The channel custom indexed 1.
        /// </value>
        public string ChannelCustomIndexed1 { get; set; }

        /// <summary>
        /// Gets or sets the interaction component data.
        /// </summary>
        /// <value>
        /// The interaction component data.
        /// </value>
        public string ComponentData { get; set; }

        /// <summary>
        /// Gets or sets the component summary.
        /// </summary>
        /// <value>
        /// The component summary.
        /// </value>
        public string ComponentSummary { get; set; }

        /// <summary>
        /// Gets or sets the Id of the entity that this interaction component is related to (determined by Rock.Model.InteractionChannel.ComponentEntityTypeId )
        /// 
        /// <item>
        ///     <term>Page Views</term>
        ///     <description><see cref="T:Rock.Model.Page" /> Id</description></item>
        /// <item>
        ///     <term>Communication Recipient Activity</term>
        ///     <description><see cref="T:Rock.Model.Communication" /> Id</description></item>
        /// <item>
        ///     <term>Content Channel Activity</term>
        ///     <description><see cref="T:Rock.Model.ContentChannel" /> Id</description></item>
        /// <item>
        ///     <term>System Events, like Workflow Form Entry</term>
        ///     <description>Depends on <see cref="T:Rock.Model.ContentChannelType"></see></description></item>
        /// </summary>
        /// <value>
        /// A System.Int32 representing the Id of the entity (object) that this interaction component is related to.
        /// </value>
        public int? EntityId { get; set; }

        /// <summary>
        /// Gets or sets the Id of the Rock.Model.InteractionChannel channel that is associated with this Component.
        /// </summary>
        /// <value>
        /// An System.Int32 representing the Id of the Rock.Model.InteractionChannel channel that this Component is associated with.
        /// </value>
        public int InteractionChannelId { get; set; }

        /// <summary>
        /// Gets or sets the interaction component name.
        /// </summary>
        /// <value>
        /// The interaction component name.
        /// </value>
        public string Name { get; set; }

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
