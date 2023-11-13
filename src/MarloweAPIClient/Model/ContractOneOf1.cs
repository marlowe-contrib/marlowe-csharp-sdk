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
    /// If an observation is true, the first contract applies, otherwise the second contract applies.
    /// </summary>
    [DataContract(Name = "Contract_oneOf_1")]
    public partial class ContractOneOf1 : IEquatable<ContractOneOf1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractOneOf1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContractOneOf1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractOneOf1" /> class.
        /// </summary>
        /// <param name="varElse">varElse (required).</param>
        /// <param name="varIf">varIf (required).</param>
        /// <param name="then">then (required).</param>
        public ContractOneOf1(Contract varElse = default(Contract), Observation varIf = default(Observation), Contract then = default(Contract))
        {
            // to ensure "varElse" is required (not null)
            if (varElse == null)
            {
                throw new ArgumentNullException("varElse is a required property for ContractOneOf1 and cannot be null");
            }
            this._VarElse = varElse;
            // to ensure "varIf" is required (not null)
            if (varIf == null)
            {
                throw new ArgumentNullException("varIf is a required property for ContractOneOf1 and cannot be null");
            }
            this._VarIf = varIf;
            // to ensure "then" is required (not null)
            if (then == null)
            {
                throw new ArgumentNullException("then is a required property for ContractOneOf1 and cannot be null");
            }
            this._Then = then;
        }

        /// <summary>
        /// Gets or Sets VarElse
        /// </summary>
        [DataMember(Name = "else", IsRequired = true, EmitDefaultValue = true)]
        public Contract VarElse
        {
            get{ return _VarElse;}
            set
            {
                _VarElse = value;
                _flagVarElse = true;
            }
        }
        private Contract _VarElse;
        private bool _flagVarElse;

        /// <summary>
        /// Returns false as VarElse should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarElse()
        {
            return _flagVarElse;
        }
        /// <summary>
        /// Gets or Sets VarIf
        /// </summary>
        [DataMember(Name = "if", IsRequired = true, EmitDefaultValue = true)]
        public Observation VarIf
        {
            get{ return _VarIf;}
            set
            {
                _VarIf = value;
                _flagVarIf = true;
            }
        }
        private Observation _VarIf;
        private bool _flagVarIf;

        /// <summary>
        /// Returns false as VarIf should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarIf()
        {
            return _flagVarIf;
        }
        /// <summary>
        /// Gets or Sets Then
        /// </summary>
        [DataMember(Name = "then", IsRequired = true, EmitDefaultValue = true)]
        public Contract Then
        {
            get{ return _Then;}
            set
            {
                _Then = value;
                _flagThen = true;
            }
        }
        private Contract _Then;
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
            sb.Append("class ContractOneOf1 {\n");
            sb.Append("  VarElse: ").Append(VarElse).Append("\n");
            sb.Append("  VarIf: ").Append(VarIf).Append("\n");
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
            return this.Equals(input as ContractOneOf1);
        }

        /// <summary>
        /// Returns true if ContractOneOf1 instances are equal
        /// </summary>
        /// <param name="input">Instance of ContractOneOf1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractOneOf1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VarElse == input.VarElse ||
                    (this.VarElse != null &&
                    this.VarElse.Equals(input.VarElse))
                ) && 
                (
                    this.VarIf == input.VarIf ||
                    (this.VarIf != null &&
                    this.VarIf.Equals(input.VarIf))
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
                if (this.VarElse != null)
                {
                    hashCode = (hashCode * 59) + this.VarElse.GetHashCode();
                }
                if (this.VarIf != null)
                {
                    hashCode = (hashCode * 59) + this.VarIf.GetHashCode();
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
