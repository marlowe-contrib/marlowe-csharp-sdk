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
    /// Divide
    /// </summary>
    [DataContract(Name = "Divide")]
    public partial class Divide : IEquatable<Divide>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Divide" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Divide() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Divide" /> class.
        /// </summary>
        /// <param name="by">by (required).</param>
        /// <param name="varDivide">varDivide (required).</param>
        public Divide(Value by = default(Value), Value varDivide = default(Value))
        {
            // to ensure "by" is required (not null)
            if (by == null)
            {
                throw new ArgumentNullException("by is a required property for Divide and cannot be null");
            }
            this.By = by;
            // to ensure "varDivide" is required (not null)
            if (varDivide == null)
            {
                throw new ArgumentNullException("varDivide is a required property for Divide and cannot be null");
            }
            this.VarDivide = varDivide;
        }

        /// <summary>
        /// Gets or Sets By
        /// </summary>
        [DataMember(Name = "by", IsRequired = true, EmitDefaultValue = true)]
        public Value By { get; set; }

        /// <summary>
        /// Gets or Sets VarDivide
        /// </summary>
        [DataMember(Name = "divide", IsRequired = true, EmitDefaultValue = true)]
        public Value VarDivide { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Divide {\n");
            sb.Append("  By: ").Append(By).Append("\n");
            sb.Append("  VarDivide: ").Append(VarDivide).Append("\n");
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
            return this.Equals(input as Divide);
        }

        /// <summary>
        /// Returns true if Divide instances are equal
        /// </summary>
        /// <param name="input">Instance of Divide to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Divide input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.By == input.By ||
                    (this.By != null &&
                    this.By.Equals(input.By))
                ) && 
                (
                    this.VarDivide == input.VarDivide ||
                    (this.VarDivide != null &&
                    this.VarDivide.Equals(input.VarDivide))
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
                if (this.By != null)
                {
                    hashCode = (hashCode * 59) + this.By.GetHashCode();
                }
                if (this.VarDivide != null)
                {
                    hashCode = (hashCode * 59) + this.VarDivide.GetHashCode();
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
