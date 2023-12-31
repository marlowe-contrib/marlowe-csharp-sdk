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
        /// with the <see cref="string" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of string.</param>
        public Contract(string actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contract" /> class
        /// with the <see cref="ContractOneOf" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ContractOneOf.</param>
        public Contract(ContractOneOf actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contract" /> class
        /// with the <see cref="ContractOneOf1" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ContractOneOf1.</param>
        public Contract(ContractOneOf1 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contract" /> class
        /// with the <see cref="ContractOneOf2" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ContractOneOf2.</param>
        public Contract(ContractOneOf2 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contract" /> class
        /// with the <see cref="ContractOneOf3" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ContractOneOf3.</param>
        public Contract(ContractOneOf3 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contract" /> class
        /// with the <see cref="ContractOneOf4" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ContractOneOf4.</param>
        public Contract(ContractOneOf4 actualInstance)
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
                if (value.GetType() == typeof(ContractOneOf))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ContractOneOf1))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ContractOneOf2))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ContractOneOf3))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ContractOneOf4))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(string))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ContractOneOf, ContractOneOf1, ContractOneOf2, ContractOneOf3, ContractOneOf4, string");
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
        /// Get the actual instance of `ContractOneOf`. If the actual instance is not `ContractOneOf`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ContractOneOf</returns>
        public ContractOneOf GetContractOneOf()
        {
            return (ContractOneOf)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ContractOneOf1`. If the actual instance is not `ContractOneOf1`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ContractOneOf1</returns>
        public ContractOneOf1 GetContractOneOf1()
        {
            return (ContractOneOf1)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ContractOneOf2`. If the actual instance is not `ContractOneOf2`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ContractOneOf2</returns>
        public ContractOneOf2 GetContractOneOf2()
        {
            return (ContractOneOf2)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ContractOneOf3`. If the actual instance is not `ContractOneOf3`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ContractOneOf3</returns>
        public ContractOneOf3 GetContractOneOf3()
        {
            return (ContractOneOf3)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ContractOneOf4`. If the actual instance is not `ContractOneOf4`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ContractOneOf4</returns>
        public ContractOneOf4 GetContractOneOf4()
        {
            return (ContractOneOf4)this.ActualInstance;
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
                if (typeof(ContractOneOf).GetProperty("AdditionalProperties") == null)
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<ContractOneOf>(jsonString, Contract.SerializerSettings));
                }
                else
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<ContractOneOf>(jsonString, Contract.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ContractOneOf");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ContractOneOf: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ContractOneOf1).GetProperty("AdditionalProperties") == null)
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<ContractOneOf1>(jsonString, Contract.SerializerSettings));
                }
                else
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<ContractOneOf1>(jsonString, Contract.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ContractOneOf1");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ContractOneOf1: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ContractOneOf2).GetProperty("AdditionalProperties") == null)
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<ContractOneOf2>(jsonString, Contract.SerializerSettings));
                }
                else
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<ContractOneOf2>(jsonString, Contract.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ContractOneOf2");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ContractOneOf2: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ContractOneOf3).GetProperty("AdditionalProperties") == null)
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<ContractOneOf3>(jsonString, Contract.SerializerSettings));
                }
                else
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<ContractOneOf3>(jsonString, Contract.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ContractOneOf3");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ContractOneOf3: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ContractOneOf4).GetProperty("AdditionalProperties") == null)
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<ContractOneOf4>(jsonString, Contract.SerializerSettings));
                }
                else
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<ContractOneOf4>(jsonString, Contract.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ContractOneOf4");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ContractOneOf4: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(string).GetProperty("AdditionalProperties") == null)
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<string>(jsonString, Contract.SerializerSettings));
                }
                else
                {
                    newContract = new Contract(JsonConvert.DeserializeObject<string>(jsonString, Contract.AdditionalPropertiesSerializerSettings));
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
            if(reader.TokenType != JsonToken.Null)
            {
                return Contract.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
