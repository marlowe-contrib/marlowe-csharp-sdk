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

namespace MarloweAPIClient.Model
{
    /// <summary>
    /// ObservationOneOf
    /// </summary>
    [DataContract(Name = "Observation_oneOf")]
    public partial class ObservationOneOf : IEquatable<ObservationOneOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationOneOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ObservationOneOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationOneOf" /> class.
        /// </summary>
        /// <param name="and">and (required).</param>
        /// <param name="both">both (required).</param>
        public ObservationOneOf(Observation and = default(Observation), Observation both = default(Observation))
        {
            // to ensure "and" is required (not null)
            if (and == null)
            {
                throw new ArgumentNullException("and is a required property for ObservationOneOf and cannot be null");
            }
            this._And = and;
            // to ensure "both" is required (not null)
            if (both == null)
            {
                throw new ArgumentNullException("both is a required property for ObservationOneOf and cannot be null");
            }
            this._Both = both;
        }

        /// <summary>
        /// Gets or Sets And
        /// </summary>
        [DataMember(Name = "and", IsRequired = true, EmitDefaultValue = true)]
        public Observation And
        {
            get{ return _And;}
            set
            {
                _And = value;
                _flagAnd = true;
            }
        }
        private Observation _And;
        private bool _flagAnd;

        /// <summary>
        /// Returns false as And should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAnd()
        {
            return _flagAnd;
        }
        /// <summary>
        /// Gets or Sets Both
        /// </summary>
        [DataMember(Name = "both", IsRequired = true, EmitDefaultValue = true)]
        public Observation Both
        {
            get{ return _Both;}
            set
            {
                _Both = value;
                _flagBoth = true;
            }
        }
        private Observation _Both;
        private bool _flagBoth;

        /// <summary>
        /// Returns false as Both should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBoth()
        {
            return _flagBoth;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ObservationOneOf {\n");
            sb.Append("  And: ").Append(And).Append("\n");
            sb.Append("  Both: ").Append(Both).Append("\n");
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
            return this.Equals(input as ObservationOneOf);
        }

        /// <summary>
        /// Returns true if ObservationOneOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ObservationOneOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObservationOneOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.And == input.And ||
                    (this.And != null &&
                    this.And.Equals(input.And))
                ) && 
                (
                    this.Both == input.Both ||
                    (this.Both != null &&
                    this.Both.Equals(input.Both))
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
                if (this.And != null)
                {
                    hashCode = (hashCode * 59) + this.And.GetHashCode();
                }
                if (this.Both != null)
                {
                    hashCode = (hashCode * 59) + this.Both.GetHashCode();
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
