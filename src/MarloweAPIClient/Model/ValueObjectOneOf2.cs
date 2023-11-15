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
    /// ValueObjectOneOf2
    /// </summary>
    [DataContract(Name = "ValueObject_oneOf_2")]
    public partial class ValueObjectOneOf2 : IEquatable<ValueObjectOneOf2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueObjectOneOf2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValueObjectOneOf2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueObjectOneOf2" /> class.
        /// </summary>
        /// <param name="add">add (required).</param>
        /// <param name="and">and (required).</param>
        public ValueObjectOneOf2(ValueObject add = default(ValueObject), ValueObject and = default(ValueObject))
        {
            // to ensure "add" is required (not null)
            if (add == null)
            {
                throw new ArgumentNullException("add is a required property for ValueObjectOneOf2 and cannot be null");
            }
            this._Add = add;
            // to ensure "and" is required (not null)
            if (and == null)
            {
                throw new ArgumentNullException("and is a required property for ValueObjectOneOf2 and cannot be null");
            }
            this._And = and;
        }

        /// <summary>
        /// Gets or Sets Add
        /// </summary>
        [DataMember(Name = "add", IsRequired = true, EmitDefaultValue = true)]
        public ValueObject Add
        {
            get{ return _Add;}
            set
            {
                _Add = value;
                _flagAdd = true;
            }
        }
        private ValueObject _Add;
        private bool _flagAdd;

        /// <summary>
        /// Returns false as Add should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAdd()
        {
            return _flagAdd;
        }
        /// <summary>
        /// Gets or Sets And
        /// </summary>
        [DataMember(Name = "and", IsRequired = true, EmitDefaultValue = true)]
        public ValueObject And
        {
            get{ return _And;}
            set
            {
                _And = value;
                _flagAnd = true;
            }
        }
        private ValueObject _And;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValueObjectOneOf2 {\n");
            sb.Append("  Add: ").Append(Add).Append("\n");
            sb.Append("  And: ").Append(And).Append("\n");
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
            return this.Equals(input as ValueObjectOneOf2);
        }

        /// <summary>
        /// Returns true if ValueObjectOneOf2 instances are equal
        /// </summary>
        /// <param name="input">Instance of ValueObjectOneOf2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValueObjectOneOf2 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Add == input.Add ||
                    (this.Add != null &&
                    this.Add.Equals(input.Add))
                ) && 
                (
                    this.And == input.And ||
                    (this.And != null &&
                    this.And.Equals(input.And))
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
                if (this.Add != null)
                {
                    hashCode = (hashCode * 59) + this.Add.GetHashCode();
                }
                if (this.And != null)
                {
                    hashCode = (hashCode * 59) + this.And.GetHashCode();
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
