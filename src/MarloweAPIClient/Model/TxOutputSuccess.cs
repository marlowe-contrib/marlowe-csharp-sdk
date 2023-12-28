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
    /// Marlowe transaction output information.
    /// </summary>
    [DataContract(Name = "TxOutputSuccess")]
    public partial class TxOutputSuccess : IEquatable<TxOutputSuccess>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TxOutputSuccess" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TxOutputSuccess() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TxOutputSuccess" /> class.
        /// </summary>
        /// <param name="contract">contract (required).</param>
        /// <param name="payments">payments (required).</param>
        /// <param name="state">state (required).</param>
        /// <param name="warnings">warnings (required).</param>
        public TxOutputSuccess(Contract contract = default(Contract), List<Payment> payments = default(List<Payment>), MarloweState state = default(MarloweState), List<TransactionWarning> warnings = default(List<TransactionWarning>))
        {
            // to ensure "contract" is required (not null)
            if (contract == null)
            {
                throw new ArgumentNullException("contract is a required property for TxOutputSuccess and cannot be null");
            }
            this.Contract = contract;
            // to ensure "payments" is required (not null)
            if (payments == null)
            {
                throw new ArgumentNullException("payments is a required property for TxOutputSuccess and cannot be null");
            }
            this.Payments = payments;
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new ArgumentNullException("state is a required property for TxOutputSuccess and cannot be null");
            }
            this.State = state;
            // to ensure "warnings" is required (not null)
            if (warnings == null)
            {
                throw new ArgumentNullException("warnings is a required property for TxOutputSuccess and cannot be null");
            }
            this.Warnings = warnings;
        }

        /// <summary>
        /// Gets or Sets Contract
        /// </summary>
        [DataMember(Name = "contract", IsRequired = true, EmitDefaultValue = true)]
        public Contract Contract { get; set; }

        /// <summary>
        /// Gets or Sets Payments
        /// </summary>
        [DataMember(Name = "payments", IsRequired = true, EmitDefaultValue = true)]
        public List<Payment> Payments { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public MarloweState State { get; set; }

        /// <summary>
        /// Gets or Sets Warnings
        /// </summary>
        [DataMember(Name = "warnings", IsRequired = true, EmitDefaultValue = true)]
        public List<TransactionWarning> Warnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TxOutputSuccess {\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
            return this.Equals(input as TxOutputSuccess);
        }

        /// <summary>
        /// Returns true if TxOutputSuccess instances are equal
        /// </summary>
        /// <param name="input">Instance of TxOutputSuccess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TxOutputSuccess input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.Payments == input.Payments ||
                    this.Payments != null &&
                    input.Payments != null &&
                    this.Payments.SequenceEqual(input.Payments)
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
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
                if (this.Contract != null)
                {
                    hashCode = (hashCode * 59) + this.Contract.GetHashCode();
                }
                if (this.Payments != null)
                {
                    hashCode = (hashCode * 59) + this.Payments.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.Warnings != null)
                {
                    hashCode = (hashCode * 59) + this.Warnings.GetHashCode();
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
