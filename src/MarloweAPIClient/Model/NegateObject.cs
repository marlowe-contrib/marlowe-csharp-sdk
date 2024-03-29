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
    /// NegateObject
    /// </summary>
    [DataContract(Name = "NegateObject")]
    public partial class NegateObject : IEquatable<NegateObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NegateObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NegateObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NegateObject" /> class.
        /// </summary>
        /// <param name="negate">negate (required).</param>
        public NegateObject(ValueObject negate = default(ValueObject))
        {
            // to ensure "negate" is required (not null)
            if (negate == null)
            {
                throw new ArgumentNullException("negate is a required property for NegateObject and cannot be null");
            }
            this.Negate = negate;
        }

        /// <summary>
        /// Gets or Sets Negate
        /// </summary>
        [DataMember(Name = "negate", IsRequired = true, EmitDefaultValue = true)]
        public ValueObject Negate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NegateObject {\n");
            sb.Append("  Negate: ").Append(Negate).Append("\n");
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
            return this.Equals(input as NegateObject);
        }

        /// <summary>
        /// Returns true if NegateObject instances are equal
        /// </summary>
        /// <param name="input">Instance of NegateObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NegateObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Negate == input.Negate ||
                    (this.Negate != null &&
                    this.Negate.Equals(input.Negate))
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
                if (this.Negate != null)
                {
                    hashCode = (hashCode * 59) + this.Negate.GetHashCode();
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
