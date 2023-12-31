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
    /// A contract which becomes active when an action occurs.
    /// </summary>
    [JsonConverter(typeof(ActionJsonConverter))]
    [DataContract(Name = "Action")]
    public partial class Action : AbstractOpenAPISchema, IEquatable<Action>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Action" /> class
        /// with the <see cref="ActionOneOf" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ActionOneOf.</param>
        public Action(ActionOneOf actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Action" /> class
        /// with the <see cref="ActionOneOf1" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ActionOneOf1.</param>
        public Action(ActionOneOf1 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Action" /> class
        /// with the <see cref="ActionOneOf2" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ActionOneOf2.</param>
        public Action(ActionOneOf2 actualInstance)
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
                if (value.GetType() == typeof(ActionOneOf))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ActionOneOf1))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ActionOneOf2))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ActionOneOf, ActionOneOf1, ActionOneOf2");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ActionOneOf`. If the actual instance is not `ActionOneOf`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ActionOneOf</returns>
        public ActionOneOf GetActionOneOf()
        {
            return (ActionOneOf)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ActionOneOf1`. If the actual instance is not `ActionOneOf1`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ActionOneOf1</returns>
        public ActionOneOf1 GetActionOneOf1()
        {
            return (ActionOneOf1)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ActionOneOf2`. If the actual instance is not `ActionOneOf2`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ActionOneOf2</returns>
        public ActionOneOf2 GetActionOneOf2()
        {
            return (ActionOneOf2)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Action {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, Action.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of Action
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of Action</returns>
        public static Action FromJson(string jsonString)
        {
            Action newAction = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAction;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ActionOneOf).GetProperty("AdditionalProperties") == null)
                {
                    newAction = new Action(JsonConvert.DeserializeObject<ActionOneOf>(jsonString, Action.SerializerSettings));
                }
                else
                {
                    newAction = new Action(JsonConvert.DeserializeObject<ActionOneOf>(jsonString, Action.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ActionOneOf");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ActionOneOf: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ActionOneOf1).GetProperty("AdditionalProperties") == null)
                {
                    newAction = new Action(JsonConvert.DeserializeObject<ActionOneOf1>(jsonString, Action.SerializerSettings));
                }
                else
                {
                    newAction = new Action(JsonConvert.DeserializeObject<ActionOneOf1>(jsonString, Action.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ActionOneOf1");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ActionOneOf1: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ActionOneOf2).GetProperty("AdditionalProperties") == null)
                {
                    newAction = new Action(JsonConvert.DeserializeObject<ActionOneOf2>(jsonString, Action.SerializerSettings));
                }
                else
                {
                    newAction = new Action(JsonConvert.DeserializeObject<ActionOneOf2>(jsonString, Action.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ActionOneOf2");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ActionOneOf2: {1}", jsonString, exception.ToString()));
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
            return newAction;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Action);
        }

        /// <summary>
        /// Returns true if Action instances are equal
        /// </summary>
        /// <param name="input">Instance of Action to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Action input)
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
    /// Custom JSON converter for Action
    /// </summary>
    public class ActionJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(Action).GetMethod("ToJson").Invoke(value, null)));
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
                return Action.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
