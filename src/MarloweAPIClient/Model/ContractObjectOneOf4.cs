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
    [DataContract(Name = "ContractObject_oneOf_4")]
    public partial class ContractObjectOneOf4 : IEquatable<ContractObjectOneOf4>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractObjectOneOf4" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContractObjectOneOf4() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractObjectOneOf4" /> class.
        /// </summary>
        /// <param name="assert">assert (required).</param>
        /// <param name="then">then (required).</param>
        public ContractObjectOneOf4(ObservationObject assert = default(ObservationObject), ContractObject then = default(ContractObject))
        {
            // to ensure "assert" is required (not null)
            if (assert == null)
            {
                throw new ArgumentNullException("assert is a required property for ContractObjectOneOf4 and cannot be null");
            }
            this._Assert = assert;
            // to ensure "then" is required (not null)
            if (then == null)
            {
                throw new ArgumentNullException("then is a required property for ContractObjectOneOf4 and cannot be null");
            }
            this._Then = then;
        }

        /// <summary>
        /// Gets or Sets Assert
        /// </summary>
        [DataMember(Name = "assert", IsRequired = true, EmitDefaultValue = true)]
        public ObservationObject Assert
        {
            get{ return _Assert;}
            set
            {
                _Assert = value;
                _flagAssert = true;
            }
        }
        private ObservationObject _Assert;
        private bool _flagAssert;

        /// <summary>
        /// Returns false as Assert should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAssert()
        {
            return _flagAssert;
        }
        /// <summary>
        /// Gets or Sets Then
        /// </summary>
        [DataMember(Name = "then", IsRequired = true, EmitDefaultValue = true)]
        public ContractObject Then
        {
            get{ return _Then;}
            set
            {
                _Then = value;
                _flagThen = true;
            }
        }
        private ContractObject _Then;
        private bool _flagThen;

        /// <summary>
        /// Returns false as Then should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeThen()
        {
            return _flagThen;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContractObjectOneOf4 {\n");
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
            return this.Equals(input as ContractObjectOneOf4);
        }

        /// <summary>
        /// Returns true if ContractObjectOneOf4 instances are equal
        /// </summary>
        /// <param name="input">Instance of ContractObjectOneOf4 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractObjectOneOf4 input)
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
