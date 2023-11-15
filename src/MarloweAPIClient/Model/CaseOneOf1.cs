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
    /// CaseOneOf1
    /// </summary>
    [DataContract(Name = "Case_oneOf_1")]
    public partial class CaseOneOf1 : IEquatable<CaseOneOf1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseOneOf1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CaseOneOf1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseOneOf1" /> class.
        /// </summary>
        /// <param name="varCase">varCase (required).</param>
        /// <param name="merkleizedThen">merkleizedThen (required).</param>
        public CaseOneOf1(Action varCase = default(Action), string merkleizedThen = default(string))
        {
            // to ensure "varCase" is required (not null)
            if (varCase == null)
            {
                throw new ArgumentNullException("varCase is a required property for CaseOneOf1 and cannot be null");
            }
            this._VarCase = varCase;
            // to ensure "merkleizedThen" is required (not null)
            if (merkleizedThen == null)
            {
                throw new ArgumentNullException("merkleizedThen is a required property for CaseOneOf1 and cannot be null");
            }
            this._MerkleizedThen = merkleizedThen;
        }

        /// <summary>
        /// Gets or Sets VarCase
        /// </summary>
        [DataMember(Name = "case", IsRequired = true, EmitDefaultValue = true)]
        public Action VarCase
        {
            get{ return _VarCase;}
            set
            {
                _VarCase = value;
                _flagVarCase = true;
            }
        }
        private Action _VarCase;
        private bool _flagVarCase;

        /// <summary>
        /// Returns false as VarCase should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarCase()
        {
            return _flagVarCase;
        }
        /// <summary>
        /// Gets or Sets MerkleizedThen
        /// </summary>
        [DataMember(Name = "merkleized_then", IsRequired = true, EmitDefaultValue = true)]
        public string MerkleizedThen
        {
            get{ return _MerkleizedThen;}
            set
            {
                _MerkleizedThen = value;
                _flagMerkleizedThen = true;
            }
        }
        private string _MerkleizedThen;
        private bool _flagMerkleizedThen;

        /// <summary>
        /// Returns false as MerkleizedThen should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMerkleizedThen()
        {
            return _flagMerkleizedThen;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CaseOneOf1 {\n");
            sb.Append("  VarCase: ").Append(VarCase).Append("\n");
            sb.Append("  MerkleizedThen: ").Append(MerkleizedThen).Append("\n");
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
            return this.Equals(input as CaseOneOf1);
        }

        /// <summary>
        /// Returns true if CaseOneOf1 instances are equal
        /// </summary>
        /// <param name="input">Instance of CaseOneOf1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseOneOf1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VarCase == input.VarCase ||
                    (this.VarCase != null &&
                    this.VarCase.Equals(input.VarCase))
                ) && 
                (
                    this.MerkleizedThen == input.MerkleizedThen ||
                    (this.MerkleizedThen != null &&
                    this.MerkleizedThen.Equals(input.MerkleizedThen))
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
                if (this.VarCase != null)
                {
                    hashCode = (hashCode * 59) + this.VarCase.GetHashCode();
                }
                if (this.MerkleizedThen != null)
                {
                    hashCode = (hashCode * 59) + this.MerkleizedThen.GetHashCode();
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
