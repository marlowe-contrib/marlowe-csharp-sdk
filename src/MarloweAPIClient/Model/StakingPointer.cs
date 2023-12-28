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
    /// A Plutus staking pointer.
    /// </summary>
    [DataContract(Name = "StakingPointer")]
    public partial class StakingPointer : IEquatable<StakingPointer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StakingPointer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StakingPointer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StakingPointer" /> class.
        /// </summary>
        /// <param name="stakingHash">stakingHash (required).</param>
        public StakingPointer(List<int> stakingHash = default(List<int>))
        {
            // to ensure "stakingHash" is required (not null)
            if (stakingHash == null)
            {
                throw new ArgumentNullException("stakingHash is a required property for StakingPointer and cannot be null");
            }
            this.StakingHash = stakingHash;
        }

        /// <summary>
        /// Gets or Sets StakingHash
        /// </summary>
        [DataMember(Name = "stakingHash", IsRequired = true, EmitDefaultValue = true)]
        public List<int> StakingHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StakingPointer {\n");
            sb.Append("  StakingHash: ").Append(StakingHash).Append("\n");
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
            return this.Equals(input as StakingPointer);
        }

        /// <summary>
        /// Returns true if StakingPointer instances are equal
        /// </summary>
        /// <param name="input">Instance of StakingPointer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StakingPointer input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StakingHash == input.StakingHash ||
                    this.StakingHash != null &&
                    input.StakingHash != null &&
                    this.StakingHash.SequenceEqual(input.StakingHash)
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
                if (this.StakingHash != null)
                {
                    hashCode = (hashCode * 59) + this.StakingHash.GetHashCode();
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
