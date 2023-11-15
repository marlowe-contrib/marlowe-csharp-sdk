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
    /// A participant in a contract
    /// </summary>
    [JsonConverter(typeof(PartyObjectJsonConverter))]
    [DataContract(Name = "PartyObject")]
    public partial class PartyObject : AbstractOpenAPISchema, IEquatable<PartyObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartyObject" /> class
        /// with the <see cref="PartyOneOf" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PartyOneOf.</param>
        public PartyObject(PartyOneOf actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartyObject" /> class
        /// with the <see cref="PartyOneOf1" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PartyOneOf1.</param>
        public PartyObject(PartyOneOf1 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartyObject" /> class
        /// with the <see cref="ActionObjectOneOf" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ActionObjectOneOf.</param>
        public PartyObject(ActionObjectOneOf actualInstance)
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
                if (value.GetType() == typeof(ActionObjectOneOf))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PartyOneOf))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PartyOneOf1))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ActionObjectOneOf, PartyOneOf, PartyOneOf1");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `PartyOneOf`. If the actual instance is not `PartyOneOf`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PartyOneOf</returns>
        public PartyOneOf GetPartyOneOf()
        {
            return (PartyOneOf)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PartyOneOf1`. If the actual instance is not `PartyOneOf1`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PartyOneOf1</returns>
        public PartyOneOf1 GetPartyOneOf1()
        {
            return (PartyOneOf1)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ActionObjectOneOf`. If the actual instance is not `ActionObjectOneOf`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ActionObjectOneOf</returns>
        public ActionObjectOneOf GetActionObjectOneOf()
        {
            return (ActionObjectOneOf)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartyObject {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, PartyObject.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of PartyObject
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of PartyObject</returns>
        public static PartyObject FromJson(string jsonString)
        {
            PartyObject newPartyObject = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newPartyObject;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ActionObjectOneOf).GetProperty("AdditionalProperties") == null)
                {
                    newPartyObject = new PartyObject(JsonConvert.DeserializeObject<ActionObjectOneOf>(jsonString, PartyObject.SerializerSettings));
                }
                else
                {
                    newPartyObject = new PartyObject(JsonConvert.DeserializeObject<ActionObjectOneOf>(jsonString, PartyObject.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ActionObjectOneOf");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ActionObjectOneOf: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PartyOneOf).GetProperty("AdditionalProperties") == null)
                {
                    newPartyObject = new PartyObject(JsonConvert.DeserializeObject<PartyOneOf>(jsonString, PartyObject.SerializerSettings));
                }
                else
                {
                    newPartyObject = new PartyObject(JsonConvert.DeserializeObject<PartyOneOf>(jsonString, PartyObject.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("PartyOneOf");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PartyOneOf: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PartyOneOf1).GetProperty("AdditionalProperties") == null)
                {
                    newPartyObject = new PartyObject(JsonConvert.DeserializeObject<PartyOneOf1>(jsonString, PartyObject.SerializerSettings));
                }
                else
                {
                    newPartyObject = new PartyObject(JsonConvert.DeserializeObject<PartyOneOf1>(jsonString, PartyObject.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("PartyOneOf1");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PartyOneOf1: {1}", jsonString, exception.ToString()));
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
            return newPartyObject;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PartyObject);
        }

        /// <summary>
        /// Returns true if PartyObject instances are equal
        /// </summary>
        /// <param name="input">Instance of PartyObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartyObject input)
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
    /// Custom JSON converter for PartyObject
    /// </summary>
    public class PartyObjectJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(PartyObject).GetMethod("ToJson").Invoke(value, null)));
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
                return PartyObject.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
