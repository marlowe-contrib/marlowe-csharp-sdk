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
    [JsonConverter(typeof(ContractObjectJsonConverter))]
    [DataContract(Name = "ContractObject")]
    public partial class ContractObject : AbstractOpenAPISchema, IEquatable<ContractObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractObject" /> class
        /// with the <see cref="CloseObject" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CloseObject.</param>
        public ContractObject(CloseObject actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContractObject" /> class
        /// with the <see cref="PayObject" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PayObject.</param>
        public ContractObject(PayObject actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContractObject" /> class
        /// with the <see cref="IfObject" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of IfObject.</param>
        public ContractObject(IfObject actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContractObject" /> class
        /// with the <see cref="WhenObject" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WhenObject.</param>
        public ContractObject(WhenObject actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContractObject" /> class
        /// with the <see cref="LetObject" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of LetObject.</param>
        public ContractObject(LetObject actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContractObject" /> class
        /// with the <see cref="AssertObject" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AssertObject.</param>
        public ContractObject(AssertObject actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContractObject" /> class
        /// with the <see cref="LabelRef" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of LabelRef.</param>
        public ContractObject(LabelRef actualInstance)
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
                if (value.GetType() == typeof(AssertObject))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CloseObject))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(IfObject))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(LabelRef))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(LetObject))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PayObject))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WhenObject))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AssertObject, CloseObject, IfObject, LabelRef, LetObject, PayObject, WhenObject");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `CloseObject`. If the actual instance is not `CloseObject`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CloseObject</returns>
        public CloseObject GetCloseObject()
        {
            return (CloseObject)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PayObject`. If the actual instance is not `PayObject`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PayObject</returns>
        public PayObject GetPayObject()
        {
            return (PayObject)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `IfObject`. If the actual instance is not `IfObject`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of IfObject</returns>
        public IfObject GetIfObject()
        {
            return (IfObject)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `WhenObject`. If the actual instance is not `WhenObject`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of WhenObject</returns>
        public WhenObject GetWhenObject()
        {
            return (WhenObject)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `LetObject`. If the actual instance is not `LetObject`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of LetObject</returns>
        public LetObject GetLetObject()
        {
            return (LetObject)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AssertObject`. If the actual instance is not `AssertObject`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AssertObject</returns>
        public AssertObject GetAssertObject()
        {
            return (AssertObject)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `LabelRef`. If the actual instance is not `LabelRef`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of LabelRef</returns>
        public LabelRef GetLabelRef()
        {
            return (LabelRef)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContractObject {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, ContractObject.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ContractObject
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ContractObject</returns>
        public static ContractObject FromJson(string jsonString)
        {
            ContractObject newContractObject = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newContractObject;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AssertObject).GetProperty("AdditionalProperties") == null)
                {
                    newContractObject = new ContractObject(JsonConvert.DeserializeObject<AssertObject>(jsonString, ContractObject.SerializerSettings));
                }
                else
                {
                    newContractObject = new ContractObject(JsonConvert.DeserializeObject<AssertObject>(jsonString, ContractObject.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AssertObject");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AssertObject: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CloseObject).GetProperty("AdditionalProperties") == null)
                {
                    newContractObject = new ContractObject(JsonConvert.DeserializeObject<CloseObject>(jsonString, ContractObject.SerializerSettings));
                }
                else
                {
                    newContractObject = new ContractObject(JsonConvert.DeserializeObject<CloseObject>(jsonString, ContractObject.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CloseObject");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CloseObject: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(IfObject).GetProperty("AdditionalProperties") == null)
                {
                    newContractObject = new ContractObject(JsonConvert.DeserializeObject<IfObject>(jsonString, ContractObject.SerializerSettings));
                }
                else
                {
                    newContractObject = new ContractObject(JsonConvert.DeserializeObject<IfObject>(jsonString, ContractObject.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("IfObject");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into IfObject: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(LabelRef).GetProperty("AdditionalProperties") == null)
                {
                    newContractObject = new ContractObject(JsonConvert.DeserializeObject<LabelRef>(jsonString, ContractObject.SerializerSettings));
                }
                else
                {
                    newContractObject = new ContractObject(JsonConvert.DeserializeObject<LabelRef>(jsonString, ContractObject.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("LabelRef");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into LabelRef: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(LetObject).GetProperty("AdditionalProperties") == null)
                {
                    newContractObject = new ContractObject(JsonConvert.DeserializeObject<LetObject>(jsonString, ContractObject.SerializerSettings));
                }
                else
                {
                    newContractObject = new ContractObject(JsonConvert.DeserializeObject<LetObject>(jsonString, ContractObject.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("LetObject");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into LetObject: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PayObject).GetProperty("AdditionalProperties") == null)
                {
                    newContractObject = new ContractObject(JsonConvert.DeserializeObject<PayObject>(jsonString, ContractObject.SerializerSettings));
                }
                else
                {
                    newContractObject = new ContractObject(JsonConvert.DeserializeObject<PayObject>(jsonString, ContractObject.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("PayObject");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PayObject: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WhenObject).GetProperty("AdditionalProperties") == null)
                {
                    newContractObject = new ContractObject(JsonConvert.DeserializeObject<WhenObject>(jsonString, ContractObject.SerializerSettings));
                }
                else
                {
                    newContractObject = new ContractObject(JsonConvert.DeserializeObject<WhenObject>(jsonString, ContractObject.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WhenObject");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WhenObject: {1}", jsonString, exception.ToString()));
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
            return newContractObject;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ContractObject);
        }

        /// <summary>
        /// Returns true if ContractObject instances are equal
        /// </summary>
        /// <param name="input">Instance of ContractObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractObject input)
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
    /// Custom JSON converter for ContractObject
    /// </summary>
    public class ContractObjectJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ContractObject).GetMethod("ToJson").Invoke(value, null)));
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
            if (reader.TokenType != JsonToken.Null)
            {
                return ContractObject.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
