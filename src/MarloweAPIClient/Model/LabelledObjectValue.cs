/*
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
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
    /// LabelledObjectValue
    /// </summary>
    [JsonConverter(typeof(LabelledObjectValueJsonConverter))]
    [DataContract(Name = "LabelledObject_value")]
    public partial class LabelledObjectValue : AbstractOpenAPISchema, IEquatable<LabelledObjectValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelledObjectValue" /> class
        /// with the <see cref="ValueObject" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ValueObject.</param>
        public LabelledObjectValue(ValueObject actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelledObjectValue" /> class
        /// with the <see cref="ObservationObject" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ObservationObject.</param>
        public LabelledObjectValue(ObservationObject actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelledObjectValue" /> class
        /// with the <see cref="ContractObject" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ContractObject.</param>
        public LabelledObjectValue(ContractObject actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelledObjectValue" /> class
        /// with the <see cref="PartyObject" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PartyObject.</param>
        public LabelledObjectValue(PartyObject actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelledObjectValue" /> class
        /// with the <see cref="TokenObject" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of TokenObject.</param>
        public LabelledObjectValue(TokenObject actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelledObjectValue" /> class
        /// with the <see cref="ActionObject" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ActionObject.</param>
        public LabelledObjectValue(ActionObject actualInstance)
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
                if (value.GetType() == typeof(ActionObject))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ContractObject))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ObservationObject))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PartyObject))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(TokenObject))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ValueObject))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ActionObject, ContractObject, ObservationObject, PartyObject, TokenObject, ValueObject");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ValueObject`. If the actual instance is not `ValueObject`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ValueObject</returns>
        public ValueObject GetValueObject()
        {
            return (ValueObject)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ObservationObject`. If the actual instance is not `ObservationObject`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ObservationObject</returns>
        public ObservationObject GetObservationObject()
        {
            return (ObservationObject)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ContractObject`. If the actual instance is not `ContractObject`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ContractObject</returns>
        public ContractObject GetContractObject()
        {
            return (ContractObject)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PartyObject`. If the actual instance is not `PartyObject`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PartyObject</returns>
        public PartyObject GetPartyObject()
        {
            return (PartyObject)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `TokenObject`. If the actual instance is not `TokenObject`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of TokenObject</returns>
        public TokenObject GetTokenObject()
        {
            return (TokenObject)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ActionObject`. If the actual instance is not `ActionObject`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ActionObject</returns>
        public ActionObject GetActionObject()
        {
            return (ActionObject)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LabelledObjectValue {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, LabelledObjectValue.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of LabelledObjectValue
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of LabelledObjectValue</returns>
        public static LabelledObjectValue FromJson(string jsonString)
        {
            LabelledObjectValue newLabelledObjectValue = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newLabelledObjectValue;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ActionObject).GetProperty("AdditionalProperties") == null)
                {
                    newLabelledObjectValue = new LabelledObjectValue(JsonConvert.DeserializeObject<ActionObject>(jsonString, LabelledObjectValue.SerializerSettings));
                }
                else
                {
                    newLabelledObjectValue = new LabelledObjectValue(JsonConvert.DeserializeObject<ActionObject>(jsonString, LabelledObjectValue.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ActionObject");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ActionObject: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ContractObject).GetProperty("AdditionalProperties") == null)
                {
                    newLabelledObjectValue = new LabelledObjectValue(JsonConvert.DeserializeObject<ContractObject>(jsonString, LabelledObjectValue.SerializerSettings));
                }
                else
                {
                    newLabelledObjectValue = new LabelledObjectValue(JsonConvert.DeserializeObject<ContractObject>(jsonString, LabelledObjectValue.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ContractObject");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ContractObject: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ObservationObject).GetProperty("AdditionalProperties") == null)
                {
                    newLabelledObjectValue = new LabelledObjectValue(JsonConvert.DeserializeObject<ObservationObject>(jsonString, LabelledObjectValue.SerializerSettings));
                }
                else
                {
                    newLabelledObjectValue = new LabelledObjectValue(JsonConvert.DeserializeObject<ObservationObject>(jsonString, LabelledObjectValue.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ObservationObject");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ObservationObject: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PartyObject).GetProperty("AdditionalProperties") == null)
                {
                    newLabelledObjectValue = new LabelledObjectValue(JsonConvert.DeserializeObject<PartyObject>(jsonString, LabelledObjectValue.SerializerSettings));
                }
                else
                {
                    newLabelledObjectValue = new LabelledObjectValue(JsonConvert.DeserializeObject<PartyObject>(jsonString, LabelledObjectValue.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("PartyObject");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PartyObject: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(TokenObject).GetProperty("AdditionalProperties") == null)
                {
                    newLabelledObjectValue = new LabelledObjectValue(JsonConvert.DeserializeObject<TokenObject>(jsonString, LabelledObjectValue.SerializerSettings));
                }
                else
                {
                    newLabelledObjectValue = new LabelledObjectValue(JsonConvert.DeserializeObject<TokenObject>(jsonString, LabelledObjectValue.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("TokenObject");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into TokenObject: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ValueObject).GetProperty("AdditionalProperties") == null)
                {
                    newLabelledObjectValue = new LabelledObjectValue(JsonConvert.DeserializeObject<ValueObject>(jsonString, LabelledObjectValue.SerializerSettings));
                }
                else
                {
                    newLabelledObjectValue = new LabelledObjectValue(JsonConvert.DeserializeObject<ValueObject>(jsonString, LabelledObjectValue.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ValueObject");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ValueObject: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newLabelledObjectValue;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LabelledObjectValue);
        }

        /// <summary>
        /// Returns true if LabelledObjectValue instances are equal
        /// </summary>
        /// <param name="input">Instance of LabelledObjectValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LabelledObjectValue input)
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
    /// Custom JSON converter for LabelledObjectValue
    /// </summary>
    public class LabelledObjectValueJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(LabelledObjectValue).GetMethod("ToJson").Invoke(value, null)));
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
                return LabelledObjectValue.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
