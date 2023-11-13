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
    /// ObservationOneOf5
    /// </summary>
    [DataContract(Name = "Observation_oneOf_5")]
    public partial class ObservationOneOf5 : IEquatable<ObservationOneOf5>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationOneOf5" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ObservationOneOf5() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationOneOf5" /> class.
        /// </summary>
        /// <param name="gt">gt (required).</param>
        /// <param name="value">value (required).</param>
        public ObservationOneOf5(Value gt = default(Value), Value value = default(Value))
        {
            // to ensure "gt" is required (not null)
            if (gt == null)
            {
                throw new ArgumentNullException("gt is a required property for ObservationOneOf5 and cannot be null");
            }
            this._Gt = gt;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for ObservationOneOf5 and cannot be null");
            }
            this._Value = value;
        }

        /// <summary>
        /// Gets or Sets Gt
        /// </summary>
        [DataMember(Name = "gt", IsRequired = true, EmitDefaultValue = true)]
        public Value Gt
        {
            get{ return _Gt;}
            set
            {
                _Gt = value;
                _flagGt = true;
            }
        }
        private Value _Gt;
        private bool _flagGt;

        /// <summary>
        /// Returns false as Gt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeGt()
        {
            return _flagGt;
        }
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public Value Value
        {
            get{ return _Value;}
            set
            {
                _Value = value;
                _flagValue = true;
            }
        }
        private Value _Value;
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
            sb.Append("class ObservationOneOf5 {\n");
            sb.Append("  Gt: ").Append(Gt).Append("\n");
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
            return this.Equals(input as ObservationOneOf5);
        }

        /// <summary>
        /// Returns true if ObservationOneOf5 instances are equal
        /// </summary>
        /// <param name="input">Instance of ObservationOneOf5 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObservationOneOf5 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Gt == input.Gt ||
                    (this.Gt != null &&
                    this.Gt.Equals(input.Gt))
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
                if (this.Gt != null)
                {
                    hashCode = (hashCode * 59) + this.Gt.GetHashCode();
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
