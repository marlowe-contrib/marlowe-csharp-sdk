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
    /// MarloweStateAccountsInnerInner
    /// </summary>
    [JsonConverter(typeof(MarloweStateAccountsInnerInnerJsonConverter))]
    [DataContract(Name = "MarloweState_accounts_inner_inner")]
    public partial class MarloweStateAccountsInnerInner : AbstractOpenAPISchema, IEquatable<MarloweStateAccountsInnerInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarloweStateAccountsInnerInner" /> class
        /// with the <see cref="List{AccountTokenTupleInner}" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of List&lt;AccountTokenTupleInner&gt;.</param>
        public MarloweStateAccountsInnerInner(List<AccountTokenTupleInner> actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarloweStateAccountsInnerInner" /> class
        /// with the <see cref="int" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of int.</param>
        public MarloweStateAccountsInnerInner(int actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
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
                if (value.GetType() == typeof(List<AccountTokenTupleInner>))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(int))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: List<AccountTokenTupleInner>, int");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `List&lt;AccountTokenTupleInner&gt;`. If the actual instance is not `List&lt;AccountTokenTupleInner&gt;`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of List&lt;AccountTokenTupleInner&gt;</returns>
        public List<AccountTokenTupleInner> GetList()
        {
            return (List<AccountTokenTupleInner>)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `int`. If the actual instance is not `int`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of int</returns>
        public int GetInt()
        {
            return (int)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarloweStateAccountsInnerInner {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, MarloweStateAccountsInnerInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of MarloweStateAccountsInnerInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of MarloweStateAccountsInnerInner</returns>
        public static MarloweStateAccountsInnerInner FromJson(string jsonString)
        {
            MarloweStateAccountsInnerInner newMarloweStateAccountsInnerInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newMarloweStateAccountsInnerInner;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(List<AccountTokenTupleInner>).GetProperty("AdditionalProperties") == null)
                {
                    newMarloweStateAccountsInnerInner = new MarloweStateAccountsInnerInner(JsonConvert.DeserializeObject<List<AccountTokenTupleInner>>(jsonString, MarloweStateAccountsInnerInner.SerializerSettings));
                }
                else
                {
                    newMarloweStateAccountsInnerInner = new MarloweStateAccountsInnerInner(JsonConvert.DeserializeObject<List<AccountTokenTupleInner>>(jsonString, MarloweStateAccountsInnerInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("List<AccountTokenTupleInner>");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into List<AccountTokenTupleInner>: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(int).GetProperty("AdditionalProperties") == null)
                {
                    newMarloweStateAccountsInnerInner = new MarloweStateAccountsInnerInner(JsonConvert.DeserializeObject<int>(jsonString, MarloweStateAccountsInnerInner.SerializerSettings));
                }
                else
                {
                    newMarloweStateAccountsInnerInner = new MarloweStateAccountsInnerInner(JsonConvert.DeserializeObject<int>(jsonString, MarloweStateAccountsInnerInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("int");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into int: {1}", jsonString, exception.ToString()));
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
            return newMarloweStateAccountsInnerInner;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MarloweStateAccountsInnerInner);
        }

        /// <summary>
        /// Returns true if MarloweStateAccountsInnerInner instances are equal
        /// </summary>
        /// <param name="input">Instance of MarloweStateAccountsInnerInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarloweStateAccountsInnerInner input)
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
    /// Custom JSON converter for MarloweStateAccountsInnerInner
    /// </summary>
    public class MarloweStateAccountsInnerInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(MarloweStateAccountsInnerInner).GetMethod("ToJson").Invoke(value, null)));
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
                return MarloweStateAccountsInnerInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
