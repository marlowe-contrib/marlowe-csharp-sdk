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
    /// Notify Input tha can be applied for a given contract
    /// </summary>
    [DataContract(Name = "CanNotify")]
    public partial class CanNotify : IEquatable<CanNotify>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CanNotify" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CanNotify() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CanNotify" /> class.
        /// </summary>
        /// <param name="caseIndex">Index of a \&quot;Case Action\&quot; in a \&quot;When\&quot; (required).</param>
        /// <param name="isMerkleizedContinuation">Indicates if a given contract continuation is merkleized (required).</param>
        public CanNotify(int caseIndex = default(int), bool isMerkleizedContinuation = default(bool))
        {
            this._CaseIndex = caseIndex;
            this._IsMerkleizedContinuation = isMerkleizedContinuation;
        }

        /// <summary>
        /// Index of a \&quot;Case Action\&quot; in a \&quot;When\&quot;
        /// </summary>
        /// <value>Index of a \&quot;Case Action\&quot; in a \&quot;When\&quot;</value>
        [DataMember(Name = "case_index", IsRequired = true, EmitDefaultValue = true)]
        public int CaseIndex
        {
            get{ return _CaseIndex;}
            set
            {
                _CaseIndex = value;
                _flagCaseIndex = true;
            }
        }
        private int _CaseIndex;
        private bool _flagCaseIndex;

        /// <summary>
        /// Returns false as CaseIndex should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCaseIndex()
        {
            return _flagCaseIndex;
        }
        /// <summary>
        /// Indicates if a given contract continuation is merkleized
        /// </summary>
        /// <value>Indicates if a given contract continuation is merkleized</value>
        [DataMember(Name = "is_merkleized_continuation", IsRequired = true, EmitDefaultValue = true)]
        public bool IsMerkleizedContinuation
        {
            get{ return _IsMerkleizedContinuation;}
            set
            {
                _IsMerkleizedContinuation = value;
                _flagIsMerkleizedContinuation = true;
            }
        }
        private bool _IsMerkleizedContinuation;
        private bool _flagIsMerkleizedContinuation;

        /// <summary>
        /// Returns false as IsMerkleizedContinuation should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsMerkleizedContinuation()
        {
            return _flagIsMerkleizedContinuation;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CanNotify {\n");
            sb.Append("  CaseIndex: ").Append(CaseIndex).Append("\n");
            sb.Append("  IsMerkleizedContinuation: ").Append(IsMerkleizedContinuation).Append("\n");
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
            return this.Equals(input as CanNotify);
        }

        /// <summary>
        /// Returns true if CanNotify instances are equal
        /// </summary>
        /// <param name="input">Instance of CanNotify to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CanNotify input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CaseIndex == input.CaseIndex ||
                    this.CaseIndex.Equals(input.CaseIndex)
                ) && 
                (
                    this.IsMerkleizedContinuation == input.IsMerkleizedContinuation ||
                    this.IsMerkleizedContinuation.Equals(input.IsMerkleizedContinuation)
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
                hashCode = (hashCode * 59) + this.CaseIndex.GetHashCode();
                hashCode = (hashCode * 59) + this.IsMerkleizedContinuation.GetHashCode();
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
