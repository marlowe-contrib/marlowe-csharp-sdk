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
    /// ObservationObjectOneOf8
    /// </summary>
    [DataContract(Name = "ObservationObject_oneOf_8")]
    public partial class ObservationObjectOneOf8 : IEquatable<ObservationObjectOneOf8>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationObjectOneOf8" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ObservationObjectOneOf8() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationObjectOneOf8" /> class.
        /// </summary>
        /// <param name="equalTo">equalTo (required).</param>
        /// <param name="value">value (required).</param>
        public ObservationObjectOneOf8(ValueObject equalTo = default(ValueObject), ValueObject value = default(ValueObject))
        {
            // to ensure "equalTo" is required (not null)
            if (equalTo == null)
            {
                throw new ArgumentNullException("equalTo is a required property for ObservationObjectOneOf8 and cannot be null");
            }
            this._EqualTo = equalTo;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for ObservationObjectOneOf8 and cannot be null");
            }
            this._Value = value;
        }

        /// <summary>
        /// Gets or Sets EqualTo
        /// </summary>
        [DataMember(Name = "equal_to", IsRequired = true, EmitDefaultValue = true)]
        public ValueObject EqualTo
        {
            get{ return _EqualTo;}
            set
            {
                _EqualTo = value;
                _flagEqualTo = true;
            }
        }
        private ValueObject _EqualTo;
        private bool _flagEqualTo;

        /// <summary>
        /// Returns false as EqualTo should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEqualTo()
        {
            return _flagEqualTo;
        }
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public ValueObject Value
        {
            get{ return _Value;}
            set
            {
                _Value = value;
                _flagValue = true;
            }
        }
        private ValueObject _Value;
        private bool _flagValue;

        /// <summary>
        /// Returns false as Value should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValue()
        {
            return _flagValue;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ObservationObjectOneOf8 {\n");
            sb.Append("  EqualTo: ").Append(EqualTo).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as ObservationObjectOneOf8);
        }

        /// <summary>
        /// Returns true if ObservationObjectOneOf8 instances are equal
        /// </summary>
        /// <param name="input">Instance of ObservationObjectOneOf8 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObservationObjectOneOf8 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EqualTo == input.EqualTo ||
                    (this.EqualTo != null &&
                    this.EqualTo.Equals(input.EqualTo))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.EqualTo != null)
                {
                    hashCode = (hashCode * 59) + this.EqualTo.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
