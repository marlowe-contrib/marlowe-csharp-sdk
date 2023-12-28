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
    /// CaseMerkleizedThen
    /// </summary>
    [DataContract(Name = "CaseMerkleizedThen")]
    public partial class CaseMerkleizedThen : IEquatable<CaseMerkleizedThen>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseMerkleizedThen" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CaseMerkleizedThen() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseMerkleizedThen" /> class.
        /// </summary>
        /// <param name="varCase">varCase (required).</param>
        /// <param name="merkleizedThen">merkleizedThen (required).</param>
        public CaseMerkleizedThen(Action varCase = default(Action), string merkleizedThen = default(string))
        {
            // to ensure "varCase" is required (not null)
            if (varCase == null)
            {
                throw new ArgumentNullException("varCase is a required property for CaseMerkleizedThen and cannot be null");
            }
            this.VarCase = varCase;
            // to ensure "merkleizedThen" is required (not null)
            if (merkleizedThen == null)
            {
                throw new ArgumentNullException("merkleizedThen is a required property for CaseMerkleizedThen and cannot be null");
            }
            this.MerkleizedThen = merkleizedThen;
        }

        /// <summary>
        /// Gets or Sets VarCase
        /// </summary>
        [DataMember(Name = "case", IsRequired = true, EmitDefaultValue = true)]
        public Action VarCase { get; set; }

        /// <summary>
        /// Gets or Sets MerkleizedThen
        /// </summary>
        [DataMember(Name = "merkleized_then", IsRequired = true, EmitDefaultValue = true)]
        public string MerkleizedThen { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CaseMerkleizedThen {\n");
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
            return this.Equals(input as CaseMerkleizedThen);
        }

        /// <summary>
        /// Returns true if CaseMerkleizedThen instances are equal
        /// </summary>
        /// <param name="input">Instance of CaseMerkleizedThen to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseMerkleizedThen input)
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
