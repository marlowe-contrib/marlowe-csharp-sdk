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
    /// MinusObject
    /// </summary>
    [DataContract(Name = "MinusObject")]
    public partial class MinusObject : IEquatable<MinusObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MinusObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MinusObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MinusObject" /> class.
        /// </summary>
        /// <param name="minus">minus (required).</param>
        /// <param name="value">value (required).</param>
        public MinusObject(ValueObject minus = default(ValueObject), ValueObject value = default(ValueObject))
        {
            // to ensure "minus" is required (not null)
            if (minus == null)
            {
                throw new ArgumentNullException("minus is a required property for MinusObject and cannot be null");
            }
            this._Minus = minus;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for MinusObject and cannot be null");
            }
            this._Value = value;
        }

        /// <summary>
        /// Gets or Sets Minus
        /// </summary>
        [DataMember(Name = "minus", IsRequired = true, EmitDefaultValue = true)]
        public ValueObject Minus
        {
            get{ return _Minus;}
            set
            {
                _Minus = value;
                _flagMinus = true;
            }
        }
        private ValueObject _Minus;
        private bool _flagMinus;

        /// <summary>
        /// Returns false as Minus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMinus()
        {
            return _flagMinus;
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
            sb.Append("class MinusObject {\n");
            sb.Append("  Minus: ").Append(Minus).Append("\n");
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
            return this.Equals(input as MinusObject);
        }

        /// <summary>
        /// Returns true if MinusObject instances are equal
        /// </summary>
        /// <param name="input">Instance of MinusObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MinusObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Minus == input.Minus ||
                    (this.Minus != null &&
                    this.Minus.Equals(input.Minus))
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
                if (this.Minus != null)
                {
                    hashCode = (hashCode * 59) + this.Minus.GetHashCode();
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