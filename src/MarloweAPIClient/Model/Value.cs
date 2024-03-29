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
    /// A time-varying expression that evaluates to a boolean
    /// </summary>
    [JsonConverter(typeof(ValueJsonConverter))]
    [DataContract(Name = "Value")]
    public partial class Value : AbstractOpenAPISchema, IEquatable<Value>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Value" /> class
        /// with the <see cref="TokenInAccount" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of TokenInAccount.</param>
        public Value(TokenInAccount actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Value" /> class
        /// with the <see cref="long" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of long.</param>
        public Value(long actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Value" /> class
        /// with the <see cref="Negate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Negate.</param>
        public Value(Negate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Value" /> class
        /// with the <see cref="Add" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Add.</param>
        public Value(Add actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Value" /> class
        /// with the <see cref="Minus" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Minus.</param>
        public Value(Minus actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Value" /> class
        /// with the <see cref="Multiply" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Multiply.</param>
        public Value(Multiply actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Value" /> class
        /// with the <see cref="Divide" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Divide.</param>
        public Value(Divide actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Value" /> class
        /// with the <see cref="ValueOfChoice" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ValueOfChoice.</param>
        public Value(ValueOfChoice actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Value" /> class
        /// with the <see cref="TimeInterval" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of TimeInterval.</param>
        public Value(TimeInterval actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Value" /> class
        /// with the <see cref="UseValue" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UseValue.</param>
        public Value(UseValue actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Value" /> class
        /// with the <see cref="IfValue" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of IfValue.</param>
        public Value(IfValue actualInstance)
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
                if (value.GetType() == typeof(Add))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Divide))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(IfValue))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Minus))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Multiply))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Negate))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(TimeInterval))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(TokenInAccount))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UseValue))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ValueOfChoice))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(long))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Add, Divide, IfValue, Minus, Multiply, Negate, TimeInterval, TokenInAccount, UseValue, ValueOfChoice, long");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `TokenInAccount`. If the actual instance is not `TokenInAccount`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of TokenInAccount</returns>
        public TokenInAccount GetTokenInAccount()
        {
            return (TokenInAccount)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `long`. If the actual instance is not `long`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of long</returns>
        public long GetLong()
        {
            return (long)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Negate`. If the actual instance is not `Negate`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Negate</returns>
        public Negate GetNegate()
        {
            return (Negate)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Add`. If the actual instance is not `Add`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Add</returns>
        public Add GetAdd()
        {
            return (Add)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Minus`. If the actual instance is not `Minus`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Minus</returns>
        public Minus GetMinus()
        {
            return (Minus)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Multiply`. If the actual instance is not `Multiply`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Multiply</returns>
        public Multiply GetMultiply()
        {
            return (Multiply)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Divide`. If the actual instance is not `Divide`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Divide</returns>
        public Divide GetDivide()
        {
            return (Divide)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ValueOfChoice`. If the actual instance is not `ValueOfChoice`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ValueOfChoice</returns>
        public ValueOfChoice GetValueOfChoice()
        {
            return (ValueOfChoice)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `TimeInterval`. If the actual instance is not `TimeInterval`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of TimeInterval</returns>
        public TimeInterval GetTimeInterval()
        {
            return (TimeInterval)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UseValue`. If the actual instance is not `UseValue`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UseValue</returns>
        public UseValue GetUseValue()
        {
            return (UseValue)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `IfValue`. If the actual instance is not `IfValue`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of IfValue</returns>
        public IfValue GetIfValue()
        {
            return (IfValue)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Value {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, Value.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of Value
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of Value</returns>
        public static Value FromJson(string jsonString)
        {
            Value newValue = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newValue;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Add).GetProperty("AdditionalProperties") == null)
                {
                    newValue = new Value(JsonConvert.DeserializeObject<Add>(jsonString, Value.SerializerSettings));
                }
                else
                {
                    newValue = new Value(JsonConvert.DeserializeObject<Add>(jsonString, Value.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Add");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Add: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Divide).GetProperty("AdditionalProperties") == null)
                {
                    newValue = new Value(JsonConvert.DeserializeObject<Divide>(jsonString, Value.SerializerSettings));
                }
                else
                {
                    newValue = new Value(JsonConvert.DeserializeObject<Divide>(jsonString, Value.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Divide");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Divide: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(IfValue).GetProperty("AdditionalProperties") == null)
                {
                    newValue = new Value(JsonConvert.DeserializeObject<IfValue>(jsonString, Value.SerializerSettings));
                }
                else
                {
                    newValue = new Value(JsonConvert.DeserializeObject<IfValue>(jsonString, Value.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("IfValue");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into IfValue: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Minus).GetProperty("AdditionalProperties") == null)
                {
                    newValue = new Value(JsonConvert.DeserializeObject<Minus>(jsonString, Value.SerializerSettings));
                }
                else
                {
                    newValue = new Value(JsonConvert.DeserializeObject<Minus>(jsonString, Value.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Minus");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Minus: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Multiply).GetProperty("AdditionalProperties") == null)
                {
                    newValue = new Value(JsonConvert.DeserializeObject<Multiply>(jsonString, Value.SerializerSettings));
                }
                else
                {
                    newValue = new Value(JsonConvert.DeserializeObject<Multiply>(jsonString, Value.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Multiply");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Multiply: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Negate).GetProperty("AdditionalProperties") == null)
                {
                    newValue = new Value(JsonConvert.DeserializeObject<Negate>(jsonString, Value.SerializerSettings));
                }
                else
                {
                    newValue = new Value(JsonConvert.DeserializeObject<Negate>(jsonString, Value.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Negate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Negate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(TimeInterval).GetProperty("AdditionalProperties") == null)
                {
                    newValue = new Value(JsonConvert.DeserializeObject<TimeInterval>(jsonString, Value.SerializerSettings));
                }
                else
                {
                    newValue = new Value(JsonConvert.DeserializeObject<TimeInterval>(jsonString, Value.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("TimeInterval");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into TimeInterval: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(TokenInAccount).GetProperty("AdditionalProperties") == null)
                {
                    newValue = new Value(JsonConvert.DeserializeObject<TokenInAccount>(jsonString, Value.SerializerSettings));
                }
                else
                {
                    newValue = new Value(JsonConvert.DeserializeObject<TokenInAccount>(jsonString, Value.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("TokenInAccount");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into TokenInAccount: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UseValue).GetProperty("AdditionalProperties") == null)
                {
                    newValue = new Value(JsonConvert.DeserializeObject<UseValue>(jsonString, Value.SerializerSettings));
                }
                else
                {
                    newValue = new Value(JsonConvert.DeserializeObject<UseValue>(jsonString, Value.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UseValue");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UseValue: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ValueOfChoice).GetProperty("AdditionalProperties") == null)
                {
                    newValue = new Value(JsonConvert.DeserializeObject<ValueOfChoice>(jsonString, Value.SerializerSettings));
                }
                else
                {
                    newValue = new Value(JsonConvert.DeserializeObject<ValueOfChoice>(jsonString, Value.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ValueOfChoice");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ValueOfChoice: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(long).GetProperty("AdditionalProperties") == null)
                {
                    newValue = new Value(JsonConvert.DeserializeObject<long>(jsonString, Value.SerializerSettings));
                }
                else
                {
                    newValue = new Value(JsonConvert.DeserializeObject<long>(jsonString, Value.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("long");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into long: {1}", jsonString, exception.ToString()));
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
            return newValue;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Value);
        }

        /// <summary>
        /// Returns true if Value instances are equal
        /// </summary>
        /// <param name="input">Instance of Value to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Value input)
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
    /// Custom JSON converter for Value
    /// </summary>
    public class ValueJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(Value).GetMethod("ToJson").Invoke(value, null)));
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
                return Value.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
