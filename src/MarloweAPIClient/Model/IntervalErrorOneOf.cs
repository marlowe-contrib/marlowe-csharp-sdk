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
    /// Invalid Marlowe transaction interval.
    /// </summary>
    [DataContract(Name = "IntervalError_oneOf")]
    public partial class IntervalErrorOneOf : IEquatable<IntervalErrorOneOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntervalErrorOneOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IntervalErrorOneOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntervalErrorOneOf" /> class.
        /// </summary>
        /// <param name="invalidInterval">invalidInterval (required).</param>
        public IntervalErrorOneOf(IntervalErrorOneOfInvalidInterval invalidInterval = default(IntervalErrorOneOfInvalidInterval))
        {
            // to ensure "invalidInterval" is required (not null)
            if (invalidInterval == null)
            {
                throw new ArgumentNullException("invalidInterval is a required property for IntervalErrorOneOf and cannot be null");
            }
            this._InvalidInterval = invalidInterval;
        }

        /// <summary>
        /// Gets or Sets InvalidInterval
        /// </summary>
        [DataMember(Name = "invalidInterval", IsRequired = true, EmitDefaultValue = true)]
        public IntervalErrorOneOfInvalidInterval InvalidInterval
        {
            get{ return _InvalidInterval;}
            set
            {
                _InvalidInterval = value;
                _flagInvalidInterval = true;
            }
        }
        private IntervalErrorOneOfInvalidInterval _InvalidInterval;
        private bool _flagInvalidInterval;

        /// <summary>
        /// Returns false as InvalidInterval should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInvalidInterval()
        {
            return _flagInvalidInterval;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IntervalErrorOneOf {\n");
            sb.Append("  InvalidInterval: ").Append(InvalidInterval).Append("\n");
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
            return this.Equals(input as IntervalErrorOneOf);
        }

        /// <summary>
        /// Returns true if IntervalErrorOneOf instances are equal
        /// </summary>
        /// <param name="input">Instance of IntervalErrorOneOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntervalErrorOneOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InvalidInterval == input.InvalidInterval ||
                    (this.InvalidInterval != null &&
                    this.InvalidInterval.Equals(input.InvalidInterval))
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
                if (this.InvalidInterval != null)
                {
                    hashCode = (hashCode * 59) + this.InvalidInterval.GetHashCode();
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
