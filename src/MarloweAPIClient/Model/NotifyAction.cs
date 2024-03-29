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

namespace MarloweAPIClient.Model
{
    /// <summary>
    /// NotifyAction
    /// </summary>
    [JsonConverter(typeof(NotifyActionJsonConverter))]
    [DataContract(Name = "NotifyAction")]
    public partial class NotifyAction : IEquatable<NotifyAction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotifyAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyAction" /> class.
        /// </summary>
        /// <param name="notifyIf">notifyIf (required).</param>
        public NotifyAction(Observation notifyIf = default(Observation))
        {
            // to ensure "notifyIf" is required (not null)
            if (notifyIf == null)
            {
                throw new ArgumentNullException("notifyIf is a required property for NotifyAction and cannot be null");
            }
            this.NotifyIf = notifyIf;
        }

        /// <summary>
        /// Gets or Sets NotifyIf
        /// </summary>
        [DataMember(Name = "notify_if", IsRequired = true, EmitDefaultValue = true)]
        public Observation NotifyIf { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotifyAction {\n");
            sb.Append("  NotifyIf: ").Append(NotifyIf).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NotifyAction);
        }

        /// <summary>
        /// Returns true if NotifyAction instances are equal
        /// </summary>
        /// <param name="input">Instance of NotifyAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotifyAction input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.NotifyIf == input.NotifyIf ||
                    (this.NotifyIf != null &&
                    this.NotifyIf.Equals(input.NotifyIf))
                );
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
                if (this.NotifyIf != null)
                {
                    hashCode = (hashCode * 59) + this.NotifyIf.GetHashCode();
                }
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
    public class NotifyActionJsonConverter : JsonConverter
    {
        public override bool CanWrite
        {
            get { return false; }
        }

        public override bool CanConvert(Type objectType)
        {
            return false;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);
            Observation notifyIf;

            // Handle the 'notify_if' field
            JToken notifyToken = jsonObject["notify_if"];
            if (notifyToken.Type == JTokenType.Boolean)
            {
                notifyIf = new Observation((bool)notifyToken);
            }
            else
            {
                notifyIf = notifyToken.ToObject<Observation>();
            }

            return new NotifyAction(notifyIf);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(NotifyAction).GetMethod("ToJson").Invoke(value, null)));
        }
    }

}
