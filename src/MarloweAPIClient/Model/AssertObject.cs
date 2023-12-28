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
    /// Check an observation and produce a warning if it is false.
    /// </summary>
    [DataContract(Name = "AssertObject")]
    public partial class AssertObject : IEquatable<AssertObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssertObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssertObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssertObject" /> class.
        /// </summary>
        /// <param name="assert">assert (required).</param>
        /// <param name="then">then (required).</param>
        public AssertObject(ObservationObject assert = default(ObservationObject), ContractObject then = default(ContractObject))
        {
            // to ensure "assert" is required (not null)
            if (assert == null)
            {
                throw new ArgumentNullException("assert is a required property for AssertObject and cannot be null");
            }
            this.Assert = assert;
            // to ensure "then" is required (not null)
            if (then == null)
            {
                throw new ArgumentNullException("then is a required property for AssertObject and cannot be null");
            }
            this.Then = then;
        }

        /// <summary>
        /// Gets or Sets Assert
        /// </summary>
        [DataMember(Name = "assert", IsRequired = true, EmitDefaultValue = true)]
        public ObservationObject Assert { get; set; }

        /// <summary>
        /// Gets or Sets Then
        /// </summary>
        [DataMember(Name = "then", IsRequired = true, EmitDefaultValue = true)]
        public ContractObject Then { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssertObject {\n");
            sb.Append("  Assert: ").Append(Assert).Append("\n");
            sb.Append("  Then: ").Append(Then).Append("\n");
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
            return this.Equals(input as AssertObject);
        }

        /// <summary>
        /// Returns true if AssertObject instances are equal
        /// </summary>
        /// <param name="input">Instance of AssertObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssertObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Assert == input.Assert ||
                    (this.Assert != null &&
                    this.Assert.Equals(input.Assert))
                ) && 
                (
                    this.Then == input.Then ||
                    (this.Then != null &&
                    this.Then.Equals(input.Then))
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
                if (this.Assert != null)
                {
                    hashCode = (hashCode * 59) + this.Assert.GetHashCode();
                }
                if (this.Then != null)
                {
                    hashCode = (hashCode * 59) + this.Then.GetHashCode();
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
