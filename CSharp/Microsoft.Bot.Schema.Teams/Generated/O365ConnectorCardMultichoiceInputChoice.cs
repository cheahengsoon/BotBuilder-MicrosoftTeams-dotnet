// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bot.Schema.Teams
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// O365O365 connector card multiple choice input item
    /// </summary>
    public partial class O365ConnectorCardMultichoiceInputChoice
    {
        /// <summary>
        /// Initializes a new instance of the
        /// O365ConnectorCardMultichoiceInputChoice class.
        /// </summary>
        public O365ConnectorCardMultichoiceInputChoice()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// O365ConnectorCardMultichoiceInputChoice class.
        /// </summary>
        /// <param name="display">The text rednered on ActionCard.</param>
        /// <param name="value">The value received as results.</param>
        public O365ConnectorCardMultichoiceInputChoice(string display = default(string), string value = default(string))
        {
            Display = display;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the text rednered on ActionCard.
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public string Display { get; set; }

        /// <summary>
        /// Gets or sets the value received as results.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
