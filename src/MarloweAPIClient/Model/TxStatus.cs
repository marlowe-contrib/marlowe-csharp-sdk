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
    /// The status of a transaction on the local node.
    /// </summary>
    /// <value>The status of a transaction on the local node.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TxStatus
    {
        /// <summary>
        /// Enum Unsigned for value: unsigned
        /// </summary>
        [EnumMember(Value = "unsigned")]
        Unsigned = 1,

        /// <summary>
        /// Enum Submitted for value: submitted
        /// </summary>
        [EnumMember(Value = "submitted")]
        Submitted = 2,

        /// <summary>
        /// Enum Confirmed for value: confirmed
        /// </summary>
        [EnumMember(Value = "confirmed")]
        Confirmed = 3
    }

}
