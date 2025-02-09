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
    /// InteractiveExperience View Model
    /// </summary>
    public partial class InteractiveExperienceBag : EntityBagBase
    {
        /// <summary>
        /// Gets or sets the background color of the action.
        /// </summary>
        /// <value>
        /// The background color of the action.
        /// </value>
        public string ActionBackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the action background image binary file identifier.
        /// </summary>
        /// <value>
        /// The action background image binary file identifier.
        /// </value>
        public int? ActionBackgroundImageBinaryFileId { get; set; }

        /// <summary>
        /// Gets or sets the custom css for the action.
        /// </summary>
        /// <value>
        /// The custom css for the action.
        /// </value>
        public string ActionCustomCss { get; set; }

        /// <summary>
        /// Gets or sets the primary button color of the action.
        /// </summary>
        /// <value>
        /// The primary button color of the action.
        /// </value>
        public string ActionPrimaryButtonColor { get; set; }

        /// <summary>
        /// Gets or sets the primary button text color of the action.
        /// </summary>
        /// <value>
        /// The primary button text color of the action.
        /// </value>
        public string ActionPrimaryButtonTextColor { get; set; }

        /// <summary>
        /// Gets or sets the secondary button color of the action.
        /// </summary>
        /// <value>
        /// The secondary button color of the action.
        /// </value>
        public string ActionSecondaryButtonColor { get; set; }

        /// <summary>
        /// Gets or sets the secondary button text color of the action.
        /// </summary>
        /// <value>
        /// The secondary button text color of the action.
        /// </value>
        public string ActionSecondaryButtonTextColor { get; set; }

        /// <summary>
        /// Gets or sets the text color of the action.
        /// </summary>
        /// <value>
        /// The text color of the action.
        /// </value>
        public string ActionTextColor { get; set; }

        /// <summary>
        /// Gets or sets the accent color for the audience.
        /// </summary>
        /// <value>
        /// The accent color for the audience.
        /// </value>
        public string AudienceAccentColor { get; set; }

        /// <summary>
        /// Gets or sets the background color for the audience.
        /// </summary>
        /// <value>
        /// The background color for the audience.
        /// </value>
        public string AudienceBackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the audience background image binary file identifier.
        /// </summary>
        /// <value>
        /// The audience background image binary file identifier.
        /// </value>
        public int? AudienceBackgroundImageBinaryFileId { get; set; }

        /// <summary>
        /// Gets or sets the custom css for the audience.
        /// </summary>
        /// <value>
        /// The custom css for the audience.
        /// </value>
        public string AudienceCustomCss { get; set; }

        /// <summary>
        /// Gets or sets the primary color for the audience.
        /// </summary>
        /// <value>
        /// The primary color for the audience.
        /// </value>
        public string AudiencePrimaryColor { get; set; }

        /// <summary>
        /// Gets or sets the secondary color for the audience.
        /// </summary>
        /// <value>
        /// The secondary color for the audience.
        /// </value>
        public string AudienceSecondaryColor { get; set; }

        /// <summary>
        /// Gets or sets the text color for the audience.
        /// </summary>
        /// <value>
        /// The text color for the audience.
        /// </value>
        public string AudienceTextColor { get; set; }

        /// <summary>
        /// Gets or sets the Description of the Rock.Model.InteractiveExperience
        /// </summary>
        /// <value>
        /// A System.String for the Description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the JSON representing the additional settings.
        /// </summary>
        /// <value>
        /// The JSON representing the additional settings.
        /// </value>
        public string ExperienceSettingsJson { get; set; }

        /// <summary>
        /// Gets or sets the IsActive flag for the Rock.Model.InteractiveExperience.
        /// </summary>
        /// <value>
        /// A System.Boolean for the IsActive flag.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the Name of the InteractiveExperience. This property is required.
        /// </summary>
        /// <value>
        /// A System.String representing the Name of the InteractiveExperience.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the no action header image binary file identifier.
        /// </summary>
        /// <value>
        /// The no action header image binary file identifier.
        /// </value>
        public int? NoActionHeaderImageBinaryFileId { get; set; }

        /// <summary>
        /// Gets or sets the no action message.
        /// </summary>
        /// <value>
        /// A System.String representing the no action message.
        /// </value>
        public string NoActionMessage { get; set; }

        /// <summary>
        /// Gets or sets the no action title.
        /// </summary>
        /// <value>
        /// A System.String representing the no action title.
        /// </value>
        public string NoActionTitle { get; set; }

        /// <summary>
        /// Gets or sets the photo binary file identifier.
        /// </summary>
        /// <value>
        /// The photo binary file identifier.
        /// </value>
        public int? PhotoBinaryFileId { get; set; }

        /// <summary>
        /// Gets or sets the Public Label of the InteractiveExperience.
        /// </summary>
        /// <value>
        /// A System.String representing the Public Label of the InteractiveExperience.
        /// </value>
        public string PublicLabel { get; set; }

        /// <summary>
        /// Gets or sets the detail message of the push notification.
        /// </summary>
        /// <value>
        /// The detail message of the push notification.
        /// </value>
        public string PushNotificationDetail { get; set; }

        /// <summary>
        /// Gets or sets the title of the push notification.
        /// </summary>
        /// <value>
        /// The title of the push notification.
        /// </value>
        public string PushNotificationTitle { get; set; }

        /// <summary>
        /// Gets or sets the push notification type.
        /// </summary>
        /// <value>
        /// The push notification type.
        /// </value>
        public int PushNotificationType { get; set; }

        /// <summary>
        /// Gets or sets the welcome header image binary file identifier.
        /// </summary>
        /// <value>
        /// The welcome header image binary file identifier.
        /// </value>
        public int? WelcomeHeaderImageBinaryFileId { get; set; }

        /// <summary>
        /// Gets or sets the welcome message.
        /// </summary>
        /// <value>
        /// A System.String representing the welcome message.
        /// </value>
        public string WelcomeMessage { get; set; }

        /// <summary>
        /// Gets or sets the welcome title.
        /// </summary>
        /// <value>
        /// A System.String representing the welcome title.
        /// </value>
        public string WelcomeTitle { get; set; }

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
