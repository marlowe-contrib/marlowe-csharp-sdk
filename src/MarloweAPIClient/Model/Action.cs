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
        /// with the <see cref="DepositAction" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DepositAction.</param>
        public Action(DepositAction actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Action" /> class
        /// with the <see cref="ChoiceAction" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ChoiceAction.</param>
        public Action(ChoiceAction actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Action" /> class
        /// with the <see cref="NotifyAction" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NotifyAction.</param>
        public Action(NotifyAction actualInstance)
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
                if (value.GetType() == typeof(ChoiceAction))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DepositAction))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NotifyAction))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ChoiceAction, DepositAction, NotifyAction");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `DepositAction`. If the actual instance is not `DepositAction`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DepositAction</returns>
        public DepositAction GetDepositAction()
        {
            return (DepositAction)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ChoiceAction`. If the actual instance is not `ChoiceAction`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ChoiceAction</returns>
        public ChoiceAction GetChoiceAction()
        {
            return (ChoiceAction)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `NotifyAction`. If the actual instance is not `NotifyAction`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of NotifyAction</returns>
        public NotifyAction GetNotifyAction()
        {
            return (NotifyAction)this.ActualInstance;
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
                if (typeof(ChoiceAction).GetProperty("AdditionalProperties") == null)
                {
                    newAction = new Action(JsonConvert.DeserializeObject<ChoiceAction>(jsonString, Action.SerializerSettings));
                }
                else
                {
                    newAction = new Action(JsonConvert.DeserializeObject<ChoiceAction>(jsonString, Action.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ChoiceAction");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ChoiceAction: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DepositAction).GetProperty("AdditionalProperties") == null)
                {
                    newAction = new Action(JsonConvert.DeserializeObject<DepositAction>(jsonString, Action.SerializerSettings));
                }
                else
                {
                    newAction = new Action(JsonConvert.DeserializeObject<DepositAction>(jsonString, Action.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DepositAction");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DepositAction: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NotifyAction).GetProperty("AdditionalProperties") == null)
                {
                    newAction = new Action(JsonConvert.DeserializeObject<NotifyAction>(jsonString, Action.SerializerSettings));
                }
                else
                {
                    newAction = new Action(JsonConvert.DeserializeObject<NotifyAction>(jsonString, Action.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NotifyAction");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NotifyAction: {1}", jsonString, exception.ToString()));
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
