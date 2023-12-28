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
    /// No more payments will be sent and the balance of the contract is 0.
    /// </summary>
    /// <value>No more payments will be sent and the balance of the contract is 0.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Close
    {
        /// <summary>
        /// Enum Close for value: close
        /// </summary>
        [EnumMember(Value = "close")]
        Close = 1
    }

}