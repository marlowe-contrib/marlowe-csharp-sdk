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
    /// A bundle of labelled Marlowe objects in define-before-use order.
    /// </summary>
    [DataContract(Name = "LabelledObject")]
    public partial class LabelledObject : IEquatable<LabelledObject>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Value for value: value
            /// </summary>
            [EnumMember(Value = "value")]
            Value = 1,

            /// <summary>
            /// Enum Observation for value: observation
            /// </summary>
            [EnumMember(Value = "observation")]
            Observation = 2,

            /// <summary>
            /// Enum Contract for value: contract
            /// </summary>
            [EnumMember(Value = "contract")]
            Contract = 3,

            /// <summary>
            /// Enum Party for value: party
            /// </summary>
            [EnumMember(Value = "party")]
            Party = 4,

            /// <summary>
            /// Enum Token for value: token
            /// </summary>
            [EnumMember(Value = "token")]
            Token = 5,

            /// <summary>
            /// Enum Action for value: action
            /// </summary>
            [EnumMember(Value = "action")]
            Action = 6
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>

        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type
        {
            get{ return _Type;}
            set
            {
                _Type = value;
                _flagType = true;
            }
        }
        private TypeEnum _Type;
        private bool _flagType;

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return _flagType;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelledObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LabelledObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelledObject" /> class.
        /// </summary>
        /// <param name="label">An arbitrary text identifier for an object in a Marlowe object bundle. (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="value">value (required).</param>
        public LabelledObject(string label = default(string), TypeEnum type = default(TypeEnum), LabelledObjectValue value = default(LabelledObjectValue))
        {
            // to ensure "label" is required (not null)
            if (label == null)
            {
                throw new ArgumentNullException("label is a required property for LabelledObject and cannot be null");
            }
            this._Label = label;
            this._Type = type;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for LabelledObject and cannot be null");
            }
            this._Value = value;
        }

        /// <summary>
        /// An arbitrary text identifier for an object in a Marlowe object bundle.
        /// </summary>
        /// <value>An arbitrary text identifier for an object in a Marlowe object bundle.</value>
        [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = true)]
        public string Label
        {
            get{ return _Label;}
            set
            {
                _Label = value;
                _flagLabel = true;
            }
        }
        private string _Label;
        private bool _flagLabel;

        /// <summary>
        /// Returns false as Label should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLabel()
        {
            return _flagLabel;
        }
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public LabelledObjectValue Value
        {
            get{ return _Value;}
            set
            {
                _Value = value;
                _flagValue = true;
            }
        }
        private LabelledObjectValue _Value;
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
            sb.Append("class LabelledObject {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as LabelledObject);
        }

        /// <summary>
        /// Returns true if LabelledObject instances are equal
        /// </summary>
        /// <param name="input">Instance of LabelledObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LabelledObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
