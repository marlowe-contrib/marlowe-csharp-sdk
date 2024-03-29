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
    /// Contract terms specified in Marlowe
    /// </summary>
    [JsonConverter(typeof(ContractJsonConverter))]
    [DataContract(Name = "Contract")]
    public partial class Contract : AbstractOpenAPISchema, IEquatable<Contract>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contract" /> class
        /// with the <see cref="Close" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Close.</param>
        public Contract(Close actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contract" /> class
        /// with the <see cref="Pay" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Pay.</param>
        public Contract(Pay actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contract" /> class
        /// with the <see cref="If" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of If.</param>
        public Contract(If actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contract" /> class
        /// with the <see cref="When" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of When.</param>
        public Contract(When actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contract" /> class
        /// with the <see cref="Let" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Let.</param>
        public Contract(Let actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contract" /> class
        /// with the <see cref="Assert" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Assert.</param>
        public Contract(Assert actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
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
                if (value.GetType() == typeof(Assert))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Close))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(If))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Let))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Pay))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(When))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Assert, Close, If, Let, Pay, When");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Close`. If the actual instance is not `Close`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Close</returns>
        public Close GetClose()
        {
            return (Close)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Pay`. If the actual instance is not `Pay`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Pay</returns>
        public Pay GetPay()
        {
            return (Pay)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `If`. If the actual instance is not `If`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of If</returns>
        public If GetIf()
        {
            return (If)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `When`. If the actual instance is not `When`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of When</returns>
        public When GetWhen()
        {
            return (When)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Let`. If the actual instance is not `Let`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Let</returns>
        public Let GetLet()
        {
            return (Let)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Assert`. If the actual instance is not `Assert`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Assert</returns>
        public Assert GetAssert()
        {
            return (Assert)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Contract {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, Contract.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of Contract
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of Contract</returns>
        public static Contract FromJson(string jsonString)
        {
            Contract newContract = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newContract;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Assert).GetProperty("AdditionalProperties") == null)
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<Assert>(jsonString, Contract.SerializerSettings));
                }
                else
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<Assert>(jsonString, Contract.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Assert");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Assert: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Close).GetProperty("AdditionalProperties") == null)
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<Close>(jsonString, Contract.SerializerSettings));
                }
                else
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<Close>(jsonString, Contract.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Close");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Close: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(If).GetProperty("AdditionalProperties") == null)
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<If>(jsonString, Contract.SerializerSettings));
                }
                else
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<If>(jsonString, Contract.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("If");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into If: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Let).GetProperty("AdditionalProperties") == null)
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<Let>(jsonString, Contract.SerializerSettings));
                }
                else
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<Let>(jsonString, Contract.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Let");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Let: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Pay).GetProperty("AdditionalProperties") == null)
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<Pay>(jsonString, Contract.SerializerSettings));
                }
                else
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<Pay>(jsonString, Contract.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Pay");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Pay: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(When).GetProperty("AdditionalProperties") == null)
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<When>(jsonString, Contract.SerializerSettings));
                }
                else
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<When>(jsonString, Contract.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("When");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into When: {1}", jsonString, exception.ToString()));
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
            return newContract;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Contract);
        }

        /// <summary>
        /// Returns true if Contract instances are equal
        /// </summary>
        /// <param name="input">Instance of Contract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contract input)
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
    /// Custom JSON converter for Contract
    /// </summary>
    public class ContractJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(Contract).GetMethod("ToJson").Invoke(value, null)));
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
            // Check the JSON token type
            switch (reader.TokenType)
            {
                case JsonToken.String:
                    // If it's a string, try to parse it as a Close enum
                    var enumString = (string)reader.Value;
                    if (Enum.TryParse(typeof(Close), enumString, true, out object result))
                    {
                        return new Contract((Close)result);
                    }
                    else
                    {
                        throw new JsonSerializationException($"Cannot convert {enumString} to Close enum");
                    }

                case JsonToken.Null:
                    return null;

                default:
                    return Contract.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
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
