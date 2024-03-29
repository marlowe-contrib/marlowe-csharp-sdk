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
using System.Reflection;

namespace MarloweAPIClient.Model
{
    /// <summary>
    /// RoleTokenConfig
    /// </summary>
    [JsonConverter(typeof(RoleTokenConfigJsonConverter))]
    [DataContract(Name = "RoleTokenConfig")]
    public partial class RoleTokenConfig : AbstractOpenAPISchema, IEquatable<RoleTokenConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleTokenConfig" /> class
        /// with the <see cref="string" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of string.</param>
        public RoleTokenConfig(string actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleTokenConfig" /> class
        /// with the <see cref="AddressAndMetadata" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AddressAndMetadata.</param>
        public RoleTokenConfig(AddressAndMetadata actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleTokenConfig" /> class
        /// with the <see cref="MetadataAndScript" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of MetadataAndScript.</param>
        public RoleTokenConfig(MetadataAndScript actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleTokenConfig" /> class
        /// with the <see cref="MetadataAndRecipients" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of MetadataAndRecipients.</param>
        public RoleTokenConfig(MetadataAndRecipients actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(AddressAndMetadata))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(MetadataAndRecipients))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(MetadataAndScript))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(string))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AddressAndMetadata, MetadataAndRecipients, MetadataAndScript, string");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `string`. If the actual instance is not `string`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of string</returns>
        public string GetString()
        {
            return (string)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AddressAndMetadata`. If the actual instance is not `AddressAndMetadata`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AddressAndMetadata</returns>
        public AddressAndMetadata GetAddressAndMetadata()
        {
            return (AddressAndMetadata)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `MetadataAndScript`. If the actual instance is not `MetadataAndScript`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of MetadataAndScript</returns>
        public MetadataAndScript GetMetadataAndScript()
        {
            return (MetadataAndScript)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `MetadataAndRecipients`. If the actual instance is not `MetadataAndRecipients`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of MetadataAndRecipients</returns>
        public MetadataAndRecipients GetMetadataAndRecipients()
        {
            return (MetadataAndRecipients)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleTokenConfig {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, RoleTokenConfig.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of RoleTokenConfig
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of RoleTokenConfig</returns>
        public static RoleTokenConfig FromJson(string jsonString)
        {
            RoleTokenConfig newRoleTokenConfig = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newRoleTokenConfig;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AddressAndMetadata).GetProperty("AdditionalProperties") == null)
                {
                    newRoleTokenConfig = new RoleTokenConfig(JsonConvert.DeserializeObject<AddressAndMetadata>(jsonString, RoleTokenConfig.SerializerSettings));
                }
                else
                {
                    newRoleTokenConfig = new RoleTokenConfig(JsonConvert.DeserializeObject<AddressAndMetadata>(jsonString, RoleTokenConfig.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AddressAndMetadata");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AddressAndMetadata: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(MetadataAndRecipients).GetProperty("AdditionalProperties") == null)
                {
                    newRoleTokenConfig = new RoleTokenConfig(JsonConvert.DeserializeObject<MetadataAndRecipients>(jsonString, RoleTokenConfig.SerializerSettings));
                }
                else
                {
                    newRoleTokenConfig = new RoleTokenConfig(JsonConvert.DeserializeObject<MetadataAndRecipients>(jsonString, RoleTokenConfig.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("MetadataAndRecipients");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into MetadataAndRecipients: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(MetadataAndScript).GetProperty("AdditionalProperties") == null)
                {
                    newRoleTokenConfig = new RoleTokenConfig(JsonConvert.DeserializeObject<MetadataAndScript>(jsonString, RoleTokenConfig.SerializerSettings));
                }
                else
                {
                    newRoleTokenConfig = new RoleTokenConfig(JsonConvert.DeserializeObject<MetadataAndScript>(jsonString, RoleTokenConfig.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("MetadataAndScript");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into MetadataAndScript: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(string).GetProperty("AdditionalProperties") == null)
                {
                    newRoleTokenConfig = new RoleTokenConfig(JsonConvert.DeserializeObject<string>(jsonString, RoleTokenConfig.SerializerSettings));
                }
                else
                {
                    newRoleTokenConfig = new RoleTokenConfig(JsonConvert.DeserializeObject<string>(jsonString, RoleTokenConfig.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("string");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into string: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newRoleTokenConfig;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RoleTokenConfig);
        }

        /// <summary>
        /// Returns true if RoleTokenConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of RoleTokenConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleTokenConfig input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for RoleTokenConfig
    /// </summary>
    public class RoleTokenConfigJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(RoleTokenConfig).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return RoleTokenConfig.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
