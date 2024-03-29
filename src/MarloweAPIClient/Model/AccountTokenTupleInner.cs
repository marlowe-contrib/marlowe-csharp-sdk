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
    /// AccountTokenTupleInner
    /// </summary>
    [JsonConverter(typeof(AccountTokenTupleInnerJsonConverter))]
    [DataContract(Name = "AccountTokenTuple_inner")]
    public partial class AccountTokenTupleInner : AbstractOpenAPISchema, IEquatable<AccountTokenTupleInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTokenTupleInner" /> class
        /// with the <see cref="Party" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Party.</param>
        public AccountTokenTupleInner(Party actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTokenTupleInner" /> class
        /// with the <see cref="Token" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Token.</param>
        public AccountTokenTupleInner(Token actualInstance)
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
                if (value.GetType() == typeof(Party))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Token))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Party, Token");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Party`. If the actual instance is not `Party`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Party</returns>
        public Party GetParty()
        {
            return (Party)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Token`. If the actual instance is not `Token`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Token</returns>
        public Token GetToken()
        {
            return (Token)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountTokenTupleInner {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AccountTokenTupleInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AccountTokenTupleInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AccountTokenTupleInner</returns>
        public static AccountTokenTupleInner FromJson(string jsonString)
        {
            AccountTokenTupleInner newAccountTokenTupleInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAccountTokenTupleInner;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Party).GetProperty("AdditionalProperties") == null)
                {
                    newAccountTokenTupleInner = new AccountTokenTupleInner(JsonConvert.DeserializeObject<Party>(jsonString, AccountTokenTupleInner.SerializerSettings));
                }
                else
                {
                    newAccountTokenTupleInner = new AccountTokenTupleInner(JsonConvert.DeserializeObject<Party>(jsonString, AccountTokenTupleInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Party");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Party: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Token).GetProperty("AdditionalProperties") == null)
                {
                    newAccountTokenTupleInner = new AccountTokenTupleInner(JsonConvert.DeserializeObject<Token>(jsonString, AccountTokenTupleInner.SerializerSettings));
                }
                else
                {
                    newAccountTokenTupleInner = new AccountTokenTupleInner(JsonConvert.DeserializeObject<Token>(jsonString, AccountTokenTupleInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Token");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Token: {1}", jsonString, exception.ToString()));
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
            return newAccountTokenTupleInner;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccountTokenTupleInner);
        }

        /// <summary>
        /// Returns true if AccountTokenTupleInner instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountTokenTupleInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountTokenTupleInner input)
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
    /// Custom JSON converter for AccountTokenTupleInner
    /// </summary>
    public class AccountTokenTupleInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AccountTokenTupleInner).GetMethod("ToJson").Invoke(value, null)));
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
                return AccountTokenTupleInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
