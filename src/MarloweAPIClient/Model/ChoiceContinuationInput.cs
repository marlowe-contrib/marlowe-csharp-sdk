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
    /// Make a choice in a contract and provide the continuation of the contract
    /// </summary>
    [DataContract(Name = "ChoiceContinuationInput")]
    public partial class ChoiceContinuationInput : IEquatable<ChoiceContinuationInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChoiceContinuationInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChoiceContinuationInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChoiceContinuationInput" /> class.
        /// </summary>
        /// <param name="continuationHash">continuationHash (required).</param>
        /// <param name="forChoiceId">forChoiceId (required).</param>
        /// <param name="inputThatChoosesNum">inputThatChoosesNum (required).</param>
        /// <param name="merkleizedContinuation">merkleizedContinuation (required).</param>
        public ChoiceContinuationInput(string continuationHash = default(string), ChoiceId forChoiceId = default(ChoiceId), int inputThatChoosesNum = default(int), Contract merkleizedContinuation = default(Contract))
        {
            // to ensure "continuationHash" is required (not null)
            if (continuationHash == null)
            {
                throw new ArgumentNullException("continuationHash is a required property for ChoiceContinuationInput and cannot be null");
            }
            this.ContinuationHash = continuationHash;
            // to ensure "forChoiceId" is required (not null)
            if (forChoiceId == null)
            {
                throw new ArgumentNullException("forChoiceId is a required property for ChoiceContinuationInput and cannot be null");
            }
            this.ForChoiceId = forChoiceId;
            this.InputThatChoosesNum = inputThatChoosesNum;
            // to ensure "merkleizedContinuation" is required (not null)
            if (merkleizedContinuation == null)
            {
                throw new ArgumentNullException("merkleizedContinuation is a required property for ChoiceContinuationInput and cannot be null");
            }
            this.MerkleizedContinuation = merkleizedContinuation;
        }

        /// <summary>
        /// Gets or Sets ContinuationHash
        /// </summary>
        [DataMember(Name = "continuation_hash", IsRequired = true, EmitDefaultValue = true)]
        public string ContinuationHash { get; set; }

        /// <summary>
        /// Gets or Sets ForChoiceId
        /// </summary>
        [DataMember(Name = "for_choice_id", IsRequired = true, EmitDefaultValue = true)]
        public ChoiceId ForChoiceId { get; set; }

        /// <summary>
        /// Gets or Sets InputThatChoosesNum
        /// </summary>
        [DataMember(Name = "input_that_chooses_num", IsRequired = true, EmitDefaultValue = true)]
        public int InputThatChoosesNum { get; set; }

        /// <summary>
        /// Gets or Sets MerkleizedContinuation
        /// </summary>
        [DataMember(Name = "merkleized_continuation", IsRequired = true, EmitDefaultValue = true)]
        public Contract MerkleizedContinuation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChoiceContinuationInput {\n");
            sb.Append("  ContinuationHash: ").Append(ContinuationHash).Append("\n");
            sb.Append("  ForChoiceId: ").Append(ForChoiceId).Append("\n");
            sb.Append("  InputThatChoosesNum: ").Append(InputThatChoosesNum).Append("\n");
            sb.Append("  MerkleizedContinuation: ").Append(MerkleizedContinuation).Append("\n");
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
            return this.Equals(input as ChoiceContinuationInput);
        }

        /// <summary>
        /// Returns true if ChoiceContinuationInput instances are equal
        /// </summary>
        /// <param name="input">Instance of ChoiceContinuationInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChoiceContinuationInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContinuationHash == input.ContinuationHash ||
                    (this.ContinuationHash != null &&
                    this.ContinuationHash.Equals(input.ContinuationHash))
                ) && 
                (
                    this.ForChoiceId == input.ForChoiceId ||
                    (this.ForChoiceId != null &&
                    this.ForChoiceId.Equals(input.ForChoiceId))
                ) && 
                (
                    this.InputThatChoosesNum == input.InputThatChoosesNum ||
                    this.InputThatChoosesNum.Equals(input.InputThatChoosesNum)
                ) && 
                (
                    this.MerkleizedContinuation == input.MerkleizedContinuation ||
                    (this.MerkleizedContinuation != null &&
                    this.MerkleizedContinuation.Equals(input.MerkleizedContinuation))
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
                if (this.ContinuationHash != null)
                {
                    hashCode = (hashCode * 59) + this.ContinuationHash.GetHashCode();
                }
                if (this.ForChoiceId != null)
                {
                    hashCode = (hashCode * 59) + this.ForChoiceId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InputThatChoosesNum.GetHashCode();
                if (this.MerkleizedContinuation != null)
                {
                    hashCode = (hashCode * 59) + this.MerkleizedContinuation.GetHashCode();
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
