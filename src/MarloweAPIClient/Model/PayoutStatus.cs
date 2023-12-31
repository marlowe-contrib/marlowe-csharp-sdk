/*
 * Marlowe Runtime REST API
 *
 * REST API for Marlowe Runtime
 *
 * The version of the OpenAPI document: 0.0.5.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = MarloweAPIClient.Client.OpenAPIDateConverter;

namespace MarloweAPIClient.Model
{
    /// <summary>
    /// The status of a payout. Either it is available to be withdrawn, or it has already been withdrawn.
    /// </summary>
    /// <value>The status of a payout. Either it is available to be withdrawn, or it has already been withdrawn.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PayoutStatus
    {
        /// <summary>
        /// Enum Available for value: available
        /// </summary>
        [EnumMember(Value = "available")]
        Available = 1,

        /// <summary>
        /// Enum Withdrawn for value: withdrawn
        /// </summary>
        [EnumMember(Value = "withdrawn")]
        Withdrawn = 2
    }

}
