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
    /// Marlowe transaction interval in past.
    /// </summary>
    [DataContract(Name = "IntervalInPast")]
    public partial class IntervalInPast : IEquatable<IntervalInPast>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntervalInPast" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IntervalInPast() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntervalInPast" /> class.
        /// </summary>
        /// <param name="intervalInPastError">intervalInPastError (required).</param>
        public IntervalInPast(IntervalInPastIntervalInPastError intervalInPastError = default(IntervalInPastIntervalInPastError))
        {
            // to ensure "intervalInPastError" is required (not null)
            if (intervalInPastError == null)
            {
                throw new ArgumentNullException("intervalInPastError is a required property for IntervalInPast and cannot be null");
            }
            this.IntervalInPastError = intervalInPastError;
        }

        /// <summary>
        /// Gets or Sets IntervalInPastError
        /// </summary>
        [DataMember(Name = "intervalInPastError", IsRequired = true, EmitDefaultValue = true)]
        public IntervalInPastIntervalInPastError IntervalInPastError { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IntervalInPast {\n");
            sb.Append("  IntervalInPastError: ").Append(IntervalInPastError).Append("\n");
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
            return this.Equals(input as IntervalInPast);
        }

        /// <summary>
        /// Returns true if IntervalInPast instances are equal
        /// </summary>
        /// <param name="input">Instance of IntervalInPast to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntervalInPast input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IntervalInPastError == input.IntervalInPastError ||
                    (this.IntervalInPastError != null &&
                    this.IntervalInPastError.Equals(input.IntervalInPastError))
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
                if (this.IntervalInPastError != null)
                {
                    hashCode = (hashCode * 59) + this.IntervalInPastError.GetHashCode();
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

}
