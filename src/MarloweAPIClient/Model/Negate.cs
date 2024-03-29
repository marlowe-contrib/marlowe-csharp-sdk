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
    /// Negate
    /// </summary>
    [DataContract(Name = "Negate")]
    public partial class Negate : IEquatable<Negate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Negate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Negate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Negate" /> class.
        /// </summary>
        /// <param name="varNegate">varNegate (required).</param>
        public Negate(Value varNegate = default(Value))
        {
            // to ensure "varNegate" is required (not null)
            if (varNegate == null)
            {
                throw new ArgumentNullException("varNegate is a required property for Negate and cannot be null");
            }
            this.VarNegate = varNegate;
        }

        /// <summary>
        /// Gets or Sets VarNegate
        /// </summary>
        [DataMember(Name = "negate", IsRequired = true, EmitDefaultValue = true)]
        public Value VarNegate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Negate {\n");
            sb.Append("  VarNegate: ").Append(VarNegate).Append("\n");
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
            return this.Equals(input as Negate);
        }

        /// <summary>
        /// Returns true if Negate instances are equal
        /// </summary>
        /// <param name="input">Instance of Negate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Negate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VarNegate == input.VarNegate ||
                    (this.VarNegate != null &&
                    this.VarNegate.Equals(input.VarNegate))
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
                if (this.VarNegate != null)
                {
                    hashCode = (hashCode * 59) + this.VarNegate.GetHashCode();
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
